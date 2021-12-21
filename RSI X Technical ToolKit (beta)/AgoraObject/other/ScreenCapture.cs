using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using agorartc;

namespace RSI_X_Desktop
{
    internal static class ScreenCapture
    {
        private static bool isJoin;
        public static bool IsScreenCapture { get; private set; }
        private static WaveFormat waveFormat;
        private static WaveFileWriter writer;
        private static IWaveIn CaptureInstance = null;
        internal static void StartScreenCapture(ScreenCaptureParameters capParam)
        {
            StopScreenCapture();
            isJoin = AgoraObject.IsJoin;
            AgoraObject.LeaveChannel();

            CaptureInstance = new WasapiLoopbackCapture();
            waveFormat = CaptureInstance.WaveFormat;
            CaptureInstance.DataAvailable += DataAvaible;

            if (capParam.bitrate == 0)
                capParam = forms.Devices.resolutionsSize[
                    forms.Devices.oldResolution];
            Rectangle region = new ();

            region.width = Screen.PrimaryScreen.Bounds.Width;
            region.height = Screen.PrimaryScreen.Bounds.Height;
            capParam.bitrate = 1200;
            capParam.frameRate = 15;

            IsScreenCapture =
                ERROR_CODE.ERR_OK == AgoraObject.Rtc.StartScreenCaptureByScreenRect(region, region, capParam);
            System.Diagnostics.Debug.WriteLine($"{DateTime.Now:HH:mm:ss:fff}: screen sharing enable ({IsScreenCapture})");

            if (IsScreenCapture) 
            {
                AgoraObject.Rtc.SetExternalAudioSource(true, 44100, 1);
                writer = new WaveFileWriter("test.wav", new WaveFormat(38400, 1));
                CaptureInstance.StartRecording();
            }

            if (isJoin) AgoraObject.JoinChannel();
        }
        private static void DataAvaible(object sender, WaveInEventArgs e) 
        {
            int samples = e.Buffer.Length / 4;
            byte[] buff = new byte[samples / 2];

            for (int i = 0; i < samples / 2; i += 2)
            {
                float t = BitConverter.ToSingle(e.Buffer, i * 4);
                t += BitConverter.ToSingle(e.Buffer, (i + 1) * 4);

                t /= 2;
                short g = Convert.ToInt16(t * short.MaxValue);
                var b = BitConverter.GetBytes(g);

                buff[i + 0] = b[0];
                buff[i + 1] = b[1];
            }

            //for (int i = 0; i < e.Buffer.Length / 2; i++)
            //{
            //    float t = BitConverter.ToSingle(e.Buffer, i * 4);
            //    t += BitConverter.ToSingle(e.Buffer, (i + 1) * 4);

            //    t /= 2;
            //    short g = Convert.ToInt16(t * short.MaxValue);
            //    var b = BitConverter.GetBytes(g);
                
            //    buff[i / 4 + 0] = b[1];
            //    buff[i / 4 + 1] = b[0];
            //}
            //writer.Write(buff);
            
            AudioFrame af = new()
            {
                bytesPerSample = 2,
                channels = 1,
                buffer = buff,
                type = AUDIO_FRAME_TYPE.FRAME_TYPE_PCM16,
                avsync_type = (int)AUDIO_FRAME_TYPE.FRAME_TYPE_PCM16,
                renderTimeMs = 1000,
                samplesPerSec = 44100,
                samples = buff.Length / 2,
            };


            var ret = AgoraObject.Rtc.PushAudioFrame(
                MEDIA_SOURCE_TYPE.AUDIO_RECORDING_SOURCE,
                af, false);
        }

        internal static void StopScreenCapture()
        {
            isJoin = AgoraObject.IsJoin;
            AgoraObject.LeaveChannel();

            AgoraObject.Rtc.SetExternalAudioSource(false, 0, 0);
            AgoraObject.Rtc.StopScreenCapture();

            CaptureInstance?.StopRecording();
            CaptureInstance?.Dispose();
            CaptureInstance = null;
            writer?.Dispose();
            writer = null;

            if (isJoin) AgoraObject.JoinChannel();
            IsScreenCapture = false;
        }
    }
}

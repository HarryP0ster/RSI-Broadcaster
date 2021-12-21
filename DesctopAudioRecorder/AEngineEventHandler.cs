﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using agorartc;

namespace DesctopAudioRecorder
{
    internal static class XAgoraObject
    {
        internal const string AppID = "31f0e571a89542b09049087e3283417f";
        public static AgoraRtcEngine Rtc { get; internal set; }
        private static IWaveIn CaptureInstance = null;

        static XAgoraObject()
        {
            Rtc = AgoraRtcEngine.CreateRtcEngine();
            Rtc.InitEventHandler(new AEngineEventHandler());
            Rtc.Initialize(new RtcEngineContext(AppID));
        }

        internal static void JoinChannel(string token, string chName)
        {
            StartScreenCapture();
            ERROR_CODE res = Rtc.JoinChannel(token, chName, "", 0);

            Rtc.MuteLocalVideoStream(true);
            Rtc.MuteAllRemoteAudioStreams(true);
            Rtc.MuteAllRemoteVideoStreams(true);
        }
        internal static void LeaveChannel()
        {
            Rtc.LeaveChannel();
        }

        internal static void StartScreenCapture()
        {
            CaptureInstance = new WasapiLoopbackCapture();
            CaptureInstance.DataAvailable += DataAvaible;
            XAgoraObject.Rtc.SetExternalAudioSource(true, 44100, 1);
            CaptureInstance.StartRecording();
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
            Console.WriteLine($"{buff.Length}");

            AudioFrame af = new()
            {
                bytesPerSample = 2,
                channels = 1,
                buffer = buff,
                type = AUDIO_FRAME_TYPE.FRAME_TYPE_PCM16,
                avsync_type = (int)AUDIO_FRAME_TYPE.FRAME_TYPE_PCM16,
                renderTimeMs = 160,
                samplesPerSec = 44100,
                samples = buff.Length / 2,
            };

            XAgoraObject.Rtc.PushAudioFrame(
                MEDIA_SOURCE_TYPE.AUDIO_RECORDING_SOURCE,
                af, false);
        }

        internal static void StopScreenCapture()
        {
            XAgoraObject.LeaveChannel();
            XAgoraObject.Rtc.SetExternalAudioSource(false, 0, 0);
            CaptureInstance?.StopRecording();
            CaptureInstance?.Dispose();
            CaptureInstance = null;
        }
    }
    internal class AEngineEventHandler : IRtcEngineEventHandlerBase
    {
        public override void OnJoinChannelSuccess(string channel, uint uid, int elapsed)
        {
            Console.WriteLine(string.Format("uid:{0}", uid));
        }
    }
}

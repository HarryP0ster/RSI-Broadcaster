using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;
using agorartc;

namespace RSI_X_Desktop
{
    internal class ImageSender
    {
        private static Timer timer;
        private static ExternalVideoFrame t = new();
        private static bool isEnable = false;
        public static bool IsEnable { get { return isEnable; } }
        static ImageSender() 
        {
            timer = new(Timer_Elapsed, null, dueTime:1000/15, period: 1000 / 15);
        }
        public static void configImageToSend(Bitmap img, int fps=15) 
        {
            if (img == null) 
            {
                t = new()
                {
                    buffer = null,
                    height = 0,
                    stride = 0,
                    timestamp = 0
                };
                GC.Collect();
                return;
            }
            t = new();
            t.height = img.Height;
            t.stride = img.Width;
            t.type   = VIDEO_BUFFER_TYPE.VIDEO_BUFFER_RAW_DATA;
            t.format = VIDEO_PIXEL_FORMAT.VIDEO_PIXEL_ARGB;
            t.timestamp = 0;

            int index = -1;
            t.buffer = new byte[img.Height * img.Width * 4];

            for (int i = 0; i < img.Height; i++)
                for (int j = 0; j < img.Width; j++)
                {
                    var pixel = img.GetPixel(j, i);

                    t.buffer[index + 1] = pixel.A;
                    t.buffer[index + 2] = pixel.R;
                    t.buffer[index + 3] = pixel.G;
                    t.buffer[index + 4] = pixel.B;
                    index += 4;
                }
            DebugWriter.WriteTime("load complete");
            //timer.Interval = 1000 / fps;
            //timer.Enabled = true;
        }
        private static bool isJoin = false;
        private static bool Callback = false;
        public static void EnableImageSender(bool enable) 
        {
            Callback = true;
            isJoin = AgoraObject.IsJoin;

            AgoraObject.LeaveChannel();
            isEnable = enable;
            
            if (enable)
                DebugWriter.WriteTime("Image sender has start");
            else 
            {
                DebugWriter.WriteTime("Image sender has stop");
                GC.Collect();
            }
        }
        public static void Rejoin() 
        {
            if (!Callback) return;

            AgoraObject.Rtc.SetExternalVideoSource(isEnable, true);
            if (isJoin) AgoraObject.JoinChannel();

            Callback = true;
        }
        public static void SendOneFrame()
        {
            t.timestamp += 1;
            AgoraObject.Rtc.PushVideoFrame(t);
        }
        private static void Timer_Elapsed(object state)
        {
            if (isEnable)
                SendOneFrame();
            //DebugLogger.Write(e.SignalTime.ToString("ss:ff"));
        }
    }
}

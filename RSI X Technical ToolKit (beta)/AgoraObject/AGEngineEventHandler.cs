using System;

using agorartc;

namespace RSI_X_Desktop
{
    internal class AGEngineEventHandler : IRtcEngineEventHandlerBase
    {
        private IFormHostHolder form;
        public AGEngineEventHandler(IFormHostHolder form) 
        {
            this.form = form;
        }
        
        public override void OnStreamMessage(uint uid, int streamId, byte[] data, uint length)
        {
            UserInfo name;
            string Message = AgoraObject.utf8enc.GetString(data);

            AgoraObject.Rtc.GetUserInfoByUid(uid, out name);
            string UserName = name.userAccount;
            var formInterpr = (form as Broadcaster);
            formInterpr.GetMessage(Message, UserName, CHANNEL_TYPE.HOST);
            Console.WriteLine("OnStreamMessage");
        }

       
        public override void OnLocalVideoStateChanged(LOCAL_VIDEO_STREAM_STATE localVideoState,
            LOCAL_VIDEO_STREAM_ERROR error)
        {
            Console.WriteLine("OnLocalVideoStateChanged");

            DebugWriter.WriteTime($"{localVideoState}, {error}");
            switch (localVideoState)
            {
                case LOCAL_VIDEO_STREAM_STATE.LOCAL_VIDEO_STREAM_STATE_CAPTURING:
                case LOCAL_VIDEO_STREAM_STATE.LOCAL_VIDEO_STREAM_STATE_ENCODING:
                    if (ImageSender.IsEnable) 
                    {
                        ImageSender.SetLocalFrame();
                        forms.PopUpForm.SetImageSend(true);
                    }
                    else 
                        ImageSender.SetLocalFrame(clear:true);
                    break;
                case LOCAL_VIDEO_STREAM_STATE.LOCAL_VIDEO_STREAM_STATE_FAILED:
                case LOCAL_VIDEO_STREAM_STATE.LOCAL_VIDEO_STREAM_STATE_STOPPED:
                default:
                    break;
            }

            switch (error) 
            {
                case LOCAL_VIDEO_STREAM_ERROR.LOCAL_VIDEO_STREAM_ERROR_CAPTURE_FAILURE:
                    if (ImageSender.IsEnable == false)
                        ImageSender.SetLocalFrame(clear: true);
                    break;
            }
        }

    }
}

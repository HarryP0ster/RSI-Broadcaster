using System;

namespace RSI_X_Desktop
{
    public interface IFormHostHolder
    {
        public IntPtr RemoteWnd { get; }
        public void RefreshLocalWnd();
        public void SetLocalVideoPreview();
        public void InvokeSetLocalFrame(System.Drawing.Bitmap bmp);
        public void CloseChat();
        public void ExitApp();
    }
    public enum EBroadcasterRoles
    {
        ROLE_DEFAULT = 0,
        ROLE_SECRETARY = 1,
        ROLE_HEAD = 2
    }
}

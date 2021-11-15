using System;

namespace RSI_X_Desktop
{
    public interface IFormHostHolder
    {
        public IntPtr RemoteWnd { get; }
        public void DevicesClosed(System.Windows.Forms.Form Wnd);
        public void SetLocalVideoPreview();
    }
    public interface IFormInterpreterHolder 
    { }
}

using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Un4seen.Bass;
using agorartc;
using RSI_X_Desktop.forms;
using static System.Environment;

namespace RSI_X_Desktop.forms
{
    public partial class PopUpForm : DevExpress.XtraEditors.XtraForm
    {
        internal struct DeviceInfo
        {
            public string Id;
            public string Name;
        }

        private static readonly string GET_VIDEO_LIST_ERROR_MSG = "Bad video list";
        private static readonly string GET_RECORDERS_LIST_ERROR_MSG = "Bad audioIn list";

        private const int HDresolution = 6;
        private const int LDresolution = 2;
        private static PopUpForm _instance;
        private static readonly Color InactiveColor = Color.FromArgb(254, 1, 243);
        private static readonly Color PushColor = Color.BurlyWood;
        private Font CommonFont = Constants.Bahnschrift16;
        public static bool IsImageSend { get; private set; }
        public static readonly Dictionary<string, VIDEO_PROFILE_TYPE> resolutions = new()
        {
            [" 160 * 120 "] = VIDEO_PROFILE_TYPE.VIDEO_PROFILE_LANDSCAPE_120P,
            [" 320 * 180 "] = VIDEO_PROFILE_TYPE.VIDEO_PROFILE_LANDSCAPE_180P,
            [" 320 * 240 "] = VIDEO_PROFILE_TYPE.VIDEO_PROFILE_LANDSCAPE_240P,
            [" 640 * 360 "] = VIDEO_PROFILE_TYPE.VIDEO_PROFILE_LANDSCAPE_360P,
            [" 640 * 480 "] = VIDEO_PROFILE_TYPE.VIDEO_PROFILE_LANDSCAPE_480P,
            ["1280 * 720 "] = VIDEO_PROFILE_TYPE.VIDEO_PROFILE_LANDSCAPE_720P,
            ["1920 * 1080"] = VIDEO_PROFILE_TYPE.VIDEO_PROFILE_LANDSCAPE_1080P,
        };
        public static readonly Dictionary<string, ScreenCaptureParameters> resolutionsSize = new()
        {
            [" 160 * 120 "] = new(120, 160)  { frameRate = 15, bitrate = (int)BITRATE.STANDARD_BITRATE, captureMouseCursor = false, windowFocus = false},
            [" 320 * 180 "] = new(180, 320)  { frameRate = 15, bitrate = (int)BITRATE.STANDARD_BITRATE, captureMouseCursor = false, windowFocus = false},
            [" 320 * 240 "] = new(240, 240)  { frameRate = 15, bitrate = (int)BITRATE.STANDARD_BITRATE, captureMouseCursor = false, windowFocus = false},
            [" 640 * 360 "] = new(360, 360)  { frameRate = 15, bitrate = (int)BITRATE.STANDARD_BITRATE, captureMouseCursor = false, windowFocus = false},
            [" 640 * 480 "] = new(480, 480)  { frameRate = 15, bitrate = (int)BITRATE.STANDARD_BITRATE, captureMouseCursor = false, windowFocus = false},
            ["1280 * 720 "] = new(960, 720)  { frameRate = 15, bitrate = (int)BITRATE.STANDARD_BITRATE, captureMouseCursor = false, windowFocus = false},
            ["1920 * 1080"] = new(1920, 1080){ frameRate = 15, bitrate = (int)BITRATE.STANDARD_BITRATE, captureMouseCursor = false, windowFocus = false},
        };
        private static IFormHostHolder workForm = AgoraObject.GetWorkForm;

        static private AgoraAudioRecordingDeviceManager RecordersManager;
        static private AgoraAudioPlaybackDeviceManager SpeakersManager;
        static private AgoraVideoDeviceManager VideoManager;
        static List<DeviceInfo> Recorders;
        static List<DeviceInfo> VideoOut;

        bool Init = false;

        private static int oldVolumeIn;
        private static DeviceInfo oldRecorder;
        private static DeviceInfo oldVideoOut;
        public static string oldResolution { get; private set; }
        private static int oldIndexResolution;

        private static int SelectedVolumeIn;
        private static DeviceInfo SelectedRecorder;
        private static DeviceInfo SelectedVideoOut;
        public static string SelectedResolution { get; private set; }
        //private static int SelectedIndexResolution = HDresolution; //1080p

        private int frames = 0;
        private string playback_device = "";
        private string recording_device = "";

        private bool IsAudioTest = false;
        private int output;
        private int input;
        private long prebuf;

        Padding MarginNormal = new Padding(15, 5, 15, 25);
        Padding Hovered = new Padding(13, 5, 13, 25);

        public PopUpForm()
        {
            InitializeComponent();

            int dpi = this.DeviceDpi;
            Font font = Constants.Bahnschrift24;

            if (dpi >= (int)Constants.DPI.P175)
                font = Constants.Bahnschrift10;
            else if (dpi >= (int)Constants.DPI.P150)
                font = Constants.Bahnschrift12;
            else if (dpi >= (int)Constants.DPI.P125)
                font = Constants.Bahnschrift14;
            else if (dpi >= (int)Constants.DPI.P100)
                font = Constants.Bahnschrift16;
            
            comboBoxAudioInput.Font = font;
            comboBoxAudioOutput.Font = font;
            comboBoxVideo.Font = font;
            ComboBoxRes.Font = font;
        }

        static PopUpForm() 
        {
            RecordersManager = AgoraObject.Rtc.CreateAudioRecordingDeviceManager();
            SpeakersManager = AgoraObject.Rtc.CreateAudioPlaybackDeviceManager();
            VideoManager = AgoraObject.Rtc.CreateVideoDeviceManager();

            oldIndexResolution = AgoraObject.joinType == HostType.Broadcaster ? 
                HDresolution : LDresolution;
        }

        public static void SetupOldDevices()
        {
            VideoOut = getListVideoDevices();
            Recorders = getListAudioInputDevices();

            bool hasOldRecorder = Recorders.Any((s) => s.Id == oldRecorder.Id);

            int index = (oldRecorder.Id != null) ?
                Recorders.FindLastIndex((s) => s.Id == oldRecorder.Id) :
                index = getActiveAudioInputDevice();


            oldRecorder = Recorders[index];

            if (VideoOut.Count > 0 && index > 0)
                oldVideoOut = VideoOut[0];

            oldResolution = resolutions.Keys.ToArray()[oldIndexResolution];
            UpdateResolution(oldResolution);
        }

        private void SetWndRegion()
        {
            Region reg = new();
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 45;
            System.Drawing.Rectangle r = new System.Drawing.Rectangle(25, 0, Width - 25, Height);
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            path.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            path.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            reg = new Region(path);

            path = new System.Drawing.Drawing2D.GraphicsPath();
            r = new System.Drawing.Rectangle(0, 0, Width, 195);
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            path.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            path.AddArc(r.X, r.Y + r.Height, 5, 5, 90, 90);

            reg.Union(new Region(path));
            this.Region = reg;
        }

        private void PopUpForm_Load(object sender, EventArgs e)
        {
            SetWndRegion();
            LabelGeneral_Click(null, null);

            _instance = this;
            oldVolumeIn = RecordersManager.GetDeviceVolume();
            trackBarSoundIn.Value = oldVolumeIn;

            Recorders = getListAudioInputDevices();
            VideoOut = getListVideoDevices();

            UpdateComboBoxRecorder();
            UpdateComboBoxVideoOut();

            setupComputerDescription();
            TableGeneral.Rows[3].Visible = false;
            TableGeneral.Rows[4].Visible = false;
            ComboBoxRes.DataSource = new List<string>(resolutions.Keys);
            ComboBoxRes.SelectedIndex = oldIndexResolution;

            btnCustomImage.ForeColor = IsImageSend ?
                PushColor : InactiveColor;

            workForm = AgoraObject.GetWorkForm;

            Init = true;

            pictureBoxLocalVideoTest.Visible = !IsImageSend;
            PreviewPanel.BackgroundImage = IsImageSend?
                new Bitmap((Owner as Broadcaster).PreviewFilePath) : null;
            workForm?.RefreshLocalWnd();
            VideoCanvas vc = new((ulong)pictureBoxLocalVideoTest.Handle, 0);
            vc.renderMode = ((int)RENDER_MODE_TYPE.RENDER_MODE_FIT);
            AgoraObject.Rtc.StartPreview();
            AgoraObject.Rtc.SetupLocalVideo(vc);
        }

        private void UpdateComboBoxRecorder()
        {
            Recorders = getListAudioInputDevices();
            List<string> listRecorders = new();
            bool hasOldRecorder = Recorders.Any((s) => s.Id == oldRecorder.Id);

            int index = (oldRecorder.Id != "" && hasOldRecorder) ?
                Recorders.FindLastIndex((s) => s.Id == oldRecorder.Id) :
                getActiveAudioInputDevice();

            if (index == -1)
                index = Recorders.Count > 0 ? 0 : -1;

            if (index == -1 || Recorders.Count == 0)
            {
                comboBoxAudioInput.DataSource = new List<string> { "Record Devices Error" };
                return;
            }

            foreach (var rec in Recorders)
                listRecorders.Add(rec.Name);

            oldRecorder = Recorders[index];
            SelectedRecorder = Recorders[index];

            comboBoxAudioInput.DataSource = listRecorders;
            comboBoxAudioInput.SelectedIndex = index;
        }
        private void UpdateComboBoxVideoOut()
        {
            VideoOut = getListVideoDevices();
            List<string> listVideo = new();
            bool hasoldVideoOut = VideoOut.Any((s) => s.Id == oldVideoOut.Id);

            int index = (oldVideoOut.Id != "") ?
                VideoOut.FindLastIndex((s) => s.Id == oldVideoOut.Id) :
                getActiveVideoDeviceIndex();

            if (index == -1)
                index = VideoOut.Count > 0 ? 0 : -1;

            if (index == -1 || VideoOut.Count == 0)
            {
                comboBoxVideo.DataSource = new List<string> { "Video Devices Error" };
                return;
            }

            foreach (var rec in VideoOut)
                listVideo.Add(rec.Name);

            oldVideoOut = VideoOut[index];
            SelectedVideoOut = VideoOut[index];

            comboBoxVideo.DataSource = listVideo;
            comboBoxVideo.SelectedIndex = index;
        }

        public static ScreenCaptureParameters GetVideoParam()
        {
            return resolutionsSize[oldResolution];
        }
        public static void ResetVideoDevice()
        {
            try
            {
                VideoOut = getListVideoDevices();

                if (VideoOut.Count == 0)
                {
                    workForm?.InvokeSetLocalFrame(Properties.Resources.logotype_black);
                    return;
                }

                int index = VideoOut.FindLastIndex((s) => s.Id == oldVideoOut.Id);
                index = index == -1 ? 0 : index;

                var device = new DeviceInfo();
                VideoManager.GetDeviceInfoByIndex(index, out device.Name, out device.Id);

                DebugWriter.WriteTime("update video device");
                VideoManager.SetCurrentDevice(device.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setupComputerDescription()
        {
            //dungeonLabel1.Text = "Версия ОС - " + OSVersion.VersionString;
            //dungeonLabel2.Text = Is64BitOperatingSystem ?
            //    "64 Bit операционная система" :
            //    "32 Bit операционная система";
            //dungeonLabel3.Text = "Пользователь - " + UserName;
        }
        private static int getActiveAudioInputDevice()
        {
            bool found = false;
            int id = 0;
            var deviceId = RecordersManager.GetCurrentDevice();

            for (int i = 0; i < RecordersManager.GetDeviceCount(); i++)
            {
                RecordersManager.GetDeviceInfoByIndex(i, out _, out string testDevice);

                if (deviceId == testDevice) { found = true; break; };
                id += 1;
            }
            //var device = RecordersManager.GetRecordingDeviceInfo();

            //foreach (var dev in RecordersManager.EnumerateRecordingDevices())
            //{
            //    if (device.deviceId == dev.deviceId) { found = true; break; }
            //    id += 1;
            //}

            if (!found)
                id = -1;

            return id;
        }
        private static int getActiveVideoDeviceIndex()
        {
            bool found = false;
            int id = 0;
            var deviceId = VideoManager.GetCurrentDevice();

            for (int i = 0; i < VideoManager.GetDeviceCount(); i++) 
            {
                VideoManager.GetDeviceInfoByIndex(i, out _, out string testDevice);

                if (deviceId == testDevice) { found = true; break; };
                id += 1;
            }

            //foreach (var dev in VideoManager.EnumerateVideoDevices())
            //{
            //    if (device == dev.deviceId) { found = true; break; };
            //    id += 1;
            //}

            if (!found)
                id = -1;

            return id;
        }

        #region getDevicesList
        private static List<DeviceInfo> getListAudioInputDevices()
        {
            List<DeviceInfo> devicesOut = new();
            try
            {
                //devicesOut.AddRange(RecordersManager.EnumerateRecordingDevices());
                for (int i = 0; i < RecordersManager.GetDeviceCount(); i++)
                {
                    DeviceInfo device;
                    var t = RecordersManager.GetDeviceInfoByIndex(i, out device.Name, out device.Id);
                    devicesOut.Add(device);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"{ex.Message}\n{GET_RECORDERS_LIST_ERROR_MSG}");
            }

            return devicesOut;
        }
        private static List<DeviceInfo> getListAudioOutDevices()
        {
            List<DeviceInfo> devicesOut = new();
            //devicesOut.AddRange(SpeakersManager.EnumeratePlaybackDevices());
            for (int i = 0; i < SpeakersManager.GetDeviceCount(); i++)
            {
                DeviceInfo device;
                var t = SpeakersManager.GetDeviceInfoByIndex(i, out device.Name, out device.Id);
                devicesOut.Add(device);
            }

            return devicesOut;
        }
        private static List<DeviceInfo> getListVideoDevices()
        {
            List<DeviceInfo> devicesOut = new();
            try
            {
                //devicesOut.AddRange(VideoManager.EnumerateVideoDevices());
                for (int i = 0; i < VideoManager.GetDeviceCount(); i++) 
                {
                    DeviceInfo device;
                    var t = VideoManager.GetDeviceInfoByIndex(i, out device.Name, out device.Id);
                    devicesOut.Add(device);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"{ex.Message}\n{GET_VIDEO_LIST_ERROR_MSG}");
            }

            return devicesOut;
        }

        //private static int GetIndexRecordingDevice(string deviceID)
        //{
        //    int ind = -1;

        //    foreach (var device in RecordersManager.EnumerateRecordingDevices())
        //    {
        //        if (device.deviceId == deviceID) break;
        //        ind++;
        //    }

        //    return ind;
        //}
        //private static int GetIndexSpekerDevice(string deviceID)
        //{
        //    int ind = -1;

        //    foreach (var device in SpeakersManager.EnumeratePlaybackDevices())
        //    {
        //        if (device.deviceId == deviceID) break;
        //        ind++;
        //    }

        //    return ind;
        //}
        //private static int GetIndexVideoDevice(string deviceID)
        //{
        //    int ind = -1;

        //    foreach (var device in VideoManager.EnumerateVideoDevices())
        //    {
        //        if (device.deviceId == deviceID) break;
        //        ind++;
        //    }

        //    return ind;
        //}
        #endregion

        #region ComboBoxEventHandlers
        private void comboBoxAudioInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Init) return;

            DeviceInfo dev;
            int ind = ((System.Windows.Forms.ComboBox)sender).SelectedIndex;
            var ret = RecordersManager.GetDeviceInfoByIndex(ind, out dev.Name, out dev.Id);

            if (ret == ERROR_CODE.ERR_OK)
                RecordersManager.SetCurrentDevice(dev.Id);
            //var RecorderList = RecordersManager.EnumerateRecordingDevices();

                //if (RecorderList.Length > ind)
                //    dev = RecorderList[ind];

                //SelectedRecorder = dev;
                //RecordersManager.SetRecordingDevice(dev.Id);
        }
        private void comboBoxAudioOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Init) return;

            DeviceInfo dev;
            int ind = ((System.Windows.Forms.ComboBox)sender).SelectedIndex;
            var ret = SpeakersManager.GetDeviceInfoByIndex(ind, out dev.Name, out dev.Id);

            if (ret == ERROR_CODE.ERR_OK)
                SpeakersManager.SetCurrentDevice(dev.Id);
            //var SpeakerList = SpeakersManager.EnumeratePlaybackDevices();

            //if (SpeakerList.Length > ind)
            //    dev = SpeakerList[ind];

            //SelectedRecorder = dev;
            //RecordersManager.SetRecordingDevice(dev.Id);
        }
        private void comboBoxVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Init) return;

            DeviceInfo dev;
            int ind = ((System.Windows.Forms.ComboBox)sender).SelectedIndex;
            var ret = VideoManager.GetDeviceInfoByIndex(ind, out dev.Name, out dev.Id);

            if (ret == ERROR_CODE.ERR_OK)
                VideoManager.SetCurrentDevice(dev.Id);
            //var VideoList = VideoManager.EnumerateVideoDevices();

            //if (VideoList.Length > ind)
            //    dev = VideoList[ind];

            //SelectedVideoOut = dev;
            //VideoManager.SetDevice(dev.Id);
            workForm.RefreshLocalWnd();
        }
        private void ComboBoxRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var res = ComboBoxRes.SelectedValue;
            UpdateResolution(res.ToString());

            SelectedResolution = res.ToString();
            pictureBoxLocalVideoTest.Refresh();
        }
        #endregion

        private void trackBarSoundIn_ValueChanged()
        {
            SelectedVolumeIn = trackBarSoundIn.Value;

            RecordersManager.
                SetDeviceVolume(SelectedVolumeIn);
        }

        private static void UpdateResolution(string res)
        {
            //AgoraObject.Rtc.SetVideoProfile(resolutions[res], false);
            if (res == null) return;

            AgoraObject.Rtc.SetVideoEncoderConfiguration(new()
            {
                dimensions = resolutionsSize[res].dimensions,
                bitrate = resolutionsSize[res].bitrate,
                frameRate = FRAME_RATE.FRAME_RATE_FPS_24,
                orientationMode = ORIENTATION_MODE.ORIENTATION_MODE_FIXED_LANDSCAPE
            });
            System.Diagnostics.Debug.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")}: select resolution: {res}");

            if (AgoraObject.IsScreenCapture)
                AgoraObject.StartScreenCapture(resolutionsSize[res]);

        }
        private void NewDevices_FormClosed(object sender, FormClosedEventArgs e)
        {
            AcceptAllOldDevices();

            workForm?.SetLocalVideoPreview();
            _instance = null;

            Dispose();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            SetupNewOldDevices();

            CloseButton_Click(sender, e);
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            SetupNewOldDevices();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            trackBarSoundIn.Value = oldVolumeIn;
            trackBarSoundIn_ValueChanged();

            //workForm?.DevicesClosed(this);
            AcceptAllOldDevices();

            Close();
        }
        private void buttonImgSend_Click(object sender, EventArgs e)
        {
            if (ImageSender.IsEnable || IsImageSend)
            {
                ImageSender.configImageToSend(null);
                ImageSender.EnableImageSender(false);

                ResetVideoDevice();
                btnCustomImage.ForeColor = InactiveColor;
                PreviewPanel.BackgroundImage = null;
                (Owner as Broadcaster).PreviewFilePath = "";
                pictureBoxLocalVideoTest.Show();
            }
            else
            {
                var fd = new OpenFileDialog();
                fd.ShowDialog();

                if (fd.FileName == String.Empty) return;

                try
                {
                    SetImageSend(false);
                    btnCustomImage.ForeColor = PushColor;
                    //btnCustomImage.Cursor = Cursors.WaitCursor;

                    (Owner as Broadcaster).PreviewFilePath = fd.FileName;
                    ImageSender.configImageToSend(new Bitmap(fd.FileName), 5);
                    ImageSender.EnableImageSender(true);
                    PreviewPanel.BackgroundImage = new Bitmap(fd.FileName);
                    pictureBoxLocalVideoTest.Hide();
                    //btnCustomImage.Cursor = Cursors.Default;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            IsImageSend = ImageSender.IsEnable;
            workForm?.InvokeUpdateColors();
        }
        public static void SetImageSend(bool block)
        {
            if (_instance == null) return;

            if (_instance.InvokeRequired)
                _instance.Invoke((MethodInvoker)delegate
                {
                    _instance.BlockImageSendBtn(block);
                });
            else
            {
                _instance.BlockImageSendBtn(block);
            }
        }
        private void BlockImageSendBtn(bool block)
        {
           //btnCustomImage.Enabled = block;
        }

        private void SetupNewOldDevices()
        {
            var ain = comboBoxAudioInput.SelectedIndex;
            var video = comboBoxVideo.SelectedIndex;

            if (Recorders.Count > ain) oldRecorder = Recorders[ain];
            if (VideoOut.Count > video) oldVideoOut = VideoOut[video];

            oldVolumeIn = trackBarSoundIn.Value;
            oldResolution = ComboBoxRes.SelectedValue.ToString();
            oldIndexResolution = ComboBoxRes.SelectedIndex;
        }
        public static void AcceptAllOldDevices()
        {
            AcceptNewRecordDevice();
            AcceptNewVideoRecDevice();
            AcceptNewResolution();
        }
        private static void AcceptNewResolution()
        {
            UpdateResolution(oldResolution);
        }
        private static void AcceptNewVideoRecDevice()
        {
            if (oldVideoOut.Id == null) return;

            try
            {
                VideoManager.SetCurrentDevice(oldVideoOut.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed video.\n" + ex.Message);
            }
        }
        private static void AcceptNewRecordDevice()
        {
            if (oldVideoOut.Id == null) return;

            try
            {
                RecordersManager.SetCurrentDevice(oldRecorder.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed recorders.\n" + ex.Message);
            }
        }

        public static void Clear()
        {
            oldVolumeIn = 100;
            oldRecorder = new();
            oldVideoOut = new();
            oldResolution = null;
            oldIndexResolution = AgoraObject.joinType == HostType.Broadcaster ?
                HDresolution : LDresolution; ;
        }

        #region Bass
        private void testMic_Click(object sender, EventArgs e)
        {
            IsAudioTest = !IsAudioTest;
            if (IsAudioTest)
            {
                ReleaseBass();
                testMic.Text = "Stop";
                AgoraObject.Rtc.DisableAudio();
                Bass.LoadMe();
                InitPlayback();
            }
            else
            {
                testMic.Text = "Test";
                ReleaseBass();
                AgoraObject.Rtc.EnableAudio();
            }
        }

        bool RECORDPROC(int handle, IntPtr buffer, int length, IntPtr user) //This functions is called every time recorder sends stream to the speaker
        {

            Bass.BASS_StreamPutData(output, buffer, length);
            if (prebuf > 0)
            { // still prebuffering
                prebuf -= length;
            }
            else
            {
                Bass.BASS_ChannelPlay(output, false);
                BASS_INFO info = Bass.BASS_GetInfo();
                prebuf = Bass.BASS_ChannelSeconds2Bytes(output, (float)info.minbuf / 1000);
                /*
                 Simply the most important part of the code is coming next, delete this and you will face 
                your death from ManagedBass NullReference exception
                 */
                if (++frames > 750) //every 7.5 seconds
                {
                    frames = 0;
                    InitPlayback();
                    return false;
                }
            }
            return true;
        }

        private void InitPlayback() //Takes input from mic and pushes it to the speaker
        {
            int speaker_index = -1;
            int microphone_index = GetRecordIndex(recording_device);

            Bass.BASS_RecordInit(microphone_index);
            Bass.BASS_Init(speaker_index, 44100, BASSInit.BASS_DEVICE_SPEAKERS, IntPtr.Zero);
            output = Bass.BASS_StreamCreate(44100, 1, BASSFlag.BASS_STREAM_AUTOFREE, BASSStreamProc.STREAMPROC_PUSH);
            Bass.BASS_ChannelSetDevice(output, speaker_index);
            Bass.BASS_ChannelSetDevice(input, microphone_index);

            input = Bass.BASS_RecordStart(44100, 1, BASSFlag.BASS_STREAM_AUTOFREE, RECORDPROC, IntPtr.Zero);
            GC.Collect();
        }

        private int GetDeviceIndex(string devicename)
        {
            var devices = Bass.BASS_GetDeviceInfos();
            int device_index = 0;
            foreach (BASS_DEVICEINFO device in devices)
            {
                if (device.name == devicename)
                    return device_index;
                else
                    device_index++;
            }
            return -1;
        }
        private int GetRecordIndex(string devicename)
        {
            var devices = Bass.BASS_RecordGetDeviceInfos();
            int device_index = 0;
            foreach (BASS_DEVICEINFO device in devices)
            {
                if (device.name == devicename)
                    return device_index;
                else
                    device_index++;
            }
            return -1;
        }

        private void ReleaseBass() //Completely releases ManagedBass streams and channels
        {
            Bass.BASS_StreamFree(output);
            Bass.BASS_ChannelStop(input);
            Bass.BASS_RecordFree();
            Bass.BASS_Free();
            Bass.BASS_Stop();
            Bass.FreeMe();
            GC.Collect();
        }

        #endregion

        private void CancelBtn_MouseHover(object sender, EventArgs e)
        {
            CancelBtn.Margin = Hovered;
            CancelBtn.Focus();
        }

        private void CancelBtn_MouseLeave(object sender, EventArgs e)
        {
            CancelBtn.Margin = MarginNormal;
        }

        private void ConfirmBtn_MouseHover(object sender, EventArgs e)
        {
            ConfirmBtn.Margin = Hovered;
            ConfirmBtn.Focus();
        }

        private void ConfirmBtn_MouseLeave(object sender, EventArgs e)
        {
            ConfirmBtn.Margin = MarginNormal;
        }

        private void ApplyBtn_MouseHover(object sender, EventArgs e)
        {
            ApplyBtn.Margin = Hovered;
            ApplyBtn.Focus();
        }

        private void ApplyBtn_MouseLeave(object sender, EventArgs e)
        {
            ApplyBtn.Margin = MarginNormal;
        }

        private void MainTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelGeneral_Paint(object sender, PaintEventArgs e)
        {
            Brush br = new SolidBrush(LabelGeneral.ForeColor);

            e.Graphics.TranslateTransform(0, LabelGeneral.Height);
            e.Graphics.RotateTransform(-90);

            e.Graphics.DrawString("General", CommonFont, br, 15, 2);
        }

        private void LabelMisc_Paint(object sender, PaintEventArgs e)
        {
            Brush br = new SolidBrush(LabelMisc.ForeColor);

            e.Graphics.TranslateTransform(0, LabelMisc.Height);
            e.Graphics.RotateTransform(-90);

            e.Graphics.DrawString("Misc", CommonFont, br, 30, 2);
        }

        private void LabelGeneral_Click(object sender, EventArgs e)
        {
            LabelGeneral.ForeColor = Color.FromArgb(40, 40, 40);
            LabelGeneral.BackColor = Color.White;
            LabelMisc.ForeColor = Color.FromArgb(240, 240, 240);
            LabelMisc.BackColor = Color.Gray;
            TableMisc.Hide();
            TableGeneral.Show();
            MainLayout.ColumnStyles[0].Width = 100;
            MainLayout.ColumnStyles[1].Width = 0;
            comboBoxAudioInput.Refresh();
            comboBoxAudioOutput.Refresh();
            comboBoxVideo.Refresh();
            ComboBoxRes.Refresh();
        }

        private void LabelMisc_Click(object sender, EventArgs e)
        {
            LabelMisc.ForeColor = Color.FromArgb(40, 40, 40);
            LabelMisc.BackColor = Color.White;
            LabelGeneral.ForeColor = Color.FromArgb(240, 240, 240);
            LabelGeneral.BackColor = Color.Gray;
            TableMisc.Show();
            TableGeneral.Hide();
            MainLayout.ColumnStyles[1].Width = 100;
            MainLayout.ColumnStyles[0].Width = 0;
            AudioQualityCmb.Refresh();
        }
    }
}
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
using agora.rtc;
using RSI_X_Desktop.forms;
using static System.Environment;

namespace RSI_X_Desktop.forms
{
    public partial class PopUpForm : DevExpress.XtraEditors.XtraForm
    {
        private const int HDresolution = 6;
        private static PopUpForm _instance;
        private static readonly Color InactiveColor = Color.White;
        private static readonly Color PushColor = Color.BurlyWood;
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
            [" 160 * 120 "] = new(120, 160, 15, BITRATE.STANDARD_BITRATE, false, false) { bitrate = 65 },
            [" 320 * 180 "] = new(180, 320, 15, BITRATE.STANDARD_BITRATE, false, false) { bitrate = 140 },
            [" 320 * 240 "] = new(240, 240, 15, BITRATE.STANDARD_BITRATE, false, false) { bitrate = 200 },
            [" 640 * 360 "] = new(360, 360, 15, BITRATE.STANDARD_BITRATE, false, false) { bitrate = 400 },
            [" 640 * 480 "] = new(480, 480, 15, BITRATE.STANDARD_BITRATE, false, false) { bitrate = 500 },
            ["1280 * 720 "] = new(960, 720, 15, BITRATE.STANDARD_BITRATE, false, false) { bitrate = 1130 },
            ["1920 * 1080"] = new(1920, 1080, 15, BITRATE.STANDARD_BITRATE, false, false) { bitrate = 2080 },
        };

        private static IFormHostHolder workForm = AgoraObject.GetWorkForm;

        static private IAgoraRtcAudioRecordingDeviceManager RecordersManager;
        static private IAgoraRtcAudioPlaybackDeviceManager SpeakersManager;
        static private IAgoraRtcVideoDeviceManager VideoManager;
        static List<DeviceInfo> Recorders;
        static List<DeviceInfo> VideoOut;

        bool Init = false;

        private static int oldVolumeIn;
        private static DeviceInfo oldRecorder;
        private static DeviceInfo oldVideoOut;
        public static string oldResolution { get; private set; }
        private static int oldIndexResolution = HDresolution; //1080p

        private static int SelectedVolumeIn;
        private static DeviceInfo SelectedRecorder;
        private static DeviceInfo SelectedVideoOut;
        public static string SelectedResolution { get; private set; }
        private static int SelectedIndexResolution = HDresolution; //1080p

        private int frames = 0;
        private string playback_device = "";
        private string recording_device = "";

        private bool IsAudioTest = false;
        private int output;
        private int input;
        private long prebuf;

        Padding MarginNormal = new Padding(15);
        Padding Hovered = new Padding(13);

        public PopUpForm()
        {
            InitializeComponent();

            RecordersManager = AgoraObject.Rtc.GetAgoraRtcAudioRecordingDeviceManager();
            SpeakersManager = AgoraObject.Rtc.GetAgoraRtcAudioPlaybackDeviceManager();
            VideoManager = AgoraObject.Rtc.GetAgoraRtcVideoDeviceManager();
        }

        public static void SetupOldDevices()
        {
            VideoOut = getListVideoDevices();
            Recorders = getListAudioInputDevices();

            bool hasOldRecorder = Recorders.Any((s) => s.deviceId == oldRecorder.deviceId);

            int index = (oldRecorder.deviceId != null) ?
                Recorders.FindLastIndex((s) => s.deviceId == oldRecorder.deviceId) :
                index = getActiveAudioInputDevice();


            oldRecorder = Recorders[index];

            if (VideoOut.Count > 0 && index > 0)
                oldVideoOut = VideoOut[0];

            oldResolution = resolutions.Keys.ToArray()[oldIndexResolution];
            UpdateResolution(oldResolution);
        }

        private void SetWndRegion()
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 45;
            System.Drawing.Rectangle r = new System.Drawing.Rectangle(0, 0, Width, Height);
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            path.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            path.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            this.Region = new Region(path);
        }

        private void PopUpForm_Load(object sender, EventArgs e)
        {
            SetWndRegion();
            _instance = this;
            oldVolumeIn = RecordersManager.GetRecordingDeviceVolume();
            trackBarSoundIn.Value = oldVolumeIn;

            Recorders = getListAudioInputDevices();
            VideoOut = getListVideoDevices();

            UpdateComboBoxRecorder();
            UpdateComboBoxVideoOut();

            setupComputerDescription();
            MainTable.Rows[3].Visible = false;
            MainTable.Rows[4].Visible = false;
            //ComboBoxRes.DataSource = new List<string>(resolutions.Keys);
            //ComboBoxRes.SelectedIndex = oldIndexResolution;

            //btnCustomImage.ForeColor = IsImageSend ?
            //    PushColor : InactiveColor;

            workForm = AgoraObject.GetWorkForm;

            Init = true;

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
            bool hasOldRecorder = Recorders.Any((s) => s.deviceId == oldRecorder.deviceId);

            int index = (oldRecorder.deviceId != "" && hasOldRecorder) ?
                Recorders.FindLastIndex((s) => s.deviceId == oldRecorder.deviceId) :
                getActiveAudioInputDevice();

            if (index == -1)
                index = Recorders.Count > 0 ? 0 : -1;

            if (index == -1 || Recorders.Count == 0)
            {
                comboBoxAudioInput.DataSource = new List<string> { "Record Devices Error" };
                return;
            }

            foreach (var rec in Recorders)
                listRecorders.Add(rec.deviceName);

            oldRecorder = Recorders[index];
            SelectedRecorder = Recorders[index];

            comboBoxAudioInput.DataSource = listRecorders;
            comboBoxAudioInput.SelectedIndex = index;
        }
        private void UpdateComboBoxVideoOut()
        {
            VideoOut = getListVideoDevices();
            List<string> listVideo = new();
            bool hasoldVideoOut = VideoOut.Any((s) => s.deviceId == oldVideoOut.deviceId);

            int index = (oldVideoOut.deviceId != "") ?
                VideoOut.FindLastIndex((s) => s.deviceId == oldVideoOut.deviceId) :
                getActiveVideoDevice();

            if (index == -1)
                index = VideoOut.Count > 0 ? 0 : -1;

            if (index == -1 || VideoOut.Count == 0)
            {
                comboBoxVideo.DataSource = new List<string> { "Video Devices Error" };
                return;
            }

            foreach (var rec in VideoOut)
                listVideo.Add(rec.deviceName);

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

                int index = VideoOut.FindLastIndex((s) => s.deviceId == oldVideoOut.deviceId);
                index = index == -1 ? 0 : index;

                var device = VideoManager.EnumerateVideoDevices()[index];

                DebugWriter.WriteTime("update video device");
                VideoManager.SetDevice(device.deviceId);
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

            var device = RecordersManager.GetRecordingDeviceInfo();

            foreach (var dev in RecordersManager.EnumerateRecordingDevices())
            {
                if (device.deviceId == dev.deviceId) { found = true; break; }
                id += 1;
            }

            if (!found)
                id = -1;

            return id;
        }
        private static int getActiveVideoDevice()
        {
            bool found = false;
            int id = 0;
            var device = VideoManager.GetDevice();

            foreach (var dev in VideoManager.EnumerateVideoDevices())
            {
                if (device == dev.deviceId) { found = true; break; };
                id += 1;
            }

            if (!found)
                id = -1;

            return id;
        }

        #region getDevicesList
        private static List<DeviceInfo> getListAudioInputDevices()
        {
            List<DeviceInfo> devicesOut = new();
            devicesOut.AddRange(RecordersManager.EnumerateRecordingDevices());

            return devicesOut;
        }
        private static List<DeviceInfo> getListAudioOutDevices()
        {
            List<DeviceInfo> devicesOut = new();
            devicesOut.AddRange(SpeakersManager.EnumeratePlaybackDevices());

            return devicesOut;
        }
        private static List<DeviceInfo> getListVideoDevices()
        {
            List<DeviceInfo> devicesOut = new();
            var t = VideoManager.EnumerateVideoDevices();
            devicesOut.AddRange(t);

            return devicesOut;
        }

        private static int GetIndexRecordingDevice(string deviceID)
        {
            int ind = -1;

            foreach (var device in RecordersManager.EnumerateRecordingDevices())
            {
                if (device.deviceId == deviceID) break;
                ind++;
            }

            return ind;
        }
        private static int GetIndexSpekerDevice(string deviceID)
        {
            int ind = -1;

            foreach (var device in SpeakersManager.EnumeratePlaybackDevices())
            {
                if (device.deviceId == deviceID) break;
                ind++;
            }

            return ind;
        }
        private static int GetIndexVideoDevice(string deviceID)
        {
            int ind = -1;

            foreach (var device in VideoManager.EnumerateVideoDevices())
            {
                if (device.deviceId == deviceID) break;
                ind++;
            }

            return ind;
        }
        #endregion

        #region ComboBoxEventHandlers
        private void comboBoxAudioInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Init) return;

            DeviceInfo dev;
            int ind = ((System.Windows.Forms.ComboBox)sender).SelectedIndex;
            var RecorderList = RecordersManager.EnumerateRecordingDevices();

            if (RecorderList.Length > ind)
                dev = RecorderList[ind];

            SelectedRecorder = dev;
            RecordersManager.SetRecordingDevice(dev.deviceId);
        }
        private void comboBoxAudioOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Init) return;

            DeviceInfo dev;
            int ind = ((System.Windows.Forms.ComboBox)sender).SelectedIndex;
            var SpeakerList = SpeakersManager.EnumeratePlaybackDevices();

            if (SpeakerList.Length > ind)
                dev = SpeakerList[ind];

            SelectedRecorder = dev;
            RecordersManager.SetRecordingDevice(dev.deviceId);
        }
        private void comboBoxVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Init) return;

            DeviceInfo dev;
            int ind = ((System.Windows.Forms.ComboBox)sender).SelectedIndex;
            var VideoList = VideoManager.EnumerateVideoDevices();

            if (VideoList.Length > ind)
                dev = VideoList[ind];

            SelectedVideoOut = dev;
            VideoManager.SetDevice(dev.deviceId);
            workForm.RefreshLocalWnd();
        }
        private void ComboBoxRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var res = ComboBoxRes.SelectedValue;
            //UpdateResolution(res.ToString());

            //SelectedResolution = res.ToString();
            //pictureBoxLocalVideoTest.Refresh();
        }
        #endregion

        private void trackBarSoundIn_ValueChanged()
        {
            SelectedVolumeIn = trackBarSoundIn.Value;

            RecordersManager.
                SetRecordingDeviceVolume(SelectedVolumeIn);
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
            var ain = comboBoxAudioInput.SelectedIndex;
            var video = comboBoxVideo.SelectedIndex;

            if (Recorders.Count > ain) oldRecorder = Recorders[ain];
            if (VideoOut.Count > video) oldVideoOut = VideoOut[video];

            oldVolumeIn = trackBarSoundIn.Value;
            //oldResolution = ComboBoxRes.SelectedValue.ToString();
            //oldIndexResolution = ComboBoxRes.SelectedIndex;

            CloseButton_Click(sender, e);
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            var ain = comboBoxAudioInput.SelectedIndex;
            var video = comboBoxVideo.SelectedIndex;

            if (Recorders.Count > ain) oldRecorder = Recorders[ain];
            if (VideoOut.Count > video) oldVideoOut = VideoOut[video];

            oldVolumeIn = trackBarSoundIn.Value;
            //oldResolution = ComboBoxRes.SelectedValue.ToString();
            //oldIndexResolution = ComboBoxRes.SelectedIndex;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            trackBarSoundIn.Value = oldVolumeIn;
            trackBarSoundIn_ValueChanged();

            //workForm?.DevicesClosed(this);
            Close();
        }
        private void buttonImgSend_Click(object sender, EventArgs e)
        {
            if (ImageSender.IsEnable || IsImageSend)
            {
                ImageSender.configImageToSend(null);
                ImageSender.EnableImageSender(false);

                ResetVideoDevice();
                //btnCustomImage.ForeColor = InactiveColor;
            }
            else
            {
                var fd = new OpenFileDialog();
                fd.ShowDialog();

                if (fd.FileName == String.Empty) return;

                try
                {
                    SetImageSend(false);
                    //btnCustomImage.ForeColor = PushColor;
                    //btnCustomImage.Cursor = Cursors.WaitCursor;

                    ImageSender.configImageToSend(new Bitmap(fd.FileName), 5);
                    ImageSender.EnableImageSender(true);

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
            if (oldVideoOut.deviceId == null) return;

            try
            {
                VideoManager.SetDevice(oldVideoOut.deviceId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed video.\n" + ex.Message);
            }
        }
        private static void AcceptNewRecordDevice()
        {
            if (oldVideoOut.deviceId == null) return;

            try
            {
                RecordersManager.SetRecordingDevice(oldRecorder.deviceId);
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
            oldIndexResolution = HDresolution;
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
            CancelBtn.Margin = DefaultMargin;
        }

        private void ConfirmBtn_MouseHover(object sender, EventArgs e)
        {
            ConfirmBtn.Margin = Hovered;
            ConfirmBtn.Focus();
        }

        private void ConfirmBtn_MouseLeave(object sender, EventArgs e)
        {
            ConfirmBtn.Margin = DefaultMargin;
        }

        private void ApplyBtn_MouseHover(object sender, EventArgs e)
        {
            ApplyBtn.Margin = Hovered;
            ApplyBtn.Focus();
        }

        private void ApplyBtn_MouseLeave(object sender, EventArgs e)
        {
            ApplyBtn.Margin = DefaultMargin;
        }
    }
}
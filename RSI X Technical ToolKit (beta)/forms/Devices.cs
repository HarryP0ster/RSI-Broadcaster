using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ReaLTaiizor;
using agorartc;
using RSI_X_Desktop.forms;
using static System.Environment;

namespace RSI_X_Desktop.forms
{
    public partial class Devices : Form
    {
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
            [" 160 * 120 "] = new(120, 160) { bitrate = 65, frameRate = 15 },
            [" 320 * 180 "] = new(180, 320) { bitrate = 140, frameRate = 15 },
            [" 320 * 240 "] = new(240, 240) { bitrate = 200, frameRate = 15 },
            [" 640 * 360 "] = new(360, 360) { bitrate = 400, frameRate = 15 },
            [" 640 * 480 "] = new(480, 480) { bitrate = 500, frameRate = 15 },
            ["1280 * 720 "] = new(960, 720) { bitrate = 1130, frameRate = 15 },
            ["1920 * 1080"] = new(1920, 1080) { bitrate = 2080, frameRate = 15 },
        };

        private IFormHostHolder workForm = AgoraObject.GetWorkForm;
        static private AgoraAudioRecordingDeviceManager RecordersManager;
        static private AgoraAudioPlaybackDeviceManager SpeakersManager;
        static private AgoraVideoDeviceManager videoDeviceManager;
        static List<string> Recorders;
        static List<string> VideoOut;

        private static int oldVolumeIn;
        private static string oldRecorder;
        private static string oldVideoOut;
        public static string oldResolution { get; private set; }
        private static int oldIndexResolution = 6; //1080p

        public Devices()
        {
            InitializeComponent();
        }
        public static void InitManager()
        {
            RecordersManager = AgoraObject.Rtc.CreateAudioRecordingDeviceManager();
            SpeakersManager = AgoraObject.Rtc.CreateAudioPlaybackDeviceManager();
            videoDeviceManager = AgoraObject.Rtc.CreateVideoDeviceManager();

            Recorders = getListAudioInputDevices();
            VideoOut = getListVideoDevices();

            bool hasOldRecorder = Recorders.Any((s) => s == oldRecorder);

            int index = (oldRecorder != null) ?
                Recorders.FindLastIndex((s) => s == oldRecorder) :
                index = getActiveAudioInputDevice();

            oldRecorder = Recorders[index];

            oldResolution = resolutions.Keys.ToArray()[oldIndexResolution];
            UpdateResolution(oldResolution);
        }
        private void NewDevices_Load(object sender, EventArgs e)
        {

            oldVolumeIn = RecordersManager.GetDeviceVolume();
            trackBarSoundIn.Value = oldVolumeIn;

            Recorders = getListAudioInputDevices();
            VideoOut = getListVideoDevices();
            
            UpdateComboBoxRecorder();
            UpdateComboBoxVideoOut();
            
            getComputerDescription();

            ComboBoxRes.DataSource = new List<string>(resolutions.Keys);
            ComboBoxRes.SelectedIndex = oldIndexResolution;
        }
        private void UpdateComboBoxRecorder()
        {
            Recorders = getListAudioInputDevices();
            bool hasOldRecorder = Recorders.Any((s) => s == oldRecorder);

            int index = (oldRecorder != null && hasOldRecorder) ?
                Recorders.FindLastIndex((s) => s == oldRecorder) :
                getActiveAudioInputDevice();

            if (index == -1)
                index = Recorders.Count > 0 ? 0 : -1;

            if (index == -1 || Recorders.Count == 0)
            {
                comboBoxAudioInput.DataSource = new List<string> { "Record Devices Error" };
                return;
            }

            oldRecorder = Recorders[index];

            comboBoxAudioInput.DataSource = Recorders;
            comboBoxAudioInput.SelectedIndex = index;
        }
        private void UpdateComboBoxVideoOut()
        {
            VideoOut = getListVideoDevices();
            bool hasoldVideoOut = VideoOut.Any((s) => s == oldVideoOut);

            int index = (oldVideoOut != null) ?
                VideoOut.FindLastIndex((s) => s == oldVideoOut) :
                getActiveVideoDevice();

            if (index == -1)
                index = VideoOut.Count > 0 ? 0 : -1;

            if (index == -1 || VideoOut.Count == 0)
            {
                comboBoxVideo.DataSource = new List<string> { "Video Devices Error" };
                return;
            }


            oldVideoOut = VideoOut[index];
            comboBoxVideo.DataSource = VideoOut;
            comboBoxVideo.SelectedIndex = index;
        }

        private void getComputerDescription()
        {
            dungeonLabel1.Text = "Версия ОС - " + OSVersion.VersionString;

            if (Is64BitOperatingSystem == true)
            {
                dungeonLabel2.Text = "64 Bit операционная система";
            }
            else
            {
                dungeonLabel2.Text = "32 Bit операционная система";
            }

            dungeonLabel3.Text = "Пользователь - " + UserName;

        }

        private static int getActiveAudioInputDevice()
        {
            int id = -1;

            RecordersManager.GetCurrentDeviceInfo(out string idAcvite, out string nameAcitve);

            for (int i = 0; i < RecordersManager.GetDeviceCount(); i++)
            {
                var ret = RecordersManager.GetDeviceInfoByIndex(i, out string name, out string deviceid);
                if (idAcvite == deviceid)
                {
                    id = i;
                    break;
                }

            }
            return id;
        }

        private int getActiveAudioOutputDevice()
        {
            int id = -1;

            SpeakersManager.GetCurrentDeviceInfo(out string idAcvite, out string nameAcitve);

            for (int i = 0; i < SpeakersManager.GetDeviceCount(); i++)
            {
                var ret = SpeakersManager.GetDeviceInfoByIndex(i, out string name, out string deviceid);
                if (idAcvite == deviceid)
                {
                    id = i;
                    break;
                }

            }
            return id;
        }

        private int getActiveVideoDevice()
        {
            int id = -1;

            string idActive = videoDeviceManager.GetCurrentDevice();

            for (int i = 0; i < videoDeviceManager.GetDeviceCount(); i++)
            {
                var ret = videoDeviceManager.GetDeviceInfoByIndex(i, out string name, out string deviceid);
                if (idActive == deviceid)
                {
                    id = i;
                    break;
                }

            }
            return id;
        }

        #region getDevicesList
        private static List<string> getListAudioInputDevices()
        {
            List<string> devicesOut = new();

            for (int i = 0; i < RecordersManager.GetDeviceCount(); i++)
            {
                string device, id;

                var ret = RecordersManager.GetDeviceInfoByIndex(i, out device, out id);

                if (ret == ERROR_CODE.ERR_OK)
                    devicesOut.Add(device);
            }
            return devicesOut;
        }

        private static List<string> getListAudioOutDevices()
        {
            List<string> devicesOut = new();

            for (int i = 0; i < SpeakersManager.GetDeviceCount(); i++)
            {
                string device, id;

                var ret = SpeakersManager.GetDeviceInfoByIndex(i, out device, out id);

                if (ret == ERROR_CODE.ERR_OK)
                    devicesOut.Add(device);
            }

            return devicesOut;
        }

        private static List<string> getListVideoDevices()
        {
            List<string> devicesOut = new();

            for (int i = 0; i < videoDeviceManager.GetDeviceCount(); i++)
            {
                string device, id;

                var ret = videoDeviceManager.GetDeviceInfoByIndex(i, out device, out id);

                if (ret == ERROR_CODE.ERR_OK)
                    devicesOut.Add(device);
            }

            return devicesOut;
        }
        #endregion

        #region ComboBoxEventHandlers
        private void comboBoxAudioInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = ((ComboBox)sender).SelectedIndex;
            string name, id;

            RecordersManager.GetDeviceInfoByIndex(ind, out name, out id);
            RecordersManager.SetCurrentDevice(id);
        }

        private void comboBoxAudioOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = ((ComboBox)sender).SelectedIndex;
            string name, id;

            SpeakersManager.GetDeviceInfoByIndex(ind, out name, out id);
            SpeakersManager.SetCurrentDevice(id);
        }

        private void comboBoxVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = ((ComboBox)sender).SelectedIndex;
            string name, id;

            videoDeviceManager.GetDeviceInfoByIndex(ind, out name, out id);
            videoDeviceManager.SetCurrentDevice(id);

            workForm.RefreshLocalWnd();
        }
        private void ComboBoxRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var res = ComboBoxRes.SelectedValue;
            UpdateResolution(res.ToString());

            pictureBoxLocalVideoTest.Refresh();
        }
        #endregion

        private static void UpdateResolution(string res)
        {
            AgoraObject.Rtc.SetVideoProfile(resolutions[res], false);
            System.Diagnostics.Debug.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")}: select resolution: {res}");

            if (AgoraObject.IsScreenCapture)
                AgoraObject.EnableScreenCapture(resolutionsSize[res]);

        }
        private void NewDevices_FormClosed(object sender, FormClosedEventArgs e)
        {
            //AgoraObject.Rtc.EnableLocalVideo(false);
            workForm?.SetLocalVideoPreview();
            Dispose();
        }

        private void trackBarSoundIn_ValueChanged()
        {
            var ret = RecordersManager.SetDeviceVolume(
                trackBarSoundIn.Value);
        }

        //private void trackBarSoundOut_ValueChanged(object sender, EventArgs e)
        //{
        //    SetVolume(trackBarSoundOut.Value);
        //    workForm?.SetTrackBarVolume(trackBarSoundOut.Value);
        //}

        public void SetAudienceSettings()
        {
            materialShowTabControl1.SelectTab(1);
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            oldRecorder = Recorders[comboBoxAudioInput.SelectedIndex];
            oldVideoOut = VideoOut[comboBoxVideo.SelectedIndex];
            oldVolumeIn = trackBarSoundIn.Value;
            oldResolution = ComboBoxRes.SelectedValue.ToString();
            oldIndexResolution = ComboBoxRes.SelectedIndex;

            CloseButton_Click(sender, e);
        }

        internal void CloseButton_Click(object sender, EventArgs e)
        {
            trackBarSoundIn.Value = oldVolumeIn;
            trackBarSoundIn_ValueChanged();

            AcceptAllOldDevices();

            AgoraObject.GetWorkForm?.DevicesClosed(this);
            Close();
        }
        public static void AcceptAllOldDevices()
        {
            try
            {
                AcceptNewRecordDevice();
                AcceptNewVideoRecDevice();
                AcceptNewResolution();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void AcceptNewResolution()
        {
            UpdateResolution(oldResolution);
        }
        private static void AcceptNewVideoRecDevice()
        {
            videoDeviceManager.GetDeviceInfoByIndex(
                VideoOut.FindLastIndex((s) => s == oldVideoOut),
                out string _, out string videoID);
            videoDeviceManager.SetCurrentDevice(videoID);
        }

        private static void AcceptNewRecordDevice()
        {
            RecordersManager.GetDeviceInfoByIndex(
                                Recorders.FindLastIndex((s) => s == oldRecorder),
                                out string _, out string recID);
            RecordersManager.SetCurrentDevice(recID);
        }
        public void typeOfAlligment(bool sign)
        {
            if (sign == true)
                materialShowTabControl1.Alignment = TabAlignment.Left;
            else
                materialShowTabControl1.Alignment = TabAlignment.Right;
        }

        private void materialShowTabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == Video)
            {
                workForm?.RefreshLocalWnd();
                VideoCanvas vc = new((ulong)pictureBoxLocalVideoTest.Handle, 0);
                vc.renderMode = ((int)RENDER_MODE_TYPE.RENDER_MODE_FIT);
                AgoraObject.Rtc.StartPreview();
                AgoraObject.Rtc.SetupLocalVideo(vc);
            }
        }
        private void materialShowTabControl1_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == Video)
                workForm?.SetLocalVideoPreview();
        }
        public static void Clear()
        {
            oldVolumeIn = 100;
            oldRecorder = null;
            oldVideoOut = null;
            oldResolution = null;
            oldIndexResolution = 3; //360p        
        }
    }
}

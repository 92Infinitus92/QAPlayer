using AxWMPLib;
using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WMPLib;

namespace QAPlayer
{
    public partial class Form1 : Form
    {
        //playspeed variables
        public const double zeroPointFive = 0.5;
        public const double zeroPointSix = 0.6;
        public const double zeroPointSeven = 0.7;
        public const double zeroPointEight = 0.8;
        public const double zeroPointNine = 0.9;
        public const double one = 1.0;
        public const double onePointOne = 1.1;
        public const double onePointTwo = 1.2;
        public const double onePointThree = 1.3;
        public const double onePointFour = 1.4;
        public const double onePointFive = 1.5;
        string[] arguments = Environment.GetCommandLineArgs();

        //globalscope dataset variables
        public DateTime startTime;
        public DateTime endTime;
        public bool isPlaying = false;
        string element;

        //database initialize
        readonly Database db = new Database();

        public Form1()
        {
            InitializeComponent();

            //allows drag and drop to the form
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        //Here we check that the dragged file is in supported extension
        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        //Implements the drag and drop autoplay function
        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var file = (string[])e.Data.GetData(DataFormats.FileDrop);
                string URL = file[0];
                this.axWindowsMediaPlayer1.URL = URL;
                startTime = DateTime.Now;
            }
        }

        //get's the file name and source
        private void Form1_Load(object sender, EventArgs e)
        {
            if (arguments.Length > 1)
            {
                axWindowsMediaPlayer1.URL = arguments[1];
                startTime = DateTime.Now;
            }
            listFile.ValueMember = "Path";
            listFile.DisplayMember = "FileName";
        }

        //implementation of adding files to a list
        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
                startTime = DateTime.Now;
            }
        }

        //the main method for the backbone requirement of tracking listenedTime
        private void CalculateTime(DateTime startTime, DateTime endTime)
        {
            string PCName = Form2.username.ToString();
            TimeSpan inSeconds = endTime - startTime;
            double totalTime = inSeconds.TotalSeconds;

            try
            {
                var cnn = db.Connect();
                //string date = endTime.ToString("dd-MM-yyyy HH:mm");
                db.PushToBaseElapsedTime(PCName, totalTime, endTime, cnn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //play/pause button
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPaused)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                btnPlay.Image = Properties.Resources.pause_30px;
                startTime = DateTime.Now;
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                btnPlay.Image = Properties.Resources.play_30px;
                endTime = DateTime.Now;
            }
        }

        //exit button
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
            Environment.Exit(0);
        }

        //the labels are connected with the timer and display the elapsed and totalTime of the current media
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            slider.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

            if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPlaying)
            {
                lblTotalTime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString.ToString();
                slider.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;
                element = axWindowsMediaPlayer1.URL;
            }
        }

        //detects when the player status is changed and collects datetime data
        private void player_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            bunifuLabel2.Text = axWindowsMediaPlayer1.status;
            //imgEqualizer.Enabled = player.status.ToLower().Contains("playing");


            if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsMediaEnded)
            {
                endTime = DateTime.Now;
                CalculateTime(startTime, endTime);
                axWindowsMediaPlayer1.settings.setMode("loop", true);
            }

            if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPaused || axWindowsMediaPlayer1.playState == WMPPlayState.wmppsStopped)
            {
                endTime = DateTime.Now;
                CalculateTime(startTime, endTime);
                isPlaying = false;
            }
            else if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPlaying)
            {
                startTime = DateTime.Now;
                isPlaying = true;
            }
        }

        //btn skip 5 seconds
        private void btnForward_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 5;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        //timer for the volume bar
        private void timer2_Tick(object sender, EventArgs e)
        {
            lblVolume.Text = "Volume: " + volumeControl2.Value.ToString() + "%";
        }

        //mouse move and label of the volume bar
        private void volumeControl2_MouseMove(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = volumeControl2.Value;
            lblVolume.Text = "Volume: " + volumeControl2.Value.ToString() + "%";
        }

        //button to minimize the app
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //moves the slider to the desired position based on mouse click event
        private void slider_MouseUp(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = slider.Value;
        }

        //btn rewinds 5 seconds
        private void btnBackward_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 5;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        //when spacebar or enter is pressed the playstate is changed the play or pause depending from the previous state
        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space))
            {
                if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPlaying)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                }
                else if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPaused)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
        }

        //slider for changing the platSpeed
        private void trbPlaySpeed_ValueChanged(object sender, EventArgs e)
        {
            switch (trbPlaySpeed.Value)
            {
                case 1:
                    axWindowsMediaPlayer1.settings.rate = zeroPointFive;
                    break;
                case 2:
                    axWindowsMediaPlayer1.settings.rate = zeroPointSix;
                    break;
                case 3:
                    axWindowsMediaPlayer1.settings.rate = zeroPointSeven;
                    break;
                case 4:
                    axWindowsMediaPlayer1.settings.rate = zeroPointEight;
                    break;
                case 5:
                    axWindowsMediaPlayer1.settings.rate = zeroPointNine;
                    break;
                case 6:
                    axWindowsMediaPlayer1.settings.rate = one;
                    break;
                case 7:
                    axWindowsMediaPlayer1.settings.rate = onePointOne;
                    break;
                case 8:
                    axWindowsMediaPlayer1.settings.rate = onePointTwo;
                    break;
                case 9:
                    axWindowsMediaPlayer1.settings.rate = onePointThree;
                    break;
                case 10:
                    axWindowsMediaPlayer1.settings.rate = onePointFour;
                    break;
                case 11:
                    axWindowsMediaPlayer1.settings.rate = onePointFive;
                    break;
            }
        }

        //applying control from certain keys from the keyboard
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 5;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }

            if (e.KeyCode == Keys.Right)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 5;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }

            if (e.KeyCode == Keys.Up)
            {
                if (volumeControl2.Value <= 90)
                {
                    axWindowsMediaPlayer1.settings.volume += 10;
                    lblVolume.Text = "Volume: " + axWindowsMediaPlayer1.settings.volume.ToString() + "%";
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (volumeControl2.Value >= 10)
                {
                    axWindowsMediaPlayer1.settings.volume -= 10;
                    lblVolume.Text = "Volume: " + axWindowsMediaPlayer1.settings.volume.ToString() + "%";
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string version = VersionLabel.ToString();
            MessageBox.Show("This Player was created for non-commercial use. It is build to serve the needs of our QA Department and if a bug is " +
                "spotted please use whatever you have as an object near You. For updates and features please contact and praise our Lord of the Code" +
                " and Saviour of the Unconnected - SYS Nick.\r\n" + version);
        }

        private void player_CurrentItemChange(object sender, _WMPOCXEvents_CurrentItemChangeEvent e)
        {
            if (isPlaying)
            {
                endTime = DateTime.Now;
                CalculateTime(startTime, endTime);
                startTime = DateTime.Now;
            }
        }

        private void slider_MouseHover(object sender, EventArgs e)
        {

        }

        public string VersionLabel
        {
            get
            {
                if (ApplicationDeployment.IsNetworkDeployed)
                {
                    Version ver = ApplicationDeployment.CurrentDeployment.CurrentVersion;
                    return string.Format("Version: {0}.{1}.{2}.{3}", ver.Major.ToString(), ver.Minor.ToString(), ver.Build.ToString(), ver.Revision.ToString());
                }
                else
                {
                    var ver = Assembly.GetExecutingAssembly().GetName().Version;
                    return string.Format("Version: {0}.{1}.{2}.{3}", ver.Major.ToString(), ver.Minor.ToString(), ver.Build.ToString(), ver.Revision.ToString());
                }
            }
        }
    }
}

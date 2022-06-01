using AxWMPLib;
using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
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
        private bool mouseDown;
        private Point diffPoint;

        //database initialize
        readonly Database db = new Database();

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

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
                btnPlay.Image = Properties.Resources.pause_30px;
                string URL = file[0];
                this.player.URL = URL;
                startTime = DateTime.Now;
            }
        }

        //get's the file name and source
        private void Form1_Load(object sender, EventArgs e)
        {
            if (arguments.Length > 1)
            {
                player.URL = arguments[1];
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
                player.URL = openFileDialog1.FileName;
                btnPlay.Image = Properties.Resources.pause_30px;
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
            if (player.playState == WMPPlayState.wmppsPaused)
            {
                player.Ctlcontrols.play();
                btnPlay.Image = Properties.Resources.pause_30px;
                startTime = DateTime.Now;
            }
            else
            {
                player.Ctlcontrols.pause();
                btnPlay.Image = Properties.Resources.play_30px;
                endTime = DateTime.Now;
            }
        }

        //exit button
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                player.Ctlcontrols.pause();
            }
            Environment.Exit(0);
        }

        //the labels are connected with the timer and display the elapsed and totalTime of the current media
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime2.Text = player.Ctlcontrols.currentPositionString;
            slider.Value = (int)player.Ctlcontrols.currentPosition;

            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                lblTotalTime2.Text = player.Ctlcontrols.currentItem.durationString.ToString();
                slider.Maximum = (int)player.currentMedia.duration;
                element = player.URL;
            }
        }

        //detects when the player status is changed and collects datetime data
        private void player_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            lblTitle.Text = player.status;
            //imgEqualizer.Enabled = player.status.ToLower().Contains("playing");


            if (player.playState == WMPPlayState.wmppsMediaEnded)
            {
                endTime = DateTime.Now;
                CalculateTime(startTime, endTime);
                player.settings.setMode("loop", true);
            }

            if (player.playState == WMPPlayState.wmppsPaused || player.playState == WMPPlayState.wmppsStopped)
            {
                endTime = DateTime.Now;
                CalculateTime(startTime, endTime);
                isPlaying = false;
            }
            else if (player.playState == WMPPlayState.wmppsPlaying)
            {
                startTime = DateTime.Now;
                isPlaying = true;
            }
        }

        //btn skip 5 seconds
        private void btnForward_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            player.Ctlcontrols.currentPosition += 5;
            player.Ctlcontrols.play();
        }

        //mouse move and label of the volume bar
        private void volumeControl2_MouseMove(object sender, MouseEventArgs e)
        {
            player.settings.volume = volumeControl2.Value;
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
            player.Ctlcontrols.currentPosition = slider.Value;
        }

        //btn rewinds 5 seconds
        private void btnBackward_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            player.Ctlcontrols.currentPosition -= 5;
            player.Ctlcontrols.play();
        }

        //when spacebar or enter is pressed the playstate is changed the play or pause depending from the previous state
        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space))
            {
                if (player.playState == WMPPlayState.wmppsPlaying)
                {
                    player.Ctlcontrols.pause();
                }
                else if (player.playState == WMPPlayState.wmppsPaused)
                {
                    player.Ctlcontrols.play();
                }
            }
        }

        //slider for changing the platSpeed
        private void trbPlaySpeed_ValueChanged(object sender, EventArgs e)
        {
            switch (trbPlaySpeed.Value)
            {
                case 1:
                    player.settings.rate = zeroPointFive;
                    break;
                case 2:
                    player.settings.rate = zeroPointSix;
                    break;
                case 3:
                    player.settings.rate = zeroPointSeven;
                    break;
                case 4:
                    player.settings.rate = zeroPointEight;
                    break;
                case 5:
                    player.settings.rate = zeroPointNine;
                    break;
                case 6:
                    player.settings.rate = one;
                    break;
                case 7:
                    player.settings.rate = onePointOne;
                    break;
                case 8:
                    player.settings.rate = onePointTwo;
                    break;
                case 9:
                    player.settings.rate = onePointThree;
                    break;
                case 10:
                    player.settings.rate = onePointFour;
                    break;
                case 11:
                    player.settings.rate = onePointFive;
                    break;
            }
        }

        //applying control from certain keys from the keyboard
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                player.Ctlcontrols.pause();
                player.Ctlcontrols.currentPosition -= 5;
                player.Ctlcontrols.play();
            }

            if (e.KeyCode == Keys.Right)
            {
                player.Ctlcontrols.pause();
                player.Ctlcontrols.currentPosition += 5;
                player.Ctlcontrols.play();
            }

            if (e.KeyCode == Keys.Up)
            {
                if (volumeControl2.Value <= 90)
                {
                    player.settings.volume += 10;
                    volumeControl2.Value += 10;
                    lblVolume.Text = "Volume: " + player.settings.volume.ToString() + "%";
                }
                else
                {
                    volumeControl2.Value = 100;
                    lblVolume.Text = "Volume: 100%";
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (volumeControl2.Value >= 10)
                {
                    player.settings.volume -= 10;
                    volumeControl2.Value -= 10;
                    lblVolume.Text = "Volume: " + player.settings.volume.ToString() + "%";
                }
                else
                {
                    volumeControl2.Value = 0;
                    lblVolume.Text = "Volume: 0%";
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


        //draggable form and header
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            diffPoint.X = Cursor.Position.X - this.Left;
            diffPoint.Y = Cursor.Position.Y - this.Top;
            mouseDown = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Left = Cursor.Position.X - diffPoint.X;
                this.Top = Cursor.Position.Y - diffPoint.Y;
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            diffPoint.X = Cursor.Position.X - this.Left;
            diffPoint.Y = Cursor.Position.Y - this.Top;
            mouseDown = true;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Left = Cursor.Position.X - diffPoint.X;
                this.Top = Cursor.Position.Y - diffPoint.Y;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000;
                return cp;
            }
        }
    }
}

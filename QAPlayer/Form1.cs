using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using WMPLib;

namespace QAPlayer
{
    public partial class Form1 : Form
    {

        public DateTime startTime;
        public DateTime endTime;
        public static string PCName = Environment.MachineName;
        public bool isPlaying = false;
        Database db = new Database();

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
                this.player.URL = URL;
                startTime = DateTime.Now;
            }
        }

        //get's the file name and source
        private void Form1_Load(object sender, EventArgs e)
        {
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
                startTime = DateTime.Now;
            }
        }

        //the main method for the backbone requirement of tracking listenedTime
        private void CalculateTime(DateTime startTime, DateTime endTime)
        {
            TimeSpan inSeconds = endTime - startTime;
            double totalTime = inSeconds.TotalSeconds;

            var cnn = db.Connect();
            string date = endTime.ToString("dd-MM-yyyy");
            db.PushToBase(PCName, totalTime, date, cnn);
        }

        //play/pause button
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPPlayState.wmppsPaused)
            {
                player.Ctlcontrols.play();
                startTime = DateTime.Now;
            }
            else
            {
                player.Ctlcontrols.pause();
                endTime = DateTime.Now;
            }
        }

        //exit button
        private void btnClose_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            Environment.Exit(0);
        }

        //the labels are connected with the timer and display the elapsed and totalTime of the current media
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = player.Ctlcontrols.currentPositionString;
            slider.Value = (int)player.Ctlcontrols.currentPosition;

            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                lblTotalTime.Text = player.Ctlcontrols.currentItem.durationString.ToString();
                slider.Maximum = (int)player.currentMedia.duration;
            }
        }

        //detects when the player status is changed and collects datetime data
        private void player_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            bunifuLabel2.Text = player.status;
            imgEqualizer.Enabled = player.status.ToLower().Contains("playing");

            if (player.playState == WMPPlayState.wmppsPaused)
            {
                endTime = DateTime.Now;
                CalculateTime(startTime, endTime);
            }
            else if (player.playState == WMPPlayState.wmppsPlaying)
            {
                startTime = DateTime.Now;
            }
        }

        //btn skip 5 seconds
        private void btnForward_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            player.Ctlcontrols.currentPosition += 5;
            player.Ctlcontrols.play();
        }

        //timer for the volume bar
        private void timer2_Tick(object sender, EventArgs e)
        {
            lblVolume.Text = "Volume: " + volumeControl2.Value.ToString() + "%";
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
    }
}
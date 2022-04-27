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
        public bool isPlaying = true;
        Database db = new Database();

        public Form1()
        {
            InitializeComponent();

            //allows drag and drop to the form
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);

        }

        //exit button
        private void btnClose_Click(object sender, EventArgs e)
        {
            endTime = DateTime.Now;
            CalculateTime(startTime, endTime);
            Environment.Exit(0);
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

        //plays the mediafile 
        private void listFile_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MediaFile file = listFile.SelectedItem as MediaFile;
            
            if (file != null)
            {
                
                player.URL = file.Path;
                player.Ctlcontrols.play();
                startTime = DateTime.Now;
            }

            


        }

        //implementation of adding files to a list
        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                player.URL = openFileDialog1.FileName;
            }
           
        }

        //the main method for the backbone requirement of tracking listenedTime
        private void CalculateTime(DateTime startTime, DateTime endTime)
        {
            double elapsedTime = 0;
            TimeSpan inSeconds = endTime - startTime;
            double totalTime = inSeconds.TotalSeconds;

            var cnn = db.Connect();
            TimeSpan time = TimeSpan.FromSeconds(elapsedTime);
            string date = endTime.ToString("dd-MM-yyyy");
            db.PushToBase(PCName, totalTime, date, cnn);
            inSeconds = TimeSpan.Zero;
        }

        //pause button
        private void btnPause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            endTime = DateTime.Now;
            CalculateTime(startTime, endTime);
        }

        //play button
        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
            startTime = DateTime.Now;
        }

        //to do!!!
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = player.Ctlcontrols.currentPositionString;

            slider.Value = (int)player.Ctlcontrols.currentPosition;

            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                slider.Maximum = (int)player.currentMedia.duration;
            
            }

        }

        //to do!!!
        private void spacePauseEvent(object sender, _WMPOCXEvents_KeyUpEvent e)
        {
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                if (e.nKeyCode == 32 || e.nKeyCode == 13)
                {
                    player.Ctlcontrols.pause();
                }
            }

            else if (isPlaying == false)
            {
                if (e.nKeyCode == 32 || e.nKeyCode == 13)
                {
                    player.Ctlcontrols.play();
                }
            }
        }

        //when X is pressed the app collects the date and time and pushes it to a method
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            endTime = DateTime.Now;
            CalculateTime(startTime, endTime);
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

            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                startTime = DateTime.Now;
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.fastForward();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblVolume.Text = "Volume: " + volumeControl2.Value.ToString() + "%";
        }

        private void volumeControl2_MouseMove(object sender, MouseEventArgs e)
        {
            player.settings.volume = volumeControl2.Value;
            lblVolume.Text = "Volume: " + volumeControl2.Value.ToString() + "%";
        }

        private void slider_MouseClick(object sender, MouseEventArgs e)
        {
            slider.AllowIncrementalClickMoves = false;
            player.Ctlcontrols.currentPosition = slider.Value;
        }

        private void slider_LocationChanged(object sender, EventArgs e)
        {
            player.Ctlcontrols.currentPosition = slider.Value;

        }
    }
}
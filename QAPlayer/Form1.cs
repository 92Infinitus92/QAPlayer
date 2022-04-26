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

            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        private void bunifuButtonNowPlaying_Click(object sender, EventArgs e)
        {
            indicator.Top = btnNowPlaying.Top + 10;
            bunifuPages1.SetPage(0);
        }

        private void bunifuButtonExplore_Click(object sender, EventArgs e)
        {
            indicator.Top = btnExplore.Top + 18;
            bunifuPages1.SetPage(1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileNames = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (fileNames != null && fileNames.Length != 0)
            {

            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            foreach (var item in openFileDialog1.FileNames)
            {
                FileInfo fi = new FileInfo(item);

                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    player.Ctlcontrols.play();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listFile.ValueMember = "Path";
            listFile.DisplayMember = "FileName";
        }

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

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "WAV|*.wav|MP4|*.mp4|WMV|*.wmv|MP3|*.mp3|MKV|*.mkv" })
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    List<MediaFile> files = new List<MediaFile>();
                    foreach (string fileName in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(fileName);
                        files.Add(new MediaFile() { FileName = Path.GetFileNameWithoutExtension(fi.FullName), Path = fi.FullName });
                    }
                    listFile.DataSource = files;
                }
        }


        private void CalculateTime(DateTime startTime, DateTime endTime)
        {
            double elapsedTime = 0;
            TimeSpan inSeconds = endTime - startTime;
            double totalTime = inSeconds.TotalSeconds;

            //var cnn = ;
            TimeSpan time = TimeSpan.FromSeconds(elapsedTime);
            string date = endTime.ToString("dd-MM-yyyy");
            //db.PushToBase(PCName, totalTime, date, cnn);
            inSeconds = TimeSpan.Zero;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = player.Ctlcontrols.currentPositionString;

            slider.Value = (int)player.Ctlcontrols.currentPosition;
        }

        private void spacePauseEvent(object sender, AxWMPLib._WMPOCXEvents_KeyUpEvent e)
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            endTime = DateTime.Now;
            CalculateTime(startTime, endTime);
        }

        private void player_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            bunifuLabel2.Text = player.status;

            imgEqualizer.Enabled = player.status.ToLower().Contains("playing");

            if (player.playState == WMPPlayState.wmppsPaused)
            {
                endTime = DateTime.Now;
                //CalculateTime(startTime, endTime);
            }

            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                startTime = DateTime.Now;
            }
        }
    }
}

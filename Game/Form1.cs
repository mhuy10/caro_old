using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace game
{
    public partial class GameCaro : Form
    {
        private Bitmap bmpbanco = new Bitmap("..//..//Game.jpg");
        private Bitmap bmpfol = new Bitmap("..//..//folder.jpg");
        private Bitmap bmpstart = new Bitmap("..//..//start.png");
        private Bitmap bmpstop = new Bitmap("..//..//stop.jpg");
        private CMp3 mp3 = new CMp3();
        public GameCaro()
        {
            InitializeComponent();
            pictureGame.Image = bmpbanco;
            Vol.Image = bmpfol;
            run.Image = bmpstart;
            stop.Image = bmpstop;
        }
        
        private void Serverbtn_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start(Application.StartupPath.ToString() + @"\Server.exe");
        }
        private void Clientbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath.ToString() + @"\Client.exe");
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Vol_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "MP3 Files|*.mp3";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    mp3.open(ofd.FileName);
                }
            }
        }

        private void run_Click(object sender, EventArgs e)
        {
            if(mp3 != null)
                mp3.play();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if(mp3 != null)
            mp3.stop();
        }
    }
}

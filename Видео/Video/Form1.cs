using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            axWindowsMediaPlayer1.uiMode = "None";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string file = openFileDialog1.FileName;
            axWindowsMediaPlayer1.URL = file;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trackBar2.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.currentMedia.duration);
            trackBar2.Value = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);

            if (axWindowsMediaPlayer1 != null)
            {
                int s = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                int h = s / 3600;
                int m = (s - (h*3600)) / 60;
                s = s - (h * 3600 + m * 60);
                label2.Text = String.Format("{0:D}:{1:D2}:{2:D2}", h, m, s);
            }
            else
            {
                label2.Text = "0:00:00";
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = trackBar2.Value;
        }
    }
}

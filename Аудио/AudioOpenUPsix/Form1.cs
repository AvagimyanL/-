using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AudioOpenUPsix
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog1;
        WaveOutEvent outputDevice;
        AudioFileReader audioFile;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "MP3 Files|*.mp3|WAV Files|*.wav";
            openFileDialog1.Title = "Select an Audio File";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if(audioFile != null)
                    {
                        outputDevice.Stop();
                        audioFile.Dispose();
                        outputDevice.Dispose();
                    }

                    audioFile = new AudioFileReader(openFileDialog1.FileName);
                    outputDevice = new WaveOutEvent();
                 
                    outputDevice.Init(audioFile);
                    outputDevice.Play();
                    timer1.Start();

                    label1.Text = "Путь к файлу: " + openFileDialog1.FileName.ToString();

                    buttonPause.ForeColor = Color.Black;
                    buttonPause.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Что то не так :( попробуйте позже");
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (outputDevice != null)
            {
                outputDevice.Play();
                timer1.Start();
                if (!buttonPause.Enabled)
                {
                    buttonPause.ForeColor = Color.Black;
                    buttonPause.Enabled = true;
                }
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (outputDevice != null)
            {
                outputDevice.Pause();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
                audioFile = new AudioFileReader(openFileDialog1.FileName);
                outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);

                buttonPause.ForeColor = Color.Gray;
                buttonPause.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trackBarMusic.Value = (int)(audioFile.CurrentTime.TotalSeconds / audioFile.TotalTime.TotalSeconds * trackBarMusic.Maximum);
        }

        private void trackBarMusic_Scroll(object sender, EventArgs e)
        {
            if (outputDevice != null && audioFile != null)
            {
                if (outputDevice.PlaybackState == PlaybackState.Playing || outputDevice.PlaybackState == PlaybackState.Paused)
                {
                    outputDevice.Pause();
                    audioFile.CurrentTime = TimeSpan.FromSeconds(trackBarMusic.Value * 1.0 / trackBarMusic.Maximum * audioFile.TotalTime.TotalSeconds);
                    outputDevice.Play();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

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

namespace Проект
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG, JPG|*.jpg;*.jpeg|All Files|*.*";
            ofd.ShowDialog();
            textBox1.Text = ofd.FileName;

        } 

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (textBox1 == null)
                {
                    MessageBox.Show("Введите путь!");
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(textBox1.Text);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }

             }

            catch (ArgumentException ex)
            {
                MessageBox.Show("Неверный аргумент: " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Ошибка пути: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}

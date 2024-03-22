using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Приложение_Автосервис
{
    public partial class Авторизация : System.Windows.Forms.Form
    {

        public Авторизация()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //      this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelAvtoriz_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "0000")    //Авторизация. Логин - admin, пароль - 0000

            {

                Dostup.X = "Администратор";



                Form2 f3 = new Form2();
                this.Hide();
                f3.ShowDialog();
            }
            else if (textBox1.Text == "user" && textBox2.Text == "1111")    //Авторизация. Логин - user, пароль - 1111
            {

                Dostup.X = "Продавец - 1";



                Kassa f2 = new Kassa();
                this.Hide();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Неудачная попытка входа", MessageBoxButtons.OK, MessageBoxIcon.Warning); //При неправильном вводе данных будет выведено предупреждащее об этом окно
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelAvtoriz_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelAvtoriz_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

     
    }
}

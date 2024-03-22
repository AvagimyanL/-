using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Приложение_Автосервис;

namespace Приложение_Автосервис
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            this.Hide();
            f7.ShowDialog();
        }
        Point lastPoint;
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?", "Подтвердите действие",  MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                Авторизация f1 = new Авторизация();
                this.Hide();
                f1.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {
                //
            }
        }

        private void Avto_Click(object sender, EventArgs e)
        {
                Автомобили f4 = new Автомобили();
                this.Hide();
                f4.ShowDialog();
        }

        private void Post_Click(object sender, EventArgs e)
        {
                Должности f5 = new Должности();
                this.Hide();
                f5.ShowDialog();  
        }

        private void Name_Click(object sender, EventArgs e)
        {
  /*          if (Dostup.X == "user")
            {
                MessageBox.Show("У вас недостаточно прав.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Dostup.X == "admin")
            {*/
                Имена f6 = new Имена();
                this.Hide();
                f6.ShowDialog();
            //}
        }

        private void Mastera_Click(object sender, EventArgs e)
        {
            Мастера f9 = new Мастера();
            this.Hide();
            f9.ShowDialog();
        }

        private void Marki_Click(object sender, EventArgs e)
        {
 
            Марки f8 = new Марки();
            this.Hide();
            f8.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Model_Click(object sender, EventArgs e)
        {

            
                Модели f10 = new Модели();
                this.Hide();
                f10.ShowDialog();
            
                
        }

        private void Name_tovara_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            this.Hide();
            f11.ShowDialog();
        }

        private void Name_uslugi_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            this.Hide();
            f12.ShowDialog();
        }

        private void Otchestva_Click(object sender, EventArgs e)
        {
            Otchestva f13 = new Otchestva();
            this.Hide();
            f13.ShowDialog();
        }

        private void Prodavsi_Click(object sender, EventArgs e)
        {
            Prodavsi f14 = new Prodavsi();
            this.Hide();
            f14.ShowDialog();
        }

        private void Tovari_Click(object sender, EventArgs e)
        {
            Tovari f15 = new Tovari();
            this.Hide();
            f15.ShowDialog();
        }

        private void Uslugi_Click(object sender, EventArgs e)
        {
            Uslugi f16 = new Uslugi();
            this.Hide();
            f16.ShowDialog();
        }

        private void Lastname_Click(object sender, EventArgs e)
        {
            Lastname f17 = new Lastname();
            this.Hide();
            f17.ShowDialog();
        }

        private void Cheki_Click(object sender, EventArgs e)
        {
            Cheki f18 = new Cheki();
            this.Hide();
            f18.ShowDialog();
        }

        private void Cheki_view_Click(object sender, EventArgs e)
        {
            Cheki_view f19 = new Cheki_view();
            this.Hide();
            f19.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kassa f13 = new Kassa();
            this.Hide();
            f13.ShowDialog();
        }
    }
}

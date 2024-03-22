using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Приложение_Автосервис.Controller;

namespace Приложение_Автосервис
{
    public partial class Мастера : Form
    {

        Query controller;

        public Мастера()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
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

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Автосервис_mdb_DataSet.Мастера". При необходимости она может быть перемещена или удалена.
            this.мастераTableAdapter.Fill(this._Автосервис_mdb_DataSet.Мастера);

        }
        Point lastPoint;

        private void Form9_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form9_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if ((LastName.Text.Equals("")) || (Namee.Text.Equals("")) || (Otchestvo.Text.Equals("")) || (Post.Text.Equals("")) || (Seria_pasporta.Text.Equals("")) || (Nomer_pasp.Text.Equals("")) || (Phone.Text.Equals("")) || (Oklad.Text.Equals("")) || (Staj.Text.Equals("")))
                MessageBox.Show("Вы не ввели все необходимые данные!!!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                controller.AddМастера(LastName.Text, Namee.Text, Otchestvo.Text, int.Parse(Seria_pasporta.Text), int.Parse(Nomer_pasp.Text), Post.Text, int.Parse(Staj.Text), Phone.Text, int.Parse(Oklad.Text));

                dataGridView1.DataSource = controller.UpdateМастера();

                LastName.Clear();
                Namee.Clear();
                Otchestvo.Clear();
                Post.Clear();
                Seria_pasporta.Clear();
                Nomer_pasp.Clear();
                Phone.Clear();
                Oklad.Clear();
                Staj.Clear();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateМастера();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            controller.DeleteМастера(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()));
            dataGridView1.DataSource = controller.UpdateМастера();
            Kod.Clear();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if ((Kod.Text.Equals("") || LastName.Text.Equals("")) || (Namee.Text.Equals("")) || (Otchestvo.Text.Equals("")) || (Post.Text.Equals("")) || (Seria_pasporta.Text.Equals("")) || (Nomer_pasp.Text.Equals("")) || (Phone.Text.Equals("")) || (Oklad.Text.Equals("")) || (Staj.Text.Equals("")))

                MessageBox.Show("Вы не ввели все необходимые данные! Заполните все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            else
            {
                controller.ChangeМастера(LastName.Text, Namee.Text, Otchestvo.Text, int.Parse(Seria_pasporta.Text), int.Parse(Nomer_pasp.Text), Post.Text, int.Parse(Staj.Text), Phone.Text, int.Parse(Oklad.Text), int.Parse(Kod.Text));
                dataGridView1.DataSource = controller.UpdateМастера();
                Kod.Clear();
                LastName.Clear();
                Namee.Clear();
                Otchestvo.Clear();
                Post.Clear();
                Seria_pasporta.Clear();
                Nomer_pasp.Clear();
                Phone.Clear();
                Oklad.Clear();
                Staj.Clear();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

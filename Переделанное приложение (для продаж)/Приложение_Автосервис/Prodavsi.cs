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
    public partial class Prodavsi : Form
    {


        Query controller;
        Point lastPoint;


        public Prodavsi()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
        }

        private void Prodavsi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Автосервис_mdb_DataSet.Продавцы". При необходимости она может быть перемещена или удалена.
            this.продавцыTableAdapter.Fill(this._Автосервис_mdb_DataSet.Продавцы);

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

        private void Prodavsi_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Prodavsi_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
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

        private void Add_Click(object sender, EventArgs e)
        {
            if ((LastName.Text.Equals("")) || (Namee.Text.Equals("")) || (Otchestvo.Text.Equals("")) || (Seria_pasporta.Text.Equals("")) || (Nomer_pasp.Text.Equals("")) || (Phone.Text.Equals("")) || (Oklad.Text.Equals("")))
                MessageBox.Show("Вы не ввели все необходимые данные!!!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                controller.AddПродавцы(LastName.Text, Namee.Text, Otchestvo.Text, int.Parse(Seria_pasporta.Text), int.Parse(Nomer_pasp.Text), Phone.Text, int.Parse(Oklad.Text));

                dataGridView1.DataSource = controller.UpdateПродавцы();

                LastName.Clear();
                Namee.Clear();
                Otchestvo.Clear();
                Seria_pasporta.Clear();
                Nomer_pasp.Clear();
                Phone.Clear();
                Oklad.Clear();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateПродавцы();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            controller.DeleteПродавцы(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()));
            dataGridView1.DataSource = controller.UpdateПродавцы();
            Kod.Clear();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if ((Kod.Text.Equals("") || LastName.Text.Equals("")) || (Namee.Text.Equals("")) || (Otchestvo.Text.Equals(""))  || (Seria_pasporta.Text.Equals("")) || (Nomer_pasp.Text.Equals("")) || (Phone.Text.Equals("")) || (Oklad.Text.Equals("")))

                MessageBox.Show("Вы не ввели все необходимые данные! Заполните все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            else
            {
                controller.ChangeПродавцы(LastName.Text, Namee.Text, Otchestvo.Text, int.Parse(Seria_pasporta.Text), int.Parse(Nomer_pasp.Text), Phone.Text, int.Parse(Oklad.Text), int.Parse(Kod.Text));
                dataGridView1.DataSource = controller.UpdateПродавцы();
                Kod.Clear();
                LastName.Clear();
                Namee.Clear();
                Otchestvo.Clear();
                Seria_pasporta.Clear();
                Nomer_pasp.Clear();
                Phone.Clear();
                Oklad.Clear();
            }
        }
    }
}

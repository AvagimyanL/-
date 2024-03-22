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
    public partial class Модели : Form
    {
        Point lastPoint;

        Query controller;

        public Модели()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Автосервис_mdb_DataSet.Модель". При необходимости она может быть перемещена или удалена.
            this.модельTableAdapter.Fill(this._Автосервис_mdb_DataSet.Модель);

        }

        private void Form10_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form10_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if ((Model.Text.Equals("")))
                MessageBox.Show("Вы не ввели все необходимые данные!!!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                controller.AddМодели (Model.Text);
                dataGridView1.DataSource = controller.UpdateМодели();
                Model.Clear();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateМодели();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            controller.DeleteМодели(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()));
            dataGridView1.DataSource = controller.UpdateМодели();
            Kod.Clear();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (((Kod.Text.Equals("")) || Model.Text.Equals("")))

                MessageBox.Show("Вы не ввели все необходимые данные! Заполните все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                controller.ChangeМодели(Model.Text, int.Parse(Kod.Text));
                dataGridView1.DataSource = controller.UpdateМодели();
                Kod.Clear();
                Model.Clear();
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

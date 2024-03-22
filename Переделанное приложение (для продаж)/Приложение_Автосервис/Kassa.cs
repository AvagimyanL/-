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
    public partial class Kassa : Form
    {


        Query controller;
        Point lastPoint;

       

        public Kassa()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 50;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer1_Tick_1);

        }


        private void Kassa_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Автосервис_mdb_DataSet.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this._Автосервис_mdb_DataSet.Услуги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Автосервис_mdb_DataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this._Автосервис_mdb_DataSet.Товары);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Автосервис_mdb_DataSet.Чеки". При необходимости она может быть перемещена или удалена.
            this.чекиTableAdapter.Fill(this._Автосервис_mdb_DataSet.Чеки);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortDateString() + " " +DateTime.Now.ToLongTimeString();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
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

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
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

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Kolichestvo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Price_tovara_TextChanged(object sender, EventArgs e)
        {

        }

        private void Marka_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nazvanie_tovara_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kod_tovara_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prodaves_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Paint(object sender, PaintEventArgs e)
        {
            label2.Text = "Работник: " + Dostup.X;
        }


        private void Poisk_tovara_but_Click(object sender, EventArgs e)
        {
            товарыBindingSource5.Filter = "Название_товара LIKE '%" + Poisk_tovara_text_box.Text + "%'"; //Поиск по названию товара
            Poisk_tovara_text_box.Clear();
        }

        private void Poisk_uslugi_but_Click(object sender, EventArgs e)
        {
            услугиBindingSource1.Filter = "Название_услуги LIKE '%" + Poisk_uslugi_text_box.Text + "%'"; //Поиск по названию услуги
            Poisk_uslugi_text_box.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}

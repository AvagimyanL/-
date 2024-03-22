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

    public partial class Должности : Form
    {

        Query controller;

        public Должности()
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

        private void label5_Click(object sender, EventArgs e)
        {
     
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Автосервис_mdb_DataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this._Автосервис_mdb_DataSet.Должности);

        }
        Point lastPoint;

        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if ((Post.Text.Equals("")))
                // Проверка на то, что все textBox(ы) заполнены. (сделано во избежание вылета программы)
                MessageBox.Show("Вы не ввели все необходимые данные!!!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                controller.AddДолжности(Post.Text);
                dataGridView1.DataSource = controller.UpdateДолжности();
                Post.Clear();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateДолжности();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            controller.DeleteДолжности(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()));

            dataGridView1.DataSource = controller.UpdateДолжности();

            Kod.Clear();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (((Kod.Text.Equals("")) || Post.Text.Equals("")))

                MessageBox.Show("Вы не ввели все необходимые данные! Заполните все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            else
            {
                controller.ChangeДолжности(Post.Text, int.Parse(Kod.Text));
                //Выше запрос из класса Query, который позволяет изменять данные в таблице Сотрудники

                dataGridView1.DataSource = controller.UpdateДолжности();
                Kod.Clear();
                Post.Clear();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

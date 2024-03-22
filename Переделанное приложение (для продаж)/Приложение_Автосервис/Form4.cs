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
    public partial class Автомобили : Form
    {

        Query controller;
        Point lastPoint;

        public Автомобили()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Автосервис_mdb_DataSet.Автомобили". При необходимости она может быть перемещена или удалена.
            this.автомобилиTableAdapter.Fill(this._Автосервис_mdb_DataSet.Автомобили);

        }
       

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateАвтомобили();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text.Equals("")) || (textBox3.Text.Equals("")))
                // Проверка на то, что все textBox(ы) заполнены. (сделано во избежание вылета программы)
                MessageBox.Show("Вы не ввели все необходимые данные!!!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                controller.AddАвтомобили(textBox2.Text, textBox3.Text);

                dataGridView1.DataSource = controller.UpdateАвтомобили();

                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            controller.DeleteАвтомобили(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString())); //Кнопка удаления данных из табл. Автомобили.
            //Запрос из класса Query, который позволяет удалять строки.

            dataGridView1.DataSource = controller.UpdateАвтомобили(); 

            textBox1.Clear(); //Очищает textBox после использования кнопки. Используется для удобства самого пользователя (чтобы он каждый раз не стирал данные из textbox(а))
        }

        private void Change_Click(object sender, EventArgs e)
        {
           
         if (((textBox1.Text.Equals("")) || textBox2.Text.Equals("")) || (textBox3.Text.Equals("")))
                
                MessageBox.Show("Вы не ввели все необходимые данные! Заполните все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            else
            {
                controller.ChangeАвтомобили(textBox2.Text, textBox3.Text, int.Parse(textBox1.Text));
                //Выше запрос из класса Query, который позволяет изменять данные в таблице Сотрудники

                dataGridView1.DataSource = controller.UpdateАвтомобили();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }   
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
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

        private void label3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
    }
}

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
    public partial class Клиенты : Form
    {

        Query controller;

        public Клиенты()
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

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Автосервис_mdb_DataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this._Автосервис_mdb_DataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Автосервис_mdb_DataSet.Марки_машин". При необходимости она может быть перемещена или удалена.
            this.марки_машинTableAdapter.Fill(this._Автосервис_mdb_DataSet.Марки_машин);

        }
        Point lastPoint;

        private void Form7_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form7_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if ((LastName.Text.Equals("")) || (Namee.Text.Equals("")) || (Otchestvo.Text.Equals("")) || (Data_rojdenia.Text.Equals("")) || (Seria_pasp.Text.Equals("")) || (Nomer_pasp.Text.Equals("")) || (Phone.Text.Equals("")))
                // Проверка на то, что все textBox(ы) заполнены. (сделано во избежание вылета программы)
                MessageBox.Show("Вы не ввели все необходимые данные!!!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                controller.AddКлиенты(LastName.Text, Namee.Text, Otchestvo.Text, DateTime.Parse(Data_rojdenia.Text), int.Parse(Seria_pasp.Text), int.Parse(Nomer_pasp.Text), Phone.Text);

                dataGridView1.DataSource = controller.UpdateКлиенты();

                LastName.Clear();
                Namee.Clear();
                Otchestvo.Clear();
                Data_rojdenia.Clear();
                Seria_pasp.Clear(); 
                Nomer_pasp.Clear();
                Phone.Clear();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateКлиенты();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            controller.DeleteКлиенты(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()));
            dataGridView1.DataSource = controller.UpdateКлиенты();
            Kod.Clear();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (((Kod.Text.Equals("")) || (LastName.Text.Equals("")) || (Namee.Text.Equals("")) || (Otchestvo.Text.Equals("")) || (Data_rojdenia.Text.Equals("")) || (Seria_pasp.Text.Equals("")) || (Nomer_pasp.Text.Equals("")) || (Phone.Text.Equals(""))))

                MessageBox.Show("Вы не ввели все необходимые данные! Заполните все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            else
            {
                controller.ChangeКлиенты(LastName.Text, Namee.Text, Otchestvo.Text, DateTime.Parse(Data_rojdenia.Text), int.Parse(Seria_pasp.Text), int.Parse(Nomer_pasp.Text), Phone.Text, int.Parse(Kod.Text));
                //Выше запрос из класса Query, который позволяет изменять данные в таблице Сотрудники

                dataGridView1.DataSource = controller.UpdateКлиенты();
                Kod.Clear();
                LastName.Clear();
                Namee.Clear();
                Otchestvo.Clear();
                Data_rojdenia.Clear();
                Seria_pasp.Clear();
                Nomer_pasp.Clear();
                Phone.Clear();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

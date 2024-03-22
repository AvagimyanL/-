namespace Приложение_Автосервис
{
    partial class Автомобили
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодавтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.автомобилиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Автосервис_mdb_DataSet = new Приложение_Автосервис._Автосервис_mdb_DataSet();
            this.автомобилиTableAdapter = new Приложение_Автосервис._Автосервис_mdb_DataSetTableAdapters.АвтомобилиTableAdapter();
            this.Kod = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Change = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.Label();
            this.Marka = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Автосервис_mdb_DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1101, 685);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодавтомобиляDataGridViewTextBoxColumn,
            this.маркаDataGridViewTextBoxColumn,
            this.модельDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.автомобилиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(593, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(708, 476);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // кодавтомобиляDataGridViewTextBoxColumn
            // 
            this.кодавтомобиляDataGridViewTextBoxColumn.DataPropertyName = "Код_автомобиля";
            this.кодавтомобиляDataGridViewTextBoxColumn.HeaderText = "Код_автомобиля";
            this.кодавтомобиляDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодавтомобиляDataGridViewTextBoxColumn.Name = "кодавтомобиляDataGridViewTextBoxColumn";
            this.кодавтомобиляDataGridViewTextBoxColumn.Width = 125;
            // 
            // маркаDataGridViewTextBoxColumn
            // 
            this.маркаDataGridViewTextBoxColumn.DataPropertyName = "Марка";
            this.маркаDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.маркаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.маркаDataGridViewTextBoxColumn.Name = "маркаDataGridViewTextBoxColumn";
            this.маркаDataGridViewTextBoxColumn.Width = 150;
            // 
            // модельDataGridViewTextBoxColumn
            // 
            this.модельDataGridViewTextBoxColumn.DataPropertyName = "Модель";
            this.модельDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.модельDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.модельDataGridViewTextBoxColumn.Name = "модельDataGridViewTextBoxColumn";
            this.модельDataGridViewTextBoxColumn.Width = 150;
            // 
            // автомобилиBindingSource
            // 
            this.автомобилиBindingSource.DataMember = "Автомобили";
            this.автомобилиBindingSource.DataSource = this._Автосервис_mdb_DataSet;
            // 
            // _Автосервис_mdb_DataSet
            // 
            this._Автосервис_mdb_DataSet.DataSetName = "_Автосервис_mdb_DataSet";
            this._Автосервис_mdb_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автомобилиTableAdapter
            // 
            this.автомобилиTableAdapter.ClearBeforeFill = true;
            // 
            // Kod
            // 
            this.Kod.AutoSize = true;
            this.Kod.BackColor = System.Drawing.Color.Silver;
            this.Kod.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kod.ForeColor = System.Drawing.Color.Black;
            this.Kod.Location = new System.Drawing.Point(89, 63);
            this.Kod.Name = "Kod";
            this.Kod.Size = new System.Drawing.Size(105, 27);
            this.Kod.TabIndex = 29;
            this.Kod.Text = "Код_авто";
            this.Kod.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Change);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Update);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Model);
            this.panel1.Controls.Add(this.Marka);
            this.panel1.Controls.Add(this.Kod);
            this.panel1.Location = new System.Drawing.Point(3, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 745);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Change
            // 
            this.Change.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change.Location = new System.Drawing.Point(300, 339);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(153, 62);
            this.Change.TabIndex = 42;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(110, 339);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(153, 62);
            this.Delete.TabIndex = 41;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update.Location = new System.Drawing.Point(300, 271);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(153, 62);
            this.Update.TabIndex = 40;
            this.Update.Text = "Обновить";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(110, 271);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(153, 62);
            this.Add.TabIndex = 39;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(208, 175);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(245, 34);
            this.textBox3.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(208, 118);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 36);
            this.textBox2.TabIndex = 33;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(208, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 36);
            this.textBox1.TabIndex = 32;
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.BackColor = System.Drawing.Color.Silver;
            this.Model.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Model.ForeColor = System.Drawing.Color.Black;
            this.Model.Location = new System.Drawing.Point(105, 175);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(89, 27);
            this.Model.TabIndex = 31;
            this.Model.Text = "Модель";
            this.Model.Click += new System.EventHandler(this.label6_Click);
            // 
            // Marka
            // 
            this.Marka.AutoSize = true;
            this.Marka.BackColor = System.Drawing.Color.Silver;
            this.Marka.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Marka.ForeColor = System.Drawing.Color.Black;
            this.Marka.Location = new System.Drawing.Point(115, 121);
            this.Marka.Name = "Marka";
            this.Marka.Size = new System.Drawing.Size(79, 27);
            this.Marka.TabIndex = 30;
            this.Marka.Text = "Марка";
            this.Marka.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1304, 89);
            this.panel3.TabIndex = 31;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1277, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 26);
            this.label4.TabIndex = 26;
            this.label4.Text = "X";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(569, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 61);
            this.label1.TabIndex = 29;
            this.label1.Text = "Автомобили";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1251, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 26);
            this.label3.TabIndex = 25;
            this.label3.Text = "п";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1224, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "_";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Приложение_Автосервис.Properties.Resources.фон_с_машиной__не_буггати_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1304, 852);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автомобили";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Автосервис_mdb_DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _Автосервис_mdb_DataSet _Автосервис_mdb_DataSet;
        private System.Windows.Forms.BindingSource автомобилиBindingSource;
        private _Автосервис_mdb_DataSetTableAdapters.АвтомобилиTableAdapter автомобилиTableAdapter;
        private System.Windows.Forms.Label Kod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label Marka;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодавтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
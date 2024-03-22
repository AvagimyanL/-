namespace Приложение_Автосервис
{
    partial class Tovari
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Автосервис_mdb_DataSet = new Приложение_Автосервис._Автосервис_mdb_DataSet();
            this.товарыTableAdapter = new Приложение_Автосервис._Автосервис_mdb_DataSetTableAdapters.ТоварыTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Nazvanie = new System.Windows.Forms.TextBox();
            this.Marka = new System.Windows.Forms.TextBox();
            this.Kod = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.Label();
            this.laabeel = new System.Windows.Forms.Label();
            this.Kod_label = new System.Windows.Forms.Label();
            this.кодтовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиетовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Автосервис_mdb_DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодтовараDataGridViewTextBoxColumn,
            this.названиетовараDataGridViewTextBoxColumn,
            this.маркаDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.товарыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(785, 444);
            this.dataGridView1.TabIndex = 0;
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this._Автосервис_mdb_DataSet;
            // 
            // _Автосервис_mdb_DataSet
            // 
            this._Автосервис_mdb_DataSet.DataSetName = "_Автосервис_mdb_DataSet";
            this._Автосервис_mdb_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(1537, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 32);
            this.label4.TabIndex = 34;
            this.label4.Text = "X";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(1503, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 35);
            this.label3.TabIndex = 33;
            this.label3.Text = "п";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(1463, -1);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 35);
            this.label2.TabIndex = 32;
            this.label2.Text = "_";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1356, 414);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 52);
            this.button1.TabIndex = 36;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1573, 459);
            this.panel1.TabIndex = 37;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Price);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Change);
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.Update);
            this.panel2.Controls.Add(this.Add);
            this.panel2.Controls.Add(this.Nazvanie);
            this.panel2.Controls.Add(this.Marka);
            this.panel2.Controls.Add(this.Kod);
            this.panel2.Controls.Add(this.Model);
            this.panel2.Controls.Add(this.laabeel);
            this.panel2.Controls.Add(this.Kod_label);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 466);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1571, 469);
            this.panel2.TabIndex = 38;
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.Location = new System.Drawing.Point(168, 224);
            this.Price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Price.Multiline = true;
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(415, 41);
            this.Price.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(75, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 34);
            this.label1.TabIndex = 53;
            this.label1.Text = "Цена";
            // 
            // Change
            // 
            this.Change.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change.Location = new System.Drawing.Point(931, 105);
            this.Change.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(204, 76);
            this.Change.TabIndex = 52;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(719, 105);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(204, 76);
            this.Delete.TabIndex = 51;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update.Location = new System.Drawing.Point(933, 21);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(204, 76);
            this.Update.TabIndex = 50;
            this.Update.Text = "Обновить";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(719, 21);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(204, 76);
            this.Add.TabIndex = 49;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Nazvanie
            // 
            this.Nazvanie.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nazvanie.Location = new System.Drawing.Point(168, 85);
            this.Nazvanie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nazvanie.Multiline = true;
            this.Nazvanie.Name = "Nazvanie";
            this.Nazvanie.Size = new System.Drawing.Size(415, 41);
            this.Nazvanie.TabIndex = 48;
            // 
            // Marka
            // 
            this.Marka.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Marka.Location = new System.Drawing.Point(168, 151);
            this.Marka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Marka.Multiline = true;
            this.Marka.Name = "Marka";
            this.Marka.Size = new System.Drawing.Size(415, 43);
            this.Marka.TabIndex = 47;
            // 
            // Kod
            // 
            this.Kod.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kod.Location = new System.Drawing.Point(168, 21);
            this.Kod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Kod.Multiline = true;
            this.Kod.Name = "Kod";
            this.Kod.Size = new System.Drawing.Size(415, 43);
            this.Kod.TabIndex = 46;
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.BackColor = System.Drawing.Color.Silver;
            this.Model.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Model.ForeColor = System.Drawing.Color.Black;
            this.Model.Location = new System.Drawing.Point(16, 90);
            this.Model.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(134, 34);
            this.Model.TabIndex = 45;
            this.Model.Text = "Название";
            // 
            // laabeel
            // 
            this.laabeel.AutoSize = true;
            this.laabeel.BackColor = System.Drawing.Color.Silver;
            this.laabeel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laabeel.ForeColor = System.Drawing.Color.Black;
            this.laabeel.Location = new System.Drawing.Point(55, 158);
            this.laabeel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laabeel.Name = "laabeel";
            this.laabeel.Size = new System.Drawing.Size(98, 34);
            this.laabeel.TabIndex = 44;
            this.laabeel.Text = "Марка";
            // 
            // Kod_label
            // 
            this.Kod_label.AutoSize = true;
            this.Kod_label.BackColor = System.Drawing.Color.Silver;
            this.Kod_label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kod_label.ForeColor = System.Drawing.Color.Black;
            this.Kod_label.Location = new System.Drawing.Point(93, 26);
            this.Kod_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kod_label.Name = "Kod_label";
            this.Kod_label.Size = new System.Drawing.Size(63, 34);
            this.Kod_label.TabIndex = 43;
            this.Kod_label.Text = "Код";
            // 
            // кодтовараDataGridViewTextBoxColumn
            // 
            this.кодтовараDataGridViewTextBoxColumn.DataPropertyName = "Код_товара";
            this.кодтовараDataGridViewTextBoxColumn.HeaderText = "Код_товара";
            this.кодтовараDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодтовараDataGridViewTextBoxColumn.Name = "кодтовараDataGridViewTextBoxColumn";
            this.кодтовараDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиетовараDataGridViewTextBoxColumn
            // 
            this.названиетовараDataGridViewTextBoxColumn.DataPropertyName = "Название_товара";
            this.названиетовараDataGridViewTextBoxColumn.HeaderText = "Название_товара";
            this.названиетовараDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиетовараDataGridViewTextBoxColumn.Name = "названиетовараDataGridViewTextBoxColumn";
            this.названиетовараDataGridViewTextBoxColumn.Width = 150;
            // 
            // маркаDataGridViewTextBoxColumn
            // 
            this.маркаDataGridViewTextBoxColumn.DataPropertyName = "Марка";
            this.маркаDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.маркаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.маркаDataGridViewTextBoxColumn.Name = "маркаDataGridViewTextBoxColumn";
            this.маркаDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.Width = 125;
            // 
            // Tovari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Приложение_Автосервис.Properties.Resources.фон_с_машиной__не_буггати_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1573, 937);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tovari";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.Tovari_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tovari_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tovari_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Автосервис_mdb_DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _Автосервис_mdb_DataSet _Автосервис_mdb_DataSet;
        private System.Windows.Forms.BindingSource товарыBindingSource;
        private _Автосервис_mdb_DataSetTableAdapters.ТоварыTableAdapter товарыTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox Nazvanie;
        private System.Windows.Forms.TextBox Marka;
        private System.Windows.Forms.TextBox Kod;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label laabeel;
        private System.Windows.Forms.Label Kod_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодтовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиетовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
    }
}
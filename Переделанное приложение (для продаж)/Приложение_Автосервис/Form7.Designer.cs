namespace Приложение_Автосервис
{
    partial class Form7
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.маркимашинBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Автосервис_mdb_DataSet = new Приложение_Автосервис._Автосервис_mdb_DataSet();
            this.марки_машинTableAdapter = new Приложение_Автосервис._Автосервис_mdb_DataSetTableAdapters.Марки_машинTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодклиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серияпаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерпаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter = new Приложение_Автосервис._Автосервис_mdb_DataSetTableAdapters.КлиентыTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Nomer_pasp = new System.Windows.Forms.TextBox();
            this.Seria_pasp = new System.Windows.Forms.TextBox();
            this.Data_rojdenia = new System.Windows.Forms.TextBox();
            this.Otchestvo = new System.Windows.Forms.TextBox();
            this.Namee = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Kod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.маркимашинBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Автосервис_mdb_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1559, 737);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(1698, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 26);
            this.label4.TabIndex = 30;
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
            this.label3.Location = new System.Drawing.Point(1672, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 26);
            this.label3.TabIndex = 29;
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
            this.label2.Location = new System.Drawing.Point(1642, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "_";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // маркимашинBindingSource
            // 
            this.маркимашинBindingSource.DataMember = "Марки_машин";
            this.маркимашинBindingSource.DataSource = this._Автосервис_mdb_DataSet;
            // 
            // _Автосервис_mdb_DataSet
            // 
            this._Автосервис_mdb_DataSet.DataSetName = "_Автосервис_mdb_DataSet";
            this._Автосервис_mdb_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // марки_машинTableAdapter
            // 
            this.марки_машинTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодклиентаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.датарожденияDataGridViewTextBoxColumn,
            this.серияпаспортаDataGridViewTextBoxColumn,
            this.номерпаспортаDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.клиентыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(544, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1210, 498);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // кодклиентаDataGridViewTextBoxColumn
            // 
            this.кодклиентаDataGridViewTextBoxColumn.DataPropertyName = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn.HeaderText = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодклиентаDataGridViewTextBoxColumn.Name = "кодклиентаDataGridViewTextBoxColumn";
            this.кодклиентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 125;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.Width = 125;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.Width = 125;
            // 
            // датарожденияDataGridViewTextBoxColumn
            // 
            this.датарожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.HeaderText = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датарожденияDataGridViewTextBoxColumn.Name = "датарожденияDataGridViewTextBoxColumn";
            this.датарожденияDataGridViewTextBoxColumn.Width = 125;
            // 
            // серияпаспортаDataGridViewTextBoxColumn
            // 
            this.серияпаспортаDataGridViewTextBoxColumn.DataPropertyName = "Серия_паспорта";
            this.серияпаспортаDataGridViewTextBoxColumn.HeaderText = "Серия_паспорта";
            this.серияпаспортаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.серияпаспортаDataGridViewTextBoxColumn.Name = "серияпаспортаDataGridViewTextBoxColumn";
            this.серияпаспортаDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерпаспортаDataGridViewTextBoxColumn
            // 
            this.номерпаспортаDataGridViewTextBoxColumn.DataPropertyName = "Номер_паспорта";
            this.номерпаспортаDataGridViewTextBoxColumn.HeaderText = "Номер_паспорта";
            this.номерпаспортаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерпаспортаDataGridViewTextBoxColumn.Name = "номерпаспортаDataGridViewTextBoxColumn";
            this.номерпаспортаDataGridViewTextBoxColumn.Width = 125;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.Width = 125;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this._Автосервис_mdb_DataSet;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1725, 96);
            this.panel1.TabIndex = 33;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.Phone);
            this.panel2.Controls.Add(this.Nomer_pasp);
            this.panel2.Controls.Add(this.Seria_pasp);
            this.panel2.Controls.Add(this.Data_rojdenia);
            this.panel2.Controls.Add(this.Otchestvo);
            this.panel2.Controls.Add(this.Namee);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.LastName);
            this.panel2.Controls.Add(this.Kod);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Change);
            this.panel2.Controls.Add(this.Add);
            this.panel2.Controls.Add(this.Update);
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1720, 783);
            this.panel2.TabIndex = 34;
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone.Location = new System.Drawing.Point(211, 313);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(326, 32);
            this.Phone.TabIndex = 70;
            // 
            // Nomer_pasp
            // 
            this.Nomer_pasp.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nomer_pasp.Location = new System.Drawing.Point(212, 270);
            this.Nomer_pasp.Name = "Nomer_pasp";
            this.Nomer_pasp.Size = new System.Drawing.Size(326, 32);
            this.Nomer_pasp.TabIndex = 69;
            // 
            // Seria_pasp
            // 
            this.Seria_pasp.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Seria_pasp.Location = new System.Drawing.Point(212, 228);
            this.Seria_pasp.Name = "Seria_pasp";
            this.Seria_pasp.Size = new System.Drawing.Size(326, 32);
            this.Seria_pasp.TabIndex = 68;
            // 
            // Data_rojdenia
            // 
            this.Data_rojdenia.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Data_rojdenia.Location = new System.Drawing.Point(211, 184);
            this.Data_rojdenia.Name = "Data_rojdenia";
            this.Data_rojdenia.Size = new System.Drawing.Size(326, 32);
            this.Data_rojdenia.TabIndex = 67;
            // 
            // Otchestvo
            // 
            this.Otchestvo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Otchestvo.Location = new System.Drawing.Point(212, 145);
            this.Otchestvo.Name = "Otchestvo";
            this.Otchestvo.Size = new System.Drawing.Size(326, 32);
            this.Otchestvo.TabIndex = 66;
            // 
            // Namee
            // 
            this.Namee.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Namee.Location = new System.Drawing.Point(212, 104);
            this.Namee.Name = "Namee";
            this.Namee.Size = new System.Drawing.Size(326, 32);
            this.Namee.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(98, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 27);
            this.label11.TabIndex = 64;
            this.label11.Text = "Телефон";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(20, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 27);
            this.label10.TabIndex = 63;
            this.label10.Text = "Номер паспорта";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(24, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 27);
            this.label9.TabIndex = 62;
            this.label9.Text = "Серия паспорта";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(33, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 27);
            this.label8.TabIndex = 61;
            this.label8.Text = "Дата рождения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(91, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 27);
            this.label7.TabIndex = 60;
            this.label7.Text = "Отчество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(143, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 27);
            this.label6.TabIndex = 59;
            this.label6.Text = "Имя";
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.Location = new System.Drawing.Point(212, 62);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(326, 32);
            this.LastName.TabIndex = 58;
            // 
            // Kod
            // 
            this.Kod.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kod.Location = new System.Drawing.Point(212, 9);
            this.Kod.Name = "Kod";
            this.Kod.Size = new System.Drawing.Size(326, 32);
            this.Kod.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(93, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 27);
            this.label5.TabIndex = 56;
            this.label5.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(148, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 27);
            this.label1.TabIndex = 55;
            this.label1.Text = "Код";
            // 
            // Change
            // 
            this.Change.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change.Location = new System.Drawing.Point(385, 467);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(153, 62);
            this.Change.TabIndex = 54;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(226, 386);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(153, 62);
            this.Add.TabIndex = 51;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update.Location = new System.Drawing.Point(385, 386);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(153, 62);
            this.Update.TabIndex = 52;
            this.Update.Text = "Обновить";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(226, 467);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(153, 62);
            this.Delete.TabIndex = 53;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Приложение_Автосервис.Properties.Resources.фон_с_машиной__не_буггати_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1725, 894);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form7_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form7_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.маркимашинBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Автосервис_mdb_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private _Автосервис_mdb_DataSet _Автосервис_mdb_DataSet;
        private System.Windows.Forms.BindingSource маркимашинBindingSource;
        private _Автосервис_mdb_DataSetTableAdapters.Марки_машинTableAdapter марки_машинTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private _Автосервис_mdb_DataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодклиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серияпаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерпаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Kod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Nomer_pasp;
        private System.Windows.Forms.TextBox Seria_pasp;
        private System.Windows.Forms.TextBox Data_rojdenia;
        private System.Windows.Forms.TextBox Otchestvo;
        private System.Windows.Forms.TextBox Namee;
        private System.Windows.Forms.Label label11;
    }
}
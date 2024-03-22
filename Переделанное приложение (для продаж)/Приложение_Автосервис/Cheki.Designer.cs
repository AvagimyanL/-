namespace Приложение_Автосервис
{
    partial class Cheki
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
            this.кодчекаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпродавцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодмастераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодклиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодтовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодуслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодавтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценатовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценауслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.чекиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Автосервис_mdb_DataSet = new Приложение_Автосервис._Автосервис_mdb_DataSet();
            this.чекиTableAdapter = new Приложение_Автосервис._Автосервис_mdb_DataSetTableAdapters.ЧекиTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.чекиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Автосервис_mdb_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодчекаDataGridViewTextBoxColumn,
            this.кодпродавцаDataGridViewTextBoxColumn,
            this.кодмастераDataGridViewTextBoxColumn,
            this.кодклиентаDataGridViewTextBoxColumn,
            this.кодтовараDataGridViewTextBoxColumn,
            this.кодуслугиDataGridViewTextBoxColumn,
            this.кодавтомобиляDataGridViewTextBoxColumn,
            this.ценатовараDataGridViewTextBoxColumn,
            this.ценауслугиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.чекиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1115, 472);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодчекаDataGridViewTextBoxColumn
            // 
            this.кодчекаDataGridViewTextBoxColumn.DataPropertyName = "Код_чека";
            this.кодчекаDataGridViewTextBoxColumn.HeaderText = "Код_чека";
            this.кодчекаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодчекаDataGridViewTextBoxColumn.Name = "кодчекаDataGridViewTextBoxColumn";
            this.кодчекаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодпродавцаDataGridViewTextBoxColumn
            // 
            this.кодпродавцаDataGridViewTextBoxColumn.DataPropertyName = "Код_продавца";
            this.кодпродавцаDataGridViewTextBoxColumn.HeaderText = "Код_продавца";
            this.кодпродавцаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодпродавцаDataGridViewTextBoxColumn.Name = "кодпродавцаDataGridViewTextBoxColumn";
            this.кодпродавцаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодмастераDataGridViewTextBoxColumn
            // 
            this.кодмастераDataGridViewTextBoxColumn.DataPropertyName = "Код_мастера";
            this.кодмастераDataGridViewTextBoxColumn.HeaderText = "Код_мастера";
            this.кодмастераDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодмастераDataGridViewTextBoxColumn.Name = "кодмастераDataGridViewTextBoxColumn";
            this.кодмастераDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодклиентаDataGridViewTextBoxColumn
            // 
            this.кодклиентаDataGridViewTextBoxColumn.DataPropertyName = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn.HeaderText = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодклиентаDataGridViewTextBoxColumn.Name = "кодклиентаDataGridViewTextBoxColumn";
            this.кодклиентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодтовараDataGridViewTextBoxColumn
            // 
            this.кодтовараDataGridViewTextBoxColumn.DataPropertyName = "Код_товара";
            this.кодтовараDataGridViewTextBoxColumn.HeaderText = "Код_товара";
            this.кодтовараDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодтовараDataGridViewTextBoxColumn.Name = "кодтовараDataGridViewTextBoxColumn";
            this.кодтовараDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодуслугиDataGridViewTextBoxColumn
            // 
            this.кодуслугиDataGridViewTextBoxColumn.DataPropertyName = "Код_услуги";
            this.кодуслугиDataGridViewTextBoxColumn.HeaderText = "Код_услуги";
            this.кодуслугиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодуслугиDataGridViewTextBoxColumn.Name = "кодуслугиDataGridViewTextBoxColumn";
            this.кодуслугиDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодавтомобиляDataGridViewTextBoxColumn
            // 
            this.кодавтомобиляDataGridViewTextBoxColumn.DataPropertyName = "Код_автомобиля";
            this.кодавтомобиляDataGridViewTextBoxColumn.HeaderText = "Код_автомобиля";
            this.кодавтомобиляDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодавтомобиляDataGridViewTextBoxColumn.Name = "кодавтомобиляDataGridViewTextBoxColumn";
            this.кодавтомобиляDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценатовараDataGridViewTextBoxColumn
            // 
            this.ценатовараDataGridViewTextBoxColumn.DataPropertyName = "Цена_товара";
            this.ценатовараDataGridViewTextBoxColumn.HeaderText = "Цена_товара";
            this.ценатовараDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценатовараDataGridViewTextBoxColumn.Name = "ценатовараDataGridViewTextBoxColumn";
            this.ценатовараDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценауслугиDataGridViewTextBoxColumn
            // 
            this.ценауслугиDataGridViewTextBoxColumn.DataPropertyName = "Цена_услуги";
            this.ценауслугиDataGridViewTextBoxColumn.HeaderText = "Цена_услуги";
            this.ценауслугиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценауслугиDataGridViewTextBoxColumn.Name = "ценауслугиDataGridViewTextBoxColumn";
            this.ценауслугиDataGridViewTextBoxColumn.Width = 125;
            // 
            // чекиBindingSource
            // 
            this.чекиBindingSource.DataMember = "Чеки";
            this.чекиBindingSource.DataSource = this._Автосервис_mdb_DataSet;
            // 
            // _Автосервис_mdb_DataSet
            // 
            this._Автосервис_mdb_DataSet.DataSetName = "_Автосервис_mdb_DataSet";
            this._Автосервис_mdb_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // чекиTableAdapter
            // 
            this.чекиTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(1224, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 26);
            this.label5.TabIndex = 35;
            this.label5.Text = "||";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(1272, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 26);
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
            this.label3.Location = new System.Drawing.Point(1246, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 26);
            this.label3.TabIndex = 33;
            this.label3.Text = "0";
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
            this.label2.Location = new System.Drawing.Point(1194, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 26);
            this.label2.TabIndex = 32;
            this.label2.Text = "_";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1138, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 42);
            this.button1.TabIndex = 36;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cheki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 636);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cheki";
            this.Text = "Чеки";
            this.Load += new System.EventHandler(this.Cheki_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cheki_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cheki_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.чекиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Автосервис_mdb_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _Автосервис_mdb_DataSet _Автосервис_mdb_DataSet;
        private System.Windows.Forms.BindingSource чекиBindingSource;
        private _Автосервис_mdb_DataSetTableAdapters.ЧекиTableAdapter чекиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодчекаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпродавцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодмастераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодклиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодтовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодуслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодавтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценатовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценауслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
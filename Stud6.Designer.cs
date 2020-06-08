namespace Klass
{
    partial class Stud6
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
            this.students6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klassDSet = new Klass.KlassDSet();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonPoisk = new System.Windows.Forms.Button();
            this.students5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students5TableAdapter = new Klass.KlassDSetTableAdapters.students5TableAdapter();
            this.students6TableAdapter = new Klass.KlassDSetTableAdapters.students6TableAdapter();
            this.klassDataSet = new Klass.KlassDataSet();
            this.students6BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.students6TableAdapter1 = new Klass.KlassDataSetTableAdapters.students6TableAdapter();
            this.klassDaSet = new Klass.KlassDaSet();
            this.students6BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.students6TableAdapter2 = new Klass.KlassDaSetTableAdapters.students6TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.students6DataGridView = new System.Windows.Forms.DataGridView();
            this.idklassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namestudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.students6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students6BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDaSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students6BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students6DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // students6BindingSource
            // 
            this.students6BindingSource.DataMember = "students6";
            this.students6BindingSource.DataSource = this.klassDSet;
            // 
            // klassDSet
            // 
            this.klassDSet.DataSetName = "KlassDSet";
            this.klassDSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(59, 610);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 67);
            this.button4.TabIndex = 57;
            this.button4.Text = "Родители";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(264, 610);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 67);
            this.button3.TabIndex = 55;
            this.button3.Text = "Сводная ведомость";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(471, 610);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 67);
            this.button2.TabIndex = 54;
            this.button2.Text = "Карта здоровья";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(704, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 67);
            this.button1.TabIndex = 53;
            this.button1.Text = "Посещаемость";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(1175, 610);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(187, 67);
            this.buttonBack.TabIndex = 52;
            this.buttonBack.Text = "Выход";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonPoisk
            // 
            this.buttonPoisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonPoisk.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPoisk.Location = new System.Drawing.Point(939, 610);
            this.buttonPoisk.Name = "buttonPoisk";
            this.buttonPoisk.Size = new System.Drawing.Size(216, 67);
            this.buttonPoisk.TabIndex = 51;
            this.buttonPoisk.Text = "Редактировать";
            this.buttonPoisk.UseVisualStyleBackColor = false;
            this.buttonPoisk.Click += new System.EventHandler(this.buttonPoisk_Click);
            // 
            // students5BindingSource
            // 
            this.students5BindingSource.DataMember = "students5";
            this.students5BindingSource.DataSource = this.klassDSet;
            // 
            // students5TableAdapter
            // 
            this.students5TableAdapter.ClearBeforeFill = true;
            // 
            // students6TableAdapter
            // 
            this.students6TableAdapter.ClearBeforeFill = true;
            // 
            // klassDataSet
            // 
            this.klassDataSet.DataSetName = "KlassDataSet";
            this.klassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // students6BindingSource1
            // 
            this.students6BindingSource1.DataMember = "students6";
            this.students6BindingSource1.DataSource = this.klassDataSet;
            // 
            // students6TableAdapter1
            // 
            this.students6TableAdapter1.ClearBeforeFill = true;
            // 
            // klassDaSet
            // 
            this.klassDaSet.DataSetName = "KlassDaSet";
            this.klassDaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // students6BindingSource2
            // 
            this.students6BindingSource2.DataMember = "students6";
            this.students6BindingSource2.DataSource = this.klassDaSet;
            // 
            // students6TableAdapter2
            // 
            this.students6TableAdapter2.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(506, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 40);
            this.label1.TabIndex = 72;
            this.label1.Text = "Список учащихся 6 класса";
            // 
            // students6DataGridView
            // 
            this.students6DataGridView.AutoGenerateColumns = false;
            this.students6DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.students6DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.students6DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idklassDataGridViewTextBoxColumn,
            this.namestudentDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.polDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn});
            this.students6DataGridView.DataSource = this.students6BindingSource2;
            this.students6DataGridView.Location = new System.Drawing.Point(6, 52);
            this.students6DataGridView.Name = "students6DataGridView";
            this.students6DataGridView.RowHeadersWidth = 51;
            this.students6DataGridView.RowTemplate.Height = 24;
            this.students6DataGridView.Size = new System.Drawing.Size(1371, 447);
            this.students6DataGridView.TabIndex = 71;
            // 
            // idklassDataGridViewTextBoxColumn
            // 
            this.idklassDataGridViewTextBoxColumn.DataPropertyName = "id_klass";
            this.idklassDataGridViewTextBoxColumn.HeaderText = "Класс";
            this.idklassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idklassDataGridViewTextBoxColumn.Name = "idklassDataGridViewTextBoxColumn";
            // 
            // namestudentDataGridViewTextBoxColumn
            // 
            this.namestudentDataGridViewTextBoxColumn.DataPropertyName = "name_student";
            this.namestudentDataGridViewTextBoxColumn.HeaderText = "Полное имя ученика";
            this.namestudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namestudentDataGridViewTextBoxColumn.Name = "namestudentDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // polDataGridViewTextBoxColumn
            // 
            this.polDataGridViewTextBoxColumn.DataPropertyName = "pol";
            this.polDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.polDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.polDataGridViewTextBoxColumn.Name = "polDataGridViewTextBoxColumn";
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Нормер телефона";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(1175, 520);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 67);
            this.button5.TabIndex = 73;
            this.button5.Text = "О программе";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Stud6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1395, 719);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.students6DataGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonPoisk);
            this.Name = "Stud6";
            this.Text = "Список учащихся 6 класса";
            this.Load += new System.EventHandler(this.Stud6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.students6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students6BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDaSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students6BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students6DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonPoisk;
        private KlassDSet klassDSet;
        private System.Windows.Forms.BindingSource students5BindingSource;
        private KlassDSetTableAdapters.students5TableAdapter students5TableAdapter;
        private System.Windows.Forms.BindingSource students6BindingSource;
        private KlassDSetTableAdapters.students6TableAdapter students6TableAdapter;
        private KlassDataSet klassDataSet;
        private System.Windows.Forms.BindingSource students6BindingSource1;
        private KlassDataSetTableAdapters.students6TableAdapter students6TableAdapter1;
        private KlassDaSet klassDaSet;
        private System.Windows.Forms.BindingSource students6BindingSource2;
        private KlassDaSetTableAdapters.students6TableAdapter students6TableAdapter2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView students6DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namestudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
    }
}
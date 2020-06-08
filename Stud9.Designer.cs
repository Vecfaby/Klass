namespace Klass
{
    partial class Stud9
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
            this.students9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klassDSet = new Klass.KlassDSet();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonPoisk = new System.Windows.Forms.Button();
            this.students9TableAdapter = new Klass.KlassDSetTableAdapters.students9TableAdapter();
            this.klassDataSet = new Klass.KlassDataSet();
            this.klassDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vedomost9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vedomost9TableAdapter = new Klass.KlassDataSetTableAdapters.vedomost9TableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.students9DataGridView = new System.Windows.Forms.DataGridView();
            this.idklassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namestudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.students9BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomost9BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students9DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // students9BindingSource
            // 
            this.students9BindingSource.DataMember = "students9";
            this.students9BindingSource.DataSource = this.klassDSet;
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
            // students9TableAdapter
            // 
            this.students9TableAdapter.ClearBeforeFill = true;
            // 
            // klassDataSet
            // 
            this.klassDataSet.DataSetName = "KlassDataSet";
            this.klassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klassDataSetBindingSource
            // 
            this.klassDataSetBindingSource.DataSource = this.klassDataSet;
            this.klassDataSetBindingSource.Position = 0;
            // 
            // vedomost9BindingSource
            // 
            this.vedomost9BindingSource.DataMember = "vedomost9";
            this.vedomost9BindingSource.DataSource = this.klassDataSet;
            // 
            // vedomost9TableAdapter
            // 
            this.vedomost9TableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(481, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 40);
            this.label2.TabIndex = 70;
            this.label2.Text = "Список учащихся 9 класса";
            // 
            // students9DataGridView
            // 
            this.students9DataGridView.AutoGenerateColumns = false;
            this.students9DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.students9DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.students9DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idklassDataGridViewTextBoxColumn,
            this.namestudentDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.polDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn});
            this.students9DataGridView.DataSource = this.students9BindingSource;
            this.students9DataGridView.Location = new System.Drawing.Point(12, 48);
            this.students9DataGridView.Name = "students9DataGridView";
            this.students9DataGridView.RowHeadersWidth = 51;
            this.students9DataGridView.RowTemplate.Height = 24;
            this.students9DataGridView.Size = new System.Drawing.Size(1371, 452);
            this.students9DataGridView.TabIndex = 69;
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
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(1175, 527);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 67);
            this.button5.TabIndex = 71;
            this.button5.Text = "О программе";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Stud9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1395, 719);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.students9DataGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonPoisk);
            this.Name = "Stud9";
            this.Text = "Список учащихся 9 класса";
            this.Load += new System.EventHandler(this.Stud9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.students9BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomost9BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students9DataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource students9BindingSource;
        private KlassDSetTableAdapters.students9TableAdapter students9TableAdapter;
        private System.Windows.Forms.BindingSource klassDataSetBindingSource;
        private KlassDataSet klassDataSet;
        private System.Windows.Forms.BindingSource vedomost9BindingSource;
        private KlassDataSetTableAdapters.vedomost9TableAdapter vedomost9TableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView students9DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namestudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
    }
}
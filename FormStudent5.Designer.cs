namespace Klass
{
    partial class FormStudent5
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
            this.students5DataGridView = new System.Windows.Forms.DataGridView();
            this.idstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idschoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idklassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namestudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameparentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idposDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.students5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klassDSet = new Klass.KlassDSet();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonPoisk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonDellete = new System.Windows.Forms.Button();
            this.buttonOtobr = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.students5TableAdapter = new Klass.KlassDSetTableAdapters.students5TableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.students5DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).BeginInit();
            this.SuspendLayout();
            // 
            // students5DataGridView
            // 
            this.students5DataGridView.AutoGenerateColumns = false;
            this.students5DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.students5DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.students5DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstudentDataGridViewTextBoxColumn,
            this.idschoolDataGridViewTextBoxColumn,
            this.idklassDataGridViewTextBoxColumn,
            this.namestudentDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.polDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.nameparentDataGridViewTextBoxColumn,
            this.passerialDataGridViewTextBoxColumn,
            this.pasnumberDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.idrodDataGridViewTextBoxColumn,
            this.idkartDataGridViewTextBoxColumn,
            this.idposDataGridViewTextBoxColumn,
            this.idvedDataGridViewTextBoxColumn});
            this.students5DataGridView.DataSource = this.students5BindingSource;
            this.students5DataGridView.Location = new System.Drawing.Point(12, 45);
            this.students5DataGridView.Name = "students5DataGridView";
            this.students5DataGridView.RowHeadersWidth = 51;
            this.students5DataGridView.RowTemplate.Height = 24;
            this.students5DataGridView.Size = new System.Drawing.Size(1371, 506);
            this.students5DataGridView.TabIndex = 55;
            // 
            // idstudentDataGridViewTextBoxColumn
            // 
            this.idstudentDataGridViewTextBoxColumn.DataPropertyName = "id_student";
            this.idstudentDataGridViewTextBoxColumn.HeaderText = "Код ученика";
            this.idstudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idstudentDataGridViewTextBoxColumn.Name = "idstudentDataGridViewTextBoxColumn";
            this.idstudentDataGridViewTextBoxColumn.Width = 110;
            // 
            // idschoolDataGridViewTextBoxColumn
            // 
            this.idschoolDataGridViewTextBoxColumn.DataPropertyName = "id_school";
            this.idschoolDataGridViewTextBoxColumn.HeaderText = "Код школы";
            this.idschoolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idschoolDataGridViewTextBoxColumn.Name = "idschoolDataGridViewTextBoxColumn";
            this.idschoolDataGridViewTextBoxColumn.Width = 101;
            // 
            // idklassDataGridViewTextBoxColumn
            // 
            this.idklassDataGridViewTextBoxColumn.DataPropertyName = "id_klass";
            this.idklassDataGridViewTextBoxColumn.HeaderText = "Класс";
            this.idklassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idklassDataGridViewTextBoxColumn.Name = "idklassDataGridViewTextBoxColumn";
            this.idklassDataGridViewTextBoxColumn.Width = 76;
            // 
            // namestudentDataGridViewTextBoxColumn
            // 
            this.namestudentDataGridViewTextBoxColumn.DataPropertyName = "name_student";
            this.namestudentDataGridViewTextBoxColumn.HeaderText = "Полное имя ученика";
            this.namestudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namestudentDataGridViewTextBoxColumn.Name = "namestudentDataGridViewTextBoxColumn";
            this.namestudentDataGridViewTextBoxColumn.Width = 159;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.Width = 128;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 77;
            // 
            // polDataGridViewTextBoxColumn
            // 
            this.polDataGridViewTextBoxColumn.DataPropertyName = "pol";
            this.polDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.polDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.polDataGridViewTextBoxColumn.Name = "polDataGridViewTextBoxColumn";
            this.polDataGridViewTextBoxColumn.Width = 63;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.Width = 97;
            // 
            // nameparentDataGridViewTextBoxColumn
            // 
            this.nameparentDataGridViewTextBoxColumn.DataPropertyName = "name_parent";
            this.nameparentDataGridViewTextBoxColumn.HeaderText = "Имя родителя";
            this.nameparentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameparentDataGridViewTextBoxColumn.Name = "nameparentDataGridViewTextBoxColumn";
            this.nameparentDataGridViewTextBoxColumn.Width = 120;
            // 
            // passerialDataGridViewTextBoxColumn
            // 
            this.passerialDataGridViewTextBoxColumn.DataPropertyName = "pas_serial";
            this.passerialDataGridViewTextBoxColumn.HeaderText = "Серия паспорта";
            this.passerialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passerialDataGridViewTextBoxColumn.Name = "passerialDataGridViewTextBoxColumn";
            this.passerialDataGridViewTextBoxColumn.Width = 132;
            // 
            // pasnumberDataGridViewTextBoxColumn
            // 
            this.pasnumberDataGridViewTextBoxColumn.DataPropertyName = "pas_number";
            this.pasnumberDataGridViewTextBoxColumn.HeaderText = "Номер паспорта";
            this.pasnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pasnumberDataGridViewTextBoxColumn.Name = "pasnumberDataGridViewTextBoxColumn";
            this.pasnumberDataGridViewTextBoxColumn.Width = 134;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Актив класса";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Width = 114;
            // 
            // idrodDataGridViewTextBoxColumn
            // 
            this.idrodDataGridViewTextBoxColumn.DataPropertyName = "id_rod";
            this.idrodDataGridViewTextBoxColumn.HeaderText = "Код родителя";
            this.idrodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idrodDataGridViewTextBoxColumn.Name = "idrodDataGridViewTextBoxColumn";
            this.idrodDataGridViewTextBoxColumn.Width = 118;
            // 
            // idkartDataGridViewTextBoxColumn
            // 
            this.idkartDataGridViewTextBoxColumn.DataPropertyName = "id_kart";
            this.idkartDataGridViewTextBoxColumn.HeaderText = "Код карты ";
            this.idkartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idkartDataGridViewTextBoxColumn.Name = "idkartDataGridViewTextBoxColumn";
            this.idkartDataGridViewTextBoxColumn.Width = 101;
            // 
            // idposDataGridViewTextBoxColumn
            // 
            this.idposDataGridViewTextBoxColumn.DataPropertyName = "id_pos";
            this.idposDataGridViewTextBoxColumn.HeaderText = "Код посещаемости";
            this.idposDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idposDataGridViewTextBoxColumn.Name = "idposDataGridViewTextBoxColumn";
            this.idposDataGridViewTextBoxColumn.Width = 149;
            // 
            // idvedDataGridViewTextBoxColumn
            // 
            this.idvedDataGridViewTextBoxColumn.DataPropertyName = "id_ved";
            this.idvedDataGridViewTextBoxColumn.HeaderText = "Код ведомости";
            this.idvedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idvedDataGridViewTextBoxColumn.Name = "idvedDataGridViewTextBoxColumn";
            this.idvedDataGridViewTextBoxColumn.Width = 125;
            // 
            // students5BindingSource
            // 
            this.students5BindingSource.DataMember = "students5";
            this.students5BindingSource.DataSource = this.klassDSet;
            // 
            // klassDSet
            // 
            this.klassDSet.DataSetName = "KlassDSet";
            this.klassDSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonPrint.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrint.Location = new System.Drawing.Point(981, 631);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(187, 67);
            this.buttonPrint.TabIndex = 56;
            this.buttonPrint.Text = "Печать";
            this.buttonPrint.UseCompatibleTextRendering = true;
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(981, 558);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 67);
            this.button4.TabIndex = 54;
            this.button4.Text = "Экспорт в Эксель";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonPoisk
            // 
            this.buttonPoisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonPoisk.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPoisk.Location = new System.Drawing.Point(488, 557);
            this.buttonPoisk.Name = "buttonPoisk";
            this.buttonPoisk.Size = new System.Drawing.Size(187, 67);
            this.buttonPoisk.TabIndex = 53;
            this.buttonPoisk.Text = "Найти";
            this.buttonPoisk.UseVisualStyleBackColor = false;
            this.buttonPoisk.Click += new System.EventHandler(this.buttonPoisk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(69, 592);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 29);
            this.label1.TabIndex = 52;
            this.label1.Text = "Введите имя ученика:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSearch.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(21, 647);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(361, 35);
            this.textBoxSearch.TabIndex = 51;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonDellete
            // 
            this.buttonDellete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDellete.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDellete.Location = new System.Drawing.Point(739, 631);
            this.buttonDellete.Name = "buttonDellete";
            this.buttonDellete.Size = new System.Drawing.Size(187, 67);
            this.buttonDellete.TabIndex = 50;
            this.buttonDellete.Text = "Удалить";
            this.buttonDellete.UseVisualStyleBackColor = false;
            this.buttonDellete.Click += new System.EventHandler(this.buttonDellete_Click);
            // 
            // buttonOtobr
            // 
            this.buttonOtobr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonOtobr.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOtobr.Location = new System.Drawing.Point(488, 631);
            this.buttonOtobr.Name = "buttonOtobr";
            this.buttonOtobr.Size = new System.Drawing.Size(187, 67);
            this.buttonOtobr.TabIndex = 49;
            this.buttonOtobr.Text = "Отобразить все";
            this.buttonOtobr.UseVisualStyleBackColor = false;
            this.buttonOtobr.Click += new System.EventHandler(this.buttonOtobr_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(739, 557);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(187, 67);
            this.buttonSave.TabIndex = 48;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(1196, 631);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(187, 67);
            this.buttonBack.TabIndex = 47;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // students5TableAdapter
            // 
            this.students5TableAdapter.ClearBeforeFill = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(514, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 40);
            this.label2.TabIndex = 67;
            this.label2.Text = "Список учащихся 5 класса";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormStudent5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1395, 719);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.students5DataGridView);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonPoisk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.buttonOtobr);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormStudent5";
            this.Text = "Список учащихся 5 класса";
            this.Load += new System.EventHandler(this.FormStudent5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.students5DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView students5DataGridView;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonPoisk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonDellete;
        private System.Windows.Forms.Button buttonOtobr;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private KlassDSet klassDSet;
        private System.Windows.Forms.BindingSource students5BindingSource;
        private KlassDSetTableAdapters.students5TableAdapter students5TableAdapter;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idschoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namestudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameparentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idposDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}
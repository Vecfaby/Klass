namespace Klass
{
    partial class FormStudent6
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
            this.students6DataGridView = new System.Windows.Forms.DataGridView();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonPoisk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonDellete = new System.Windows.Forms.Button();
            this.buttonOtobr = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.klassDSet = new Klass.KlassDSet();
            this.students6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students6TableAdapter = new Klass.KlassDSetTableAdapters.students6TableAdapter();
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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.students6DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students6BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // students6DataGridView
            // 
            this.students6DataGridView.AutoGenerateColumns = false;
            this.students6DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.students6DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.students6DataGridView.DataSource = this.students6BindingSource;
            this.students6DataGridView.Location = new System.Drawing.Point(12, 16);
            this.students6DataGridView.Name = "students6DataGridView";
            this.students6DataGridView.RowHeadersWidth = 51;
            this.students6DataGridView.RowTemplate.Height = 24;
            this.students6DataGridView.Size = new System.Drawing.Size(1371, 539);
            this.students6DataGridView.TabIndex = 65;
            this.students6DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.students5DataGridView_CellContentClick);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonPrint.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrint.Location = new System.Drawing.Point(981, 635);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(187, 67);
            this.buttonPrint.TabIndex = 66;
            this.buttonPrint.Text = "Печать";
            this.buttonPrint.UseCompatibleTextRendering = true;
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(981, 562);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 67);
            this.button4.TabIndex = 64;
            this.button4.Text = "Экспорт в Эксель";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonPoisk
            // 
            this.buttonPoisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonPoisk.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPoisk.Location = new System.Drawing.Point(488, 561);
            this.buttonPoisk.Name = "buttonPoisk";
            this.buttonPoisk.Size = new System.Drawing.Size(187, 67);
            this.buttonPoisk.TabIndex = 63;
            this.buttonPoisk.Text = "Найти";
            this.buttonPoisk.UseVisualStyleBackColor = false;
            this.buttonPoisk.Click += new System.EventHandler(this.buttonPoisk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(69, 596);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 29);
            this.label1.TabIndex = 62;
            this.label1.Text = "Введите имя ученика:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSearch.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(21, 651);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(361, 35);
            this.textBoxSearch.TabIndex = 61;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonDellete
            // 
            this.buttonDellete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDellete.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDellete.Location = new System.Drawing.Point(739, 635);
            this.buttonDellete.Name = "buttonDellete";
            this.buttonDellete.Size = new System.Drawing.Size(187, 67);
            this.buttonDellete.TabIndex = 60;
            this.buttonDellete.Text = "Удалить";
            this.buttonDellete.UseVisualStyleBackColor = false;
            this.buttonDellete.Click += new System.EventHandler(this.buttonDellete_Click);
            // 
            // buttonOtobr
            // 
            this.buttonOtobr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonOtobr.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOtobr.Location = new System.Drawing.Point(488, 635);
            this.buttonOtobr.Name = "buttonOtobr";
            this.buttonOtobr.Size = new System.Drawing.Size(187, 67);
            this.buttonOtobr.TabIndex = 59;
            this.buttonOtobr.Text = "Отобразить все";
            this.buttonOtobr.UseVisualStyleBackColor = false;
            this.buttonOtobr.Click += new System.EventHandler(this.buttonOtobr_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(739, 561);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(187, 67);
            this.buttonSave.TabIndex = 58;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(1196, 635);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(187, 67);
            this.buttonBack.TabIndex = 57;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // klassDSet
            // 
            this.klassDSet.DataSetName = "KlassDSet";
            this.klassDSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // students6BindingSource
            // 
            this.students6BindingSource.DataMember = "students6";
            this.students6BindingSource.DataSource = this.klassDSet;
            // 
            // students6TableAdapter
            // 
            this.students6TableAdapter.ClearBeforeFill = true;
            // 
            // idstudentDataGridViewTextBoxColumn
            // 
            this.idstudentDataGridViewTextBoxColumn.DataPropertyName = "id_student";
            this.idstudentDataGridViewTextBoxColumn.HeaderText = "id_student";
            this.idstudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idstudentDataGridViewTextBoxColumn.Name = "idstudentDataGridViewTextBoxColumn";
            this.idstudentDataGridViewTextBoxColumn.Width = 125;
            // 
            // idschoolDataGridViewTextBoxColumn
            // 
            this.idschoolDataGridViewTextBoxColumn.DataPropertyName = "id_school";
            this.idschoolDataGridViewTextBoxColumn.HeaderText = "id_school";
            this.idschoolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idschoolDataGridViewTextBoxColumn.Name = "idschoolDataGridViewTextBoxColumn";
            this.idschoolDataGridViewTextBoxColumn.Width = 125;
            // 
            // idklassDataGridViewTextBoxColumn
            // 
            this.idklassDataGridViewTextBoxColumn.DataPropertyName = "id_klass";
            this.idklassDataGridViewTextBoxColumn.HeaderText = "id_klass";
            this.idklassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idklassDataGridViewTextBoxColumn.Name = "idklassDataGridViewTextBoxColumn";
            this.idklassDataGridViewTextBoxColumn.Width = 125;
            // 
            // namestudentDataGridViewTextBoxColumn
            // 
            this.namestudentDataGridViewTextBoxColumn.DataPropertyName = "name_student";
            this.namestudentDataGridViewTextBoxColumn.HeaderText = "name_student";
            this.namestudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namestudentDataGridViewTextBoxColumn.Name = "namestudentDataGridViewTextBoxColumn";
            this.namestudentDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "birthday";
            this.birthdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // polDataGridViewTextBoxColumn
            // 
            this.polDataGridViewTextBoxColumn.DataPropertyName = "pol";
            this.polDataGridViewTextBoxColumn.HeaderText = "pol";
            this.polDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.polDataGridViewTextBoxColumn.Name = "polDataGridViewTextBoxColumn";
            this.polDataGridViewTextBoxColumn.Width = 125;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameparentDataGridViewTextBoxColumn
            // 
            this.nameparentDataGridViewTextBoxColumn.DataPropertyName = "name_parent";
            this.nameparentDataGridViewTextBoxColumn.HeaderText = "name_parent";
            this.nameparentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameparentDataGridViewTextBoxColumn.Name = "nameparentDataGridViewTextBoxColumn";
            this.nameparentDataGridViewTextBoxColumn.Width = 125;
            // 
            // passerialDataGridViewTextBoxColumn
            // 
            this.passerialDataGridViewTextBoxColumn.DataPropertyName = "pas_serial";
            this.passerialDataGridViewTextBoxColumn.HeaderText = "pas_serial";
            this.passerialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passerialDataGridViewTextBoxColumn.Name = "passerialDataGridViewTextBoxColumn";
            this.passerialDataGridViewTextBoxColumn.Width = 125;
            // 
            // pasnumberDataGridViewTextBoxColumn
            // 
            this.pasnumberDataGridViewTextBoxColumn.DataPropertyName = "pas_number";
            this.pasnumberDataGridViewTextBoxColumn.HeaderText = "pas_number";
            this.pasnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pasnumberDataGridViewTextBoxColumn.Name = "pasnumberDataGridViewTextBoxColumn";
            this.pasnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Width = 125;
            // 
            // idrodDataGridViewTextBoxColumn
            // 
            this.idrodDataGridViewTextBoxColumn.DataPropertyName = "id_rod";
            this.idrodDataGridViewTextBoxColumn.HeaderText = "id_rod";
            this.idrodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idrodDataGridViewTextBoxColumn.Name = "idrodDataGridViewTextBoxColumn";
            this.idrodDataGridViewTextBoxColumn.Width = 125;
            // 
            // idkartDataGridViewTextBoxColumn
            // 
            this.idkartDataGridViewTextBoxColumn.DataPropertyName = "id_kart";
            this.idkartDataGridViewTextBoxColumn.HeaderText = "id_kart";
            this.idkartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idkartDataGridViewTextBoxColumn.Name = "idkartDataGridViewTextBoxColumn";
            this.idkartDataGridViewTextBoxColumn.Width = 125;
            // 
            // idposDataGridViewTextBoxColumn
            // 
            this.idposDataGridViewTextBoxColumn.DataPropertyName = "id_pos";
            this.idposDataGridViewTextBoxColumn.HeaderText = "id_pos";
            this.idposDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idposDataGridViewTextBoxColumn.Name = "idposDataGridViewTextBoxColumn";
            this.idposDataGridViewTextBoxColumn.Width = 125;
            // 
            // idvedDataGridViewTextBoxColumn
            // 
            this.idvedDataGridViewTextBoxColumn.DataPropertyName = "id_ved";
            this.idvedDataGridViewTextBoxColumn.HeaderText = "id_ved";
            this.idvedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idvedDataGridViewTextBoxColumn.Name = "idvedDataGridViewTextBoxColumn";
            this.idvedDataGridViewTextBoxColumn.Width = 125;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormStudent6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 719);
            this.Controls.Add(this.students6DataGridView);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonPoisk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.buttonOtobr);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormStudent6";
            this.Text = "FormStudent6";
            this.Load += new System.EventHandler(this.FormStudent6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.students6DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students6BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView students6DataGridView;
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
        private System.Windows.Forms.BindingSource students6BindingSource;
        private KlassDSetTableAdapters.students6TableAdapter students6TableAdapter;
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
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
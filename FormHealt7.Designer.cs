namespace Klass
{
    partial class FormHealt7
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.karta_health7DataGridView = new System.Windows.Forms.DataGridView();
            this.idkartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grouphealthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnozDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kartahealth7BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.klassDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klassDataSet = new Klass.KlassDataSet();
            this.kartahealth7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klassDSet = new Klass.KlassDSet();
            this.buttonDellete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.karta_health7TableAdapter = new Klass.KlassDSetTableAdapters.karta_health7TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.namestudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKstudents7kartahealth7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klassDataSet1 = new Klass.KlassDataSet1();
            this.students7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students7TableAdapter = new Klass.KlassDSetTableAdapters.students7TableAdapter();
            this.usersTableAdapter = new Klass.KlassDataSet1TableAdapters.UsersTableAdapter();
            this.karta_health7TableAdapter1 = new Klass.KlassDataSetTableAdapters.karta_health7TableAdapter();
            this.students7TableAdapter1 = new Klass.KlassDataSetTableAdapters.students7TableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.karta_health7DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartahealth7BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartahealth7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKstudents7kartahealth7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students7BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // karta_health7DataGridView
            // 
            this.karta_health7DataGridView.AutoGenerateColumns = false;
            this.karta_health7DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.karta_health7DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.karta_health7DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.karta_health7DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkartDataGridViewTextBoxColumn,
            this.grouphealthDataGridViewTextBoxColumn,
            this.diagnozDataGridViewTextBoxColumn});
            this.karta_health7DataGridView.DataSource = this.kartahealth7BindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.karta_health7DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.karta_health7DataGridView.Location = new System.Drawing.Point(130, 61);
            this.karta_health7DataGridView.Name = "karta_health7DataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.karta_health7DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.karta_health7DataGridView.RowHeadersWidth = 51;
            this.karta_health7DataGridView.RowTemplate.Height = 24;
            this.karta_health7DataGridView.Size = new System.Drawing.Size(518, 510);
            this.karta_health7DataGridView.TabIndex = 72;
            this.karta_health7DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.karta_health7DataGridView_CellContentClick);
            // 
            // idkartDataGridViewTextBoxColumn
            // 
            this.idkartDataGridViewTextBoxColumn.DataPropertyName = "id_kart";
            this.idkartDataGridViewTextBoxColumn.HeaderText = "Код карты";
            this.idkartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idkartDataGridViewTextBoxColumn.Name = "idkartDataGridViewTextBoxColumn";
            // 
            // grouphealthDataGridViewTextBoxColumn
            // 
            this.grouphealthDataGridViewTextBoxColumn.DataPropertyName = "group_health";
            this.grouphealthDataGridViewTextBoxColumn.HeaderText = "Группа здоровья";
            this.grouphealthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.grouphealthDataGridViewTextBoxColumn.Name = "grouphealthDataGridViewTextBoxColumn";
            // 
            // diagnozDataGridViewTextBoxColumn
            // 
            this.diagnozDataGridViewTextBoxColumn.DataPropertyName = "diagnoz";
            this.diagnozDataGridViewTextBoxColumn.HeaderText = "Диагноз";
            this.diagnozDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diagnozDataGridViewTextBoxColumn.Name = "diagnozDataGridViewTextBoxColumn";
            // 
            // kartahealth7BindingSource1
            // 
            this.kartahealth7BindingSource1.DataMember = "karta_health7";
            this.kartahealth7BindingSource1.DataSource = this.klassDataSetBindingSource;
            // 
            // klassDataSetBindingSource
            // 
            this.klassDataSetBindingSource.DataSource = this.klassDataSet;
            this.klassDataSetBindingSource.Position = 0;
            // 
            // klassDataSet
            // 
            this.klassDataSet.DataSetName = "KlassDataSet";
            this.klassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kartahealth7BindingSource
            // 
            this.kartahealth7BindingSource.DataMember = "karta_health7";
            this.kartahealth7BindingSource.DataSource = this.klassDSet;
            // 
            // klassDSet
            // 
            this.klassDSet.DataSetName = "KlassDSet";
            this.klassDSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonDellete
            // 
            this.buttonDellete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDellete.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDellete.Location = new System.Drawing.Point(588, 618);
            this.buttonDellete.Name = "buttonDellete";
            this.buttonDellete.Size = new System.Drawing.Size(216, 67);
            this.buttonDellete.TabIndex = 71;
            this.buttonDellete.Text = "Удалить";
            this.buttonDellete.UseVisualStyleBackColor = false;
            this.buttonDellete.Click += new System.EventHandler(this.buttonDellete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(282, 618);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(216, 67);
            this.buttonSave.TabIndex = 70;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(925, 618);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(187, 67);
            this.buttonBack.TabIndex = 69;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // karta_health7TableAdapter
            // 
            this.karta_health7TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(435, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 40);
            this.label1.TabIndex = 73;
            this.label1.Text = "Карта здоровья учеников 7 класса";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namestudentDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKstudents7kartahealth7BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(743, 61);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(473, 71);
            this.dataGridView2.TabIndex = 76;
            // 
            // namestudentDataGridViewTextBoxColumn
            // 
            this.namestudentDataGridViewTextBoxColumn.DataPropertyName = "name_student";
            this.namestudentDataGridViewTextBoxColumn.HeaderText = "Имя ученика";
            this.namestudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namestudentDataGridViewTextBoxColumn.Name = "namestudentDataGridViewTextBoxColumn";
            // 
            // fKstudents7kartahealth7BindingSource
            // 
            this.fKstudents7kartahealth7BindingSource.DataMember = "FK_students7_karta_health7";
            this.fKstudents7kartahealth7BindingSource.DataSource = this.kartahealth7BindingSource1;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.klassDataSet1;
            // 
            // klassDataSet1
            // 
            this.klassDataSet1.DataSetName = "KlassDataSet1";
            this.klassDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // students7BindingSource
            // 
            this.students7BindingSource.DataMember = "students7";
            this.students7BindingSource.DataSource = this.klassDSet;
            // 
            // students7TableAdapter
            // 
            this.students7TableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // karta_health7TableAdapter1
            // 
            this.karta_health7TableAdapter1.ClearBeforeFill = true;
            // 
            // students7TableAdapter1
            // 
            this.students7TableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(764, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 58);
            this.label2.TabIndex = 77;
            this.label2.Text = "Если поле \"Имя ученика\" заполнено, \r\nто удаление записи невозможно!";
            // 
            // FormHealt7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1395, 719);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.karta_health7DataGridView);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormHealt7";
            this.Text = "Карта здоровья 7  класса";
            this.Load += new System.EventHandler(this.FormHealt7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.karta_health7DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartahealth7BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartahealth7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKstudents7kartahealth7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students7BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView karta_health7DataGridView;
        private System.Windows.Forms.Button buttonDellete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private KlassDSet klassDSet;
        private System.Windows.Forms.BindingSource kartahealth7BindingSource;
        private KlassDSetTableAdapters.karta_health7TableAdapter karta_health7TableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource students7BindingSource;
        private KlassDSetTableAdapters.students7TableAdapter students7TableAdapter;
        private KlassDataSet1 klassDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private KlassDataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource klassDataSetBindingSource;
        private KlassDataSet klassDataSet;
        private System.Windows.Forms.BindingSource kartahealth7BindingSource1;
        private KlassDataSetTableAdapters.karta_health7TableAdapter karta_health7TableAdapter1;
        private System.Windows.Forms.BindingSource fKstudents7kartahealth7BindingSource;
        private KlassDataSetTableAdapters.students7TableAdapter students7TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grouphealthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnozDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namestudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}
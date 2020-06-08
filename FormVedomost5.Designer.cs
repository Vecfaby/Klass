namespace Klass
{
    partial class FormVedomost5
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
            this.vedomost5DataGridView = new System.Windows.Forms.DataGridView();
            this.idvedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fizikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.algebraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geometriyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.russkiyazikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biologiyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.himiyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informatikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geografiyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istoriyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obchestvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vedomost5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klassDSet = new Klass.KlassDSet();
            this.buttonDellete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.vedomost5TableAdapter = new Klass.KlassDSetTableAdapters.vedomost5TableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.fKstudents5vedomost5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students5TableAdapter = new Klass.KlassDSetTableAdapters.students5TableAdapter();
            this.namestudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vedomost5DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomost5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKstudents5vedomost5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vedomost5DataGridView
            // 
            this.vedomost5DataGridView.AutoGenerateColumns = false;
            this.vedomost5DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.vedomost5DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vedomost5DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvedDataGridViewTextBoxColumn,
            this.fizikaDataGridViewTextBoxColumn,
            this.algebraDataGridViewTextBoxColumn,
            this.geometriyaDataGridViewTextBoxColumn,
            this.russkiyazikDataGridViewTextBoxColumn,
            this.biologiyaDataGridViewTextBoxColumn,
            this.himiyaDataGridViewTextBoxColumn,
            this.informatikaDataGridViewTextBoxColumn,
            this.geografiyaDataGridViewTextBoxColumn,
            this.izoDataGridViewTextBoxColumn,
            this.istoriyaDataGridViewTextBoxColumn,
            this.obchestvoDataGridViewTextBoxColumn});
            this.vedomost5DataGridView.DataSource = this.vedomost5BindingSource;
            this.vedomost5DataGridView.Location = new System.Drawing.Point(65, 45);
            this.vedomost5DataGridView.Name = "vedomost5DataGridView";
            this.vedomost5DataGridView.RowHeadersWidth = 51;
            this.vedomost5DataGridView.RowTemplate.Height = 24;
            this.vedomost5DataGridView.Size = new System.Drawing.Size(1263, 475);
            this.vedomost5DataGridView.TabIndex = 68;
            // 
            // idvedDataGridViewTextBoxColumn
            // 
            this.idvedDataGridViewTextBoxColumn.DataPropertyName = "id_ved";
            this.idvedDataGridViewTextBoxColumn.HeaderText = "Код ведомости";
            this.idvedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idvedDataGridViewTextBoxColumn.Name = "idvedDataGridViewTextBoxColumn";
            this.idvedDataGridViewTextBoxColumn.Width = 125;
            // 
            // fizikaDataGridViewTextBoxColumn
            // 
            this.fizikaDataGridViewTextBoxColumn.DataPropertyName = "fizika";
            this.fizikaDataGridViewTextBoxColumn.HeaderText = "Физика";
            this.fizikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fizikaDataGridViewTextBoxColumn.Name = "fizikaDataGridViewTextBoxColumn";
            this.fizikaDataGridViewTextBoxColumn.Width = 88;
            // 
            // algebraDataGridViewTextBoxColumn
            // 
            this.algebraDataGridViewTextBoxColumn.DataPropertyName = "algebra";
            this.algebraDataGridViewTextBoxColumn.HeaderText = "Алгебра";
            this.algebraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.algebraDataGridViewTextBoxColumn.Name = "algebraDataGridViewTextBoxColumn";
            this.algebraDataGridViewTextBoxColumn.Width = 91;
            // 
            // geometriyaDataGridViewTextBoxColumn
            // 
            this.geometriyaDataGridViewTextBoxColumn.DataPropertyName = "geometriya";
            this.geometriyaDataGridViewTextBoxColumn.HeaderText = "Геометрия";
            this.geometriyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.geometriyaDataGridViewTextBoxColumn.Name = "geometriyaDataGridViewTextBoxColumn";
            this.geometriyaDataGridViewTextBoxColumn.Width = 109;
            // 
            // russkiyazikDataGridViewTextBoxColumn
            // 
            this.russkiyazikDataGridViewTextBoxColumn.DataPropertyName = "russki_yazik";
            this.russkiyazikDataGridViewTextBoxColumn.HeaderText = "Русский язык";
            this.russkiyazikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.russkiyazikDataGridViewTextBoxColumn.Name = "russkiyazikDataGridViewTextBoxColumn";
            this.russkiyazikDataGridViewTextBoxColumn.Width = 116;
            // 
            // biologiyaDataGridViewTextBoxColumn
            // 
            this.biologiyaDataGridViewTextBoxColumn.DataPropertyName = "biologiya";
            this.biologiyaDataGridViewTextBoxColumn.HeaderText = "Биология";
            this.biologiyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.biologiyaDataGridViewTextBoxColumn.Name = "biologiyaDataGridViewTextBoxColumn";
            this.biologiyaDataGridViewTextBoxColumn.Width = 99;
            // 
            // himiyaDataGridViewTextBoxColumn
            // 
            this.himiyaDataGridViewTextBoxColumn.DataPropertyName = "himiya";
            this.himiyaDataGridViewTextBoxColumn.HeaderText = "Химия";
            this.himiyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.himiyaDataGridViewTextBoxColumn.Name = "himiyaDataGridViewTextBoxColumn";
            this.himiyaDataGridViewTextBoxColumn.Width = 79;
            // 
            // informatikaDataGridViewTextBoxColumn
            // 
            this.informatikaDataGridViewTextBoxColumn.DataPropertyName = "informatika";
            this.informatikaDataGridViewTextBoxColumn.HeaderText = "Информатика";
            this.informatikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.informatikaDataGridViewTextBoxColumn.Name = "informatikaDataGridViewTextBoxColumn";
            this.informatikaDataGridViewTextBoxColumn.Width = 129;
            // 
            // geografiyaDataGridViewTextBoxColumn
            // 
            this.geografiyaDataGridViewTextBoxColumn.DataPropertyName = "geografiya";
            this.geografiyaDataGridViewTextBoxColumn.HeaderText = "География";
            this.geografiyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.geografiyaDataGridViewTextBoxColumn.Name = "geografiyaDataGridViewTextBoxColumn";
            this.geografiyaDataGridViewTextBoxColumn.Width = 109;
            // 
            // izoDataGridViewTextBoxColumn
            // 
            this.izoDataGridViewTextBoxColumn.DataPropertyName = "izo";
            this.izoDataGridViewTextBoxColumn.HeaderText = "ИЗО";
            this.izoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.izoDataGridViewTextBoxColumn.Name = "izoDataGridViewTextBoxColumn";
            this.izoDataGridViewTextBoxColumn.Width = 67;
            // 
            // istoriyaDataGridViewTextBoxColumn
            // 
            this.istoriyaDataGridViewTextBoxColumn.DataPropertyName = "istoriya";
            this.istoriyaDataGridViewTextBoxColumn.HeaderText = "История";
            this.istoriyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.istoriyaDataGridViewTextBoxColumn.Name = "istoriyaDataGridViewTextBoxColumn";
            this.istoriyaDataGridViewTextBoxColumn.Width = 93;
            // 
            // obchestvoDataGridViewTextBoxColumn
            // 
            this.obchestvoDataGridViewTextBoxColumn.DataPropertyName = "obchestvo";
            this.obchestvoDataGridViewTextBoxColumn.HeaderText = "Общество";
            this.obchestvoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.obchestvoDataGridViewTextBoxColumn.Name = "obchestvoDataGridViewTextBoxColumn";
            this.obchestvoDataGridViewTextBoxColumn.Width = 104;
            // 
            // vedomost5BindingSource
            // 
            this.vedomost5BindingSource.DataMember = "vedomost5";
            this.vedomost5BindingSource.DataSource = this.klassDSet;
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
            this.buttonDellete.Location = new System.Drawing.Point(749, 605);
            this.buttonDellete.Name = "buttonDellete";
            this.buttonDellete.Size = new System.Drawing.Size(216, 67);
            this.buttonDellete.TabIndex = 67;
            this.buttonDellete.Text = "Удалить";
            this.buttonDellete.UseVisualStyleBackColor = false;
            this.buttonDellete.Click += new System.EventHandler(this.buttonDellete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(442, 603);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(216, 67);
            this.buttonSave.TabIndex = 66;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(1066, 605);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(187, 67);
            this.buttonBack.TabIndex = 65;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // vedomost5TableAdapter
            // 
            this.vedomost5TableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(507, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 40);
            this.label2.TabIndex = 69;
            this.label2.Text = "Сводная ведомость 5 класса";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(82, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 69);
            this.button1.TabIndex = 74;
            this.button1.Text = "Вычислить среднюю оценку";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namestudentDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKstudents5vedomost5BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(259, 526);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(434, 71);
            this.dataGridView2.TabIndex = 79;
            // 
            // fKstudents5vedomost5BindingSource
            // 
            this.fKstudents5vedomost5BindingSource.DataMember = "FK_students5_vedomost5";
            this.fKstudents5vedomost5BindingSource.DataSource = this.vedomost5BindingSource;
            // 
            // students5TableAdapter
            // 
            this.students5TableAdapter.ClearBeforeFill = true;
            // 
            // namestudentDataGridViewTextBoxColumn
            // 
            this.namestudentDataGridViewTextBoxColumn.DataPropertyName = "name_student";
            this.namestudentDataGridViewTextBoxColumn.HeaderText = "Имя ученика";
            this.namestudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namestudentDataGridViewTextBoxColumn.Name = "namestudentDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(709, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 58);
            this.label1.TabIndex = 80;
            this.label1.Text = "Если поле \"Имя ученика\" заполнено, \r\nто удаление записи невозможно!";
            // 
            // FormVedomost5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1395, 719);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vedomost5DataGridView);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormVedomost5";
            this.Text = "Сводная ведомость 5 класса";
            this.Load += new System.EventHandler(this.FormVedomost5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vedomost5DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomost5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKstudents5vedomost5BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vedomost5DataGridView;
        private System.Windows.Forms.Button buttonDellete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private KlassDSet klassDSet;
        private System.Windows.Forms.BindingSource vedomost5BindingSource;
        private KlassDSetTableAdapters.vedomost5TableAdapter vedomost5TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fizikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn algebraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geometriyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn russkiyazikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biologiyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn himiyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn informatikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geografiyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn istoriyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obchestvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource fKstudents5vedomost5BindingSource;
        private KlassDSetTableAdapters.students5TableAdapter students5TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namestudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}
﻿namespace Klass
{
    partial class FormVedomost6
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
            this.buttonDellete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.klassDSet = new Klass.KlassDSet();
            this.vedomost6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vedomost6TableAdapter = new Klass.KlassDSetTableAdapters.vedomost6TableAdapter();
            this.vedomost6BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vedomost6DataGridView = new System.Windows.Forms.DataGridView();
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.klassDataSet = new Klass.KlassDataSet();
            this.vedomost6BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vedomost6TableAdapter1 = new Klass.KlassDataSetTableAdapters.vedomost6TableAdapter();
            this.fKstudents6vedomost6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students6TableAdapter = new Klass.KlassDataSetTableAdapters.students6TableAdapter();
            this.namestudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomost6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomost6BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomost6DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomost6BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKstudents6vedomost6BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDellete
            // 
            this.buttonDellete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDellete.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDellete.Location = new System.Drawing.Point(750, 607);
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
            this.buttonSave.Location = new System.Drawing.Point(444, 607);
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
            this.buttonBack.Location = new System.Drawing.Point(1087, 607);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(187, 67);
            this.buttonBack.TabIndex = 65;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // klassDSet
            // 
            this.klassDSet.DataSetName = "KlassDSet";
            this.klassDSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vedomost6BindingSource
            // 
            this.vedomost6BindingSource.DataMember = "vedomost6";
            this.vedomost6BindingSource.DataSource = this.klassDSet;
            // 
            // vedomost6TableAdapter
            // 
            this.vedomost6TableAdapter.ClearBeforeFill = true;
            // 
            // vedomost6BindingSource1
            // 
            this.vedomost6BindingSource1.DataMember = "vedomost6";
            this.vedomost6BindingSource1.DataSource = this.klassDSet;
            // 
            // vedomost6DataGridView
            // 
            this.vedomost6DataGridView.AutoGenerateColumns = false;
            this.vedomost6DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.vedomost6DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vedomost6DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.vedomost6DataGridView.DataSource = this.vedomost6BindingSource2;
            this.vedomost6DataGridView.Location = new System.Drawing.Point(51, 53);
            this.vedomost6DataGridView.Name = "vedomost6DataGridView";
            this.vedomost6DataGridView.RowHeadersWidth = 51;
            this.vedomost6DataGridView.RowTemplate.Height = 24;
            this.vedomost6DataGridView.Size = new System.Drawing.Size(1265, 471);
            this.vedomost6DataGridView.TabIndex = 68;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(474, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 40);
            this.label2.TabIndex = 70;
            this.label2.Text = "Сводная ведомость 6 класса";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(92, 605);
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
            this.dataGridView2.DataSource = this.fKstudents6vedomost6BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(263, 528);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(434, 71);
            this.dataGridView2.TabIndex = 79;
            // 
            // klassDataSet
            // 
            this.klassDataSet.DataSetName = "KlassDataSet";
            this.klassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vedomost6BindingSource2
            // 
            this.vedomost6BindingSource2.DataMember = "vedomost6";
            this.vedomost6BindingSource2.DataSource = this.klassDataSet;
            // 
            // vedomost6TableAdapter1
            // 
            this.vedomost6TableAdapter1.ClearBeforeFill = true;
            // 
            // fKstudents6vedomost6BindingSource
            // 
            this.fKstudents6vedomost6BindingSource.DataMember = "FK_students6_vedomost6";
            this.fKstudents6vedomost6BindingSource.DataSource = this.vedomost6BindingSource2;
            // 
            // students6TableAdapter
            // 
            this.students6TableAdapter.ClearBeforeFill = true;
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
            this.label1.Location = new System.Drawing.Point(725, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 58);
            this.label1.TabIndex = 80;
            this.label1.Text = "Если поле \"Имя ученика\" заполнено, \r\nто удаление записи невозможно!";
            // 
            // FormVedomost6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1395, 719);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vedomost6DataGridView);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormVedomost6";
            this.Text = "Сводная ведомость 6 класса";
            this.Load += new System.EventHandler(this.FormVedomost6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomost6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomost6BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomost6DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomost6BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKstudents6vedomost6BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDellete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private KlassDSet klassDSet;
        private System.Windows.Forms.BindingSource vedomost6BindingSource;
        private KlassDSetTableAdapters.vedomost6TableAdapter vedomost6TableAdapter;
        private System.Windows.Forms.BindingSource vedomost6BindingSource1;
        private System.Windows.Forms.DataGridView vedomost6DataGridView;
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
        private KlassDataSet klassDataSet;
        private System.Windows.Forms.BindingSource vedomost6BindingSource2;
        private KlassDataSetTableAdapters.vedomost6TableAdapter vedomost6TableAdapter1;
        private System.Windows.Forms.BindingSource fKstudents6vedomost6BindingSource;
        private KlassDataSetTableAdapters.students6TableAdapter students6TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namestudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}
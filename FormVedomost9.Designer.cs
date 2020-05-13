namespace Klass
{
    partial class FormVedomost9
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
            this.vedomost9DataGridView = new System.Windows.Forms.DataGridView();
            this.vedomost9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klassDSet = new Klass.KlassDSet();
            this.buttonDellete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.vedomost9TableAdapter = new Klass.KlassDSetTableAdapters.vedomost9TableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.vedomost9DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomost9BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).BeginInit();
            this.SuspendLayout();
            // 
            // vedomost9DataGridView
            // 
            this.vedomost9DataGridView.AutoGenerateColumns = false;
            this.vedomost9DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.vedomost9DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vedomost9DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.vedomost9DataGridView.DataSource = this.vedomost9BindingSource;
            this.vedomost9DataGridView.Location = new System.Drawing.Point(60, 52);
            this.vedomost9DataGridView.Name = "vedomost9DataGridView";
            this.vedomost9DataGridView.RowHeadersWidth = 51;
            this.vedomost9DataGridView.RowTemplate.Height = 24;
            this.vedomost9DataGridView.Size = new System.Drawing.Size(1270, 532);
            this.vedomost9DataGridView.TabIndex = 76;
            // 
            // vedomost9BindingSource
            // 
            this.vedomost9BindingSource.DataMember = "vedomost9";
            this.vedomost9BindingSource.DataSource = this.klassDSet;
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
            this.buttonDellete.Location = new System.Drawing.Point(762, 616);
            this.buttonDellete.Name = "buttonDellete";
            this.buttonDellete.Size = new System.Drawing.Size(216, 69);
            this.buttonDellete.TabIndex = 75;
            this.buttonDellete.Text = "Удалить";
            this.buttonDellete.UseVisualStyleBackColor = false;
            this.buttonDellete.Click += new System.EventHandler(this.buttonDellete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(456, 616);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(216, 69);
            this.buttonSave.TabIndex = 74;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(1099, 616);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(187, 69);
            this.buttonBack.TabIndex = 73;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // vedomost9TableAdapter
            // 
            this.vedomost9TableAdapter.ClearBeforeFill = true;
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
            this.label2.Location = new System.Drawing.Point(491, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 40);
            this.label2.TabIndex = 77;
            this.label2.Text = "Сводная ведомость 9 класса";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(106, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 69);
            this.button1.TabIndex = 78;
            this.button1.Text = "Вычислить среднюю оценку";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormVedomost9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1395, 719);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vedomost9DataGridView);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormVedomost9";
            this.Text = "Сводная ведомость 9 класса";
            this.Load += new System.EventHandler(this.FormVedomost9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vedomost9DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomost9BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vedomost9DataGridView;
        private System.Windows.Forms.Button buttonDellete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private KlassDSet klassDSet;
        private System.Windows.Forms.BindingSource vedomost9BindingSource;
        private KlassDSetTableAdapters.vedomost9TableAdapter vedomost9TableAdapter;
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
    }
}
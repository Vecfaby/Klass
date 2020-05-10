namespace Klass
{
    partial class FormVedomost8
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
            this.vedomost8DataGridView = new System.Windows.Forms.DataGridView();
            this.buttonDellete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.klassDSet = new Klass.KlassDSet();
            this.vedomost8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vedomost8TableAdapter = new Klass.KlassDSetTableAdapters.vedomost8TableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.vedomost8DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomost8BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vedomost8DataGridView
            // 
            this.vedomost8DataGridView.AutoGenerateColumns = false;
            this.vedomost8DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.vedomost8DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vedomost8DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.vedomost8DataGridView.DataSource = this.vedomost8BindingSource;
            this.vedomost8DataGridView.Location = new System.Drawing.Point(113, 12);
            this.vedomost8DataGridView.Name = "vedomost8DataGridView";
            this.vedomost8DataGridView.RowHeadersWidth = 51;
            this.vedomost8DataGridView.RowTemplate.Height = 24;
            this.vedomost8DataGridView.Size = new System.Drawing.Size(1169, 572);
            this.vedomost8DataGridView.TabIndex = 76;
            // 
            // buttonDellete
            // 
            this.buttonDellete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDellete.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDellete.Location = new System.Drawing.Point(582, 590);
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
            this.buttonSave.Location = new System.Drawing.Point(276, 590);
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
            this.buttonBack.Location = new System.Drawing.Point(919, 590);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(187, 69);
            this.buttonBack.TabIndex = 73;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // klassDSet
            // 
            this.klassDSet.DataSetName = "KlassDSet";
            this.klassDSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vedomost8BindingSource
            // 
            this.vedomost8BindingSource.DataMember = "vedomost8";
            this.vedomost8BindingSource.DataSource = this.klassDSet;
            // 
            // vedomost8TableAdapter
            // 
            this.vedomost8TableAdapter.ClearBeforeFill = true;
            // 
            // idvedDataGridViewTextBoxColumn
            // 
            this.idvedDataGridViewTextBoxColumn.DataPropertyName = "id_ved";
            this.idvedDataGridViewTextBoxColumn.HeaderText = "id_ved";
            this.idvedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idvedDataGridViewTextBoxColumn.Name = "idvedDataGridViewTextBoxColumn";
            this.idvedDataGridViewTextBoxColumn.Width = 79;
            // 
            // fizikaDataGridViewTextBoxColumn
            // 
            this.fizikaDataGridViewTextBoxColumn.DataPropertyName = "fizika";
            this.fizikaDataGridViewTextBoxColumn.HeaderText = "fizika";
            this.fizikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fizikaDataGridViewTextBoxColumn.Name = "fizikaDataGridViewTextBoxColumn";
            this.fizikaDataGridViewTextBoxColumn.Width = 69;
            // 
            // algebraDataGridViewTextBoxColumn
            // 
            this.algebraDataGridViewTextBoxColumn.DataPropertyName = "algebra";
            this.algebraDataGridViewTextBoxColumn.HeaderText = "algebra";
            this.algebraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.algebraDataGridViewTextBoxColumn.Name = "algebraDataGridViewTextBoxColumn";
            this.algebraDataGridViewTextBoxColumn.Width = 85;
            // 
            // geometriyaDataGridViewTextBoxColumn
            // 
            this.geometriyaDataGridViewTextBoxColumn.DataPropertyName = "geometriya";
            this.geometriyaDataGridViewTextBoxColumn.HeaderText = "geometriya";
            this.geometriyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.geometriyaDataGridViewTextBoxColumn.Name = "geometriyaDataGridViewTextBoxColumn";
            this.geometriyaDataGridViewTextBoxColumn.Width = 107;
            // 
            // russkiyazikDataGridViewTextBoxColumn
            // 
            this.russkiyazikDataGridViewTextBoxColumn.DataPropertyName = "russki_yazik";
            this.russkiyazikDataGridViewTextBoxColumn.HeaderText = "russki_yazik";
            this.russkiyazikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.russkiyazikDataGridViewTextBoxColumn.Name = "russkiyazikDataGridViewTextBoxColumn";
            this.russkiyazikDataGridViewTextBoxColumn.Width = 114;
            // 
            // biologiyaDataGridViewTextBoxColumn
            // 
            this.biologiyaDataGridViewTextBoxColumn.DataPropertyName = "biologiya";
            this.biologiyaDataGridViewTextBoxColumn.HeaderText = "biologiya";
            this.biologiyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.biologiyaDataGridViewTextBoxColumn.Name = "biologiyaDataGridViewTextBoxColumn";
            this.biologiyaDataGridViewTextBoxColumn.Width = 93;
            // 
            // himiyaDataGridViewTextBoxColumn
            // 
            this.himiyaDataGridViewTextBoxColumn.DataPropertyName = "himiya";
            this.himiyaDataGridViewTextBoxColumn.HeaderText = "himiya";
            this.himiyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.himiyaDataGridViewTextBoxColumn.Name = "himiyaDataGridViewTextBoxColumn";
            this.himiyaDataGridViewTextBoxColumn.Width = 77;
            // 
            // informatikaDataGridViewTextBoxColumn
            // 
            this.informatikaDataGridViewTextBoxColumn.DataPropertyName = "informatika";
            this.informatikaDataGridViewTextBoxColumn.HeaderText = "informatika";
            this.informatikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.informatikaDataGridViewTextBoxColumn.Name = "informatikaDataGridViewTextBoxColumn";
            this.informatikaDataGridViewTextBoxColumn.Width = 106;
            // 
            // geografiyaDataGridViewTextBoxColumn
            // 
            this.geografiyaDataGridViewTextBoxColumn.DataPropertyName = "geografiya";
            this.geografiyaDataGridViewTextBoxColumn.HeaderText = "geografiya";
            this.geografiyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.geografiyaDataGridViewTextBoxColumn.Name = "geografiyaDataGridViewTextBoxColumn";
            this.geografiyaDataGridViewTextBoxColumn.Width = 104;
            // 
            // izoDataGridViewTextBoxColumn
            // 
            this.izoDataGridViewTextBoxColumn.DataPropertyName = "izo";
            this.izoDataGridViewTextBoxColumn.HeaderText = "izo";
            this.izoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.izoDataGridViewTextBoxColumn.Name = "izoDataGridViewTextBoxColumn";
            this.izoDataGridViewTextBoxColumn.Width = 55;
            // 
            // istoriyaDataGridViewTextBoxColumn
            // 
            this.istoriyaDataGridViewTextBoxColumn.DataPropertyName = "istoriya";
            this.istoriyaDataGridViewTextBoxColumn.HeaderText = "istoriya";
            this.istoriyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.istoriyaDataGridViewTextBoxColumn.Name = "istoriyaDataGridViewTextBoxColumn";
            this.istoriyaDataGridViewTextBoxColumn.Width = 82;
            // 
            // obchestvoDataGridViewTextBoxColumn
            // 
            this.obchestvoDataGridViewTextBoxColumn.DataPropertyName = "obchestvo";
            this.obchestvoDataGridViewTextBoxColumn.HeaderText = "obchestvo";
            this.obchestvoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.obchestvoDataGridViewTextBoxColumn.Name = "obchestvoDataGridViewTextBoxColumn";
            this.obchestvoDataGridViewTextBoxColumn.Width = 102;
            // 
            // FormVedomost8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 719);
            this.Controls.Add(this.vedomost8DataGridView);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormVedomost8";
            this.Text = "FormVedomost8";
            this.Load += new System.EventHandler(this.FormVedomost8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vedomost8DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vedomost8BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vedomost8DataGridView;
        private System.Windows.Forms.Button buttonDellete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private KlassDSet klassDSet;
        private System.Windows.Forms.BindingSource vedomost8BindingSource;
        private KlassDSetTableAdapters.vedomost8TableAdapter vedomost8TableAdapter;
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
    }
}
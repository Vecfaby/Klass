namespace Klass
{
    partial class FormVneurochnaya
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
            this.vneDataGridView = new System.Windows.Forms.DataGridView();
            this.klassDSet = new Klass.KlassDSet();
            this.instruktionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instruktionTableAdapter = new Klass.KlassDSetTableAdapters.instruktionTableAdapter();
            this.vneurochnayadeyatelnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vneurochnaya_deyatelnostTableAdapter = new Klass.KlassDSetTableAdapters.vneurochnaya_deyatelnostTableAdapter();
            this.idstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namekruzhkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vneDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vneurochnayadeyatelnostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDellete
            // 
            this.buttonDellete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDellete.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDellete.Location = new System.Drawing.Point(650, 593);
            this.buttonDellete.Name = "buttonDellete";
            this.buttonDellete.Size = new System.Drawing.Size(216, 67);
            this.buttonDellete.TabIndex = 75;
            this.buttonDellete.Text = "Удалить";
            this.buttonDellete.UseVisualStyleBackColor = false;
            this.buttonDellete.Click += new System.EventHandler(this.buttonDellete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(362, 593);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(216, 67);
            this.buttonSave.TabIndex = 74;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(932, 593);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(187, 67);
            this.buttonBack.TabIndex = 73;
            this.buttonBack.Text = "Главное меню";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // vneDataGridView
            // 
            this.vneDataGridView.AutoGenerateColumns = false;
            this.vneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vneDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstudentDataGridViewTextBoxColumn,
            this.namekruzhkaDataGridViewTextBoxColumn});
            this.vneDataGridView.DataSource = this.vneurochnayadeyatelnostBindingSource;
            this.vneDataGridView.Location = new System.Drawing.Point(557, 22);
            this.vneDataGridView.Name = "vneDataGridView";
            this.vneDataGridView.RowHeadersWidth = 51;
            this.vneDataGridView.RowTemplate.Height = 24;
            this.vneDataGridView.Size = new System.Drawing.Size(379, 529);
            this.vneDataGridView.TabIndex = 72;
            // 
            // klassDSet
            // 
            this.klassDSet.DataSetName = "KlassDSet";
            this.klassDSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instruktionBindingSource
            // 
            this.instruktionBindingSource.DataMember = "instruktion";
            this.instruktionBindingSource.DataSource = this.klassDSet;
            // 
            // instruktionTableAdapter
            // 
            this.instruktionTableAdapter.ClearBeforeFill = true;
            // 
            // vneurochnayadeyatelnostBindingSource
            // 
            this.vneurochnayadeyatelnostBindingSource.DataMember = "vneurochnaya_deyatelnost";
            this.vneurochnayadeyatelnostBindingSource.DataSource = this.klassDSet;
            // 
            // vneurochnaya_deyatelnostTableAdapter
            // 
            this.vneurochnaya_deyatelnostTableAdapter.ClearBeforeFill = true;
            // 
            // idstudentDataGridViewTextBoxColumn
            // 
            this.idstudentDataGridViewTextBoxColumn.DataPropertyName = "id_student";
            this.idstudentDataGridViewTextBoxColumn.HeaderText = "id_student";
            this.idstudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idstudentDataGridViewTextBoxColumn.Name = "idstudentDataGridViewTextBoxColumn";
            this.idstudentDataGridViewTextBoxColumn.Width = 125;
            // 
            // namekruzhkaDataGridViewTextBoxColumn
            // 
            this.namekruzhkaDataGridViewTextBoxColumn.DataPropertyName = "name_kruzhka";
            this.namekruzhkaDataGridViewTextBoxColumn.HeaderText = "name_kruzhka";
            this.namekruzhkaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namekruzhkaDataGridViewTextBoxColumn.Name = "namekruzhkaDataGridViewTextBoxColumn";
            this.namekruzhkaDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormVneurochnaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 719);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.vneDataGridView);
            this.Name = "FormVneurochnaya";
            this.Text = "FormVneurochnaya";
            this.Load += new System.EventHandler(this.FormVneurochnaya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vneDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vneurochnayadeyatelnostBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDellete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView vneDataGridView;
        private KlassDSet klassDSet;
        private System.Windows.Forms.BindingSource instruktionBindingSource;
        private KlassDSetTableAdapters.instruktionTableAdapter instruktionTableAdapter;
        private System.Windows.Forms.BindingSource vneurochnayadeyatelnostBindingSource;
        private KlassDSetTableAdapters.vneurochnaya_deyatelnostTableAdapter vneurochnaya_deyatelnostTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namekruzhkaDataGridViewTextBoxColumn;
    }
}
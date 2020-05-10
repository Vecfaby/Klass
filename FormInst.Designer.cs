namespace Klass
{
    partial class FormInst
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
            this.zhurnal_TBDataGridView = new System.Windows.Forms.DataGridView();
            this.klassDSet = new Klass.KlassDSet();
            this.instruktionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instruktionTableAdapter = new Klass.KlassDSetTableAdapters.instruktionTableAdapter();
            this.idinstrukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberinstrukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameinstrukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.zhurnal_TBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDellete
            // 
            this.buttonDellete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDellete.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDellete.Location = new System.Drawing.Point(630, 594);
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
            this.buttonSave.Location = new System.Drawing.Point(342, 594);
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
            this.buttonBack.Location = new System.Drawing.Point(919, 594);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(187, 67);
            this.buttonBack.TabIndex = 73;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // zhurnal_TBDataGridView
            // 
            this.zhurnal_TBDataGridView.AutoGenerateColumns = false;
            this.zhurnal_TBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zhurnal_TBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idinstrukDataGridViewTextBoxColumn,
            this.numberinstrukDataGridViewTextBoxColumn,
            this.nameinstrukDataGridViewTextBoxColumn});
            this.zhurnal_TBDataGridView.DataSource = this.instruktionBindingSource;
            this.zhurnal_TBDataGridView.Location = new System.Drawing.Point(516, 54);
            this.zhurnal_TBDataGridView.Name = "zhurnal_TBDataGridView";
            this.zhurnal_TBDataGridView.RowHeadersWidth = 51;
            this.zhurnal_TBDataGridView.RowTemplate.Height = 24;
            this.zhurnal_TBDataGridView.Size = new System.Drawing.Size(432, 449);
            this.zhurnal_TBDataGridView.TabIndex = 72;
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
            // idinstrukDataGridViewTextBoxColumn
            // 
            this.idinstrukDataGridViewTextBoxColumn.DataPropertyName = "id_instruk";
            this.idinstrukDataGridViewTextBoxColumn.HeaderText = "id_instruk";
            this.idinstrukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idinstrukDataGridViewTextBoxColumn.Name = "idinstrukDataGridViewTextBoxColumn";
            this.idinstrukDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberinstrukDataGridViewTextBoxColumn
            // 
            this.numberinstrukDataGridViewTextBoxColumn.DataPropertyName = "number_instruk";
            this.numberinstrukDataGridViewTextBoxColumn.HeaderText = "number_instruk";
            this.numberinstrukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberinstrukDataGridViewTextBoxColumn.Name = "numberinstrukDataGridViewTextBoxColumn";
            this.numberinstrukDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameinstrukDataGridViewTextBoxColumn
            // 
            this.nameinstrukDataGridViewTextBoxColumn.DataPropertyName = "name_instruk";
            this.nameinstrukDataGridViewTextBoxColumn.HeaderText = "name_instruk";
            this.nameinstrukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameinstrukDataGridViewTextBoxColumn.Name = "nameinstrukDataGridViewTextBoxColumn";
            this.nameinstrukDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormInst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 719);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.zhurnal_TBDataGridView);
            this.Name = "FormInst";
            this.Text = "FormInst";
            this.Load += new System.EventHandler(this.FormInst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zhurnal_TBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDellete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView zhurnal_TBDataGridView;
        private KlassDSet klassDSet;
        private System.Windows.Forms.BindingSource instruktionBindingSource;
        private KlassDSetTableAdapters.instruktionTableAdapter instruktionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinstrukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberinstrukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameinstrukDataGridViewTextBoxColumn;
    }
}
﻿namespace Klass
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
            this.instruktionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klassDSet = new Klass.KlassDSet();
            this.instruktionTableAdapter = new Klass.KlassDSetTableAdapters.instruktionTableAdapter();
            this.instDataGridView = new System.Windows.Forms.DataGridView();
            this.idinstrukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberinstrukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameinstrukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instruktionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.klassDaSet = new Klass.KlassDaSet();
            this.instruktionTableAdapter1 = new Klass.KlassDaSetTableAdapters.instruktionTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.instruktionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDaSet)).BeginInit();
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
            // instruktionBindingSource
            // 
            this.instruktionBindingSource.DataMember = "instruktion";
            this.instruktionBindingSource.DataSource = this.klassDSet;
            // 
            // klassDSet
            // 
            this.klassDSet.DataSetName = "KlassDSet";
            this.klassDSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instruktionTableAdapter
            // 
            this.instruktionTableAdapter.ClearBeforeFill = true;
            // 
            // instDataGridView
            // 
            this.instDataGridView.AutoGenerateColumns = false;
            this.instDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.instDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idinstrukDataGridViewTextBoxColumn,
            this.numberinstrukDataGridViewTextBoxColumn,
            this.nameinstrukDataGridViewTextBoxColumn});
            this.instDataGridView.DataSource = this.instruktionBindingSource1;
            this.instDataGridView.Location = new System.Drawing.Point(383, 63);
            this.instDataGridView.Name = "instDataGridView";
            this.instDataGridView.RowHeadersWidth = 51;
            this.instDataGridView.RowTemplate.Height = 24;
            this.instDataGridView.Size = new System.Drawing.Size(567, 449);
            this.instDataGridView.TabIndex = 76;
            // 
            // idinstrukDataGridViewTextBoxColumn
            // 
            this.idinstrukDataGridViewTextBoxColumn.DataPropertyName = "id_instruk";
            this.idinstrukDataGridViewTextBoxColumn.HeaderText = "Код инструктажа";
            this.idinstrukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idinstrukDataGridViewTextBoxColumn.Name = "idinstrukDataGridViewTextBoxColumn";
            // 
            // numberinstrukDataGridViewTextBoxColumn
            // 
            this.numberinstrukDataGridViewTextBoxColumn.DataPropertyName = "number_instruk";
            this.numberinstrukDataGridViewTextBoxColumn.HeaderText = "Номер инструктажа";
            this.numberinstrukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberinstrukDataGridViewTextBoxColumn.Name = "numberinstrukDataGridViewTextBoxColumn";
            // 
            // nameinstrukDataGridViewTextBoxColumn
            // 
            this.nameinstrukDataGridViewTextBoxColumn.DataPropertyName = "name_instruk";
            this.nameinstrukDataGridViewTextBoxColumn.HeaderText = "Название инструктажа";
            this.nameinstrukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameinstrukDataGridViewTextBoxColumn.Name = "nameinstrukDataGridViewTextBoxColumn";
            // 
            // instruktionBindingSource1
            // 
            this.instruktionBindingSource1.DataMember = "instruktion";
            this.instruktionBindingSource1.DataSource = this.klassDaSet;
            // 
            // klassDaSet
            // 
            this.klassDaSet.DataSetName = "KlassDaSet";
            this.klassDaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instruktionTableAdapter1
            // 
            this.instruktionTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(614, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 40);
            this.label1.TabIndex = 77;
            this.label1.Text = "Инструктажи";
            // 
            // FormInst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1395, 719);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instDataGridView);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormInst";
            this.Text = "Инструктажи";
            this.Load += new System.EventHandler(this.FormInst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.instruktionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDaSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDellete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private KlassDSet klassDSet;
        private System.Windows.Forms.BindingSource instruktionBindingSource;
        private KlassDSetTableAdapters.instruktionTableAdapter instruktionTableAdapter;
        private System.Windows.Forms.DataGridView instDataGridView;
        private KlassDaSet klassDaSet;
        private System.Windows.Forms.BindingSource instruktionBindingSource1;
        private KlassDaSetTableAdapters.instruktionTableAdapter instruktionTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinstrukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberinstrukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameinstrukDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}
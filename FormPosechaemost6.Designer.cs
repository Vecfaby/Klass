﻿namespace Klass
{
    partial class FormPosechaemost6
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
            this.posechaemost6DataGridView = new System.Windows.Forms.DataGridView();
            this.klassDSet = new Klass.KlassDSet();
            this.posechaemost6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posechaemost6TableAdapter = new Klass.KlassDSetTableAdapters.posechaemost6TableAdapter();
            this.idposDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pouvazhitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezuvazhitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chet1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chet2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chet3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chet4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.posechaemost6DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posechaemost6BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDellete
            // 
            this.buttonDellete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDellete.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDellete.Location = new System.Drawing.Point(588, 591);
            this.buttonDellete.Name = "buttonDellete";
            this.buttonDellete.Size = new System.Drawing.Size(216, 67);
            this.buttonDellete.TabIndex = 68;
            this.buttonDellete.Text = "Удалить";
            this.buttonDellete.UseVisualStyleBackColor = false;
            this.buttonDellete.Click += new System.EventHandler(this.buttonDellete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(282, 591);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(216, 67);
            this.buttonSave.TabIndex = 67;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(925, 591);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(187, 67);
            this.buttonBack.TabIndex = 66;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // posechaemost6DataGridView
            // 
            this.posechaemost6DataGridView.AutoGenerateColumns = false;
            this.posechaemost6DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.posechaemost6DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.posechaemost6DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idposDataGridViewTextBoxColumn,
            this.pouvazhitDataGridViewTextBoxColumn,
            this.bezuvazhitDataGridViewTextBoxColumn,
            this.chet1DataGridViewTextBoxColumn,
            this.chet2DataGridViewTextBoxColumn,
            this.chet3DataGridViewTextBoxColumn,
            this.chet4DataGridViewTextBoxColumn});
            this.posechaemost6DataGridView.DataSource = this.posechaemost6BindingSource;
            this.posechaemost6DataGridView.Location = new System.Drawing.Point(390, 62);
            this.posechaemost6DataGridView.Name = "posechaemost6DataGridView";
            this.posechaemost6DataGridView.RowHeadersWidth = 51;
            this.posechaemost6DataGridView.RowTemplate.Height = 24;
            this.posechaemost6DataGridView.Size = new System.Drawing.Size(639, 492);
            this.posechaemost6DataGridView.TabIndex = 65;
            // 
            // klassDSet
            // 
            this.klassDSet.DataSetName = "KlassDSet";
            this.klassDSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // posechaemost6BindingSource
            // 
            this.posechaemost6BindingSource.DataMember = "posechaemost6";
            this.posechaemost6BindingSource.DataSource = this.klassDSet;
            // 
            // posechaemost6TableAdapter
            // 
            this.posechaemost6TableAdapter.ClearBeforeFill = true;
            // 
            // idposDataGridViewTextBoxColumn
            // 
            this.idposDataGridViewTextBoxColumn.DataPropertyName = "id_pos";
            this.idposDataGridViewTextBoxColumn.HeaderText = "id_pos";
            this.idposDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idposDataGridViewTextBoxColumn.Name = "idposDataGridViewTextBoxColumn";
            this.idposDataGridViewTextBoxColumn.Width = 79;
            // 
            // pouvazhitDataGridViewTextBoxColumn
            // 
            this.pouvazhitDataGridViewTextBoxColumn.DataPropertyName = "po_uvazhit";
            this.pouvazhitDataGridViewTextBoxColumn.HeaderText = "po_uvazhit";
            this.pouvazhitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pouvazhitDataGridViewTextBoxColumn.Name = "pouvazhitDataGridViewTextBoxColumn";
            this.pouvazhitDataGridViewTextBoxColumn.Width = 106;
            // 
            // bezuvazhitDataGridViewTextBoxColumn
            // 
            this.bezuvazhitDataGridViewTextBoxColumn.DataPropertyName = "bez_uvazhit";
            this.bezuvazhitDataGridViewTextBoxColumn.HeaderText = "bez_uvazhit";
            this.bezuvazhitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bezuvazhitDataGridViewTextBoxColumn.Name = "bezuvazhitDataGridViewTextBoxColumn";
            this.bezuvazhitDataGridViewTextBoxColumn.Width = 113;
            // 
            // chet1DataGridViewTextBoxColumn
            // 
            this.chet1DataGridViewTextBoxColumn.DataPropertyName = "chet1";
            this.chet1DataGridViewTextBoxColumn.HeaderText = "chet1";
            this.chet1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chet1DataGridViewTextBoxColumn.Name = "chet1DataGridViewTextBoxColumn";
            this.chet1DataGridViewTextBoxColumn.Width = 72;
            // 
            // chet2DataGridViewTextBoxColumn
            // 
            this.chet2DataGridViewTextBoxColumn.DataPropertyName = "chet2";
            this.chet2DataGridViewTextBoxColumn.HeaderText = "chet2";
            this.chet2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chet2DataGridViewTextBoxColumn.Name = "chet2DataGridViewTextBoxColumn";
            this.chet2DataGridViewTextBoxColumn.Width = 72;
            // 
            // chet3DataGridViewTextBoxColumn
            // 
            this.chet3DataGridViewTextBoxColumn.DataPropertyName = "chet3";
            this.chet3DataGridViewTextBoxColumn.HeaderText = "chet3";
            this.chet3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chet3DataGridViewTextBoxColumn.Name = "chet3DataGridViewTextBoxColumn";
            this.chet3DataGridViewTextBoxColumn.Width = 72;
            // 
            // chet4DataGridViewTextBoxColumn
            // 
            this.chet4DataGridViewTextBoxColumn.DataPropertyName = "chet4";
            this.chet4DataGridViewTextBoxColumn.HeaderText = "chet4";
            this.chet4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chet4DataGridViewTextBoxColumn.Name = "chet4DataGridViewTextBoxColumn";
            this.chet4DataGridViewTextBoxColumn.Width = 72;
            // 
            // FormPosechaemost6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 719);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.posechaemost6DataGridView);
            this.Name = "FormPosechaemost6";
            this.Text = "FormPosechaemost6";
            this.Load += new System.EventHandler(this.FormPosechaemost6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posechaemost6DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posechaemost6BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDellete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView posechaemost6DataGridView;
        private KlassDSet klassDSet;
        private System.Windows.Forms.BindingSource posechaemost6BindingSource;
        private KlassDSetTableAdapters.posechaemost6TableAdapter posechaemost6TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idposDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pouvazhitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezuvazhitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chet1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chet2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chet3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chet4DataGridViewTextBoxColumn;
    }
}
﻿namespace Klass
{
    partial class FormPosechaemost8
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
            this.posechaemost8DataGridView = new System.Windows.Forms.DataGridView();
            this.posechaemost8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klassDSet = new Klass.KlassDSet();
            this.posechaemost8TableAdapter = new Klass.KlassDSetTableAdapters.posechaemost8TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.idposDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pouvazhitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezuvazhitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chet1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chet2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chet3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chet4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.posechaemost8DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posechaemost8BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).BeginInit();
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
            // posechaemost8DataGridView
            // 
            this.posechaemost8DataGridView.AutoGenerateColumns = false;
            this.posechaemost8DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.posechaemost8DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.posechaemost8DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idposDataGridViewTextBoxColumn,
            this.pouvazhitDataGridViewTextBoxColumn,
            this.bezuvazhitDataGridViewTextBoxColumn,
            this.chet1DataGridViewTextBoxColumn,
            this.chet2DataGridViewTextBoxColumn,
            this.chet3DataGridViewTextBoxColumn,
            this.chet4DataGridViewTextBoxColumn});
            this.posechaemost8DataGridView.DataSource = this.posechaemost8BindingSource;
            this.posechaemost8DataGridView.Location = new System.Drawing.Point(256, 59);
            this.posechaemost8DataGridView.Name = "posechaemost8DataGridView";
            this.posechaemost8DataGridView.RowHeadersWidth = 51;
            this.posechaemost8DataGridView.RowTemplate.Height = 24;
            this.posechaemost8DataGridView.Size = new System.Drawing.Size(896, 492);
            this.posechaemost8DataGridView.TabIndex = 65;
            this.posechaemost8DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.posechaemost8DataGridView_CellContentClick);
            // 
            // posechaemost8BindingSource
            // 
            this.posechaemost8BindingSource.DataMember = "posechaemost8";
            this.posechaemost8BindingSource.DataSource = this.klassDSet;
            // 
            // klassDSet
            // 
            this.klassDSet.DataSetName = "KlassDSet";
            this.klassDSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // posechaemost8TableAdapter
            // 
            this.posechaemost8TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(446, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 40);
            this.label1.TabIndex = 75;
            this.label1.Text = "Посещаемость учеников 8 класса";
            // 
            // idposDataGridViewTextBoxColumn
            // 
            this.idposDataGridViewTextBoxColumn.DataPropertyName = "id_pos";
            this.idposDataGridViewTextBoxColumn.HeaderText = "Код посещаемости";
            this.idposDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idposDataGridViewTextBoxColumn.Name = "idposDataGridViewTextBoxColumn";
            this.idposDataGridViewTextBoxColumn.Width = 149;
            // 
            // pouvazhitDataGridViewTextBoxColumn
            // 
            this.pouvazhitDataGridViewTextBoxColumn.DataPropertyName = "po_uvazhit";
            this.pouvazhitDataGridViewTextBoxColumn.HeaderText = "По уважительной";
            this.pouvazhitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pouvazhitDataGridViewTextBoxColumn.Name = "pouvazhitDataGridViewTextBoxColumn";
            this.pouvazhitDataGridViewTextBoxColumn.Width = 139;
            // 
            // bezuvazhitDataGridViewTextBoxColumn
            // 
            this.bezuvazhitDataGridViewTextBoxColumn.DataPropertyName = "bez_uvazhit";
            this.bezuvazhitDataGridViewTextBoxColumn.HeaderText = "Без уважительной";
            this.bezuvazhitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bezuvazhitDataGridViewTextBoxColumn.Name = "bezuvazhitDataGridViewTextBoxColumn";
            this.bezuvazhitDataGridViewTextBoxColumn.Width = 145;
            // 
            // chet1DataGridViewTextBoxColumn
            // 
            this.chet1DataGridViewTextBoxColumn.DataPropertyName = "chet1";
            this.chet1DataGridViewTextBoxColumn.HeaderText = "I четверть";
            this.chet1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chet1DataGridViewTextBoxColumn.Name = "chet1DataGridViewTextBoxColumn";
            this.chet1DataGridViewTextBoxColumn.Width = 104;
            // 
            // chet2DataGridViewTextBoxColumn
            // 
            this.chet2DataGridViewTextBoxColumn.DataPropertyName = "chet2";
            this.chet2DataGridViewTextBoxColumn.HeaderText = "II четверть";
            this.chet2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chet2DataGridViewTextBoxColumn.Name = "chet2DataGridViewTextBoxColumn";
            this.chet2DataGridViewTextBoxColumn.Width = 99;
            // 
            // chet3DataGridViewTextBoxColumn
            // 
            this.chet3DataGridViewTextBoxColumn.DataPropertyName = "chet3";
            this.chet3DataGridViewTextBoxColumn.HeaderText = "III четверть";
            this.chet3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chet3DataGridViewTextBoxColumn.Name = "chet3DataGridViewTextBoxColumn";
            this.chet3DataGridViewTextBoxColumn.Width = 101;
            // 
            // chet4DataGridViewTextBoxColumn
            // 
            this.chet4DataGridViewTextBoxColumn.DataPropertyName = "chet4";
            this.chet4DataGridViewTextBoxColumn.HeaderText = "IV четверть";
            this.chet4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chet4DataGridViewTextBoxColumn.Name = "chet4DataGridViewTextBoxColumn";
            this.chet4DataGridViewTextBoxColumn.Width = 104;
            // 
            // FormPosechaemost8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1395, 719);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.posechaemost8DataGridView);
            this.Name = "FormPosechaemost8";
            this.Text = "Посещаемость 8 класса";
            this.Load += new System.EventHandler(this.FormPosechaemost8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posechaemost8DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posechaemost8BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDellete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView posechaemost8DataGridView;
        private KlassDSet klassDSet;
        private System.Windows.Forms.BindingSource posechaemost8BindingSource;
        private KlassDSetTableAdapters.posechaemost8TableAdapter posechaemost8TableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idposDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pouvazhitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezuvazhitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chet1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chet2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chet3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chet4DataGridViewTextBoxColumn;
    }
}
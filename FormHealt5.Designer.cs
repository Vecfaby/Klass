﻿namespace Klass
{
    partial class FormHealt5
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
            this.karta_health5DataGridView = new System.Windows.Forms.DataGridView();
            this.buttonDellete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.klassDSet = new Klass.KlassDSet();
            this.kartahealth5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.karta_health5TableAdapter = new Klass.KlassDSetTableAdapters.karta_health5TableAdapter();
            this.idkartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grouphealthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnozDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.karta_health5DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartahealth5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // karta_health5DataGridView
            // 
            this.karta_health5DataGridView.AutoGenerateColumns = false;
            this.karta_health5DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.karta_health5DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.karta_health5DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkartDataGridViewTextBoxColumn,
            this.grouphealthDataGridViewTextBoxColumn,
            this.diagnozDataGridViewTextBoxColumn});
            this.karta_health5DataGridView.DataSource = this.kartahealth5BindingSource;
            this.karta_health5DataGridView.Location = new System.Drawing.Point(413, 12);
            this.karta_health5DataGridView.Name = "karta_health5DataGridView";
            this.karta_health5DataGridView.RowHeadersWidth = 51;
            this.karta_health5DataGridView.RowTemplate.Height = 24;
            this.karta_health5DataGridView.Size = new System.Drawing.Size(518, 510);
            this.karta_health5DataGridView.TabIndex = 68;
            // 
            // buttonDellete
            // 
            this.buttonDellete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDellete.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDellete.Location = new System.Drawing.Point(560, 597);
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
            this.buttonSave.Location = new System.Drawing.Point(254, 597);
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
            this.buttonBack.Location = new System.Drawing.Point(897, 597);
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
            // kartahealth5BindingSource
            // 
            this.kartahealth5BindingSource.DataMember = "karta_health5";
            this.kartahealth5BindingSource.DataSource = this.klassDSet;
            // 
            // karta_health5TableAdapter
            // 
            this.karta_health5TableAdapter.ClearBeforeFill = true;
            // 
            // idkartDataGridViewTextBoxColumn
            // 
            this.idkartDataGridViewTextBoxColumn.DataPropertyName = "id_kart";
            this.idkartDataGridViewTextBoxColumn.HeaderText = "id_kart";
            this.idkartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idkartDataGridViewTextBoxColumn.Name = "idkartDataGridViewTextBoxColumn";
            // 
            // grouphealthDataGridViewTextBoxColumn
            // 
            this.grouphealthDataGridViewTextBoxColumn.DataPropertyName = "group_health";
            this.grouphealthDataGridViewTextBoxColumn.HeaderText = "group_health";
            this.grouphealthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.grouphealthDataGridViewTextBoxColumn.Name = "grouphealthDataGridViewTextBoxColumn";
            // 
            // diagnozDataGridViewTextBoxColumn
            // 
            this.diagnozDataGridViewTextBoxColumn.DataPropertyName = "diagnoz";
            this.diagnozDataGridViewTextBoxColumn.HeaderText = "diagnoz";
            this.diagnozDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diagnozDataGridViewTextBoxColumn.Name = "diagnozDataGridViewTextBoxColumn";
            // 
            // FormHealt5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 719);
            this.Controls.Add(this.karta_health5DataGridView);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormHealt5";
            this.Text = "FormHealt5";
            this.Load += new System.EventHandler(this.FormHealt5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.karta_health5DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartahealth5BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView karta_health5DataGridView;
        private System.Windows.Forms.Button buttonDellete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private KlassDSet klassDSet;
        private System.Windows.Forms.BindingSource kartahealth5BindingSource;
        private KlassDSetTableAdapters.karta_health5TableAdapter karta_health5TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grouphealthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnozDataGridViewTextBoxColumn;
    }
}
﻿namespace Klass
{
    partial class FormZhurnal
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
            this.klassDSet = new Klass.KlassDSet();
            this.zhurnal_TBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zhurnal_TBTableAdapter = new Klass.KlassDSetTableAdapters.zhurnal_TBTableAdapter();
            this.tableAdapterManager = new Klass.KlassDSetTableAdapters.TableAdapterManager();
            this.zhurnal_TBDataGridView = new System.Windows.Forms.DataGridView();
            this.zhurnalTBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.klassDataSet = new Klass.KlassDataSet();
            this.buttonDellete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.klassDaSet = new Klass.KlassDaSet();
            this.zhurnalTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zhurnal_TBTableAdapter1 = new Klass.KlassDaSetTableAdapters.zhurnal_TBTableAdapter();
            this.zhurnal_TBTableAdapter2 = new Klass.KlassDataSetTableAdapters.zhurnal_TBTableAdapter();
            this.inDataSet = new Klass.InDataSet();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhurnal_TBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhurnal_TBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhurnalTBBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDaSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhurnalTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // klassDSet
            // 
            this.klassDSet.DataSetName = "KlassDSet";
            this.klassDSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zhurnal_TBBindingSource
            // 
            this.zhurnal_TBBindingSource.DataMember = "zhurnal_TB";
            this.zhurnal_TBBindingSource.DataSource = this.klassDSet;
            // 
            // zhurnal_TBTableAdapter
            // 
            this.zhurnal_TBTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.instruktionTableAdapter = null;
            this.tableAdapterManager.karta_health5TableAdapter = null;
            this.tableAdapterManager.karta_health6TableAdapter = null;
            this.tableAdapterManager.karta_health7TableAdapter = null;
            this.tableAdapterManager.karta_health8TableAdapter = null;
            this.tableAdapterManager.karta_health9TableAdapter = null;
            this.tableAdapterManager.Klass_rukTableAdapter = null;
            this.tableAdapterManager.posechaemost5TableAdapter = null;
            this.tableAdapterManager.posechaemost6TableAdapter = null;
            this.tableAdapterManager.posechaemost7TableAdapter = null;
            this.tableAdapterManager.posechaemost8TableAdapter = null;
            this.tableAdapterManager.posechaemost9TableAdapter = null;
            this.tableAdapterManager.roditeli5TableAdapter = null;
            this.tableAdapterManager.roditeli6TableAdapter = null;
            this.tableAdapterManager.roditeli7TableAdapter = null;
            this.tableAdapterManager.roditeli8TableAdapter = null;
            this.tableAdapterManager.roditeli9TableAdapter = null;
            this.tableAdapterManager.rukTableAdapter = null;
            this.tableAdapterManager.schoolTableAdapter = null;
            this.tableAdapterManager.students5TableAdapter = null;
            this.tableAdapterManager.students6TableAdapter = null;
            this.tableAdapterManager.students7TableAdapter = null;
            this.tableAdapterManager.students8TableAdapter = null;
            this.tableAdapterManager.students9TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Klass.KlassDSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.vedomost5TableAdapter = null;
            this.tableAdapterManager.vedomost6TableAdapter = null;
            this.tableAdapterManager.vedomost7TableAdapter = null;
            this.tableAdapterManager.vedomost8TableAdapter = null;
            this.tableAdapterManager.vedomost9TableAdapter = null;
            this.tableAdapterManager.vneurochnaya_deyatelnostTableAdapter = null;
            this.tableAdapterManager.zhurnal_TBTableAdapter = this.zhurnal_TBTableAdapter;
            // 
            // zhurnal_TBDataGridView
            // 
            this.zhurnal_TBDataGridView.AutoGenerateColumns = false;
            this.zhurnal_TBDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.zhurnal_TBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zhurnal_TBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.zhurnal_TBDataGridView.DataSource = this.zhurnalTBBindingSource1;
            this.zhurnal_TBDataGridView.Location = new System.Drawing.Point(342, 34);
            this.zhurnal_TBDataGridView.Name = "zhurnal_TBDataGridView";
            this.zhurnal_TBDataGridView.RowHeadersWidth = 51;
            this.zhurnal_TBDataGridView.RowTemplate.Height = 24;
            this.zhurnal_TBDataGridView.Size = new System.Drawing.Size(601, 449);
            this.zhurnal_TBDataGridView.TabIndex = 1;
            // 
            // zhurnalTBBindingSource1
            // 
            this.zhurnalTBBindingSource1.DataMember = "zhurnal_TB";
            this.zhurnalTBBindingSource1.DataSource = this.klassDataSet;
            // 
            // klassDataSet
            // 
            this.klassDataSet.DataSetName = "KlassDataSet";
            this.klassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonDellete
            // 
            this.buttonDellete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDellete.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDellete.Location = new System.Drawing.Point(467, 576);
            this.buttonDellete.Name = "buttonDellete";
            this.buttonDellete.Size = new System.Drawing.Size(216, 67);
            this.buttonDellete.TabIndex = 70;
            this.buttonDellete.Text = "Удалить";
            this.buttonDellete.UseVisualStyleBackColor = false;
            this.buttonDellete.Click += new System.EventHandler(this.buttonDellete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(179, 576);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(216, 67);
            this.buttonSave.TabIndex = 69;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(999, 576);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(187, 67);
            this.buttonBack.TabIndex = 68;
            this.buttonBack.Text = "Главное меню";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(737, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 67);
            this.button1.TabIndex = 71;
            this.button1.Text = "Инструктажи";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // klassDaSet
            // 
            this.klassDaSet.DataSetName = "KlassDaSet";
            this.klassDaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zhurnalTBBindingSource
            // 
            this.zhurnalTBBindingSource.DataMember = "zhurnal_TB";
            this.zhurnalTBBindingSource.DataSource = this.klassDaSet;
            // 
            // zhurnal_TBTableAdapter1
            // 
            this.zhurnal_TBTableAdapter1.ClearBeforeFill = true;
            // 
            // zhurnal_TBTableAdapter2
            // 
            this.zhurnal_TBTableAdapter2.ClearBeforeFill = true;
            // 
            // inDataSet
            // 
            this.inDataSet.DataSetName = "InDataSet";
            this.inDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_instruk";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код инструктажа";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "date_instruk";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата инструктажа";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_klass";
            this.dataGridViewTextBoxColumn1.HeaderText = "Класс";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // FormZhurnal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1395, 719);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.zhurnal_TBDataGridView);
            this.Name = "FormZhurnal";
            this.Text = "Журнал техники безопасности";
            this.Load += new System.EventHandler(this.FormZhurnal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhurnal_TBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhurnal_TBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhurnalTBBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDaSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhurnalTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private KlassDSet klassDSet;
        private System.Windows.Forms.BindingSource zhurnal_TBBindingSource;
        private KlassDSetTableAdapters.zhurnal_TBTableAdapter zhurnal_TBTableAdapter;
        private KlassDSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView zhurnal_TBDataGridView;
        private System.Windows.Forms.Button buttonDellete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button button1;
        private KlassDaSet klassDaSet;
        private System.Windows.Forms.BindingSource zhurnalTBBindingSource;
        private KlassDaSetTableAdapters.zhurnal_TBTableAdapter zhurnal_TBTableAdapter1;
        private KlassDataSet klassDataSet;
        private System.Windows.Forms.BindingSource zhurnalTBBindingSource1;
        private KlassDataSetTableAdapters.zhurnal_TBTableAdapter zhurnal_TBTableAdapter2;
        private InDataSet inDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
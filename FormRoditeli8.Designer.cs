﻿namespace Klass
{
    partial class FormRoditeli8
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
            this.roditeli8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roditeli8TableAdapter = new Klass.KlassDSetTableAdapters.roditeli8TableAdapter();
            this.tableAdapterManager = new Klass.KlassDSetTableAdapters.TableAdapterManager();
            this.roditeli8DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roditeli8BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.klassDataSet = new Klass.KlassDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.namestudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKstudents8roditeli8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roditeli8TableAdapter1 = new Klass.KlassDataSetTableAdapters.roditeli8TableAdapter();
            this.students8TableAdapter = new Klass.KlassDataSetTableAdapters.students8TableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roditeli8BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roditeli8DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roditeli8BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKstudents8roditeli8BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDellete
            // 
            this.buttonDellete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDellete.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDellete.Location = new System.Drawing.Point(587, 640);
            this.buttonDellete.Name = "buttonDellete";
            this.buttonDellete.Size = new System.Drawing.Size(216, 67);
            this.buttonDellete.TabIndex = 63;
            this.buttonDellete.Text = "Удалить";
            this.buttonDellete.UseVisualStyleBackColor = false;
            this.buttonDellete.Click += new System.EventHandler(this.buttonDellete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(256, 640);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(216, 67);
            this.buttonSave.TabIndex = 62;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(924, 640);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(187, 67);
            this.buttonBack.TabIndex = 61;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // klassDSet
            // 
            this.klassDSet.DataSetName = "KlassDSet";
            this.klassDSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roditeli8BindingSource
            // 
            this.roditeli8BindingSource.DataMember = "roditeli8";
            this.roditeli8BindingSource.DataSource = this.klassDSet;
            // 
            // roditeli8TableAdapter
            // 
            this.roditeli8TableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.roditeli8TableAdapter = this.roditeli8TableAdapter;
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
            this.tableAdapterManager.zhurnal_TBTableAdapter = null;
            // 
            // roditeli8DataGridView
            // 
            this.roditeli8DataGridView.AutoGenerateColumns = false;
            this.roditeli8DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.roditeli8DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roditeli8DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.roditeli8DataGridView.DataSource = this.roditeli8BindingSource1;
            this.roditeli8DataGridView.Location = new System.Drawing.Point(38, 45);
            this.roditeli8DataGridView.Name = "roditeli8DataGridView";
            this.roditeli8DataGridView.RowHeadersWidth = 51;
            this.roditeli8DataGridView.RowTemplate.Height = 24;
            this.roditeli8DataGridView.Size = new System.Drawing.Size(1303, 512);
            this.roditeli8DataGridView.TabIndex = 64;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_rod";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код родителя";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 118;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name_mom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Полное имя матери";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "data_rozhdeniya_mom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата рождения матери";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 132;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "job_mom";
            this.dataGridViewTextBoxColumn4.HeaderText = "Место работы матери";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 124;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "phone_mom";
            this.dataGridViewTextBoxColumn5.HeaderText = "Телефон матери";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 136;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "name_dad";
            this.dataGridViewTextBoxColumn6.HeaderText = "Полное имя отца";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 90;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "data_rozhdeniya_dad";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата рождения отца";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 132;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "job_dad";
            this.dataGridViewTextBoxColumn8.HeaderText = "Место работы отца";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 111;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "phone_dad";
            this.dataGridViewTextBoxColumn9.HeaderText = "Телефон отца";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 121;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "adres";
            this.dataGridViewTextBoxColumn10.HeaderText = "Адрес ";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 81;
            // 
            // roditeli8BindingSource1
            // 
            this.roditeli8BindingSource1.DataMember = "roditeli8";
            this.roditeli8BindingSource1.DataSource = this.klassDataSet;
            // 
            // klassDataSet
            // 
            this.klassDataSet.DataSetName = "KlassDataSet";
            this.klassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(466, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 40);
            this.label1.TabIndex = 65;
            this.label1.Text = "Родители учеников 8 класса";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namestudentDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKstudents8roditeli8BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(256, 563);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(434, 71);
            this.dataGridView2.TabIndex = 79;
            // 
            // namestudentDataGridViewTextBoxColumn
            // 
            this.namestudentDataGridViewTextBoxColumn.DataPropertyName = "name_student";
            this.namestudentDataGridViewTextBoxColumn.HeaderText = "Имя ученика";
            this.namestudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namestudentDataGridViewTextBoxColumn.Name = "namestudentDataGridViewTextBoxColumn";
            // 
            // fKstudents8roditeli8BindingSource
            // 
            this.fKstudents8roditeli8BindingSource.DataMember = "FK_students8_roditeli8";
            this.fKstudents8roditeli8BindingSource.DataSource = this.roditeli8BindingSource1;
            // 
            // roditeli8TableAdapter1
            // 
            this.roditeli8TableAdapter1.ClearBeforeFill = true;
            // 
            // students8TableAdapter
            // 
            this.students8TableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(696, 563);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 58);
            this.label2.TabIndex = 80;
            this.label2.Text = "Если поле \"Имя ученика\" заполнено, \r\nто удаление записи невозможно!";
            // 
            // FormRoditeli8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1395, 719);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roditeli8DataGridView);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormRoditeli8";
            this.Text = "Родители учеников 8 класса";
            this.Load += new System.EventHandler(this.FormRoditeli8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roditeli8BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roditeli8DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roditeli8BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKstudents8roditeli8BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDellete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private KlassDSet klassDSet;
        private System.Windows.Forms.BindingSource roditeli8BindingSource;
        private KlassDSetTableAdapters.roditeli8TableAdapter roditeli8TableAdapter;
        private KlassDSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView roditeli8DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private KlassDataSet klassDataSet;
        private System.Windows.Forms.BindingSource roditeli8BindingSource1;
        private KlassDataSetTableAdapters.roditeli8TableAdapter roditeli8TableAdapter1;
        private System.Windows.Forms.BindingSource fKstudents8roditeli8BindingSource;
        private KlassDataSetTableAdapters.students8TableAdapter students8TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namestudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}
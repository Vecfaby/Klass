namespace Klass
{
    partial class Formzapisi
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
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Klass.KlassDSetTableAdapters.UsersTableAdapter();
            this.klassDaSet = new Klass.KlassDaSet();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter1 = new Klass.KlassDaSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new Klass.KlassDaSetTableAdapters.TableAdapterManager();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.regDataSet = new Klass.RegDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.usersTableAdapter2 = new Klass.RegDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager1 = new Klass.RegDataSetTableAdapters.TableAdapterManager();
            this.usersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.klassDataSet1 = new Klass.KlassDataSet1();
            this.klassDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter3 = new Klass.KlassDataSet1TableAdapters.UsersTableAdapter();
            this.tableAdapterManager2 = new Klass.KlassDataSet1TableAdapters.TableAdapterManager();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDaSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDellete
            // 
            this.buttonDellete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDellete.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDellete.Location = new System.Drawing.Point(308, 528);
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
            this.buttonSave.Location = new System.Drawing.Point(29, 528);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(216, 67);
            this.buttonSave.TabIndex = 68;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(603, 528);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(187, 67);
            this.buttonBack.TabIndex = 67;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // klassDSet
            // 
            this.klassDSet.DataSetName = "KlassDSet";
            this.klassDSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.klassDSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // klassDaSet
            // 
            this.klassDaSet.DataSetName = "KlassDaSet";
            this.klassDaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.klassDaSet;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
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
            this.tableAdapterManager.UpdateOrder = Klass.KlassDaSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter1;
            this.tableAdapterManager.vedomost5TableAdapter = null;
            this.tableAdapterManager.vedomost6TableAdapter = null;
            this.tableAdapterManager.vedomost7TableAdapter = null;
            this.tableAdapterManager.vedomost8TableAdapter = null;
            this.tableAdapterManager.vedomost9TableAdapter = null;
            this.tableAdapterManager.vneurochnaya_deyatelnostTableAdapter = null;
            this.tableAdapterManager.zhurnal_TBTableAdapter = null;
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "Users";
            this.usersBindingSource2.DataSource = this.regDataSet;
            // 
            // regDataSet
            // 
            this.regDataSet.DataSetName = "RegDataSet";
            this.regDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(285, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 40);
            this.label2.TabIndex = 79;
            this.label2.Text = "Учетные записи";
            // 
            // usersTableAdapter2
            // 
            this.usersTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.instruktionTableAdapter = null;
            this.tableAdapterManager1.karta_health5TableAdapter = null;
            this.tableAdapterManager1.karta_health6TableAdapter = null;
            this.tableAdapterManager1.karta_health7TableAdapter = null;
            this.tableAdapterManager1.karta_health8TableAdapter = null;
            this.tableAdapterManager1.karta_health9TableAdapter = null;
            this.tableAdapterManager1.Klass_rukTableAdapter = null;
            this.tableAdapterManager1.posechaemost5TableAdapter = null;
            this.tableAdapterManager1.posechaemost6TableAdapter = null;
            this.tableAdapterManager1.posechaemost7TableAdapter = null;
            this.tableAdapterManager1.posechaemost8TableAdapter = null;
            this.tableAdapterManager1.posechaemost9TableAdapter = null;
            this.tableAdapterManager1.roditeli5TableAdapter = null;
            this.tableAdapterManager1.roditeli6TableAdapter = null;
            this.tableAdapterManager1.roditeli7TableAdapter = null;
            this.tableAdapterManager1.roditeli8TableAdapter = null;
            this.tableAdapterManager1.roditeli9TableAdapter = null;
            this.tableAdapterManager1.rukTableAdapter = null;
            this.tableAdapterManager1.schoolTableAdapter = null;
            this.tableAdapterManager1.students5TableAdapter = null;
            this.tableAdapterManager1.students6TableAdapter = null;
            this.tableAdapterManager1.students7TableAdapter = null;
            this.tableAdapterManager1.students8TableAdapter = null;
            this.tableAdapterManager1.students9TableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Klass.RegDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsersTableAdapter = this.usersTableAdapter2;
            this.tableAdapterManager1.vedomost5TableAdapter = null;
            this.tableAdapterManager1.vedomost6TableAdapter = null;
            this.tableAdapterManager1.vedomost7TableAdapter = null;
            this.tableAdapterManager1.vedomost8TableAdapter = null;
            this.tableAdapterManager1.vedomost9TableAdapter = null;
            this.tableAdapterManager1.vneurochnaya_deyatelnostTableAdapter = null;
            this.tableAdapterManager1.zhurnal_TBTableAdapter = null;
            // 
            // usersBindingSource3
            // 
            this.usersBindingSource3.DataMember = "Users";
            this.usersBindingSource3.DataSource = this.regDataSet;
            // 
            // klassDataSet1
            // 
            this.klassDataSet1.DataSetName = "KlassDataSet1";
            this.klassDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klassDataSet1BindingSource
            // 
            this.klassDataSet1BindingSource.DataSource = this.klassDataSet1;
            this.klassDataSet1BindingSource.Position = 0;
            // 
            // usersBindingSource4
            // 
            this.usersBindingSource4.DataMember = "Users";
            this.usersBindingSource4.DataSource = this.klassDataSet1;
            // 
            // usersTableAdapter3
            // 
            this.usersTableAdapter3.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.UpdateOrder = Klass.KlassDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager2.UsersTableAdapter = this.usersTableAdapter3;
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.usersDataGridView.DataSource = this.usersBindingSource4;
            this.usersDataGridView.Location = new System.Drawing.Point(97, 69);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.RowHeadersWidth = 51;
            this.usersDataGridView.RowTemplate.Height = 24;
            this.usersDataGridView.Size = new System.Drawing.Size(645, 362);
            this.usersDataGridView.TabIndex = 79;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_user";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код пользователя";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Login";
            this.dataGridViewTextBoxColumn2.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Role";
            this.dataGridViewTextBoxColumn4.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Formzapisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(910, 647);
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Name = "Formzapisi";
            this.Text = "Учетные записи";
            this.Load += new System.EventHandler(this.Formzapisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDaSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDellete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private KlassDSet klassDSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private KlassDSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private KlassDaSet klassDaSet;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private KlassDaSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private KlassDaSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label2;
        private RegDataSet regDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private RegDataSetTableAdapters.UsersTableAdapter usersTableAdapter2;
        private RegDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource usersBindingSource3;
        private KlassDataSet1 klassDataSet1;
        private System.Windows.Forms.BindingSource klassDataSet1BindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource4;
        private KlassDataSet1TableAdapters.UsersTableAdapter usersTableAdapter3;
        private KlassDataSet1TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
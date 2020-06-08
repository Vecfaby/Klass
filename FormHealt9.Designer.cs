namespace Klass
{
    partial class FormHealt9
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
            this.karta_health9DataGridView = new System.Windows.Forms.DataGridView();
            this.idkartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grouphealthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnozDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kartahealth9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klassDSet = new Klass.KlassDSet();
            this.buttonDellete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.karta_health9TableAdapter = new Klass.KlassDSetTableAdapters.karta_health9TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.klassDataSet = new Klass.KlassDataSet();
            this.kartahealth9BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.karta_health9TableAdapter1 = new Klass.KlassDataSetTableAdapters.karta_health9TableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.fKstudents9kartahealth9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students9TableAdapter = new Klass.KlassDataSetTableAdapters.students9TableAdapter();
            this.namestudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.karta_health9DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartahealth9BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartahealth9BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKstudents9kartahealth9BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // karta_health9DataGridView
            // 
            this.karta_health9DataGridView.AutoGenerateColumns = false;
            this.karta_health9DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.karta_health9DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.karta_health9DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkartDataGridViewTextBoxColumn,
            this.grouphealthDataGridViewTextBoxColumn,
            this.diagnozDataGridViewTextBoxColumn});
            this.karta_health9DataGridView.DataSource = this.kartahealth9BindingSource1;
            this.karta_health9DataGridView.Location = new System.Drawing.Point(88, 73);
            this.karta_health9DataGridView.Name = "karta_health9DataGridView";
            this.karta_health9DataGridView.RowHeadersWidth = 51;
            this.karta_health9DataGridView.RowTemplate.Height = 24;
            this.karta_health9DataGridView.Size = new System.Drawing.Size(518, 510);
            this.karta_health9DataGridView.TabIndex = 72;
            // 
            // idkartDataGridViewTextBoxColumn
            // 
            this.idkartDataGridViewTextBoxColumn.DataPropertyName = "id_kart";
            this.idkartDataGridViewTextBoxColumn.HeaderText = "Код карты";
            this.idkartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idkartDataGridViewTextBoxColumn.Name = "idkartDataGridViewTextBoxColumn";
            // 
            // grouphealthDataGridViewTextBoxColumn
            // 
            this.grouphealthDataGridViewTextBoxColumn.DataPropertyName = "group_health";
            this.grouphealthDataGridViewTextBoxColumn.HeaderText = "Группа здоровья";
            this.grouphealthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.grouphealthDataGridViewTextBoxColumn.Name = "grouphealthDataGridViewTextBoxColumn";
            // 
            // diagnozDataGridViewTextBoxColumn
            // 
            this.diagnozDataGridViewTextBoxColumn.DataPropertyName = "diagnoz";
            this.diagnozDataGridViewTextBoxColumn.HeaderText = "Диагноз";
            this.diagnozDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diagnozDataGridViewTextBoxColumn.Name = "diagnozDataGridViewTextBoxColumn";
            // 
            // kartahealth9BindingSource
            // 
            this.kartahealth9BindingSource.DataMember = "karta_health9";
            this.kartahealth9BindingSource.DataSource = this.klassDSet;
            // 
            // klassDSet
            // 
            this.klassDSet.DataSetName = "KlassDSet";
            this.klassDSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonDellete
            // 
            this.buttonDellete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDellete.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDellete.Location = new System.Drawing.Point(588, 618);
            this.buttonDellete.Name = "buttonDellete";
            this.buttonDellete.Size = new System.Drawing.Size(216, 67);
            this.buttonDellete.TabIndex = 71;
            this.buttonDellete.Text = "Удалить";
            this.buttonDellete.UseVisualStyleBackColor = false;
            this.buttonDellete.Click += new System.EventHandler(this.buttonDellete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(282, 618);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(216, 67);
            this.buttonSave.TabIndex = 70;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(925, 618);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(187, 67);
            this.buttonBack.TabIndex = 69;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // karta_health9TableAdapter
            // 
            this.karta_health9TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(446, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 40);
            this.label1.TabIndex = 73;
            this.label1.Text = "Карта здоровья учеников 9 класса";
            // 
            // klassDataSet
            // 
            this.klassDataSet.DataSetName = "KlassDataSet";
            this.klassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kartahealth9BindingSource1
            // 
            this.kartahealth9BindingSource1.DataMember = "karta_health9";
            this.kartahealth9BindingSource1.DataSource = this.klassDataSet;
            // 
            // karta_health9TableAdapter1
            // 
            this.karta_health9TableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namestudentDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKstudents9kartahealth9BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(687, 73);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(473, 71);
            this.dataGridView2.TabIndex = 77;
            // 
            // fKstudents9kartahealth9BindingSource
            // 
            this.fKstudents9kartahealth9BindingSource.DataMember = "FK_students9_karta_health9";
            this.fKstudents9kartahealth9BindingSource.DataSource = this.kartahealth9BindingSource1;
            // 
            // students9TableAdapter
            // 
            this.students9TableAdapter.ClearBeforeFill = true;
            // 
            // namestudentDataGridViewTextBoxColumn
            // 
            this.namestudentDataGridViewTextBoxColumn.DataPropertyName = "name_student";
            this.namestudentDataGridViewTextBoxColumn.HeaderText = "Имя ученика";
            this.namestudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namestudentDataGridViewTextBoxColumn.Name = "namestudentDataGridViewTextBoxColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(704, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 58);
            this.label2.TabIndex = 78;
            this.label2.Text = "Если поле \"Имя ученика\" заполнено, \r\nто удаление записи невозможно!";
            // 
            // FormHealt9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1395, 719);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.karta_health9DataGridView);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormHealt9";
            this.Text = "Карта здоровья 9 класса";
            this.Load += new System.EventHandler(this.FormHealt9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.karta_health9DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartahealth9BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartahealth9BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKstudents9kartahealth9BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView karta_health9DataGridView;
        private System.Windows.Forms.Button buttonDellete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private KlassDSet klassDSet;
        private System.Windows.Forms.BindingSource kartahealth9BindingSource;
        private KlassDSetTableAdapters.karta_health9TableAdapter karta_health9TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grouphealthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnozDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private KlassDataSet klassDataSet;
        private System.Windows.Forms.BindingSource kartahealth9BindingSource1;
        private KlassDataSetTableAdapters.karta_health9TableAdapter karta_health9TableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource fKstudents9kartahealth9BindingSource;
        private KlassDataSetTableAdapters.students9TableAdapter students9TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namestudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}
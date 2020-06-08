namespace Klass
{
    partial class FormHealt8
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
            this.karta_health8DataGridView = new System.Windows.Forms.DataGridView();
            this.idkartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grouphealthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnozDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kartahealth8BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.klassDataSet = new Klass.KlassDataSet();
            this.kartahealth8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klassDSet = new Klass.KlassDSet();
            this.buttonDellete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.karta_health8TableAdapter = new Klass.KlassDSetTableAdapters.karta_health8TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.karta_health8TableAdapter1 = new Klass.KlassDataSetTableAdapters.karta_health8TableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.namestudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKstudents8kartahealth8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students8TableAdapter = new Klass.KlassDataSetTableAdapters.students8TableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.karta_health8DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartahealth8BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartahealth8BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKstudents8kartahealth8BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // karta_health8DataGridView
            // 
            this.karta_health8DataGridView.AutoGenerateColumns = false;
            this.karta_health8DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.karta_health8DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.karta_health8DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkartDataGridViewTextBoxColumn,
            this.grouphealthDataGridViewTextBoxColumn,
            this.diagnozDataGridViewTextBoxColumn});
            this.karta_health8DataGridView.DataSource = this.kartahealth8BindingSource1;
            this.karta_health8DataGridView.Location = new System.Drawing.Point(132, 52);
            this.karta_health8DataGridView.Name = "karta_health8DataGridView";
            this.karta_health8DataGridView.RowHeadersWidth = 51;
            this.karta_health8DataGridView.RowTemplate.Height = 24;
            this.karta_health8DataGridView.Size = new System.Drawing.Size(518, 510);
            this.karta_health8DataGridView.TabIndex = 72;
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
            // kartahealth8BindingSource1
            // 
            this.kartahealth8BindingSource1.DataMember = "karta_health8";
            this.kartahealth8BindingSource1.DataSource = this.klassDataSet;
            // 
            // klassDataSet
            // 
            this.klassDataSet.DataSetName = "KlassDataSet";
            this.klassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kartahealth8BindingSource
            // 
            this.kartahealth8BindingSource.DataMember = "karta_health8";
            this.kartahealth8BindingSource.DataSource = this.klassDSet;
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
            // karta_health8TableAdapter
            // 
            this.karta_health8TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(436, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 40);
            this.label1.TabIndex = 73;
            this.label1.Text = "Карта здоровья учеников 8 класса";
            // 
            // karta_health8TableAdapter1
            // 
            this.karta_health8TableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namestudentDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKstudents8kartahealth8BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(722, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(473, 71);
            this.dataGridView2.TabIndex = 77;
            // 
            // namestudentDataGridViewTextBoxColumn
            // 
            this.namestudentDataGridViewTextBoxColumn.DataPropertyName = "name_student";
            this.namestudentDataGridViewTextBoxColumn.HeaderText = "Имя ученика";
            this.namestudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namestudentDataGridViewTextBoxColumn.Name = "namestudentDataGridViewTextBoxColumn";
            // 
            // fKstudents8kartahealth8BindingSource
            // 
            this.fKstudents8kartahealth8BindingSource.DataMember = "FK_students8_karta_health8";
            this.fKstudents8kartahealth8BindingSource.DataSource = this.kartahealth8BindingSource1;
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
            this.label2.Location = new System.Drawing.Point(740, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 58);
            this.label2.TabIndex = 78;
            this.label2.Text = "Если поле \"Имя ученика\" заполнено, \r\nто удаление записи невозможно!";
            // 
            // FormHealt8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1395, 719);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.karta_health8DataGridView);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormHealt8";
            this.Text = "Карта здоровья 8 класса";
            this.Load += new System.EventHandler(this.FormHealt8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.karta_health8DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartahealth8BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartahealth8BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKstudents8kartahealth8BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView karta_health8DataGridView;
        private System.Windows.Forms.Button buttonDellete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private KlassDSet klassDSet;
        private System.Windows.Forms.BindingSource kartahealth8BindingSource;
        private KlassDSetTableAdapters.karta_health8TableAdapter karta_health8TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grouphealthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnozDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private KlassDataSet klassDataSet;
        private System.Windows.Forms.BindingSource kartahealth8BindingSource1;
        private KlassDataSetTableAdapters.karta_health8TableAdapter karta_health8TableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource fKstudents8kartahealth8BindingSource;
        private KlassDataSetTableAdapters.students8TableAdapter students8TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namestudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}
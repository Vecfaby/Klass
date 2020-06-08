namespace Klass
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
            this.idkartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grouphealthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnozDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kartahealth5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klassDSet = new Klass.KlassDSet();
            this.buttonDellete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.karta_health5TableAdapter = new Klass.KlassDSetTableAdapters.karta_health5TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namestudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKstudents5kartahealth5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students5TableAdapter = new Klass.KlassDSetTableAdapters.students5TableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.karta_health5DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartahealth5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKstudents5kartahealth5BindingSource)).BeginInit();
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
            this.karta_health5DataGridView.Location = new System.Drawing.Point(188, 73);
            this.karta_health5DataGridView.Name = "karta_health5DataGridView";
            this.karta_health5DataGridView.RowHeadersWidth = 51;
            this.karta_health5DataGridView.RowTemplate.Height = 24;
            this.karta_health5DataGridView.Size = new System.Drawing.Size(518, 514);
            this.karta_health5DataGridView.TabIndex = 68;
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
            // kartahealth5BindingSource
            // 
            this.kartahealth5BindingSource.DataMember = "karta_health5";
            this.kartahealth5BindingSource.DataSource = this.klassDSet;
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
            // karta_health5TableAdapter
            // 
            this.karta_health5TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(406, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 40);
            this.label1.TabIndex = 69;
            this.label1.Text = "Карта здоровья учеников 5 класса";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namestudentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKstudents5kartahealth5BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(746, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(473, 71);
            this.dataGridView1.TabIndex = 70;
            // 
            // namestudentDataGridViewTextBoxColumn
            // 
            this.namestudentDataGridViewTextBoxColumn.DataPropertyName = "name_student";
            this.namestudentDataGridViewTextBoxColumn.HeaderText = "Имя ученика";
            this.namestudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namestudentDataGridViewTextBoxColumn.Name = "namestudentDataGridViewTextBoxColumn";
            // 
            // fKstudents5kartahealth5BindingSource
            // 
            this.fKstudents5kartahealth5BindingSource.DataMember = "FK_students5_karta_health5";
            this.fKstudents5kartahealth5BindingSource.DataSource = this.kartahealth5BindingSource;
            // 
            // students5TableAdapter
            // 
            this.students5TableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(766, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 58);
            this.label2.TabIndex = 71;
            this.label2.Text = "Если поле \"Имя ученика\" заполнено, \r\nто удаление записи невозможно!";
            // 
            // FormHealt5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1395, 719);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.karta_health5DataGridView);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormHealt5";
            this.Load += new System.EventHandler(this.FormHealt5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.karta_health5DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartahealth5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassDSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKstudents5kartahealth5BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fKstudents5kartahealth5BindingSource;
        private KlassDSetTableAdapters.students5TableAdapter students5TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namestudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}
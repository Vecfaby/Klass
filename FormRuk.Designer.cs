namespace Klass
{
    partial class FormRuk
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
            System.Windows.Forms.Label id_klassLabel;
            System.Windows.Forms.Label name_rukLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label adresLabel;
            System.Windows.Forms.Label id_shcoolLabel;
            System.Windows.Forms.Label name_shcoolLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRuk));
            this.klassDatSet = new Klass.KlassDatSet();
            this.klass_rukBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klass_rukTableAdapter = new Klass.KlassDatSetTableAdapters.Klass_rukTableAdapter();
            this.tableAdapterManager = new Klass.KlassDatSetTableAdapters.TableAdapterManager();
            this.klass_rukBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.klass_rukBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_klassTextBox = new System.Windows.Forms.TextBox();
            this.name_rukTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.id_shcoolTextBox = new System.Windows.Forms.TextBox();
            this.name_shcoolTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            id_klassLabel = new System.Windows.Forms.Label();
            name_rukLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            adresLabel = new System.Windows.Forms.Label();
            id_shcoolLabel = new System.Windows.Forms.Label();
            name_shcoolLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.klassDatSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klass_rukBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klass_rukBindingNavigator)).BeginInit();
            this.klass_rukBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_klassLabel
            // 
            id_klassLabel.AutoSize = true;
            id_klassLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_klassLabel.Location = new System.Drawing.Point(97, 64);
            id_klassLabel.Name = "id_klassLabel";
            id_klassLabel.Size = new System.Drawing.Size(78, 24);
            id_klassLabel.TabIndex = 1;
            id_klassLabel.Text = "Класс:";
            id_klassLabel.Click += new System.EventHandler(this.id_klassLabel_Click);
            // 
            // name_rukLabel
            // 
            name_rukLabel.AutoSize = true;
            name_rukLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_rukLabel.Location = new System.Drawing.Point(97, 102);
            name_rukLabel.Name = "name_rukLabel";
            name_rukLabel.Size = new System.Drawing.Size(324, 24);
            name_rukLabel.TabIndex = 3;
            name_rukLabel.Text = "Имя классного руководителя:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneLabel.Location = new System.Drawing.Point(97, 137);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(109, 24);
            phoneLabel.TabIndex = 5;
            phoneLabel.Text = "Телефон:";
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            adresLabel.Location = new System.Drawing.Point(97, 178);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new System.Drawing.Size(80, 24);
            adresLabel.TabIndex = 7;
            adresLabel.Text = "Адрес:";
            // 
            // id_shcoolLabel
            // 
            id_shcoolLabel.AutoSize = true;
            id_shcoolLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_shcoolLabel.Location = new System.Drawing.Point(97, 216);
            id_shcoolLabel.Name = "id_shcoolLabel";
            id_shcoolLabel.Size = new System.Drawing.Size(162, 24);
            id_shcoolLabel.TabIndex = 9;
            id_shcoolLabel.Text = "Номер школы:";
            // 
            // name_shcoolLabel
            // 
            name_shcoolLabel.AutoSize = true;
            name_shcoolLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_shcoolLabel.Location = new System.Drawing.Point(97, 254);
            name_shcoolLabel.Name = "name_shcoolLabel";
            name_shcoolLabel.Size = new System.Drawing.Size(194, 24);
            name_shcoolLabel.TabIndex = 11;
            name_shcoolLabel.Text = "Название школы:";
            // 
            // klassDatSet
            // 
            this.klassDatSet.DataSetName = "KlassDatSet";
            this.klassDatSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klass_rukBindingSource
            // 
            this.klass_rukBindingSource.DataMember = "Klass_ruk";
            this.klass_rukBindingSource.DataSource = this.klassDatSet;
            // 
            // klass_rukTableAdapter
            // 
            this.klass_rukTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Klass_rukTableAdapter = this.klass_rukTableAdapter;
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
            this.tableAdapterManager.UpdateOrder = Klass.KlassDatSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.vedomost5TableAdapter = null;
            this.tableAdapterManager.vedomost6TableAdapter = null;
            this.tableAdapterManager.vedomost7TableAdapter = null;
            this.tableAdapterManager.vedomost8TableAdapter = null;
            this.tableAdapterManager.vedomost9TableAdapter = null;
            this.tableAdapterManager.vneurochnaya_deyatelnostTableAdapter = null;
            this.tableAdapterManager.zhurnal_TBTableAdapter = null;
            // 
            // klass_rukBindingNavigator
            // 
            this.klass_rukBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.klass_rukBindingNavigator.BindingSource = this.klass_rukBindingSource;
            this.klass_rukBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.klass_rukBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.klass_rukBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.klass_rukBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.klass_rukBindingNavigatorSaveItem});
            this.klass_rukBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.klass_rukBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.klass_rukBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.klass_rukBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.klass_rukBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.klass_rukBindingNavigator.Name = "klass_rukBindingNavigator";
            this.klass_rukBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.klass_rukBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.klass_rukBindingNavigator.TabIndex = 0;
            this.klass_rukBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // klass_rukBindingNavigatorSaveItem
            // 
            this.klass_rukBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.klass_rukBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("klass_rukBindingNavigatorSaveItem.Image")));
            this.klass_rukBindingNavigatorSaveItem.Name = "klass_rukBindingNavigatorSaveItem";
            this.klass_rukBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.klass_rukBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.klass_rukBindingNavigatorSaveItem.Click += new System.EventHandler(this.klass_rukBindingNavigatorSaveItem_Click);
            // 
            // id_klassTextBox
            // 
            this.id_klassTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klass_rukBindingSource, "id_klass", true));
            this.id_klassTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_klassTextBox.Location = new System.Drawing.Point(481, 61);
            this.id_klassTextBox.Name = "id_klassTextBox";
            this.id_klassTextBox.Size = new System.Drawing.Size(225, 32);
            this.id_klassTextBox.TabIndex = 2;
            // 
            // name_rukTextBox
            // 
            this.name_rukTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klass_rukBindingSource, "name_ruk", true));
            this.name_rukTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_rukTextBox.Location = new System.Drawing.Point(481, 99);
            this.name_rukTextBox.Name = "name_rukTextBox";
            this.name_rukTextBox.Size = new System.Drawing.Size(225, 32);
            this.name_rukTextBox.TabIndex = 4;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klass_rukBindingSource, "phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.Location = new System.Drawing.Point(481, 137);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(225, 32);
            this.phoneTextBox.TabIndex = 6;
            // 
            // adresTextBox
            // 
            this.adresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klass_rukBindingSource, "adres", true));
            this.adresTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adresTextBox.Location = new System.Drawing.Point(481, 175);
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(225, 32);
            this.adresTextBox.TabIndex = 8;
            // 
            // id_shcoolTextBox
            // 
            this.id_shcoolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klass_rukBindingSource, "id_shcool", true));
            this.id_shcoolTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_shcoolTextBox.Location = new System.Drawing.Point(481, 213);
            this.id_shcoolTextBox.Name = "id_shcoolTextBox";
            this.id_shcoolTextBox.Size = new System.Drawing.Size(225, 32);
            this.id_shcoolTextBox.TabIndex = 10;
            // 
            // name_shcoolTextBox
            // 
            this.name_shcoolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klass_rukBindingSource, "name_shcool", true));
            this.name_shcoolTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_shcoolTextBox.Location = new System.Drawing.Point(481, 251);
            this.name_shcoolTextBox.Name = "name_shcoolTextBox";
            this.name_shcoolTextBox.Size = new System.Drawing.Size(225, 32);
            this.name_shcoolTextBox.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(141, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 58);
            this.button2.TabIndex = 44;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(391, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 58);
            this.button1.TabIndex = 45;
            this.button1.Text = "Главное меню";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(id_klassLabel);
            this.Controls.Add(this.id_klassTextBox);
            this.Controls.Add(name_rukLabel);
            this.Controls.Add(this.name_rukTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(adresLabel);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(id_shcoolLabel);
            this.Controls.Add(this.id_shcoolTextBox);
            this.Controls.Add(name_shcoolLabel);
            this.Controls.Add(this.name_shcoolTextBox);
            this.Controls.Add(this.klass_rukBindingNavigator);
            this.Name = "FormRuk";
            this.Text = "FormRuk";
            this.Load += new System.EventHandler(this.FormRuk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klassDatSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klass_rukBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klass_rukBindingNavigator)).EndInit();
            this.klass_rukBindingNavigator.ResumeLayout(false);
            this.klass_rukBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KlassDatSet klassDatSet;
        private System.Windows.Forms.BindingSource klass_rukBindingSource;
        private KlassDatSetTableAdapters.Klass_rukTableAdapter klass_rukTableAdapter;
        private KlassDatSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator klass_rukBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton klass_rukBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_klassTextBox;
        private System.Windows.Forms.TextBox name_rukTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.TextBox id_shcoolTextBox;
        private System.Windows.Forms.TextBox name_shcoolTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
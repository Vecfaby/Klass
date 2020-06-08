namespace Klass
{
    partial class FormMenu
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonzapisi = new System.Windows.Forms.Button();
            this.buttonZhur = new System.Windows.Forms.Button();
            this.buttonStud = new System.Windows.Forms.Button();
            this.buttonRuk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonExit.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(329, 412);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(187, 73);
            this.buttonExit.TabIndex = 33;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseCompatibleTextRendering = true;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonzapisi
            // 
            this.buttonzapisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonzapisi.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonzapisi.Location = new System.Drawing.Point(459, 286);
            this.buttonzapisi.Name = "buttonzapisi";
            this.buttonzapisi.Size = new System.Drawing.Size(187, 73);
            this.buttonzapisi.TabIndex = 32;
            this.buttonzapisi.Text = "Учетные записи";
            this.buttonzapisi.UseVisualStyleBackColor = false;
            this.buttonzapisi.Click += new System.EventHandler(this.buttonzapisi_Click);
            // 
            // buttonZhur
            // 
            this.buttonZhur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonZhur.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZhur.Location = new System.Drawing.Point(214, 286);
            this.buttonZhur.Name = "buttonZhur";
            this.buttonZhur.Size = new System.Drawing.Size(187, 73);
            this.buttonZhur.TabIndex = 31;
            this.buttonZhur.Text = "Журнал ТБ";
            this.buttonZhur.UseVisualStyleBackColor = false;
            this.buttonZhur.Click += new System.EventHandler(this.buttonZhur_Click);
            // 
            // buttonStud
            // 
            this.buttonStud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonStud.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStud.Location = new System.Drawing.Point(459, 148);
            this.buttonStud.Name = "buttonStud";
            this.buttonStud.Size = new System.Drawing.Size(187, 73);
            this.buttonStud.TabIndex = 29;
            this.buttonStud.Text = "Учащиеся";
            this.buttonStud.UseVisualStyleBackColor = false;
            this.buttonStud.Click += new System.EventHandler(this.buttonStud_Click);
            // 
            // buttonRuk
            // 
            this.buttonRuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonRuk.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRuk.Location = new System.Drawing.Point(225, 148);
            this.buttonRuk.Name = "buttonRuk";
            this.buttonRuk.Size = new System.Drawing.Size(187, 73);
            this.buttonRuk.TabIndex = 28;
            this.buttonRuk.Text = "Классные руководители";
            this.buttonRuk.UseVisualStyleBackColor = false;
            this.buttonRuk.Click += new System.EventHandler(this.buttonRuk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(322, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 40);
            this.label1.TabIndex = 34;
            this.label1.Text = "Главное меню";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonzapisi);
            this.Controls.Add(this.buttonZhur);
            this.Controls.Add(this.buttonStud);
            this.Controls.Add(this.buttonRuk);
            this.Name = "FormMenu";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonzapisi;
        private System.Windows.Forms.Button buttonZhur;
        private System.Windows.Forms.Button buttonStud;
        private System.Windows.Forms.Button buttonRuk;
        private System.Windows.Forms.Label label1;
    }
}
﻿namespace Klass
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
            this.buttonVneur = new System.Windows.Forms.Button();
            this.buttonStud = new System.Windows.Forms.Button();
            this.buttonRuk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonExit.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(466, 407);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(187, 73);
            this.buttonExit.TabIndex = 33;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseCompatibleTextRendering = true;
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // buttonzapisi
            // 
            this.buttonzapisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonzapisi.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonzapisi.Location = new System.Drawing.Point(187, 407);
            this.buttonzapisi.Name = "buttonzapisi";
            this.buttonzapisi.Size = new System.Drawing.Size(187, 73);
            this.buttonzapisi.TabIndex = 32;
            this.buttonzapisi.Text = "Учетные записи";
            this.buttonzapisi.UseVisualStyleBackColor = false;
            // 
            // buttonZhur
            // 
            this.buttonZhur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonZhur.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZhur.Location = new System.Drawing.Point(187, 274);
            this.buttonZhur.Name = "buttonZhur";
            this.buttonZhur.Size = new System.Drawing.Size(187, 73);
            this.buttonZhur.TabIndex = 31;
            this.buttonZhur.Text = "Журнал ТБ";
            this.buttonZhur.UseVisualStyleBackColor = false;
            this.buttonZhur.Click += new System.EventHandler(this.buttonZhur_Click);
            // 
            // buttonVneur
            // 
            this.buttonVneur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonVneur.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVneur.Location = new System.Drawing.Point(466, 274);
            this.buttonVneur.Name = "buttonVneur";
            this.buttonVneur.Size = new System.Drawing.Size(187, 73);
            this.buttonVneur.TabIndex = 30;
            this.buttonVneur.Text = "Внеурочная деятельность";
            this.buttonVneur.UseVisualStyleBackColor = false;
            this.buttonVneur.Click += new System.EventHandler(this.buttonVneur_Click);
            // 
            // buttonStud
            // 
            this.buttonStud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonStud.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStud.Location = new System.Drawing.Point(466, 142);
            this.buttonStud.Name = "buttonStud";
            this.buttonStud.Size = new System.Drawing.Size(187, 73);
            this.buttonStud.TabIndex = 29;
            this.buttonStud.Text = "Ученики";
            this.buttonStud.UseVisualStyleBackColor = false;
            this.buttonStud.Click += new System.EventHandler(this.buttonStud_Click);
            // 
            // buttonRuk
            // 
            this.buttonRuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonRuk.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRuk.Location = new System.Drawing.Point(187, 142);
            this.buttonRuk.Name = "buttonRuk";
            this.buttonRuk.Size = new System.Drawing.Size(187, 73);
            this.buttonRuk.TabIndex = 28;
            this.buttonRuk.Text = "Классные руководители";
            this.buttonRuk.UseVisualStyleBackColor = false;
            this.buttonRuk.Click += new System.EventHandler(this.buttonRuk_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 623);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonzapisi);
            this.Controls.Add(this.buttonZhur);
            this.Controls.Add(this.buttonVneur);
            this.Controls.Add(this.buttonStud);
            this.Controls.Add(this.buttonRuk);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonzapisi;
        private System.Windows.Forms.Button buttonZhur;
        private System.Windows.Forms.Button buttonVneur;
        private System.Windows.Forms.Button buttonStud;
        private System.Windows.Forms.Button buttonRuk;
    }
}
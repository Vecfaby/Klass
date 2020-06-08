namespace Klass
{
    partial class FormReg
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
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label roleLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.roleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            loginLabel.Location = new System.Drawing.Point(215, 157);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(100, 29);
            loginLabel.TabIndex = 21;
            loginLabel.Text = "Логин:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passwordLabel.Location = new System.Drawing.Point(215, 198);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(114, 29);
            passwordLabel.TabIndex = 22;
            passwordLabel.Text = "Пароль:";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            roleLabel.Location = new System.Drawing.Point(215, 268);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(163, 29);
            roleLabel.TabIndex = 23;
            roleLabel.Text = "Должность:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(727, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 58);
            this.button1.TabIndex = 29;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(437, 151);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(220, 35);
            this.loginTextBox.TabIndex = 28;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(437, 192);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(220, 35);
            this.passwordTextBox.TabIndex = 26;
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonEnter.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter.Location = new System.Drawing.Point(265, 383);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(308, 58);
            this.buttonEnter.TabIndex = 25;
            this.buttonEnter.Text = "Зарегестрироваться";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(761, 80);
            this.label1.TabIndex = 24;
            this.label1.Text = "Для того чтобы зарегестрироваться в программе\r\n                         заполните" +
    " данные";
            // 
            // roleTextBox
            // 
            this.roleTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.roleTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.roleTextBox.BackColor = System.Drawing.Color.White;
            this.roleTextBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleTextBox.Location = new System.Drawing.Point(437, 265);
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.Size = new System.Drawing.Size(220, 35);
            this.roleTextBox.TabIndex = 27;
            this.roleTextBox.TextChanged += new System.EventHandler(this.roleTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(29, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(779, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Напишите \"Руководитель\" и выбрерите нужный класс из предложенных вариантов";
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(901, 515);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.roleTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(loginLabel);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(roleLabel);
            this.Name = "FormReg";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.FormReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roleTextBox;
        private System.Windows.Forms.Label label2;
    }
}
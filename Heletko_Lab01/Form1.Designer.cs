namespace Heletko_Lab01
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.authorizationGroupBox = new System.Windows.Forms.GroupBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.authorizationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // authorizationGroupBox
            // 
            this.authorizationGroupBox.Controls.Add(this.passwordTextBox);
            this.authorizationGroupBox.Controls.Add(this.loginLabel);
            this.authorizationGroupBox.Controls.Add(this.loginTextBox);
            this.authorizationGroupBox.Controls.Add(this.passwordLabel);
            this.authorizationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.authorizationGroupBox.Name = "authorizationGroupBox";
            this.authorizationGroupBox.Size = new System.Drawing.Size(181, 85);
            this.authorizationGroupBox.TabIndex = 0;
            this.authorizationGroupBox.TabStop = false;
            this.authorizationGroupBox.Text = "Авторизація";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(60, 103);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Увійти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(6, 28);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(34, 13);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Логін";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(6, 53);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(45, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Пароль";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(141, 108);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(22, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "ОК";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(57, 25);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(118, 20);
            this.loginTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(57, 51);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(118, 20);
            this.passwordTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 138);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.authorizationGroupBox);
            this.Name = "Form1";
            this.Text = "Авторизація";
            this.authorizationGroupBox.ResumeLayout(false);
            this.authorizationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox authorizationGroupBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label statusLabel;
    }
}


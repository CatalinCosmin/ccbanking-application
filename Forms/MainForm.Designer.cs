
namespace CCBANKING
{
    partial class MainForm
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
            this.StartContainer = new System.Windows.Forms.Panel();
            this.LoginContainer = new System.Windows.Forms.Panel();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.LoginInputButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordInputBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.MainContainer = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.TransferButton = new System.Windows.Forms.Button();
            this.DepositButton = new System.Windows.Forms.Button();
            this.RemoveCardButton = new System.Windows.Forms.Button();
            this.SelectCardButton = new System.Windows.Forms.Button();
            this.AddCardButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ExitAppButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StartContainer.SuspendLayout();
            this.LoginContainer.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartContainer
            // 
            this.StartContainer.Controls.Add(this.LoginContainer);
            this.StartContainer.Controls.Add(this.label1);
            this.StartContainer.Controls.Add(this.ExitButton);
            this.StartContainer.Controls.Add(this.LoginButton);
            this.StartContainer.Location = new System.Drawing.Point(0, 30);
            this.StartContainer.Name = "StartContainer";
            this.StartContainer.Size = new System.Drawing.Size(800, 570);
            this.StartContainer.TabIndex = 0;
            // 
            // LoginContainer
            // 
            this.LoginContainer.Controls.Add(this.ErrorMessageLabel);
            this.LoginContainer.Controls.Add(this.RegisterButton);
            this.LoginContainer.Controls.Add(this.LoginInputButton);
            this.LoginContainer.Controls.Add(this.label4);
            this.LoginContainer.Controls.Add(this.PasswordInputBox);
            this.LoginContainer.Controls.Add(this.label3);
            this.LoginContainer.Controls.Add(this.UsernameInputBox);
            this.LoginContainer.Location = new System.Drawing.Point(0, 0);
            this.LoginContainer.Name = "LoginContainer";
            this.LoginContainer.Size = new System.Drawing.Size(800, 570);
            this.LoginContainer.TabIndex = 3;
            this.LoginContainer.Visible = false;
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ErrorMessageLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(275, 161);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(250, 25);
            this.ErrorMessageLabel.TabIndex = 5;
            this.ErrorMessageLabel.Text = "Username or password is invalid";
            this.ErrorMessageLabel.Visible = false;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RegisterButton.Location = new System.Drawing.Point(211, 348);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(161, 40);
            this.RegisterButton.TabIndex = 0;
            this.RegisterButton.Text = "REGISTER";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginInputButton
            // 
            this.LoginInputButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginInputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginInputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoginInputButton.Location = new System.Drawing.Point(438, 348);
            this.LoginInputButton.Name = "LoginInputButton";
            this.LoginInputButton.Size = new System.Drawing.Size(150, 40);
            this.LoginInputButton.TabIndex = 4;
            this.LoginInputButton.Text = "LOGIN";
            this.LoginInputButton.UseVisualStyleBackColor = false;
            this.LoginInputButton.Click += new System.EventHandler(this.LoginInputButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(206, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // PasswordInputBox
            // 
            this.PasswordInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PasswordInputBox.Location = new System.Drawing.Point(381, 270);
            this.PasswordInputBox.MaxLength = 20;
            this.PasswordInputBox.Name = "PasswordInputBox";
            this.PasswordInputBox.PasswordChar = 'x';
            this.PasswordInputBox.Size = new System.Drawing.Size(207, 30);
            this.PasswordInputBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(206, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            // 
            // UsernameInputBox
            // 
            this.UsernameInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.UsernameInputBox.Location = new System.Drawing.Point(381, 200);
            this.UsernameInputBox.MaxLength = 20;
            this.UsernameInputBox.Name = "UsernameInputBox";
            this.UsernameInputBox.Size = new System.Drawing.Size(207, 30);
            this.UsernameInputBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.Location = new System.Drawing.Point(200, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 80);
            this.label1.TabIndex = 2;
            this.label1.Text = "CC BANKING";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ExitButton.Location = new System.Drawing.Point(300, 324);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(200, 60);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LoginButton.Location = new System.Drawing.Point(300, 256);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(200, 60);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // MainContainer
            // 
            this.MainContainer.Controls.Add(this.label8);
            this.MainContainer.Controls.Add(this.label7);
            this.MainContainer.Controls.Add(this.label6);
            this.MainContainer.Controls.Add(this.SettingsButton);
            this.MainContainer.Controls.Add(this.TransferButton);
            this.MainContainer.Controls.Add(this.DepositButton);
            this.MainContainer.Controls.Add(this.RemoveCardButton);
            this.MainContainer.Controls.Add(this.SelectCardButton);
            this.MainContainer.Controls.Add(this.AddCardButton);
            this.MainContainer.Controls.Add(this.LogoutButton);
            this.MainContainer.Controls.Add(this.label5);
            this.MainContainer.Location = new System.Drawing.Point(0, 30);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(800, 570);
            this.MainContainer.TabIndex = 6;
            this.MainContainer.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(322, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "There are no cards";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(322, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "There are no cards";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(204, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Selected card: * * x x x x";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SettingsButton.Location = new System.Drawing.Point(506, 360);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(210, 50);
            this.SettingsButton.TabIndex = 7;
            this.SettingsButton.Text = "SETTINGS";
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // TransferButton
            // 
            this.TransferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransferButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TransferButton.Location = new System.Drawing.Point(506, 276);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(210, 50);
            this.TransferButton.TabIndex = 6;
            this.TransferButton.Text = "TRANSFER AMOUNT";
            this.TransferButton.UseVisualStyleBackColor = true;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // DepositButton
            // 
            this.DepositButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DepositButton.Location = new System.Drawing.Point(506, 191);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(210, 50);
            this.DepositButton.TabIndex = 5;
            this.DepositButton.Text = "DEPOSIT AMOUNT";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // RemoveCardButton
            // 
            this.RemoveCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.RemoveCardButton.Location = new System.Drawing.Point(94, 360);
            this.RemoveCardButton.Name = "RemoveCardButton";
            this.RemoveCardButton.Size = new System.Drawing.Size(210, 50);
            this.RemoveCardButton.TabIndex = 4;
            this.RemoveCardButton.Text = "REMOVE CARD";
            this.RemoveCardButton.UseVisualStyleBackColor = true;
            this.RemoveCardButton.Click += new System.EventHandler(this.RemoveCardButton_Click);
            // 
            // SelectCardButton
            // 
            this.SelectCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SelectCardButton.Location = new System.Drawing.Point(94, 276);
            this.SelectCardButton.Name = "SelectCardButton";
            this.SelectCardButton.Size = new System.Drawing.Size(210, 50);
            this.SelectCardButton.TabIndex = 3;
            this.SelectCardButton.Text = "SELECT CARD";
            this.SelectCardButton.UseVisualStyleBackColor = true;
            this.SelectCardButton.Click += new System.EventHandler(this.SelectCardButton_Click);
            // 
            // AddCardButton
            // 
            this.AddCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AddCardButton.Location = new System.Drawing.Point(94, 191);
            this.AddCardButton.Name = "AddCardButton";
            this.AddCardButton.Size = new System.Drawing.Size(210, 50);
            this.AddCardButton.TabIndex = 2;
            this.AddCardButton.Text = "ADD CARD";
            this.AddCardButton.UseVisualStyleBackColor = true;
            this.AddCardButton.Click += new System.EventHandler(this.AddCardButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LogoutButton.Location = new System.Drawing.Point(40, 70);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(100, 30);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Text = "LOG OUT";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(40, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(450, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Welcome, USERNAME";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExitAppButton
            // 
            this.ExitAppButton.Location = new System.Drawing.Point(768, 2);
            this.ExitAppButton.Name = "ExitAppButton";
            this.ExitAppButton.Size = new System.Drawing.Size(26, 26);
            this.ExitAppButton.TabIndex = 3;
            this.ExitAppButton.Text = "X";
            this.ExitAppButton.UseVisualStyleBackColor = true;
            this.ExitAppButton.Click += new System.EventHandler(this.ExitAppButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "CCBanking Application";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExitAppButton);
            this.Controls.Add(this.StartContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCBANKING App";
            this.StartContainer.ResumeLayout(false);
            this.LoginContainer.ResumeLayout(false);
            this.LoginContainer.PerformLayout();
            this.MainContainer.ResumeLayout(false);
            this.MainContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StartContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ExitAppButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel LoginContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsernameInputBox;
        private System.Windows.Forms.Button LoginInputButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordInputBox;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.Panel MainContainer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button RemoveCardButton;
        private System.Windows.Forms.Button SelectCardButton;
        private System.Windows.Forms.Button AddCardButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label label8;
    }
}


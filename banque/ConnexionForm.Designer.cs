namespace banque
{
    partial class ConnexionForm
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
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.usernameLabel = new MetroFramework.Controls.MetroLabel();
            this.passwordTextbox = new MetroFramework.Controls.MetroTextBox();
            this.usernameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(407, 168);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(88, 19);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Mot de passe";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(256, 168);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(109, 19);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "Nom d\'utilisateur";
            // 
            // passwordTextbox
            // 
            // 
            // 
            // 
            this.passwordTextbox.CustomButton.Image = null;
            this.passwordTextbox.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.passwordTextbox.CustomButton.Name = "";
            this.passwordTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextbox.CustomButton.TabIndex = 1;
            this.passwordTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextbox.CustomButton.UseSelectable = true;
            this.passwordTextbox.CustomButton.Visible = false;
            this.passwordTextbox.Lines = new string[0];
            this.passwordTextbox.Location = new System.Drawing.Point(407, 190);
            this.passwordTextbox.MaxLength = 32767;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '•';
            this.passwordTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextbox.SelectedText = "";
            this.passwordTextbox.SelectionLength = 0;
            this.passwordTextbox.SelectionStart = 0;
            this.passwordTextbox.ShortcutsEnabled = true;
            this.passwordTextbox.Size = new System.Drawing.Size(109, 23);
            this.passwordTextbox.TabIndex = 7;
            this.passwordTextbox.UseSelectable = true;
            this.passwordTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextbox_KeyDown);
            // 
            // usernameTextbox
            // 
            // 
            // 
            // 
            this.usernameTextbox.CustomButton.Image = null;
            this.usernameTextbox.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.usernameTextbox.CustomButton.Name = "";
            this.usernameTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.usernameTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernameTextbox.CustomButton.TabIndex = 1;
            this.usernameTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameTextbox.CustomButton.UseSelectable = true;
            this.usernameTextbox.CustomButton.Visible = false;
            this.usernameTextbox.Lines = new string[0];
            this.usernameTextbox.Location = new System.Drawing.Point(256, 190);
            this.usernameTextbox.MaxLength = 32767;
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.PasswordChar = '\0';
            this.usernameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameTextbox.SelectedText = "";
            this.usernameTextbox.SelectionLength = 0;
            this.usernameTextbox.SelectionStart = 0;
            this.usernameTextbox.ShortcutsEnabled = true;
            this.usernameTextbox.Size = new System.Drawing.Size(109, 23);
            this.usernameTextbox.TabIndex = 6;
            this.usernameTextbox.UseSelectable = true;
            this.usernameTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernameTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginButton.Location = new System.Drawing.Point(347, 230);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(80, 26);
            this.loginButton.TabIndex = 10;
            this.loginButton.Text = "Se connecter";
            this.loginButton.UseSelectable = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // ConnexionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Name = "ConnexionForm";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroLabel usernameLabel;
        private MetroFramework.Controls.MetroTextBox passwordTextbox;
        private MetroFramework.Controls.MetroTextBox usernameTextbox;
        private MetroFramework.Controls.MetroButton loginButton;
    }
}


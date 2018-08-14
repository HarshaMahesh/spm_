namespace Intern_forms_management_system.Login
{
    partial class LoginUI
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTextBoxUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelUsername = new MetroFramework.Controls.MetroLabel();
            this.metroLabelPassword = new MetroFramework.Controls.MetroLabel();
            this.metroButtonLogin = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroPanel1.Controls.Add(this.metroButtonLogin);
            this.metroPanel1.Controls.Add(this.metroLabelPassword);
            this.metroPanel1.Controls.Add(this.metroLabelUsername);
            this.metroPanel1.Controls.Add(this.metroTextBoxPassword);
            this.metroPanel1.Controls.Add(this.metroTextBoxUsername);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 12);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(776, 426);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTextBoxUsername
            // 
            this.metroTextBoxUsername.Location = new System.Drawing.Point(274, 125);
            this.metroTextBoxUsername.Name = "metroTextBoxUsername";
            this.metroTextBoxUsername.Size = new System.Drawing.Size(206, 23);
            this.metroTextBoxUsername.TabIndex = 2;
            this.metroTextBoxUsername.Text = "metroTextBox1";
            // 
            // metroTextBoxPassword
            // 
            this.metroTextBoxPassword.Location = new System.Drawing.Point(274, 192);
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.Size = new System.Drawing.Size(206, 23);
            this.metroTextBoxPassword.TabIndex = 3;
            this.metroTextBoxPassword.Text = "metroTextBox2";
            // 
            // metroLabelUsername
            // 
            this.metroLabelUsername.AutoSize = true;
            this.metroLabelUsername.Location = new System.Drawing.Point(138, 125);
            this.metroLabelUsername.Name = "metroLabelUsername";
            this.metroLabelUsername.Size = new System.Drawing.Size(68, 19);
            this.metroLabelUsername.TabIndex = 4;
            this.metroLabelUsername.Text = "Username";
            // 
            // metroLabelPassword
            // 
            this.metroLabelPassword.AutoSize = true;
            this.metroLabelPassword.Location = new System.Drawing.Point(138, 192);
            this.metroLabelPassword.Name = "metroLabelPassword";
            this.metroLabelPassword.Size = new System.Drawing.Size(63, 19);
            this.metroLabelPassword.TabIndex = 5;
            this.metroLabelPassword.Text = "Password";
            // 
            // metroButtonLogin
            // 
            this.metroButtonLogin.Location = new System.Drawing.Point(274, 289);
            this.metroButtonLogin.Name = "metroButtonLogin";
            this.metroButtonLogin.Size = new System.Drawing.Size(100, 23);
            this.metroButtonLogin.TabIndex = 6;
            this.metroButtonLogin.Text = "metroButton1";
            this.metroButtonLogin.Click += new System.EventHandler(this.metroButtonLogin_Click);
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanel1);
            this.Name = "LoginUI";
            this.Text = "LoginUI";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxUsername;
        private MetroFramework.Controls.MetroButton metroButtonLogin;
        private MetroFramework.Controls.MetroLabel metroLabelPassword;
        private MetroFramework.Controls.MetroLabel metroLabelUsername;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassword;
    }
}
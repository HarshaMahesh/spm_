namespace Intern_forms_management_system.UIForms
{
    partial class SplashScreen
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.proBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.lblLoging = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // proBar
            // 
            this.proBar.BackColor = System.Drawing.Color.Silver;
            this.proBar.BorderRadius = 5;
            this.proBar.Location = new System.Drawing.Point(274, 231);
            this.proBar.MaximumValue = 100;
            this.proBar.Name = "proBar";
            this.proBar.ProgressColor = System.Drawing.Color.Teal;
            this.proBar.Size = new System.Drawing.Size(410, 10);
            this.proBar.TabIndex = 0;
            this.proBar.Value = 0;
            this.proBar.progressChanged += new System.EventHandler(this.proBar_progressChanged);
            // 
            // lblLoging
            // 
            this.lblLoging.AutoSize = true;
            this.lblLoging.BackColor = System.Drawing.Color.Transparent;
            this.lblLoging.Location = new System.Drawing.Point(133, 228);
            this.lblLoging.Name = "lblLoging";
            this.lblLoging.Size = new System.Drawing.Size(0, 13);
            this.lblLoging.TabIndex = 1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Intern_forms_management_system.Properties.Resources.circular_water_fill_loading_animation1;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Intern_forms_management_system.Properties.Resources.circular_water_fill_loading_animation2;
            this.pictureBox1.Location = new System.Drawing.Point(-21, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::Intern_forms_management_system.Properties.Resources.splash1;
            this.ClientSize = new System.Drawing.Size(696, 300);
            this.ControlBox = false;
            this.Controls.Add(this.lblLoging);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.proBar);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private Bunifu.Framework.UI.BunifuProgressBar proBar;
        private System.Windows.Forms.Label lblLoging;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
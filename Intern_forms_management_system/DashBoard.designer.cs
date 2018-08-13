namespace Car_Rentel_System_v0._1.UI_Forms
{
    partial class DashBoard
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.Elipse = new ns1.BunifuElipse(this.components);
            this.DragControl = new ns1.BunifuDragControl(this.components);
            this.MainPanel = new ns1.BunifuGradientPanel();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SlidePanel = new ns1.BunifuGradientPanel();
            this.btBooking = new ns1.BunifuFlatButton();
            this.DBBackup = new ns1.BunifuFlatButton();
            this.btnMenu2 = new ns1.BunifuImageButton();
            this.btnMenu = new ns1.BunifuImageButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton8 = new ns1.BunifuFlatButton();
            this.User = new ns1.BunifuFlatButton();
            this.bunifuFlatButton5 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton3 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton9 = new ns1.BunifuFlatButton();
            this.Providers = new ns1.BunifuFlatButton();
            this.bunifuFlatButton2 = new ns1.BunifuFlatButton();
            this.Employee = new ns1.BunifuFlatButton();
            this.LogoAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SlidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 5;
            this.Elipse.TargetControl = this;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.MainPanel;
            this.DragControl.Vertical = true;
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.bunifuImageButton1);
            this.LogoAnimation.SetDecoration(this.MainPanel, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.MainPanel, BunifuAnimatorNS.DecorationType.None);
            this.MainPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.MainPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.MainPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.MainPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.MainPanel.Location = new System.Drawing.Point(0, -1);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Quality = 10;
            this.MainPanel.Size = new System.Drawing.Size(1148, 67);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel2_Paint);
            this.MainPanel.MouseEnter += new System.EventHandler(this.MainPanel_MouseEnter);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimation.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1109, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 11;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 30;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.PanelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 1F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation2;
            this.PanelAnimator.MaxAnimationTime = 5500;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.panel2);
            this.LogoAnimation.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 692);
            this.panel1.TabIndex = 2;
            this.panel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel1_Scroll);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.LogoAnimation.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(218, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 451);
            this.panel2.TabIndex = 0;
            // 
            // SlidePanel
            // 
            this.SlidePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SlidePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SlidePanel.BackgroundImage")));
            this.SlidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlidePanel.Controls.Add(this.btBooking);
            this.SlidePanel.Controls.Add(this.DBBackup);
            this.SlidePanel.Controls.Add(this.btnMenu2);
            this.SlidePanel.Controls.Add(this.btnMenu);
            this.SlidePanel.Controls.Add(this.logo);
            this.SlidePanel.Controls.Add(this.bunifuFlatButton8);
            this.SlidePanel.Controls.Add(this.User);
            this.SlidePanel.Controls.Add(this.bunifuFlatButton5);
            this.SlidePanel.Controls.Add(this.bunifuFlatButton3);
            this.SlidePanel.Controls.Add(this.bunifuFlatButton9);
            this.SlidePanel.Controls.Add(this.Providers);
            this.SlidePanel.Controls.Add(this.bunifuFlatButton2);
            this.SlidePanel.Controls.Add(this.Employee);
            this.LogoAnimation.SetDecoration(this.SlidePanel, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.SlidePanel, BunifuAnimatorNS.DecorationType.None);
            this.SlidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidePanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.SlidePanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.SlidePanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.SlidePanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.SlidePanel.Location = new System.Drawing.Point(0, 0);
            this.SlidePanel.Name = "SlidePanel";
            this.SlidePanel.Quality = 10;
            this.SlidePanel.Size = new System.Drawing.Size(220, 692);
            this.SlidePanel.TabIndex = 0;
            this.SlidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SlidePanel_Paint);
            this.SlidePanel.Enter += new System.EventHandler(this.SlidePanel_Enter);
            this.SlidePanel.Leave += new System.EventHandler(this.SlidePanel_Leave);
            this.SlidePanel.MouseEnter += new System.EventHandler(this.SlidePanel_MouseEnter);
            this.SlidePanel.MouseLeave += new System.EventHandler(this.SlidePanel_MouseLeave);
            this.SlidePanel.MouseHover += new System.EventHandler(this.SlidePanel_MouseHover);
            this.SlidePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SlidePanel_MouseMove);
            this.SlidePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SlidePanel_MouseUp);
            // 
            // btBooking
            // 
            this.btBooking.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btBooking.BackColor = System.Drawing.Color.Transparent;
            this.btBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBooking.BorderRadius = 0;
            this.btBooking.ButtonText = "      Booking Managing";
            this.btBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimation.SetDecoration(this.btBooking, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btBooking, BunifuAnimatorNS.DecorationType.None);
            this.btBooking.DisabledColor = System.Drawing.Color.Gray;
            this.btBooking.Iconcolor = System.Drawing.Color.Transparent;
            this.btBooking.Iconimage = ((System.Drawing.Image)(resources.GetObject("btBooking.Iconimage")));
            this.btBooking.Iconimage_right = null;
            this.btBooking.Iconimage_right_Selected = null;
            this.btBooking.Iconimage_Selected = null;
            this.btBooking.IconMarginLeft = 10;
            this.btBooking.IconMarginRight = 0;
            this.btBooking.IconRightVisible = true;
            this.btBooking.IconRightZoom = 0D;
            this.btBooking.IconVisible = true;
            this.btBooking.IconZoom = 80D;
            this.btBooking.IsTab = true;
            this.btBooking.Location = new System.Drawing.Point(-1, 287);
            this.btBooking.Name = "btBooking";
            this.btBooking.Normalcolor = System.Drawing.Color.Transparent;
            this.btBooking.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btBooking.OnHoverTextColor = System.Drawing.Color.White;
            this.btBooking.selected = false;
            this.btBooking.Size = new System.Drawing.Size(221, 48);
            this.btBooking.TabIndex = 13;
            this.btBooking.Text = "      Booking Managing";
            this.btBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBooking.Textcolor = System.Drawing.Color.White;
            this.btBooking.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBooking.Click += new System.EventHandler(this.btBooking_Click);
            // 
            // DBBackup
            // 
            this.DBBackup.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.DBBackup.BackColor = System.Drawing.Color.Transparent;
            this.DBBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DBBackup.BorderRadius = 0;
            this.DBBackup.ButtonText = "      Data Backup";
            this.DBBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimation.SetDecoration(this.DBBackup, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.DBBackup, BunifuAnimatorNS.DecorationType.None);
            this.DBBackup.DisabledColor = System.Drawing.Color.Gray;
            this.DBBackup.Iconcolor = System.Drawing.Color.Transparent;
            this.DBBackup.Iconimage = ((System.Drawing.Image)(resources.GetObject("DBBackup.Iconimage")));
            this.DBBackup.Iconimage_right = null;
            this.DBBackup.Iconimage_right_Selected = null;
            this.DBBackup.Iconimage_Selected = null;
            this.DBBackup.IconMarginLeft = 10;
            this.DBBackup.IconMarginRight = 0;
            this.DBBackup.IconRightVisible = true;
            this.DBBackup.IconRightZoom = 0D;
            this.DBBackup.IconVisible = true;
            this.DBBackup.IconZoom = 80D;
            this.DBBackup.IsTab = true;
            this.DBBackup.Location = new System.Drawing.Point(0, 575);
            this.DBBackup.Name = "DBBackup";
            this.DBBackup.Normalcolor = System.Drawing.Color.Transparent;
            this.DBBackup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.DBBackup.OnHoverTextColor = System.Drawing.Color.White;
            this.DBBackup.selected = false;
            this.DBBackup.Size = new System.Drawing.Size(221, 48);
            this.DBBackup.TabIndex = 11;
            this.DBBackup.Text = "      Data Backup";
            this.DBBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DBBackup.Textcolor = System.Drawing.Color.White;
            this.DBBackup.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBBackup.Click += new System.EventHandler(this.bunifuFlatButton7_Click);
            // 
            // btnMenu2
            // 
            this.btnMenu2.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimation.SetDecoration(this.btnMenu2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnMenu2, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu2.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu2.Image")));
            this.btnMenu2.ImageActive = null;
            this.btnMenu2.Location = new System.Drawing.Point(14, 36);
            this.btnMenu2.Name = "btnMenu2";
            this.btnMenu2.Size = new System.Drawing.Size(27, 23);
            this.btnMenu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu2.TabIndex = 10;
            this.btnMenu2.TabStop = false;
            this.btnMenu2.Zoom = 50;
            this.btnMenu2.Click += new System.EventHandler(this.btnMenu2_Click);
            this.btnMenu2.MouseEnter += new System.EventHandler(this.btnMenu2_MouseEnter);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimation.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(12, 99);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(200, 23);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 30;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMenu_MouseDown);
            this.btnMenu.MouseEnter += new System.EventHandler(this.btnMenu_MouseEnter);
            this.btnMenu.MouseLeave += new System.EventHandler(this.btnMenu_MouseLeave);
            this.btnMenu.MouseHover += new System.EventHandler(this.btnMenu_MouseHover);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(7, 6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(198, 76);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "      Reports";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimation.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton8.Iconimage")));
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 10;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 80D;
            this.bunifuFlatButton8.IsTab = true;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(0, 521);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(221, 48);
            this.bunifuFlatButton8.TabIndex = 9;
            this.bunifuFlatButton8.Text = "      Reports";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton8.Click += new System.EventHandler(this.bunifuFlatButton8_Click);
            // 
            // User
            // 
            this.User.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.User.BorderRadius = 0;
            this.User.ButtonText = "      User Handling";
            this.User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimation.SetDecoration(this.User, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.User, BunifuAnimatorNS.DecorationType.None);
            this.User.DisabledColor = System.Drawing.Color.Gray;
            this.User.Iconcolor = System.Drawing.Color.Transparent;
            this.User.Iconimage = ((System.Drawing.Image)(resources.GetObject("User.Iconimage")));
            this.User.Iconimage_right = null;
            this.User.Iconimage_right_Selected = null;
            this.User.Iconimage_Selected = null;
            this.User.IconMarginLeft = 10;
            this.User.IconMarginRight = 0;
            this.User.IconRightVisible = true;
            this.User.IconRightZoom = 0D;
            this.User.IconVisible = true;
            this.User.IconZoom = 80D;
            this.User.IsTab = true;
            this.User.Location = new System.Drawing.Point(0, 427);
            this.User.Name = "User";
            this.User.Normalcolor = System.Drawing.Color.Transparent;
            this.User.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.User.OnHoverTextColor = System.Drawing.Color.White;
            this.User.selected = false;
            this.User.Size = new System.Drawing.Size(221, 48);
            this.User.TabIndex = 6;
            this.User.Text = "      User Handling";
            this.User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.User.Textcolor = System.Drawing.Color.White;
            this.User.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "      Special Packages";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimation.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 10;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 80D;
            this.bunifuFlatButton5.IsTab = true;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(0, 474);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(221, 48);
            this.bunifuFlatButton5.TabIndex = 5;
            this.bunifuFlatButton5.Text = "      Special Packages";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "      Customer Details";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimation.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 10;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 80D;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 380);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(221, 48);
            this.bunifuFlatButton3.TabIndex = 3;
            this.bunifuFlatButton3.Text = "      Customer Details";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton9
            // 
            this.bunifuFlatButton9.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton9.BorderRadius = 0;
            this.bunifuFlatButton9.ButtonText = "     Log Out";
            this.bunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimation.SetDecoration(this.bunifuFlatButton9, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton9.Iconimage")));
            this.bunifuFlatButton9.Iconimage_right = null;
            this.bunifuFlatButton9.Iconimage_right_Selected = null;
            this.bunifuFlatButton9.Iconimage_Selected = null;
            this.bunifuFlatButton9.IconMarginLeft = 10;
            this.bunifuFlatButton9.IconMarginRight = 0;
            this.bunifuFlatButton9.IconRightVisible = true;
            this.bunifuFlatButton9.IconRightZoom = 0D;
            this.bunifuFlatButton9.IconVisible = true;
            this.bunifuFlatButton9.IconZoom = 80D;
            this.bunifuFlatButton9.IsTab = true;
            this.bunifuFlatButton9.Location = new System.Drawing.Point(0, 145);
            this.bunifuFlatButton9.Name = "bunifuFlatButton9";
            this.bunifuFlatButton9.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.bunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton9.selected = true;
            this.bunifuFlatButton9.Size = new System.Drawing.Size(221, 48);
            this.bunifuFlatButton9.TabIndex = 8;
            this.bunifuFlatButton9.Text = "     Log Out";
            this.bunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton9.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton9.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton9.Click += new System.EventHandler(this.bunifuFlatButton9_Click);
            this.bunifuFlatButton9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton9_MouseClick);
            this.bunifuFlatButton9.MouseEnter += new System.EventHandler(this.bunifuFlatButton9_MouseEnter);
            this.bunifuFlatButton9.MouseLeave += new System.EventHandler(this.bunifuFlatButton9_MouseLeave);
            // 
            // Providers
            // 
            this.Providers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Providers.BackColor = System.Drawing.Color.Transparent;
            this.Providers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Providers.BorderRadius = 0;
            this.Providers.ButtonText = "      Providers Managing";
            this.Providers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimation.SetDecoration(this.Providers, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Providers, BunifuAnimatorNS.DecorationType.None);
            this.Providers.DisabledColor = System.Drawing.Color.Gray;
            this.Providers.Iconcolor = System.Drawing.Color.Transparent;
            this.Providers.Iconimage = ((System.Drawing.Image)(resources.GetObject("Providers.Iconimage")));
            this.Providers.Iconimage_right = null;
            this.Providers.Iconimage_right_Selected = null;
            this.Providers.Iconimage_Selected = null;
            this.Providers.IconMarginLeft = 10;
            this.Providers.IconMarginRight = 0;
            this.Providers.IconRightVisible = true;
            this.Providers.IconRightZoom = 0D;
            this.Providers.IconVisible = true;
            this.Providers.IconZoom = 80D;
            this.Providers.IsTab = true;
            this.Providers.Location = new System.Drawing.Point(0, 333);
            this.Providers.Name = "Providers";
            this.Providers.Normalcolor = System.Drawing.Color.Transparent;
            this.Providers.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.Providers.OnHoverTextColor = System.Drawing.Color.White;
            this.Providers.selected = false;
            this.Providers.Size = new System.Drawing.Size(221, 48);
            this.Providers.TabIndex = 7;
            this.Providers.Text = "      Providers Managing";
            this.Providers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Providers.Textcolor = System.Drawing.Color.White;
            this.Providers.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Providers.Click += new System.EventHandler(this.bunifuFlatButton10_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "      Vehicle Managing";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimation.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 10;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 80D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 239);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(221, 48);
            this.bunifuFlatButton2.TabIndex = 2;
            this.bunifuFlatButton2.Text = "      Vehicle Managing";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // Employee
            // 
            this.Employee.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Employee.BackColor = System.Drawing.Color.Transparent;
            this.Employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Employee.BorderRadius = 0;
            this.Employee.ButtonText = "      Employee Managing";
            this.Employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimation.SetDecoration(this.Employee, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Employee, BunifuAnimatorNS.DecorationType.None);
            this.Employee.DisabledColor = System.Drawing.Color.Gray;
            this.Employee.Iconcolor = System.Drawing.Color.Transparent;
            this.Employee.Iconimage = ((System.Drawing.Image)(resources.GetObject("Employee.Iconimage")));
            this.Employee.Iconimage_right = null;
            this.Employee.Iconimage_right_Selected = null;
            this.Employee.Iconimage_Selected = null;
            this.Employee.IconMarginLeft = 10;
            this.Employee.IconMarginRight = 0;
            this.Employee.IconRightVisible = true;
            this.Employee.IconRightZoom = 0D;
            this.Employee.IconVisible = true;
            this.Employee.IconZoom = 80D;
            this.Employee.IsTab = true;
            this.Employee.Location = new System.Drawing.Point(0, 192);
            this.Employee.Name = "Employee";
            this.Employee.Normalcolor = System.Drawing.Color.Transparent;
            this.Employee.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.Employee.OnHoverTextColor = System.Drawing.Color.White;
            this.Employee.selected = false;
            this.Employee.Size = new System.Drawing.Size(221, 48);
            this.Employee.TabIndex = 1;
            this.Employee.Text = "      Employee Managing";
            this.Employee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Employee.Textcolor = System.Drawing.Color.White;
            this.Employee.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // LogoAnimation
            // 
            this.LogoAnimation.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.LogoAnimation.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.LogoAnimation.DefaultAnimation = animation1;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1149, 692);
            this.Controls.Add(this.SlidePanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.SlidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse Elipse;
        private ns1.BunifuDragControl DragControl;
        private ns1.BunifuGradientPanel MainPanel;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private BunifuAnimatorNS.BunifuTransition LogoAnimation;
        private ns1.BunifuImageButton bunifuImageButton1;
        private ns1.BunifuImageButton btnMenu2;
        private ns1.BunifuImageButton btnMenu;
        private ns1.BunifuFlatButton bunifuFlatButton8;
        private ns1.BunifuFlatButton bunifuFlatButton5;
        private ns1.BunifuFlatButton bunifuFlatButton3;
        private ns1.BunifuFlatButton bunifuFlatButton9;
        private ns1.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuGradientPanel SlidePanel;
        private System.Windows.Forms.PictureBox logo;
        private ns1.BunifuFlatButton btBooking;
        public ns1.BunifuFlatButton User;
        public ns1.BunifuFlatButton Employee;
        public ns1.BunifuFlatButton Providers;
        public ns1.BunifuFlatButton DBBackup;
        private System.Windows.Forms.Panel panel2;
    }
}
namespace SA_PAWN_Company
{
    partial class frmDashboardMaterial
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboardMaterial));
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.MainUC = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnHeader = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNav = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSignOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnReports = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHoliday = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInventory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCustomers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmployees = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStuff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNewPawn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel5 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.profileImg = new System.Windows.Forms.PictureBox();
            this.ucMain1 = new SA_PAWN_Company.UCMain();
            this.MainUC.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.bunifuGradientPanel4.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
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
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.MaxAnimationTime = 500;
            // 
            // MainUC
            // 
            this.MainUC.AutoScroll = true;
            this.MainUC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainUC.BackgroundImage")));
            this.MainUC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainUC.Controls.Add(this.ucMain1);
            this.bunifuTransition1.SetDecoration(this.MainUC, BunifuAnimatorNS.DecorationType.None);
            this.MainUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainUC.GradientBottomLeft = System.Drawing.Color.White;
            this.MainUC.GradientBottomRight = System.Drawing.Color.White;
            this.MainUC.GradientTopLeft = System.Drawing.Color.White;
            this.MainUC.GradientTopRight = System.Drawing.Color.White;
            this.MainUC.Location = new System.Drawing.Point(242, 60);
            this.MainUC.Name = "MainUC";
            this.MainUC.Quality = 10;
            this.MainUC.Size = new System.Drawing.Size(954, 730);
            this.MainUC.TabIndex = 2;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnHeader);
            this.bunifuGradientPanel1.Controls.Add(this.btnNav);
            this.bunifuGradientPanel1.Controls.Add(this.btnMin);
            this.bunifuGradientPanel1.Controls.Add(this.btnClose);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1196, 60);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnHeader
            // 
            this.btnHeader.Activecolor = System.Drawing.Color.Transparent;
            this.btnHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHeader.BackColor = System.Drawing.Color.Transparent;
            this.btnHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHeader.BorderRadius = 0;
            this.btnHeader.ButtonText = "Dashboard";
            this.btnHeader.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuTransition1.SetDecoration(this.btnHeader, BunifuAnimatorNS.DecorationType.None);
            this.btnHeader.DisabledColor = System.Drawing.Color.Gray;
            this.btnHeader.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHeader.Iconimage = null;
            this.btnHeader.Iconimage_right = null;
            this.btnHeader.Iconimage_right_Selected = null;
            this.btnHeader.Iconimage_Selected = null;
            this.btnHeader.IconMarginLeft = 0;
            this.btnHeader.IconMarginRight = 0;
            this.btnHeader.IconRightVisible = true;
            this.btnHeader.IconRightZoom = 0D;
            this.btnHeader.IconVisible = true;
            this.btnHeader.IconZoom = 90D;
            this.btnHeader.IsTab = false;
            this.btnHeader.Location = new System.Drawing.Point(103, 0);
            this.btnHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHeader.Name = "btnHeader";
            this.btnHeader.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHeader.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnHeader.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHeader.selected = false;
            this.btnHeader.Size = new System.Drawing.Size(966, 60);
            this.btnHeader.TabIndex = 3;
            this.btnHeader.Text = "Dashboard";
            this.btnHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHeader.Textcolor = System.Drawing.Color.White;
            this.btnHeader.TextFont = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnNav
            // 
            this.btnNav.BackColor = System.Drawing.Color.Transparent;
            this.btnNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnNav, BunifuAnimatorNS.DecorationType.None);
            this.btnNav.Image = global::SA_PAWN_Company.Properties.Resources.menu;
            this.btnNav.ImageActive = null;
            this.btnNav.Location = new System.Drawing.Point(12, 9);
            this.btnNav.Name = "btnNav";
            this.btnNav.Size = new System.Drawing.Size(45, 45);
            this.btnNav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNav.TabIndex = 2;
            this.btnNav.TabStop = false;
            this.btnNav.Zoom = 10;
            this.btnNav.Click += new System.EventHandler(this.btnNav_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMin, BunifuAnimatorNS.DecorationType.None);
            this.btnMin.Image = global::SA_PAWN_Company.Properties.Resources.remove;
            this.btnMin.ImageActive = null;
            this.btnMin.Location = new System.Drawing.Point(1076, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 35);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 1;
            this.btnMin.TabStop = false;
            this.btnMin.Zoom = 10;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Image = global::SA_PAWN_Company.Properties.Resources.close_button;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1149, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnSignOut.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignOut.BorderRadius = 0;
            this.btnSignOut.ButtonText = " Sign Out";
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnSignOut, BunifuAnimatorNS.DecorationType.None);
            this.btnSignOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnSignOut.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignOut.Iconimage = global::SA_PAWN_Company.Properties.Resources.smartphone1;
            this.btnSignOut.Iconimage_right = null;
            this.btnSignOut.Iconimage_right_Selected = null;
            this.btnSignOut.Iconimage_Selected = null;
            this.btnSignOut.IconMarginLeft = 1;
            this.btnSignOut.IconMarginRight = 0;
            this.btnSignOut.IconRightVisible = true;
            this.btnSignOut.IconRightZoom = 0D;
            this.btnSignOut.IconVisible = true;
            this.btnSignOut.IconZoom = 60D;
            this.btnSignOut.IsTab = true;
            this.btnSignOut.Location = new System.Drawing.Point(1, 456);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnSignOut.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnSignOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSignOut.selected = false;
            this.btnSignOut.Size = new System.Drawing.Size(241, 48);
            this.btnSignOut.TabIndex = 9;
            this.btnSignOut.Text = " Sign Out";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.Textcolor = System.Drawing.Color.White;
            this.btnSignOut.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.Controls.Add(this.bunifuSeparator1);
            this.bunifuGradientPanel4.Controls.Add(this.btnReports);
            this.bunifuGradientPanel4.Controls.Add(this.btnHoliday);
            this.bunifuGradientPanel4.Controls.Add(this.btnInventory);
            this.bunifuGradientPanel4.Controls.Add(this.btnCustomers);
            this.bunifuGradientPanel4.Controls.Add(this.btnEmployees);
            this.bunifuGradientPanel4.Controls.Add(this.btnStuff);
            this.bunifuGradientPanel4.Controls.Add(this.btnHome);
            this.bunifuGradientPanel4.Controls.Add(this.btnNewPawn);
            this.bunifuGradientPanel4.Controls.Add(this.btnSignOut);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(0, 217);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(242, 501);
            this.bunifuGradientPanel4.TabIndex = 10;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, -14);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(241, 13);
            this.bunifuSeparator1.TabIndex = 12;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnReports
            // 
            this.btnReports.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnReports.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReports.BorderRadius = 0;
            this.btnReports.ButtonText = " Reports";
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnReports, BunifuAnimatorNS.DecorationType.None);
            this.btnReports.DisabledColor = System.Drawing.Color.Gray;
            this.btnReports.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReports.Iconimage = global::SA_PAWN_Company.Properties.Resources.badge;
            this.btnReports.Iconimage_right = null;
            this.btnReports.Iconimage_right_Selected = null;
            this.btnReports.Iconimage_Selected = null;
            this.btnReports.IconMarginLeft = 1;
            this.btnReports.IconMarginRight = 0;
            this.btnReports.IconRightVisible = true;
            this.btnReports.IconRightZoom = 0D;
            this.btnReports.IconVisible = true;
            this.btnReports.IconZoom = 60D;
            this.btnReports.IsTab = true;
            this.btnReports.Location = new System.Drawing.Point(0, 344);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnReports.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnReports.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReports.selected = false;
            this.btnReports.Size = new System.Drawing.Size(241, 48);
            this.btnReports.TabIndex = 18;
            this.btnReports.Text = " Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Textcolor = System.Drawing.Color.White;
            this.btnReports.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnHoliday
            // 
            this.btnHoliday.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnHoliday.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHoliday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHoliday.BorderRadius = 0;
            this.btnHoliday.ButtonText = " Holidays";
            this.btnHoliday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnHoliday, BunifuAnimatorNS.DecorationType.None);
            this.btnHoliday.DisabledColor = System.Drawing.Color.Gray;
            this.btnHoliday.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoliday.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHoliday.Iconimage = global::SA_PAWN_Company.Properties.Resources.calendar;
            this.btnHoliday.Iconimage_right = null;
            this.btnHoliday.Iconimage_right_Selected = null;
            this.btnHoliday.Iconimage_Selected = null;
            this.btnHoliday.IconMarginLeft = 1;
            this.btnHoliday.IconMarginRight = 0;
            this.btnHoliday.IconRightVisible = true;
            this.btnHoliday.IconRightZoom = 0D;
            this.btnHoliday.IconVisible = true;
            this.btnHoliday.IconZoom = 60D;
            this.btnHoliday.IsTab = true;
            this.btnHoliday.Location = new System.Drawing.Point(1, 400);
            this.btnHoliday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHoliday.Name = "btnHoliday";
            this.btnHoliday.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnHoliday.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnHoliday.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHoliday.selected = false;
            this.btnHoliday.Size = new System.Drawing.Size(241, 48);
            this.btnHoliday.TabIndex = 17;
            this.btnHoliday.Text = " Holidays";
            this.btnHoliday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoliday.Textcolor = System.Drawing.Color.White;
            this.btnHoliday.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnInventory
            // 
            this.btnInventory.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnInventory.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventory.BorderRadius = 0;
            this.btnInventory.ButtonText = " Inventory";
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnInventory, BunifuAnimatorNS.DecorationType.None);
            this.btnInventory.DisabledColor = System.Drawing.Color.Gray;
            this.btnInventory.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInventory.Iconimage = global::SA_PAWN_Company.Properties.Resources.hospital_supplies;
            this.btnInventory.Iconimage_right = null;
            this.btnInventory.Iconimage_right_Selected = null;
            this.btnInventory.Iconimage_Selected = null;
            this.btnInventory.IconMarginLeft = 1;
            this.btnInventory.IconMarginRight = 0;
            this.btnInventory.IconRightVisible = true;
            this.btnInventory.IconRightZoom = 0D;
            this.btnInventory.IconVisible = true;
            this.btnInventory.IconZoom = 60D;
            this.btnInventory.IsTab = true;
            this.btnInventory.Location = new System.Drawing.Point(0, 288);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnInventory.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnInventory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInventory.selected = false;
            this.btnInventory.Size = new System.Drawing.Size(241, 48);
            this.btnInventory.TabIndex = 16;
            this.btnInventory.Text = " Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Textcolor = System.Drawing.Color.White;
            this.btnInventory.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCustomers
            // 
            this.btnCustomers.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnCustomers.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomers.BorderRadius = 0;
            this.btnCustomers.ButtonText = " Customers";
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnCustomers, BunifuAnimatorNS.DecorationType.None);
            this.btnCustomers.DisabledColor = System.Drawing.Color.Gray;
            this.btnCustomers.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCustomers.Iconimage = global::SA_PAWN_Company.Properties.Resources.clerk_with_tie;
            this.btnCustomers.Iconimage_right = null;
            this.btnCustomers.Iconimage_right_Selected = null;
            this.btnCustomers.Iconimage_Selected = null;
            this.btnCustomers.IconMarginLeft = 1;
            this.btnCustomers.IconMarginRight = 0;
            this.btnCustomers.IconRightVisible = true;
            this.btnCustomers.IconRightZoom = 0D;
            this.btnCustomers.IconVisible = true;
            this.btnCustomers.IconZoom = 60D;
            this.btnCustomers.IsTab = true;
            this.btnCustomers.Location = new System.Drawing.Point(0, 232);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnCustomers.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnCustomers.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCustomers.selected = false;
            this.btnCustomers.Size = new System.Drawing.Size(241, 48);
            this.btnCustomers.TabIndex = 15;
            this.btnCustomers.Text = " Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Textcolor = System.Drawing.Color.White;
            this.btnCustomers.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnEmployees
            // 
            this.btnEmployees.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnEmployees.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployees.BorderRadius = 0;
            this.btnEmployees.ButtonText = " Employees";
            this.btnEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnEmployees, BunifuAnimatorNS.DecorationType.None);
            this.btnEmployees.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmployees.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmployees.Iconimage = global::SA_PAWN_Company.Properties.Resources.users;
            this.btnEmployees.Iconimage_right = null;
            this.btnEmployees.Iconimage_right_Selected = null;
            this.btnEmployees.Iconimage_Selected = null;
            this.btnEmployees.IconMarginLeft = 1;
            this.btnEmployees.IconMarginRight = 0;
            this.btnEmployees.IconRightVisible = true;
            this.btnEmployees.IconRightZoom = 0D;
            this.btnEmployees.IconVisible = true;
            this.btnEmployees.IconZoom = 60D;
            this.btnEmployees.IsTab = true;
            this.btnEmployees.Location = new System.Drawing.Point(1, 176);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnEmployees.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnEmployees.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmployees.selected = false;
            this.btnEmployees.Size = new System.Drawing.Size(241, 48);
            this.btnEmployees.TabIndex = 14;
            this.btnEmployees.Text = " Employees";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Textcolor = System.Drawing.Color.White;
            this.btnEmployees.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnStuff
            // 
            this.btnStuff.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnStuff.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStuff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStuff.BorderRadius = 0;
            this.btnStuff.ButtonText = " Stuff Pawn";
            this.btnStuff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnStuff, BunifuAnimatorNS.DecorationType.None);
            this.btnStuff.DisabledColor = System.Drawing.Color.Gray;
            this.btnStuff.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuff.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStuff.Iconimage = global::SA_PAWN_Company.Properties.Resources.shopping_cart__1_;
            this.btnStuff.Iconimage_right = null;
            this.btnStuff.Iconimage_right_Selected = null;
            this.btnStuff.Iconimage_Selected = null;
            this.btnStuff.IconMarginLeft = 1;
            this.btnStuff.IconMarginRight = 0;
            this.btnStuff.IconRightVisible = true;
            this.btnStuff.IconRightZoom = 0D;
            this.btnStuff.IconVisible = true;
            this.btnStuff.IconZoom = 60D;
            this.btnStuff.IsTab = true;
            this.btnStuff.Location = new System.Drawing.Point(1, 120);
            this.btnStuff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStuff.Name = "btnStuff";
            this.btnStuff.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnStuff.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnStuff.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStuff.selected = false;
            this.btnStuff.Size = new System.Drawing.Size(241, 48);
            this.btnStuff.TabIndex = 13;
            this.btnStuff.Text = " Stuff Pawn";
            this.btnStuff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStuff.Textcolor = System.Drawing.Color.White;
            this.btnStuff.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnHome.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = " Dashboard";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = global::SA_PAWN_Company.Properties.Resources.home;
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 1;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 60D;
            this.btnHome.IsTab = true;
            this.btnHome.Location = new System.Drawing.Point(1, 8);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnHome.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHome.selected = true;
            this.btnHome.Size = new System.Drawing.Size(241, 48);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = " Dashboard";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.White;
            this.btnHome.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnNewPawn
            // 
            this.btnNewPawn.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnNewPawn.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewPawn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewPawn.BorderRadius = 0;
            this.btnNewPawn.ButtonText = " New Pawn";
            this.btnNewPawn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnNewPawn, BunifuAnimatorNS.DecorationType.None);
            this.btnNewPawn.DisabledColor = System.Drawing.Color.Gray;
            this.btnNewPawn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPawn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewPawn.Iconimage = global::SA_PAWN_Company.Properties.Resources.pawn;
            this.btnNewPawn.Iconimage_right = null;
            this.btnNewPawn.Iconimage_right_Selected = null;
            this.btnNewPawn.Iconimage_Selected = null;
            this.btnNewPawn.IconMarginLeft = 1;
            this.btnNewPawn.IconMarginRight = 0;
            this.btnNewPawn.IconRightVisible = true;
            this.btnNewPawn.IconRightZoom = 0D;
            this.btnNewPawn.IconVisible = true;
            this.btnNewPawn.IconZoom = 60D;
            this.btnNewPawn.IsTab = true;
            this.btnNewPawn.Location = new System.Drawing.Point(1, 64);
            this.btnNewPawn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewPawn.Name = "btnNewPawn";
            this.btnNewPawn.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnNewPawn.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnNewPawn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNewPawn.selected = false;
            this.btnNewPawn.Size = new System.Drawing.Size(241, 48);
            this.btnNewPawn.TabIndex = 12;
            this.btnNewPawn.Text = " New Pawn";
            this.btnNewPawn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewPawn.Textcolor = System.Drawing.Color.White;
            this.btnNewPawn.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPawn.Click += new System.EventHandler(this.btnNewPawn_Click);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.bunifuGradientPanel5);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuGradientPanel4);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Gainsboro;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 60);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(242, 730);
            this.bunifuGradientPanel2.TabIndex = 1;
            // 
            // bunifuGradientPanel5
            // 
            this.bunifuGradientPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel5.BackgroundImage")));
            this.bunifuGradientPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel5.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel5.Controls.Add(this.profileImg);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel5.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel5.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel5.Location = new System.Drawing.Point(1, 0);
            this.bunifuGradientPanel5.Name = "bunifuGradientPanel5";
            this.bunifuGradientPanel5.Quality = 10;
            this.bunifuGradientPanel5.Size = new System.Drawing.Size(241, 211);
            this.bunifuGradientPanel5.TabIndex = 11;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(41, 172);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(158, 29);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Chea Sambo";
            // 
            // profileImg
            // 
            this.profileImg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.profileImg.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.profileImg, BunifuAnimatorNS.DecorationType.None);
            this.profileImg.Image = global::SA_PAWN_Company.Properties.Resources.logo;
            this.profileImg.Location = new System.Drawing.Point(46, 7);
            this.profileImg.Name = "profileImg";
            this.profileImg.Size = new System.Drawing.Size(150, 150);
            this.profileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileImg.TabIndex = 3;
            this.profileImg.TabStop = false;
            // 
            // ucMain1
            // 
            this.bunifuTransition1.SetDecoration(this.ucMain1, BunifuAnimatorNS.DecorationType.None);
            this.ucMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMain1.Location = new System.Drawing.Point(0, 0);
            this.ucMain1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ucMain1.Name = "ucMain1";
            this.ucMain1.Size = new System.Drawing.Size(954, 730);
            this.ucMain1.TabIndex = 0;
            // 
            // frmDashboardMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1196, 790);
            this.Controls.Add(this.MainUC);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDashboardMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainUC.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel5.ResumeLayout(false);
            this.bunifuGradientPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMin;
        private Bunifu.Framework.UI.BunifuImageButton btnNav;
        private Bunifu.Framework.UI.BunifuGradientPanel MainUC;
        private Bunifu.Framework.UI.BunifuFlatButton btnHeader;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private UCMain ucMain1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignOut;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton btnReports;
        private Bunifu.Framework.UI.BunifuFlatButton btnHoliday;
        private Bunifu.Framework.UI.BunifuFlatButton btnInventory;
        private Bunifu.Framework.UI.BunifuFlatButton btnCustomers;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmployees;
        private Bunifu.Framework.UI.BunifuFlatButton btnStuff;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewPawn;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox profileImg;
    }
}
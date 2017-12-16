namespace SA_PAWN_Company
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panHeader = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnNav = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panNav = new System.Windows.Forms.Panel();
            this.panMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNewPawn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStuff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInventory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCustomers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmployees = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReports = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHoliday = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSignOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panProfile = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Button();
            this.proImage = new System.Windows.Forms.PictureBox();
            this.panContent = new System.Windows.Forms.Panel();
            this.bTran = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panNav.SuspendLayout();
            this.panMenu.SuspendLayout();
            this.panProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.panHeader.Controls.Add(this.lbTitle);
            this.panHeader.Controls.Add(this.btnNav);
            this.panHeader.Controls.Add(this.btnMin);
            this.panHeader.Controls.Add(this.btnClose);
            this.bTran.SetDecoration(this.panHeader, BunifuAnimatorNS.DecorationType.None);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(1260, 79);
            this.panHeader.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.bTran.SetDecoration(this.lbTitle, BunifuAnimatorNS.DecorationType.None);
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(109, 21);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(166, 34);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "Dashboard";
            // 
            // btnNav
            // 
            this.btnNav.BackColor = System.Drawing.Color.Transparent;
            this.btnNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTran.SetDecoration(this.btnNav, BunifuAnimatorNS.DecorationType.None);
            this.btnNav.Image = global::SA_PAWN_Company.Properties.Resources.menu;
            this.btnNav.ImageActive = null;
            this.btnNav.Location = new System.Drawing.Point(36, 17);
            this.btnNav.Name = "btnNav";
            this.btnNav.Size = new System.Drawing.Size(45, 45);
            this.btnNav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNav.TabIndex = 5;
            this.btnNav.TabStop = false;
            this.btnNav.Zoom = 10;
            this.btnNav.Click += new System.EventHandler(this.btnNav_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTran.SetDecoration(this.btnMin, BunifuAnimatorNS.DecorationType.None);
            this.btnMin.Image = global::SA_PAWN_Company.Properties.Resources.remove;
            this.btnMin.ImageActive = null;
            this.btnMin.Location = new System.Drawing.Point(1116, 20);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 35);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 4;
            this.btnMin.TabStop = false;
            this.btnMin.Zoom = 10;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTran.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Image = global::SA_PAWN_Company.Properties.Resources.close_button;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1189, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panNav
            // 
            this.panNav.Controls.Add(this.panMenu);
            this.panNav.Controls.Add(this.panProfile);
            this.bTran.SetDecoration(this.panNav, BunifuAnimatorNS.DecorationType.None);
            this.panNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panNav.Location = new System.Drawing.Point(0, 79);
            this.panNav.Name = "panNav";
            this.panNav.Size = new System.Drawing.Size(269, 719);
            this.panNav.TabIndex = 1;
            // 
            // panMenu
            // 
            this.panMenu.Controls.Add(this.btnHome);
            this.panMenu.Controls.Add(this.btnNewPawn);
            this.panMenu.Controls.Add(this.btnStuff);
            this.panMenu.Controls.Add(this.btnInventory);
            this.panMenu.Controls.Add(this.btnCustomers);
            this.panMenu.Controls.Add(this.btnEmployees);
            this.panMenu.Controls.Add(this.btnReports);
            this.panMenu.Controls.Add(this.btnHoliday);
            this.panMenu.Controls.Add(this.btnSignOut);
            this.bTran.SetDecoration(this.panMenu, BunifuAnimatorNS.DecorationType.None);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panMenu.Location = new System.Drawing.Point(0, 199);
            this.panMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(269, 520);
            this.panMenu.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHome.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = " Dashboard";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTran.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = global::SA_PAWN_Company.Properties.Resources.home;
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 15;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 60D;
            this.btnHome.IsTab = true;
            this.btnHome.Location = new System.Drawing.Point(4, 4);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnHome.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHome.selected = true;
            this.btnHome.Size = new System.Drawing.Size(258, 48);
            this.btnHome.TabIndex = 29;
            this.btnHome.Tag = "home";
            this.btnHome.Text = " Dashboard";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.White;
            this.btnHome.TextFont = new System.Drawing.Font("AKbalthom KhmerLer", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Visible = false;
            // 
            // btnNewPawn
            // 
            this.btnNewPawn.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnNewPawn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNewPawn.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewPawn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewPawn.BorderRadius = 0;
            this.btnNewPawn.ButtonText = " New Pawn";
            this.btnNewPawn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTran.SetDecoration(this.btnNewPawn, BunifuAnimatorNS.DecorationType.None);
            this.btnNewPawn.DisabledColor = System.Drawing.Color.Gray;
            this.btnNewPawn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPawn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewPawn.Iconimage = global::SA_PAWN_Company.Properties.Resources.pawn;
            this.btnNewPawn.Iconimage_right = null;
            this.btnNewPawn.Iconimage_right_Selected = null;
            this.btnNewPawn.Iconimage_Selected = null;
            this.btnNewPawn.IconMarginLeft = 15;
            this.btnNewPawn.IconMarginRight = 0;
            this.btnNewPawn.IconRightVisible = true;
            this.btnNewPawn.IconRightZoom = 0D;
            this.btnNewPawn.IconVisible = true;
            this.btnNewPawn.IconZoom = 60D;
            this.btnNewPawn.IsTab = true;
            this.btnNewPawn.Location = new System.Drawing.Point(4, 60);
            this.btnNewPawn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewPawn.Name = "btnNewPawn";
            this.btnNewPawn.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnNewPawn.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnNewPawn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNewPawn.selected = false;
            this.btnNewPawn.Size = new System.Drawing.Size(258, 48);
            this.btnNewPawn.TabIndex = 30;
            this.btnNewPawn.Tag = "pawn";
            this.btnNewPawn.Text = " New Pawn";
            this.btnNewPawn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewPawn.Textcolor = System.Drawing.Color.White;
            this.btnNewPawn.TextFont = new System.Drawing.Font("AKbalthom KhmerLer", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPawn.Visible = false;
            // 
            // btnStuff
            // 
            this.btnStuff.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnStuff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStuff.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStuff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStuff.BorderRadius = 0;
            this.btnStuff.ButtonText = " Stuff Pawn";
            this.btnStuff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTran.SetDecoration(this.btnStuff, BunifuAnimatorNS.DecorationType.None);
            this.btnStuff.DisabledColor = System.Drawing.Color.Gray;
            this.btnStuff.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuff.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStuff.Iconimage = global::SA_PAWN_Company.Properties.Resources.shopping_cart__1_;
            this.btnStuff.Iconimage_right = null;
            this.btnStuff.Iconimage_right_Selected = null;
            this.btnStuff.Iconimage_Selected = null;
            this.btnStuff.IconMarginLeft = 15;
            this.btnStuff.IconMarginRight = 0;
            this.btnStuff.IconRightVisible = true;
            this.btnStuff.IconRightZoom = 0D;
            this.btnStuff.IconVisible = true;
            this.btnStuff.IconZoom = 60D;
            this.btnStuff.IsTab = true;
            this.btnStuff.Location = new System.Drawing.Point(4, 116);
            this.btnStuff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStuff.Name = "btnStuff";
            this.btnStuff.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnStuff.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnStuff.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStuff.selected = false;
            this.btnStuff.Size = new System.Drawing.Size(258, 48);
            this.btnStuff.TabIndex = 31;
            this.btnStuff.Tag = "stuff";
            this.btnStuff.Text = " Stuff Pawn";
            this.btnStuff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStuff.Textcolor = System.Drawing.Color.White;
            this.btnStuff.TextFont = new System.Drawing.Font("AKbalthom KhmerLer", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuff.Visible = false;
            // 
            // btnInventory
            // 
            this.btnInventory.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnInventory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInventory.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventory.BorderRadius = 0;
            this.btnInventory.ButtonText = " Inventory";
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTran.SetDecoration(this.btnInventory, BunifuAnimatorNS.DecorationType.None);
            this.btnInventory.DisabledColor = System.Drawing.Color.Gray;
            this.btnInventory.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInventory.Iconimage = global::SA_PAWN_Company.Properties.Resources.hospital_supplies;
            this.btnInventory.Iconimage_right = null;
            this.btnInventory.Iconimage_right_Selected = null;
            this.btnInventory.Iconimage_Selected = null;
            this.btnInventory.IconMarginLeft = 15;
            this.btnInventory.IconMarginRight = 0;
            this.btnInventory.IconRightVisible = true;
            this.btnInventory.IconRightZoom = 0D;
            this.btnInventory.IconVisible = true;
            this.btnInventory.IconZoom = 60D;
            this.btnInventory.IsTab = true;
            this.btnInventory.Location = new System.Drawing.Point(4, 172);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnInventory.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnInventory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInventory.selected = false;
            this.btnInventory.Size = new System.Drawing.Size(258, 48);
            this.btnInventory.TabIndex = 34;
            this.btnInventory.Tag = "inventory";
            this.btnInventory.Text = " Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Textcolor = System.Drawing.Color.White;
            this.btnInventory.TextFont = new System.Drawing.Font("AKbalthom KhmerLer", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Visible = false;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnCustomers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCustomers.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomers.BorderRadius = 0;
            this.btnCustomers.ButtonText = " Customers";
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTran.SetDecoration(this.btnCustomers, BunifuAnimatorNS.DecorationType.None);
            this.btnCustomers.DisabledColor = System.Drawing.Color.Gray;
            this.btnCustomers.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCustomers.Iconimage = global::SA_PAWN_Company.Properties.Resources.clerk_with_tie;
            this.btnCustomers.Iconimage_right = null;
            this.btnCustomers.Iconimage_right_Selected = null;
            this.btnCustomers.Iconimage_Selected = null;
            this.btnCustomers.IconMarginLeft = 15;
            this.btnCustomers.IconMarginRight = 0;
            this.btnCustomers.IconRightVisible = true;
            this.btnCustomers.IconRightZoom = 0D;
            this.btnCustomers.IconVisible = true;
            this.btnCustomers.IconZoom = 60D;
            this.btnCustomers.IsTab = true;
            this.btnCustomers.Location = new System.Drawing.Point(4, 228);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnCustomers.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnCustomers.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCustomers.selected = false;
            this.btnCustomers.Size = new System.Drawing.Size(258, 48);
            this.btnCustomers.TabIndex = 33;
            this.btnCustomers.Tag = "customer";
            this.btnCustomers.Text = " Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Textcolor = System.Drawing.Color.White;
            this.btnCustomers.TextFont = new System.Drawing.Font("AKbalthom KhmerLer", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Visible = false;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnEmployees.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEmployees.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployees.BorderRadius = 0;
            this.btnEmployees.ButtonText = " Employees";
            this.btnEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTran.SetDecoration(this.btnEmployees, BunifuAnimatorNS.DecorationType.None);
            this.btnEmployees.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmployees.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmployees.Iconimage = global::SA_PAWN_Company.Properties.Resources.users;
            this.btnEmployees.Iconimage_right = null;
            this.btnEmployees.Iconimage_right_Selected = null;
            this.btnEmployees.Iconimage_Selected = null;
            this.btnEmployees.IconMarginLeft = 15;
            this.btnEmployees.IconMarginRight = 0;
            this.btnEmployees.IconRightVisible = true;
            this.btnEmployees.IconRightZoom = 0D;
            this.btnEmployees.IconVisible = true;
            this.btnEmployees.IconZoom = 60D;
            this.btnEmployees.IsTab = true;
            this.btnEmployees.Location = new System.Drawing.Point(4, 284);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnEmployees.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnEmployees.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmployees.selected = false;
            this.btnEmployees.Size = new System.Drawing.Size(258, 48);
            this.btnEmployees.TabIndex = 32;
            this.btnEmployees.Tag = "employee";
            this.btnEmployees.Text = " Employees";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Textcolor = System.Drawing.Color.White;
            this.btnEmployees.TextFont = new System.Drawing.Font("AKbalthom KhmerLer", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.Visible = false;
            // 
            // btnReports
            // 
            this.btnReports.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnReports.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReports.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReports.BorderRadius = 0;
            this.btnReports.ButtonText = " Reports";
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTran.SetDecoration(this.btnReports, BunifuAnimatorNS.DecorationType.None);
            this.btnReports.DisabledColor = System.Drawing.Color.Gray;
            this.btnReports.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReports.Iconimage = global::SA_PAWN_Company.Properties.Resources.badge;
            this.btnReports.Iconimage_right = null;
            this.btnReports.Iconimage_right_Selected = null;
            this.btnReports.Iconimage_Selected = null;
            this.btnReports.IconMarginLeft = 15;
            this.btnReports.IconMarginRight = 0;
            this.btnReports.IconRightVisible = true;
            this.btnReports.IconRightZoom = 0D;
            this.btnReports.IconVisible = true;
            this.btnReports.IconZoom = 60D;
            this.btnReports.IsTab = true;
            this.btnReports.Location = new System.Drawing.Point(4, 340);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnReports.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnReports.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReports.selected = false;
            this.btnReports.Size = new System.Drawing.Size(258, 48);
            this.btnReports.TabIndex = 36;
            this.btnReports.Tag = "report";
            this.btnReports.Text = " Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Textcolor = System.Drawing.Color.White;
            this.btnReports.TextFont = new System.Drawing.Font("AKbalthom KhmerLer", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Visible = false;
            // 
            // btnHoliday
            // 
            this.btnHoliday.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnHoliday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHoliday.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHoliday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHoliday.BorderRadius = 0;
            this.btnHoliday.ButtonText = " Holidays";
            this.btnHoliday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTran.SetDecoration(this.btnHoliday, BunifuAnimatorNS.DecorationType.None);
            this.btnHoliday.DisabledColor = System.Drawing.Color.Gray;
            this.btnHoliday.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoliday.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHoliday.Iconimage = global::SA_PAWN_Company.Properties.Resources.calendar;
            this.btnHoliday.Iconimage_right = null;
            this.btnHoliday.Iconimage_right_Selected = null;
            this.btnHoliday.Iconimage_Selected = null;
            this.btnHoliday.IconMarginLeft = 15;
            this.btnHoliday.IconMarginRight = 0;
            this.btnHoliday.IconRightVisible = true;
            this.btnHoliday.IconRightZoom = 0D;
            this.btnHoliday.IconVisible = true;
            this.btnHoliday.IconZoom = 60D;
            this.btnHoliday.IsTab = true;
            this.btnHoliday.Location = new System.Drawing.Point(4, 396);
            this.btnHoliday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHoliday.Name = "btnHoliday";
            this.btnHoliday.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnHoliday.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnHoliday.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHoliday.selected = false;
            this.btnHoliday.Size = new System.Drawing.Size(258, 48);
            this.btnHoliday.TabIndex = 35;
            this.btnHoliday.Tag = "holiday";
            this.btnHoliday.Text = " Holidays";
            this.btnHoliday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoliday.Textcolor = System.Drawing.Color.White;
            this.btnHoliday.TextFont = new System.Drawing.Font("AKbalthom KhmerLer", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoliday.Visible = false;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Activecolor = System.Drawing.Color.Crimson;
            this.btnSignOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSignOut.BackColor = System.Drawing.Color.Crimson;
            this.btnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignOut.BorderRadius = 0;
            this.btnSignOut.ButtonText = " Sign Out";
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTran.SetDecoration(this.btnSignOut, BunifuAnimatorNS.DecorationType.None);
            this.btnSignOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnSignOut.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignOut.Iconimage = global::SA_PAWN_Company.Properties.Resources.smartphone1;
            this.btnSignOut.Iconimage_right = null;
            this.btnSignOut.Iconimage_right_Selected = null;
            this.btnSignOut.Iconimage_Selected = null;
            this.btnSignOut.IconMarginLeft = 15;
            this.btnSignOut.IconMarginRight = 0;
            this.btnSignOut.IconRightVisible = true;
            this.btnSignOut.IconRightZoom = 0D;
            this.btnSignOut.IconVisible = true;
            this.btnSignOut.IconZoom = 60D;
            this.btnSignOut.IsTab = true;
            this.btnSignOut.Location = new System.Drawing.Point(4, 452);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Normalcolor = System.Drawing.Color.Crimson;
            this.btnSignOut.OnHovercolor = System.Drawing.Color.DarkRed;
            this.btnSignOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSignOut.selected = false;
            this.btnSignOut.Size = new System.Drawing.Size(258, 48);
            this.btnSignOut.TabIndex = 28;
            this.btnSignOut.Tag = "signout";
            this.btnSignOut.Text = " Sign Out";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.Textcolor = System.Drawing.Color.White;
            this.btnSignOut.TextFont = new System.Drawing.Font("AKbalthom KhmerLer", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Visible = false;
            // 
            // panProfile
            // 
            this.panProfile.BackColor = System.Drawing.Color.Transparent;
            this.panProfile.Controls.Add(this.lbUsername);
            this.panProfile.Controls.Add(this.proImage);
            this.bTran.SetDecoration(this.panProfile, BunifuAnimatorNS.DecorationType.None);
            this.panProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panProfile.Location = new System.Drawing.Point(0, 0);
            this.panProfile.Name = "panProfile";
            this.panProfile.Size = new System.Drawing.Size(269, 199);
            this.panProfile.TabIndex = 1;
            // 
            // lbUsername
            // 
            this.lbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bTran.SetDecoration(this.lbUsername, BunifuAnimatorNS.DecorationType.None);
            this.lbUsername.FlatAppearance.BorderSize = 0;
            this.lbUsername.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lbUsername.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.lbUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbUsername.Location = new System.Drawing.Point(3, 137);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(263, 48);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "Chea Sambo";
            this.lbUsername.UseVisualStyleBackColor = true;
            // 
            // proImage
            // 
            this.proImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bTran.SetDecoration(this.proImage, BunifuAnimatorNS.DecorationType.None);
            this.proImage.Image = global::SA_PAWN_Company.Properties.Resources.logo;
            this.proImage.Location = new System.Drawing.Point(74, 15);
            this.proImage.Name = "proImage";
            this.proImage.Size = new System.Drawing.Size(112, 116);
            this.proImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.proImage.TabIndex = 0;
            this.proImage.TabStop = false;
            // 
            // panContent
            // 
            this.panContent.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bTran.SetDecoration(this.panContent, BunifuAnimatorNS.DecorationType.None);
            this.panContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContent.Location = new System.Drawing.Point(269, 79);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(991, 719);
            this.panContent.TabIndex = 2;
            // 
            // bTran
            // 
            this.bTran.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bTran.Cursor = null;
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
            this.bTran.DefaultAnimation = animation1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 798);
            this.ControlBox = false;
            this.Controls.Add(this.panContent);
            this.Controls.Add(this.panNav);
            this.Controls.Add(this.panHeader);
            this.bTran.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{ Form Document }";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panNav.ResumeLayout(false);
            this.panMenu.ResumeLayout(false);
            this.panProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHeader;
        private Bunifu.Framework.UI.BunifuImageButton btnNav;
        private Bunifu.Framework.UI.BunifuImageButton btnMin;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panNav;
        private System.Windows.Forms.Panel panContent;
        private System.Windows.Forms.Panel panProfile;
        private BunifuAnimatorNS.BunifuTransition bTran;
        private System.Windows.Forms.PictureBox proImage;
        private System.Windows.Forms.Button lbUsername;
        private System.Windows.Forms.FlowLayoutPanel panMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnReports;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmployees;
        private Bunifu.Framework.UI.BunifuFlatButton btnHoliday;
        private Bunifu.Framework.UI.BunifuFlatButton btnInventory;
        private Bunifu.Framework.UI.BunifuFlatButton btnCustomers;
        private Bunifu.Framework.UI.BunifuFlatButton btnStuff;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewPawn;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignOut;
    }
}
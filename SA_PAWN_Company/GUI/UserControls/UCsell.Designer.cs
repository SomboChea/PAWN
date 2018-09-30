namespace SA_PAWN_Company
{
    partial class UCsell
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txttotalqty = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label2 = new System.Windows.Forms.Label();
            this.cbinventype = new System.Windows.Forms.ComboBox();
            this.cbinventoryname = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnlist = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtprice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtamount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtreturn = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtreceive = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cblisttype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSale = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlist)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(33, 378);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1182, 269);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Inventory Name";
            this.columnHeader1.Width = 263;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Inventory Type";
            this.columnHeader2.Width = 214;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Inventory Price";
            this.columnHeader3.Width = 227;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 132;
            // 
            // txttotalqty
            // 
            this.txttotalqty.BorderColorFocused = System.Drawing.Color.Blue;
            this.txttotalqty.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttotalqty.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txttotalqty.BorderThickness = 3;
            this.txttotalqty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttotalqty.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txttotalqty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttotalqty.isPassword = false;
            this.txttotalqty.Location = new System.Drawing.Point(225, 30);
            this.txttotalqty.Margin = new System.Windows.Forms.Padding(4);
            this.txttotalqty.Name = "txttotalqty";
            this.txttotalqty.Size = new System.Drawing.Size(313, 39);
            this.txttotalqty.TabIndex = 10;
            this.txttotalqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.cbinventype);
            this.bunifuCards1.Controls.Add(this.cbinventoryname);
            this.bunifuCards1.Controls.Add(this.pictureBox1);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel7);
            this.bunifuCards1.Controls.Add(this.btnlist);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuCards1.Controls.Add(this.txtprice);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(33, 31);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(765, 270);
            this.bunifuCards1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "$";
            // 
            // cbinventype
            // 
            this.cbinventype.FormattingEnabled = true;
            this.cbinventype.Location = new System.Drawing.Point(249, 45);
            this.cbinventype.Name = "cbinventype";
            this.cbinventype.Size = new System.Drawing.Size(289, 35);
            this.cbinventype.TabIndex = 23;
            this.cbinventype.SelectedIndexChanged += new System.EventHandler(this.cbinventype_SelectedIndexChanged);
            // 
            // cbinventoryname
            // 
            this.cbinventoryname.FormattingEnabled = true;
            this.cbinventoryname.Location = new System.Drawing.Point(249, 116);
            this.cbinventoryname.Name = "cbinventoryname";
            this.cbinventoryname.Size = new System.Drawing.Size(289, 35);
            this.cbinventoryname.TabIndex = 23;
            this.cbinventoryname.SelectedIndexChanged += new System.EventHandler(this.cbinventoryname_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SA_PAWN_Company.Properties.Resources.download1;
            this.pictureBox1.Location = new System.Drawing.Point(574, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(13, 48);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(176, 27);
            this.bunifuCustomLabel7.TabIndex = 20;
            this.bunifuCustomLabel7.Text = "Inventory Type:";
            // 
            // btnlist
            // 
            this.btnlist.BackColor = System.Drawing.Color.DarkCyan;
            this.btnlist.Image = global::SA_PAWN_Company.Properties.Resources.badge1;
            this.btnlist.ImageActive = null;
            this.btnlist.Location = new System.Drawing.Point(574, 45);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(146, 35);
            this.btnlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnlist.TabIndex = 19;
            this.btnlist.TabStop = false;
            this.btnlist.Zoom = 10;
            this.btnlist.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(13, 196);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(73, 27);
            this.bunifuCustomLabel6.TabIndex = 17;
            this.bunifuCustomLabel6.Text = "Price:";
            // 
            // txtprice
            // 
            this.txtprice.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtprice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtprice.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtprice.BorderThickness = 3;
            this.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtprice.isPassword = false;
            this.txtprice.Location = new System.Drawing.Point(249, 186);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(289, 45);
            this.txtprice.TabIndex = 16;
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(13, 119);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(187, 27);
            this.bunifuCustomLabel5.TabIndex = 15;
            this.bunifuCustomLabel5.Text = "Inventory Name:";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.DeepPink;
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards2.Controls.Add(this.txtamount);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards2.Controls.Add(this.txttotalqty);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(33, 664);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(574, 147);
            this.bunifuCards2.TabIndex = 12;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(13, 87);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(158, 27);
            this.bunifuCustomLabel2.TabIndex = 13;
            this.bunifuCustomLabel2.Text = "Total Amount:";
            // 
            // txtamount
            // 
            this.txtamount.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtamount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtamount.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtamount.BorderThickness = 3;
            this.txtamount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtamount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtamount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtamount.isPassword = false;
            this.txtamount.Location = new System.Drawing.Point(225, 87);
            this.txtamount.Margin = new System.Windows.Forms.Padding(4);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(313, 39);
            this.txtamount.TabIndex = 12;
            this.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(13, 30);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(167, 27);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "Total Quantity:";
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards3.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards3.Controls.Add(this.txtreturn);
            this.bunifuCards3.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuCards3.Controls.Add(this.txtreceive);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(634, 664);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(581, 147);
            this.bunifuCards3.TabIndex = 14;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(13, 87);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(155, 27);
            this.bunifuCustomLabel3.TabIndex = 13;
            this.bunifuCustomLabel3.Text = "Cash Return:";
            // 
            // txtreturn
            // 
            this.txtreturn.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtreturn.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtreturn.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtreturn.BorderThickness = 3;
            this.txtreturn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtreturn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtreturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtreturn.isPassword = false;
            this.txtreturn.Location = new System.Drawing.Point(256, 87);
            this.txtreturn.Margin = new System.Windows.Forms.Padding(4);
            this.txtreturn.Name = "txtreturn";
            this.txtreturn.Size = new System.Drawing.Size(295, 39);
            this.txtreturn.TabIndex = 12;
            this.txtreturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(13, 30);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(180, 27);
            this.bunifuCustomLabel4.TabIndex = 11;
            this.bunifuCustomLabel4.Text = "Revieced Cash:";
            // 
            // txtreceive
            // 
            this.txtreceive.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtreceive.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtreceive.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtreceive.BorderThickness = 3;
            this.txtreceive.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtreceive.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtreceive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtreceive.isPassword = false;
            this.txtreceive.Location = new System.Drawing.Point(256, 30);
            this.txtreceive.Margin = new System.Windows.Forms.Padding(4);
            this.txtreceive.Name = "txtreceive";
            this.txtreceive.Size = new System.Drawing.Size(295, 39);
            this.txtreceive.TabIndex = 10;
            this.txtreceive.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cblisttype
            // 
            this.cblisttype.Font = new System.Drawing.Font("Arial", 12F);
            this.cblisttype.FormattingEnabled = true;
            this.cblisttype.Items.AddRange(new object[] {
            "Detail",
            "Image"});
            this.cblisttype.Location = new System.Drawing.Point(1011, 336);
            this.cblisttype.Name = "cblisttype";
            this.cblisttype.Size = new System.Drawing.Size(203, 26);
            this.cblisttype.TabIndex = 15;
            this.cblisttype.SelectedIndexChanged += new System.EventHandler(this.cblisttype_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(883, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "List Type :";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.color = System.Drawing.Color.SeaGreen;
            this.btnDelete.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::SA_PAWN_Company.Properties.Resources.delete;
            this.btnDelete.ImagePosition = 20;
            this.btnDelete.ImageZoom = 50;
            this.btnDelete.LabelPosition = 41;
            this.btnDelete.LabelText = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(1087, 31);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 129);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SeaGreen;
            this.btnClear.color = System.Drawing.Color.SeaGreen;
            this.btnClear.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::SA_PAWN_Company.Properties.Resources.sweep;
            this.btnClear.ImagePosition = 20;
            this.btnClear.ImageZoom = 50;
            this.btnClear.LabelPosition = 41;
            this.btnClear.LabelText = "Clear";
            this.btnClear.Location = new System.Drawing.Point(947, 172);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 129);
            this.btnClear.TabIndex = 8;
            this.btnClear.Click += new System.EventHandler(this.bunifuTileButton5_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.color = System.Drawing.Color.SeaGreen;
            this.btnUpdate.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::SA_PAWN_Company.Properties.Resources.warehouse;
            this.btnUpdate.ImagePosition = 20;
            this.btnUpdate.ImageZoom = 50;
            this.btnUpdate.LabelPosition = 41;
            this.btnUpdate.LabelText = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(947, 31);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 129);
            this.btnUpdate.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnExit.color = System.Drawing.Color.SeaGreen;
            this.btnExit.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::SA_PAWN_Company.Properties.Resources.smartphone;
            this.btnExit.ImagePosition = 20;
            this.btnExit.ImageZoom = 50;
            this.btnExit.LabelPosition = 41;
            this.btnExit.LabelText = "Exit";
            this.btnExit.Location = new System.Drawing.Point(1087, 172);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 129);
            this.btnExit.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.color = System.Drawing.Color.SeaGreen;
            this.btnAdd.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::SA_PAWN_Company.Properties.Resources.add_documents_1_;
            this.btnAdd.ImagePosition = 20;
            this.btnAdd.ImageZoom = 50;
            this.btnAdd.LabelPosition = 41;
            this.btnAdd.LabelText = "Add";
            this.btnAdd.Location = new System.Drawing.Point(807, 31);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 129);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSale.color = System.Drawing.Color.SeaGreen;
            this.btnSale.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSale.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnSale.ForeColor = System.Drawing.Color.White;
            this.btnSale.Image = global::SA_PAWN_Company.Properties.Resources.badge;
            this.btnSale.ImagePosition = 20;
            this.btnSale.ImageZoom = 50;
            this.btnSale.LabelPosition = 41;
            this.btnSale.LabelText = "Sale";
            this.btnSale.Location = new System.Drawing.Point(807, 172);
            this.btnSale.Margin = new System.Windows.Forms.Padding(6);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(128, 129);
            this.btnSale.TabIndex = 2;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // UCsell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cblisttype);
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "UCsell";
            this.Size = new System.Drawing.Size(1250, 835);
            this.Load += new System.EventHandler(this.UCsell_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlist)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private Bunifu.Framework.UI.BunifuTileButton btnSale;
        private Bunifu.Framework.UI.BunifuTileButton btnAdd;
        private Bunifu.Framework.UI.BunifuTileButton btnExit;
        private Bunifu.Framework.UI.BunifuTileButton btnUpdate;
        private Bunifu.Framework.UI.BunifuTileButton btnClear;
        private Bunifu.Framework.UI.BunifuTileButton btnDelete;
        private Bunifu.Framework.UI.BunifuMetroTextbox txttotalqty;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtamount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtreturn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtreceive;
        private Bunifu.Framework.UI.BunifuImageButton btnlist;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtprice;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbinventype;
        private System.Windows.Forms.ComboBox cbinventoryname;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox cblisttype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

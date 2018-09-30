namespace SA_PAWN_Company
{
    partial class DemoHTTP
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
            this.headerBox = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRefresh = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.itemBox = new System.Windows.Forms.FlowLayoutPanel();
            this.lb404 = new System.Windows.Forms.Label();
            this.cbShowby = new System.Windows.Forms.ComboBox();
            this.headerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.itemBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerBox
            // 
            this.headerBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerBox.BackColor = System.Drawing.Color.DeepPink;
            this.headerBox.Controls.Add(this.cbShowby);
            this.headerBox.Controls.Add(this.txtSearch);
            this.headerBox.Controls.Add(this.bunifuImageButton1);
            this.headerBox.Controls.Add(this.btnRefresh);
            this.headerBox.Controls.Add(this.label1);
            this.headerBox.Controls.Add(this.btnExit);
            this.headerBox.Location = new System.Drawing.Point(0, 0);
            this.headerBox.Name = "headerBox";
            this.headerBox.Size = new System.Drawing.Size(1120, 70);
            this.headerBox.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(408, 11);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(511, 46);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = global::SA_PAWN_Company.Properties.Resources.magnifying_glass;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(938, 11);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(54, 46);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Image = global::SA_PAWN_Company.Properties.Resources.update_arrows;
            this.btnRefresh.ImageActive = null;
            this.btnRefresh.Location = new System.Drawing.Point(1010, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(30, 30);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Zoom = 10;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "API Request Demo";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::SA_PAWN_Company.Properties.Resources.close_button;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(1063, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 45);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // itemBox
            // 
            this.itemBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.itemBox.BackColor = System.Drawing.Color.White;
            this.itemBox.Controls.Add(this.lb404);
            this.itemBox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.itemBox.Location = new System.Drawing.Point(-1, 89);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(1120, 566);
            this.itemBox.TabIndex = 1;
            // 
            // lb404
            // 
            this.lb404.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb404.AutoSize = true;
            this.itemBox.SetFlowBreak(this.lb404, true);
            this.lb404.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb404.Location = new System.Drawing.Point(3, 0);
            this.lb404.Name = "lb404";
            this.lb404.Size = new System.Drawing.Size(701, 142);
            this.lb404.TabIndex = 0;
            this.lb404.Text = "Not Found!";
            this.lb404.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb404.Visible = false;
            // 
            // cbShowby
            // 
            this.cbShowby.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbShowby.BackColor = System.Drawing.Color.White;
            this.cbShowby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShowby.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbShowby.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowby.FormattingEnabled = true;
            this.cbShowby.Items.AddRange(new object[] {
            "Drink",
            "Juice",
            "Milk",
            "Beer"});
            this.cbShowby.Location = new System.Drawing.Point(673, 14);
            this.cbShowby.Name = "cbShowby";
            this.cbShowby.Size = new System.Drawing.Size(246, 41);
            this.cbShowby.TabIndex = 5;
            this.cbShowby.SelectedIndexChanged += new System.EventHandler(this.cbShowby_SelectedIndexChanged);
            // 
            // DemoHTTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 655);
            this.ControlBox = false;
            this.Controls.Add(this.headerBox);
            this.Controls.Add(this.itemBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DemoHTTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DemoHTTP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DemoHTTP_Load);
            this.headerBox.ResumeLayout(false);
            this.headerBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.itemBox.ResumeLayout(false);
            this.itemBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerBox;
        private System.Windows.Forms.FlowLayoutPanel itemBox;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label lb404;
        private System.Windows.Forms.ComboBox cbShowby;
    }
}
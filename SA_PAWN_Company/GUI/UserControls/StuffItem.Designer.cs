namespace SA_PAWN_Company
{
    partial class StuffItem
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
            this.panHead = new System.Windows.Forms.Panel();
            this.panItem = new System.Windows.Forms.Panel();
            this.lbOvertime = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbExpDate = new System.Windows.Forms.Label();
            this.btnWriteOff = new System.Windows.Forms.Button();
            this.lbPunish = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbInterest = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbCust = new System.Windows.Forms.Label();
            this.lbEmp = new System.Windows.Forms.Label();
            this.lbRate = new System.Windows.Forms.Label();
            this.lbDuration = new System.Windows.Forms.Label();
            this.lbPawnPrice = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.stuffPhoto = new System.Windows.Forms.PictureBox();
            this.panItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stuffPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panHead
            // 
            this.panHead.BackColor = System.Drawing.Color.Green;
            this.panHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Margin = new System.Windows.Forms.Padding(4);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(724, 8);
            this.panHead.TabIndex = 0;
            // 
            // panItem
            // 
            this.panItem.BackColor = System.Drawing.Color.White;
            this.panItem.Controls.Add(this.lbOvertime);
            this.panItem.Controls.Add(this.lbID);
            this.panItem.Controls.Add(this.lbExpDate);
            this.panItem.Controls.Add(this.btnWriteOff);
            this.panItem.Controls.Add(this.lbPunish);
            this.panItem.Controls.Add(this.lbAmount);
            this.panItem.Controls.Add(this.lbInterest);
            this.panItem.Controls.Add(this.bunifuSeparator1);
            this.panItem.Controls.Add(this.lbCust);
            this.panItem.Controls.Add(this.lbEmp);
            this.panItem.Controls.Add(this.lbRate);
            this.panItem.Controls.Add(this.lbDuration);
            this.panItem.Controls.Add(this.lbPawnPrice);
            this.panItem.Controls.Add(this.lbDate);
            this.panItem.Controls.Add(this.lbName);
            this.panItem.Controls.Add(this.stuffPhoto);
            this.panItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panItem.Location = new System.Drawing.Point(0, 8);
            this.panItem.Margin = new System.Windows.Forms.Padding(4);
            this.panItem.Name = "panItem";
            this.panItem.Size = new System.Drawing.Size(724, 273);
            this.panItem.TabIndex = 1;
            // 
            // lbOvertime
            // 
            this.lbOvertime.AutoSize = true;
            this.lbOvertime.Location = new System.Drawing.Point(221, 232);
            this.lbOvertime.Name = "lbOvertime";
            this.lbOvertime.Size = new System.Drawing.Size(85, 19);
            this.lbOvertime.TabIndex = 15;
            this.lbOvertime.Text = "Overtimes: ";
            this.lbOvertime.Visible = false;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(221, 58);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(73, 19);
            this.lbID.TabIndex = 14;
            this.lbID.Text = "Pawn ID: ";
            // 
            // lbExpDate
            // 
            this.lbExpDate.AutoSize = true;
            this.lbExpDate.Location = new System.Drawing.Point(437, 90);
            this.lbExpDate.Name = "lbExpDate";
            this.lbExpDate.Size = new System.Drawing.Size(76, 19);
            this.lbExpDate.TabIndex = 13;
            this.lbExpDate.Text = "ExpDate: ";
            // 
            // btnWriteOff
            // 
            this.btnWriteOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWriteOff.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnWriteOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWriteOff.FlatAppearance.BorderSize = 0;
            this.btnWriteOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWriteOff.Location = new System.Drawing.Point(596, 7);
            this.btnWriteOff.Name = "btnWriteOff";
            this.btnWriteOff.Size = new System.Drawing.Size(116, 37);
            this.btnWriteOff.TabIndex = 12;
            this.btnWriteOff.Text = "Write Off";
            this.btnWriteOff.UseVisualStyleBackColor = false;
            this.btnWriteOff.Visible = false;
            this.btnWriteOff.Click += new System.EventHandler(this.btnWriteOff_Click);
            // 
            // lbPunish
            // 
            this.lbPunish.AutoSize = true;
            this.lbPunish.Location = new System.Drawing.Point(437, 201);
            this.lbPunish.Name = "lbPunish";
            this.lbPunish.Size = new System.Drawing.Size(149, 19);
            this.lbPunish.TabIndex = 11;
            this.lbPunish.Text = "Total Punishement: $";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.Location = new System.Drawing.Point(437, 234);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(113, 17);
            this.lbAmount.TabIndex = 10;
            this.lbAmount.Text = "Total Amount: $";
            // 
            // lbInterest
            // 
            this.lbInterest.AutoSize = true;
            this.lbInterest.Location = new System.Drawing.Point(221, 201);
            this.lbInterest.Name = "lbInterest";
            this.lbInterest.Size = new System.Drawing.Size(110, 19);
            this.lbInterest.TabIndex = 9;
            this.lbInterest.Text = "Total Interest: $";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(225, 177);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(494, 19);
            this.bunifuSeparator1.TabIndex = 8;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lbCust
            // 
            this.lbCust.AutoSize = true;
            this.lbCust.Location = new System.Drawing.Point(437, 152);
            this.lbCust.Name = "lbCust";
            this.lbCust.Size = new System.Drawing.Size(103, 19);
            this.lbCust.TabIndex = 7;
            this.lbCust.Text = "Customer Tel: ";
            // 
            // lbEmp
            // 
            this.lbEmp.AutoSize = true;
            this.lbEmp.Location = new System.Drawing.Point(437, 120);
            this.lbEmp.Name = "lbEmp";
            this.lbEmp.Size = new System.Drawing.Size(86, 19);
            this.lbEmp.TabIndex = 6;
            this.lbEmp.Text = "Employee: ";
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Location = new System.Drawing.Point(221, 152);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(98, 19);
            this.lbRate.TabIndex = 5;
            this.lbRate.Text = "Interest rate: ";
            // 
            // lbDuration
            // 
            this.lbDuration.AutoSize = true;
            this.lbDuration.Location = new System.Drawing.Point(221, 119);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(76, 19);
            this.lbDuration.TabIndex = 4;
            this.lbDuration.Text = "Duration: ";
            // 
            // lbPawnPrice
            // 
            this.lbPawnPrice.AutoSize = true;
            this.lbPawnPrice.Location = new System.Drawing.Point(221, 90);
            this.lbPawnPrice.Name = "lbPawnPrice";
            this.lbPawnPrice.Size = new System.Drawing.Size(101, 19);
            this.lbPawnPrice.TabIndex = 3;
            this.lbPawnPrice.Text = "Pawn Price: $";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(437, 58);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(51, 19);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "Date: ";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(218, 4);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(157, 32);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Stuff Name";
            // 
            // stuffPhoto
            // 
            this.stuffPhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.stuffPhoto.Image = global::SA_PAWN_Company.Properties.Resources.cart512x512;
            this.stuffPhoto.Location = new System.Drawing.Point(0, 0);
            this.stuffPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.stuffPhoto.Name = "stuffPhoto";
            this.stuffPhoto.Size = new System.Drawing.Size(210, 273);
            this.stuffPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stuffPhoto.TabIndex = 0;
            this.stuffPhoto.TabStop = false;
            // 
            // StuffItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panItem);
            this.Controls.Add(this.panHead);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StuffItem";
            this.Size = new System.Drawing.Size(724, 281);
            this.panItem.ResumeLayout(false);
            this.panItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stuffPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHead;
        private System.Windows.Forms.Panel panItem;
        private System.Windows.Forms.PictureBox stuffPhoto;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCust;
        private System.Windows.Forms.Label lbEmp;
        private System.Windows.Forms.Label lbRate;
        private System.Windows.Forms.Label lbDuration;
        private System.Windows.Forms.Label lbPawnPrice;
        private System.Windows.Forms.Label lbDate;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lbPunish;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbInterest;
        private System.Windows.Forms.Button btnWriteOff;
        private System.Windows.Forms.Label lbExpDate;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbOvertime;
    }
}

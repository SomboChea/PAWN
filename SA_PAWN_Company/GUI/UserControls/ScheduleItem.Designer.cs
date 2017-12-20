namespace SA_PAWN_Company
{
    partial class ScheduleItem
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
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lbAmountDays = new System.Windows.Forms.Label();
            this.lbPaydate = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lbSchTitle = new System.Windows.Forms.Label();
            this.lbRate = new System.Windows.Forms.Label();
            this.lbInterest = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbPunish = new System.Windows.Forms.Label();
            this.lbTotalPay = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.bunifuSeparator1);
            this.bunifuCards1.Controls.Add(this.lbTotalPay);
            this.bunifuCards1.Controls.Add(this.lbPunish);
            this.bunifuCards1.Controls.Add(this.lbAmount);
            this.bunifuCards1.Controls.Add(this.lbInterest);
            this.bunifuCards1.Controls.Add(this.lbRate);
            this.bunifuCards1.Controls.Add(this.lbAmountDays);
            this.bunifuCards1.Controls.Add(this.lbPaydate);
            this.bunifuCards1.Controls.Add(this.btnPay);
            this.bunifuCards1.Controls.Add(this.lbSchTitle);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(495, 231);
            this.bunifuCards1.TabIndex = 0;
            // 
            // lbAmountDays
            // 
            this.lbAmountDays.AutoSize = true;
            this.lbAmountDays.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmountDays.Location = new System.Drawing.Point(275, 100);
            this.lbAmountDays.Name = "lbAmountDays";
            this.lbAmountDays.Size = new System.Drawing.Size(130, 21);
            this.lbAmountDays.TabIndex = 4;
            this.lbAmountDays.Text = "Amount days: ";
            // 
            // lbPaydate
            // 
            this.lbPaydate.AutoSize = true;
            this.lbPaydate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaydate.Location = new System.Drawing.Point(223, 19);
            this.lbPaydate.Name = "lbPaydate";
            this.lbPaydate.Size = new System.Drawing.Size(113, 23);
            this.lbPaydate.TabIndex = 3;
            this.lbPaydate.Text = "Pay Date: ";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Location = new System.Drawing.Point(340, 170);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(132, 40);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lbSchTitle
            // 
            this.lbSchTitle.AutoSize = true;
            this.lbSchTitle.Location = new System.Drawing.Point(21, 15);
            this.lbSchTitle.Name = "lbSchTitle";
            this.lbSchTitle.Size = new System.Drawing.Size(180, 30);
            this.lbSchTitle.TabIndex = 1;
            this.lbSchTitle.Text = "Schedule No: ";
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRate.Location = new System.Drawing.Point(28, 63);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(123, 21);
            this.lbRate.TabIndex = 5;
            this.lbRate.Text = "Interest rate: ";
            // 
            // lbInterest
            // 
            this.lbInterest.AutoSize = true;
            this.lbInterest.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInterest.Location = new System.Drawing.Point(275, 63);
            this.lbInterest.Name = "lbInterest";
            this.lbInterest.Size = new System.Drawing.Size(83, 21);
            this.lbInterest.TabIndex = 6;
            this.lbInterest.Text = "Interest: ";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.Location = new System.Drawing.Point(28, 100);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(121, 21);
            this.lbAmount.TabIndex = 7;
            this.lbAmount.Text = "Amount Pay: ";
            // 
            // lbPunish
            // 
            this.lbPunish.AutoSize = true;
            this.lbPunish.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPunish.Location = new System.Drawing.Point(28, 136);
            this.lbPunish.Name = "lbPunish";
            this.lbPunish.Size = new System.Drawing.Size(124, 21);
            this.lbPunish.TabIndex = 8;
            this.lbPunish.Text = "Punishement: ";
            // 
            // lbTotalPay
            // 
            this.lbTotalPay.AutoSize = true;
            this.lbTotalPay.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPay.Location = new System.Drawing.Point(28, 189);
            this.lbTotalPay.Name = "lbTotalPay";
            this.lbTotalPay.Size = new System.Drawing.Size(167, 21);
            this.lbTotalPay.TabIndex = 9;
            this.lbTotalPay.Text = "Total Amount Pay: ";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.DimGray;
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(32, 164);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(304, 18);
            this.bunifuSeparator1.TabIndex = 10;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // ScheduleItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ScheduleItem";
            this.Size = new System.Drawing.Size(495, 231);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label lbSchTitle;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lbPaydate;
        private System.Windows.Forms.Label lbAmountDays;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lbTotalPay;
        private System.Windows.Forms.Label lbPunish;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbInterest;
        private System.Windows.Forms.Label lbRate;
    }
}

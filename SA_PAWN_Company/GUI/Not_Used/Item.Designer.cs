namespace SA_PAWN_Company
{
    partial class Item
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
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.panHead = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.lbCate = new System.Windows.Forms.Label();
            this.lbQty = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageBox
            // 
            this.ImageBox.Image = global::SA_PAWN_Company.Properties.Resources.Logo_PAWN;
            this.ImageBox.Location = new System.Drawing.Point(17, 22);
            this.ImageBox.Margin = new System.Windows.Forms.Padding(4);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(198, 234);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 0;
            this.ImageBox.TabStop = false;
            // 
            // panHead
            // 
            this.panHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panHead.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Margin = new System.Windows.Forms.Padding(4);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(581, 10);
            this.panHead.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(233, 22);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(247, 30);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Product Name: XBN";
            // 
            // lbCate
            // 
            this.lbCate.AutoSize = true;
            this.lbCate.Location = new System.Drawing.Point(234, 68);
            this.lbCate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCate.Name = "lbCate";
            this.lbCate.Size = new System.Drawing.Size(131, 21);
            this.lbCate.TabIndex = 3;
            this.lbCate.Text = "Category: CXZ";
            // 
            // lbQty
            // 
            this.lbQty.AutoSize = true;
            this.lbQty.Location = new System.Drawing.Point(234, 119);
            this.lbQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQty.Name = "lbQty";
            this.lbQty.Size = new System.Drawing.Size(114, 21);
            this.lbQty.TabIndex = 4;
            this.lbQty.Text = "Quanitity: X0";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(234, 164);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(78, 21);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "Price: $0";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(330, 235);
            this.lbAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(150, 21);
            this.lbAmount.TabIndex = 6;
            this.lbAmount.Text = "Total Amount: $0";
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbQty);
            this.Controls.Add(this.lbCate);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.panHead);
            this.Controls.Add(this.ImageBox);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(581, 282);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Panel panHead;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCate;
        private System.Windows.Forms.Label lbQty;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbAmount;
    }
}

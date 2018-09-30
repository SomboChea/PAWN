namespace SA_PAWN_Company
{
    partial class RoleItem
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
            this.panMain = new System.Windows.Forms.Panel();
            this.Nono = new System.Windows.Forms.Button();
            this.checkBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.iconBig = new System.Windows.Forms.PictureBox();
            this.panMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBig)).BeginInit();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.Nono);
            this.panMain.Controls.Add(this.checkBox);
            this.panMain.Controls.Add(this.iconBig);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 0);
            this.panMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(142, 127);
            this.panMain.TabIndex = 0;
            this.panMain.Click += new System.EventHandler(this.panMain_Click);
            // 
            // Nono
            // 
            this.Nono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nono.BackColor = System.Drawing.Color.DarkGray;
            this.Nono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nono.FlatAppearance.BorderSize = 0;
            this.Nono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nono.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nono.ForeColor = System.Drawing.Color.White;
            this.Nono.Location = new System.Drawing.Point(0, 95);
            this.Nono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Nono.Name = "Nono";
            this.Nono.Size = new System.Drawing.Size(142, 32);
            this.Nono.TabIndex = 2;
            this.Nono.Text = "Title";
            this.Nono.UseVisualStyleBackColor = false;
            this.Nono.Click += new System.EventHandler(this.panMain_Click);
            // 
            // checkBox
            // 
            this.checkBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkBox.Checked = false;
            this.checkBox.CheckedOnColor = System.Drawing.Color.DeepPink;
            this.checkBox.ForeColor = System.Drawing.Color.White;
            this.checkBox.Location = new System.Drawing.Point(3, 3);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(20, 20);
            this.checkBox.TabIndex = 1;
            this.checkBox.OnChange += new System.EventHandler(this.checkBox_OnChange);
            // 
            // iconBig
            // 
            this.iconBig.BackColor = System.Drawing.Color.DimGray;
            this.iconBig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconBig.Image = global::SA_PAWN_Company.Properties.Resources.shutdown;
            this.iconBig.Location = new System.Drawing.Point(0, 0);
            this.iconBig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconBig.Name = "iconBig";
            this.iconBig.Size = new System.Drawing.Size(142, 127);
            this.iconBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBig.TabIndex = 0;
            this.iconBig.TabStop = false;
            this.iconBig.Click += new System.EventHandler(this.panMain_Click);
            // 
            // RoleItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RoleItem";
            this.Size = new System.Drawing.Size(142, 127);
            this.panMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconBig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private Bunifu.Framework.UI.BunifuCheckbox checkBox;
        public System.Windows.Forms.PictureBox iconBig;
        public System.Windows.Forms.Button Nono;
    }
}

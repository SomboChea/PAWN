namespace SA_PAWN_Company
{
    partial class UCStuff
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
            this.panStuffItems = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panStuffItems
            // 
            this.panStuffItems.BackColor = System.Drawing.Color.Gainsboro;
            this.panStuffItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panStuffItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panStuffItems.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panStuffItems.Location = new System.Drawing.Point(0, 0);
            this.panStuffItems.Name = "panStuffItems";
            this.panStuffItems.Size = new System.Drawing.Size(1227, 763);
            this.panStuffItems.TabIndex = 0;
            // 
            // UCStuff
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panStuffItems);
            this.Name = "UCStuff";
            this.Size = new System.Drawing.Size(1227, 763);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panStuffItems;
    }
}

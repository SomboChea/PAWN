namespace SA_PAWN_Company
{
    partial class UCinventory
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
            this.panInventory = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panInventory
            // 
            this.panInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panInventory.Location = new System.Drawing.Point(0, 0);
            this.panInventory.Name = "panInventory";
            this.panInventory.Size = new System.Drawing.Size(1250, 791);
            this.panInventory.TabIndex = 0;
            // 
            // UCinventory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panInventory);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCinventory";
            this.Size = new System.Drawing.Size(1250, 791);
            this.Load += new System.EventHandler(this.UCinventory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panInventory;
    }
}

namespace SA_PAWN_Company
{
    partial class PopupBox
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
            this.panOne = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panOne
            // 
            this.panOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panOne.Location = new System.Drawing.Point(0, 0);
            this.panOne.Name = "panOne";
            this.panOne.Size = new System.Drawing.Size(620, 269);
            this.panOne.TabIndex = 0;
            this.panOne.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panOne_ControlRemoved);
            // 
            // PopupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 269);
            this.Controls.Add(this.panOne);
            this.Name = "PopupBox";
            this.Text = "demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panOne;
    }
}
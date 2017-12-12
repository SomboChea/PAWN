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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.panTwo = new System.Windows.Forms.Panel();
            this.panTwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panOne
            // 
            this.panOne.Dock = System.Windows.Forms.DockStyle.Top;
            this.panOne.Location = new System.Drawing.Point(0, 0);
            this.panOne.Name = "panOne";
            this.panOne.Size = new System.Drawing.Size(620, 266);
            this.panOne.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnNext.Location = new System.Drawing.Point(431, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(189, 54);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next...";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnPrev.Location = new System.Drawing.Point(0, 0);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(200, 54);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "...Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // panTwo
            // 
            this.panTwo.Controls.Add(this.btnPrev);
            this.panTwo.Controls.Add(this.btnNext);
            this.panTwo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panTwo.Location = new System.Drawing.Point(0, 291);
            this.panTwo.Name = "panTwo";
            this.panTwo.Size = new System.Drawing.Size(620, 54);
            this.panTwo.TabIndex = 1;
            // 
            // PopupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 345);
            this.Controls.Add(this.panOne);
            this.Controls.Add(this.panTwo);
            this.Name = "PopupBox";
            this.Text = "demo";
            this.panTwo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panOne;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Panel panTwo;
    }
}
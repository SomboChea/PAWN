namespace SA_PAWN_Company
{
    partial class Loading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.LoadingImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImg)).BeginInit();
            this.SuspendLayout();
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 2000;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // LoadingImg
            // 
            this.LoadingImg.BackColor = System.Drawing.SystemColors.Control;
            this.LoadingImg.Image = global::SA_PAWN_Company.Properties.Resources.DDA1om1___Imgur;
            this.LoadingImg.Location = new System.Drawing.Point(0, -1);
            this.LoadingImg.Name = "LoadingImg";
            this.LoadingImg.Size = new System.Drawing.Size(500, 200);
            this.LoadingImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadingImg.TabIndex = 2;
            this.LoadingImg.TabStop = false;
            this.LoadingImg.UseWaitCursor = true;
            this.LoadingImg.Click += new System.EventHandler(this.LoadingImg_Click);
            // 
            // Loading
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.ControlBox = false;
            this.Controls.Add(this.LoadingImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loading";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.LoadingImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LoadingImg;
        private System.Windows.Forms.Timer timerLoading;
    }
}
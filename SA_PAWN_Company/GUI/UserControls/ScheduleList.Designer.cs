namespace SA_PAWN_Company
{
    partial class ScheduleList
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
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.cbBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.itemBox = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.cbBy);
            this.bunifuCards1.Controls.Add(this.txtSearch);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1125, 690);
            this.bunifuCards1.TabIndex = 1;
            // 
            // cbBy
            // 
            this.cbBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBy.FormattingEnabled = true;
            this.cbBy.Location = new System.Drawing.Point(88, 25);
            this.cbBy.Name = "cbBy";
            this.cbBy.Size = new System.Drawing.Size(244, 35);
            this.cbBy.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(349, 25);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(745, 37);
            this.txtSearch.TabIndex = 1;
            // 
            // itemBox
            // 
            this.itemBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.itemBox.Location = new System.Drawing.Point(0, 104);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(1125, 586);
            this.itemBox.TabIndex = 2;
            // 
            // ScheduleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemBox);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ScheduleList";
            this.Size = new System.Drawing.Size(1125, 690);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.ComboBox cbBy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel itemBox;
    }
}

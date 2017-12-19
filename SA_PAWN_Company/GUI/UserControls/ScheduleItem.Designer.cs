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
            this.lbSchTitle = new System.Windows.Forms.Label();
            this.btnPaid = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.btnPaid);
            this.bunifuCards1.Controls.Add(this.lbSchTitle);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(488, 268);
            this.bunifuCards1.TabIndex = 0;
            // 
            // lbSchTitle
            // 
            this.lbSchTitle.AutoSize = true;
            this.lbSchTitle.Location = new System.Drawing.Point(21, 27);
            this.lbSchTitle.Name = "lbSchTitle";
            this.lbSchTitle.Size = new System.Drawing.Size(213, 30);
            this.lbSchTitle.TabIndex = 1;
            this.lbSchTitle.Text = "Schedule ID: XX1";
            // 
            // btnPaid
            // 
            this.btnPaid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPaid.FlatAppearance.BorderSize = 0;
            this.btnPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaid.Location = new System.Drawing.Point(334, 210);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(132, 40);
            this.btnPaid.TabIndex = 2;
            this.btnPaid.Text = "Paid";
            this.btnPaid.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount Pay : $X100";
            // 
            // ScheduleItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ScheduleItem";
            this.Size = new System.Drawing.Size(488, 268);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label lbSchTitle;
        private System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.Label label2;
    }
}

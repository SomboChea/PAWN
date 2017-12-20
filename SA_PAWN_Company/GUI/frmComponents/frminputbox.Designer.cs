namespace SA_PAWN_Company
{
    partial class frminputbox
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
            this.lbparam = new System.Windows.Forms.Label();
            this.txtvalue = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbparam
            // 
            this.lbparam.AutoSize = true;
            this.lbparam.Location = new System.Drawing.Point(12, 22);
            this.lbparam.Name = "lbparam";
            this.lbparam.Size = new System.Drawing.Size(70, 26);
            this.lbparam.TabIndex = 0;
            this.lbparam.Text = "label1";
            // 
            // txtvalue
            // 
            this.txtvalue.Location = new System.Drawing.Point(17, 62);
            this.txtvalue.Name = "txtvalue";
            this.txtvalue.Size = new System.Drawing.Size(558, 32);
            this.txtvalue.TabIndex = 1;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Red;
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btncancel.Location = new System.Drawing.Point(469, 115);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(106, 41);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.Lime;
            this.btnok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnok.ForeColor = System.Drawing.SystemColors.Control;
            this.btnok.Location = new System.Drawing.Point(357, 115);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(106, 41);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // frminputbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 174);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtvalue);
            this.Controls.Add(this.lbparam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frminputbox";
            this.Text = "frminputbox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frminputbox_FormClosing);
            this.Load += new System.EventHandler(this.frminputbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtvalue;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnok;
        public System.Windows.Forms.Label lbparam;
    }
}
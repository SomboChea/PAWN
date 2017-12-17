namespace SA_PAWN_Company
{
    partial class frmAddPos
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
            this.chklist = new System.Windows.Forms.CheckedListBox();
            this.dgPos = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPos)).BeginInit();
            this.SuspendLayout();
            // 
            // chklist
            // 
            this.chklist.FormattingEnabled = true;
            this.chklist.Location = new System.Drawing.Point(12, 70);
            this.chklist.Name = "chklist";
            this.chklist.Size = new System.Drawing.Size(239, 274);
            this.chklist.TabIndex = 0;
            // 
            // dgPos
            // 
            this.dgPos.AllowUserToAddRows = false;
            this.dgPos.AllowUserToDeleteRows = false;
            this.dgPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPos.Location = new System.Drawing.Point(269, 21);
            this.dgPos.MultiSelect = false;
            this.dgPos.Name = "dgPos";
            this.dgPos.ReadOnly = true;
            this.dgPos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPos.Size = new System.Drawing.Size(246, 385);
            this.dgPos.TabIndex = 1;
            this.dgPos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPos_CellContentClick);
            this.dgPos.Click += new System.EventHandler(this.dgPos_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Blue;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOK.Location = new System.Drawing.Point(12, 359);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(104, 47);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Red;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnclear.Location = new System.Drawing.Point(147, 359);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(104, 47);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(12, 21);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(239, 32);
            this.txtname.TabIndex = 3;
            // 
            // frmAddPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 456);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgPos);
            this.Controls.Add(this.chklist);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmAddPos";
            this.Text = "Add Position";
            this.Load += new System.EventHandler(this.frmAddPos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklist;
        private System.Windows.Forms.DataGridView dgPos;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtname;
    }
}
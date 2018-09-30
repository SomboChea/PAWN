namespace SA_PAWN_Company
{
    partial class FindStuff
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
            this.listStuff = new System.Windows.Forms.ListView();
            this.cbID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listStuff
            // 
            this.listStuff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cbID,
            this.cbName,
            this.cbType});
            this.listStuff.FullRowSelect = true;
            this.listStuff.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listStuff.Location = new System.Drawing.Point(14, 14);
            this.listStuff.Margin = new System.Windows.Forms.Padding(5);
            this.listStuff.MultiSelect = false;
            this.listStuff.Name = "listStuff";
            this.listStuff.Size = new System.Drawing.Size(1007, 333);
            this.listStuff.TabIndex = 0;
            this.listStuff.UseCompatibleStateImageBehavior = false;
            this.listStuff.View = System.Windows.Forms.View.Details;
            // 
            // cbID
            // 
            this.cbID.Text = "ID";
            this.cbID.Width = 113;
            // 
            // cbName
            // 
            this.cbName.Text = "Name";
            this.cbName.Width = 371;
            // 
            // cbType
            // 
            this.cbType.Text = "Type";
            this.cbType.Width = 141;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOK.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOK.Location = new System.Drawing.Point(852, 355);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(169, 40);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FindStuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 406);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.listStuff);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FindStuff";
            this.Text = "FindStuff";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listStuff;
        private System.Windows.Forms.ColumnHeader cbID;
        private System.Windows.Forms.ColumnHeader cbName;
        private System.Windows.Forms.ColumnHeader cbType;
        private System.Windows.Forms.Button btnOK;
    }
}
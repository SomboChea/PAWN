namespace SA_PAWN_Company
{
    partial class UserRoleItem
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
            this.btnRoleName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRoleName
            // 
            this.btnRoleName.AutoSize = true;
            this.btnRoleName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRoleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRoleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRoleName.FlatAppearance.BorderSize = 0;
            this.btnRoleName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleName.Location = new System.Drawing.Point(0, 0);
            this.btnRoleName.Name = "btnRoleName";
            this.btnRoleName.Size = new System.Drawing.Size(242, 48);
            this.btnRoleName.TabIndex = 0;
            this.btnRoleName.Text = "Role Name";
            this.btnRoleName.UseVisualStyleBackColor = false;
            // 
            // UserRoleItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRoleName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UserRoleItem";
            this.Size = new System.Drawing.Size(242, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoleName;
    }
}

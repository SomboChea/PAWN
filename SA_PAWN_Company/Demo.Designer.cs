namespace SA_PAWN_Company
{
    partial class Demo
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
            this.roleItem1 = new SA_PAWN_Company.RoleItem();
            this.roleItem2 = new SA_PAWN_Company.RoleItem();
            this.roleItem3 = new SA_PAWN_Company.RoleItem();
            this.roleItem4 = new SA_PAWN_Company.RoleItem();
            this.SuspendLayout();
            // 
            // roleItem1
            // 
            this.roleItem1.Location = new System.Drawing.Point(12, 12);
            this.roleItem1.Name = "roleItem1";
            this.roleItem1.Size = new System.Drawing.Size(264, 173);
            this.roleItem1.TabIndex = 0;
            // 
            // roleItem2
            // 
            this.roleItem2.Location = new System.Drawing.Point(294, 12);
            this.roleItem2.Name = "roleItem2";
            this.roleItem2.Size = new System.Drawing.Size(264, 173);
            this.roleItem2.TabIndex = 1;
            // 
            // roleItem3
            // 
            this.roleItem3.Location = new System.Drawing.Point(12, 201);
            this.roleItem3.Name = "roleItem3";
            this.roleItem3.Size = new System.Drawing.Size(264, 173);
            this.roleItem3.TabIndex = 2;
            // 
            // roleItem4
            // 
            this.roleItem4.Location = new System.Drawing.Point(294, 201);
            this.roleItem4.Name = "roleItem4";
            this.roleItem4.Size = new System.Drawing.Size(264, 173);
            this.roleItem4.TabIndex = 3;
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 393);
            this.Controls.Add(this.roleItem4);
            this.Controls.Add(this.roleItem3);
            this.Controls.Add(this.roleItem2);
            this.Controls.Add(this.roleItem1);
            this.Name = "Demo";
            this.Text = "Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private RoleItem roleItem1;
        private RoleItem roleItem2;
        private RoleItem roleItem3;
        private RoleItem roleItem4;
    }
}
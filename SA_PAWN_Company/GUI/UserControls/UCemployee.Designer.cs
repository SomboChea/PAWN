namespace SA_PAWN_Company
{
    partial class UCemployee
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
            this.dgEmployee = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdduser = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnaddpos = new System.Windows.Forms.Button();
            this.cbposition = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsalary = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemail = new MetroFramework.Controls.MetroTextBox();
            this.txtphone = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rfemale = new System.Windows.Forms.RadioButton();
            this.rmale = new System.Windows.Forms.RadioButton();
            this.txtaddress = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.picturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEmployee
            // 
            this.dgEmployee.AllowUserToAddRows = false;
            this.dgEmployee.AllowUserToDeleteRows = false;
            this.dgEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dgEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployee.Location = new System.Drawing.Point(27, 28);
            this.dgEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgEmployee.MultiSelect = false;
            this.dgEmployee.Name = "dgEmployee";
            this.dgEmployee.ReadOnly = true;
            this.dgEmployee.RowTemplate.Height = 24;
            this.dgEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmployee.Size = new System.Drawing.Size(1192, 294);
            this.dgEmployee.TabIndex = 0;
            this.dgEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmployee_CellContentClick);
            this.dgEmployee.Click += new System.EventHandler(this.dgEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtname.Lines = new string[0];
            this.txtname.Location = new System.Drawing.Point(113, 63);
            this.txtname.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtname.MaxLength = 32767;
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtname.SelectedText = "";
            this.txtname.Size = new System.Drawing.Size(324, 34);
            this.txtname.TabIndex = 5;
            this.txtname.Tag = "Name";
            this.txtname.UseCustomBackColor = true;
            this.txtname.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAdduser);
            this.groupBox1.Controls.Add(this.btnclr);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.btnaddpos);
            this.groupBox1.Controls.Add(this.cbposition);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtsalary);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtphone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnbrowse);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.picturebox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1192, 387);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(877, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 31);
            this.label7.TabIndex = 22;
            this.label7.Text = "$";
            // 
            // btnAdduser
            // 
            this.btnAdduser.BackColor = System.Drawing.Color.Blue;
            this.btnAdduser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdduser.Location = new System.Drawing.Point(502, 199);
            this.btnAdduser.Name = "btnAdduser";
            this.btnAdduser.Size = new System.Drawing.Size(361, 56);
            this.btnAdduser.TabIndex = 21;
            this.btnAdduser.Text = "Add User";
            this.btnAdduser.UseVisualStyleBackColor = false;
            this.btnAdduser.Click += new System.EventHandler(this.btnAdduser_Click);
            // 
            // btnclr
            // 
            this.btnclr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnclr.BackColor = System.Drawing.Color.Red;
            this.btnclr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclr.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.ForeColor = System.Drawing.SystemColors.Control;
            this.btnclr.Location = new System.Drawing.Point(714, 286);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(184, 48);
            this.btnclr.TabIndex = 20;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = false;
            this.btnclr.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnadd
            // 
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnadd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnadd.Location = new System.Drawing.Point(480, 286);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(184, 48);
            this.btnadd.TabIndex = 20;
            this.btnadd.Text = "Add Employee";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnaddpos
            // 
            this.btnaddpos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnaddpos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddpos.ForeColor = System.Drawing.SystemColors.Info;
            this.btnaddpos.Location = new System.Drawing.Point(839, 124);
            this.btnaddpos.Name = "btnaddpos";
            this.btnaddpos.Size = new System.Drawing.Size(59, 29);
            this.btnaddpos.TabIndex = 18;
            this.btnaddpos.Text = "ADD";
            this.btnaddpos.UseVisualStyleBackColor = false;
            this.btnaddpos.Click += new System.EventHandler(this.btnaddpos_Click);
            // 
            // cbposition
            // 
            this.cbposition.FormattingEnabled = true;
            this.cbposition.ItemHeight = 24;
            this.cbposition.Location = new System.Drawing.Point(574, 121);
            this.cbposition.Name = "cbposition";
            this.cbposition.Size = new System.Drawing.Size(257, 30);
            this.cbposition.TabIndex = 17;
            this.cbposition.Tag = "Positon";
            this.cbposition.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(475, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Position:";
            // 
            // txtsalary
            // 
            this.txtsalary.BackColor = System.Drawing.Color.White;
            this.txtsalary.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtsalary.Lines = new string[0];
            this.txtsalary.Location = new System.Drawing.Point(574, 63);
            this.txtsalary.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtsalary.MaxLength = 32767;
            this.txtsalary.Multiline = true;
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.PasswordChar = '\0';
            this.txtsalary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsalary.SelectedText = "";
            this.txtsalary.Size = new System.Drawing.Size(295, 34);
            this.txtsalary.TabIndex = 13;
            this.txtsalary.Tag = "Salary";
            this.txtsalary.UseCustomBackColor = true;
            this.txtsalary.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Salary:";
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.White;
            this.txtemail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtemail.Lines = new string[0];
            this.txtemail.Location = new System.Drawing.Point(113, 336);
            this.txtemail.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtemail.MaxLength = 32767;
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(324, 34);
            this.txtemail.TabIndex = 11;
            this.txtemail.Tag = "Email";
            this.txtemail.UseCustomBackColor = true;
            this.txtemail.UseSelectable = true;
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.White;
            this.txtphone.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtphone.Lines = new string[0];
            this.txtphone.Location = new System.Drawing.Point(113, 274);
            this.txtphone.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtphone.MaxLength = 32767;
            this.txtphone.Multiline = true;
            this.txtphone.Name = "txtphone";
            this.txtphone.PasswordChar = '\0';
            this.txtphone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtphone.SelectedText = "";
            this.txtphone.Size = new System.Drawing.Size(324, 34);
            this.txtphone.TabIndex = 11;
            this.txtphone.Tag = "Tel";
            this.txtphone.UseCustomBackColor = true;
            this.txtphone.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 336);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tel:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rfemale);
            this.groupBox2.Controls.Add(this.rmale);
            this.groupBox2.Location = new System.Drawing.Point(16, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 73);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // rfemale
            // 
            this.rfemale.AutoSize = true;
            this.rfemale.Location = new System.Drawing.Point(245, 31);
            this.rfemale.Name = "rfemale";
            this.rfemale.Size = new System.Drawing.Size(108, 35);
            this.rfemale.TabIndex = 1;
            this.rfemale.TabStop = true;
            this.rfemale.Text = "Female";
            this.rfemale.UseVisualStyleBackColor = true;
            // 
            // rmale
            // 
            this.rmale.AutoSize = true;
            this.rmale.Location = new System.Drawing.Point(80, 31);
            this.rmale.Name = "rmale";
            this.rmale.Size = new System.Drawing.Size(82, 35);
            this.rmale.TabIndex = 0;
            this.rmale.TabStop = true;
            this.rmale.Text = "Male";
            this.rmale.UseVisualStyleBackColor = true;
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.White;
            this.txtaddress.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtaddress.Lines = new string[0];
            this.txtaddress.Location = new System.Drawing.Point(113, 215);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtaddress.MaxLength = 32767;
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtaddress.SelectedText = "";
            this.txtaddress.Size = new System.Drawing.Size(324, 71);
            this.txtaddress.TabIndex = 8;
            this.txtaddress.Tag = "Address";
            this.txtaddress.UseCustomBackColor = true;
            this.txtaddress.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Address:";
            // 
            // btnbrowse
            // 
            this.btnbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbrowse.Location = new System.Drawing.Point(1010, 249);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(165, 37);
            this.btnbrowse.TabIndex = 7;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // picturebox
            // 
            this.picturebox.Image = global::SA_PAWN_Company.Properties.Resources.Simpleicons_Interface_business_man_1_svg;
            this.picturebox.Location = new System.Drawing.Point(1010, 34);
            this.picturebox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(165, 196);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox.TabIndex = 1;
            this.picturebox.TabStop = false;
            // 
            // UCemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgEmployee);
            this.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCemployee";
            this.Size = new System.Drawing.Size(1243, 805);
            this.Load += new System.EventHandler(this.UCemployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmployee;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rfemale;
        private System.Windows.Forms.RadioButton rmale;
        private MetroFramework.Controls.MetroTextBox txtaddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtsalary;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtphone;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cbposition;
        private System.Windows.Forms.Button btnaddpos;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Button btnAdduser;
        private MetroFramework.Controls.MetroTextBox txtemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

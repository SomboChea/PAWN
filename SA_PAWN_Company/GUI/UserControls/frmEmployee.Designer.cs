
using System.Windows.Forms;

namespace SA_PAWN_Company
{
    partial class frmEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.lable = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbposition = new System.Windows.Forms.ComboBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnbrowse
            // 
            this.btnbrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnbrowse.FlatAppearance.BorderSize = 0;
            this.btnbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbrowse.Location = new System.Drawing.Point(635, 322);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(156, 35);
            this.btnbrowse.TabIndex = 2;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = false;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(80, 73);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(71, 26);
            this.lable.TabIndex = 3;
            this.lable.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(244, 70);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(307, 32);
            this.txtname.TabIndex = 4;
            this.txtname.Tag = "Name";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(80, 117);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(84, 26);
            this.Gender.TabIndex = 3;
            this.Gender.Text = "Gender";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(80, 165);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(68, 26);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(244, 162);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(307, 32);
            this.txtemail.TabIndex = 4;
            this.txtemail.Tag = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tel";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(244, 211);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(307, 32);
            this.txttel.TabIndex = 4;
            this.txttel.Tag = "Tel";
            this.txttel.TextChanged += new System.EventHandler(this.txttel_TextChanged);
            this.txttel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttel_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Salary";
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(286, 258);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(265, 32);
            this.txtsalary.TabIndex = 4;
            this.txtsalary.Tag = "Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "Address";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(244, 346);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(307, 32);
            this.txtaddress.TabIndex = 4;
            this.txtaddress.Tag = "Address";
            this.txtaddress.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 498);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 26);
            this.label8.TabIndex = 3;
            this.label8.Text = "Confirm";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(244, 406);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(307, 32);
            this.txtuser.TabIndex = 4;
            this.txtuser.Tag = "Username";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(244, 450);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(307, 32);
            this.txtpass.TabIndex = 4;
            this.txtpass.Tag = "Password";
            // 
            // txtconfirm
            // 
            this.txtconfirm.Location = new System.Drawing.Point(244, 498);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.PasswordChar = '*';
            this.txtconfirm.Size = new System.Drawing.Size(307, 32);
            this.txtconfirm.TabIndex = 4;
            this.txtconfirm.Tag = "Password";
            // 
            // cbgender
            // 
            this.cbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(244, 114);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(307, 33);
            this.cbgender.TabIndex = 5;
            this.cbgender.Tag = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 26);
            this.label9.TabIndex = 3;
            this.label9.Text = "Position";
            // 
            // cbposition
            // 
            this.cbposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbposition.FormattingEnabled = true;
            this.cbposition.Location = new System.Drawing.Point(244, 302);
            this.cbposition.Name = "cbposition";
            this.cbposition.Size = new System.Drawing.Size(197, 33);
            this.cbposition.TabIndex = 5;
            this.cbposition.Tag = "Position";
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnok.FlatAppearance.BorderSize = 0;
            this.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnok.ForeColor = System.Drawing.Color.White;
            this.btnok.Location = new System.Drawing.Point(635, 406);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(156, 50);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Red;
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(635, 480);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(156, 50);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button4.Location = new System.Drawing.Point(447, 301);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 34);
            this.button4.TabIndex = 2;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::SA_PAWN_Company.Properties.Resources.Simpleicons_Interface_business_man_1_svg;
            this.pictureBox1.Location = new System.Drawing.Point(635, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmEmployee
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(827, 551);
            this.ControlBox = false;
            this.Controls.Add(this.cbposition);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtconfirm);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    

        private Label label1;
        private PictureBox pictureBox1;
        private Button btnbrowse;

        #endregion

        private Label lable;
        private TextBox txtname;
        private Label Gender;
        private Label Email;
        private TextBox txtemail;
        private Label label5;
        private TextBox txttel;
        private Label label6;
        private TextBox txtsalary;
        private Label label7;
        private TextBox txtaddress;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label8;
        private TextBox txtuser;
        private TextBox txtpass;
        private TextBox txtconfirm;
        private ComboBox cbgender;
        private Label label9;
        private ComboBox cbposition;
        private Button btnok;
        private Button btncancel;
        private Button button4;
    }
}
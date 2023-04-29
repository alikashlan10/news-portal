
namespace software
{
    partial class Form1
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
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.firstnameTB = new System.Windows.Forms.TextBox();
            this.lastnameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.loginbtn = new System.Windows.Forms.Button();
            this.passloginTB = new System.Windows.Forms.TextBox();
            this.unloginTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Rrgisterpanel = new System.Windows.Forms.Panel();
            this.loginlinkbtn = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.readermain = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.serachbarTB = new System.Windows.Forms.TextBox();
            this.mainnewspanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.moderator = new System.Windows.Forms.Panel();
            this.loginpanel.SuspendLayout();
            this.Rrgisterpanel.SuspendLayout();
            this.readermain.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameTB
            // 
            this.usernameTB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.usernameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTB.Location = new System.Drawing.Point(180, 42);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(100, 15);
            this.usernameTB.TabIndex = 0;
            this.usernameTB.TextChanged += new System.EventHandler(this.usernameTB_TextChanged);
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTB.Location = new System.Drawing.Point(180, 81);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(100, 15);
            this.passwordTB.TabIndex = 1;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "password";
            // 
            // ageTB
            // 
            this.ageTB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ageTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ageTB.Location = new System.Drawing.Point(180, 123);
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(100, 15);
            this.ageTB.TabIndex = 5;
            this.ageTB.TextChanged += new System.EventHandler(this.ageTB_TextChanged);
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(66, 125);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(32, 17);
            this.age.TabIndex = 6;
            this.age.Text = "age";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(243, 282);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(75, 21);
            this.female.TabIndex = 7;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(178, 282);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(59, 21);
            this.male.TabIndex = 8;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // firstnameTB
            // 
            this.firstnameTB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.firstnameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstnameTB.Location = new System.Drawing.Point(178, 172);
            this.firstnameTB.Name = "firstnameTB";
            this.firstnameTB.Size = new System.Drawing.Size(100, 15);
            this.firstnameTB.TabIndex = 9;
            this.firstnameTB.TextChanged += new System.EventHandler(this.firstnameTB_TextChanged);
            // 
            // lastnameTB
            // 
            this.lastnameTB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lastnameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastnameTB.Location = new System.Drawing.Point(177, 224);
            this.lastnameTB.Name = "lastnameTB";
            this.lastnameTB.Size = new System.Drawing.Size(100, 15);
            this.lastnameTB.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "firstname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "lastname";
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.register.Location = new System.Drawing.Point(249, 340);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(159, 46);
            this.register.TabIndex = 13;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // loginpanel
            // 
            this.loginpanel.Controls.Add(this.loginbtn);
            this.loginpanel.Controls.Add(this.passloginTB);
            this.loginpanel.Controls.Add(this.unloginTB);
            this.loginpanel.Controls.Add(this.label6);
            this.loginpanel.Controls.Add(this.label3);
            this.loginpanel.Location = new System.Drawing.Point(-2, -1);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(681, 423);
            this.loginpanel.TabIndex = 14;
            this.loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginpanel_Paint);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginbtn.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginbtn.Location = new System.Drawing.Point(266, 310);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(135, 64);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // passloginTB
            // 
            this.passloginTB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.passloginTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passloginTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passloginTB.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passloginTB.Location = new System.Drawing.Point(288, 202);
            this.passloginTB.Name = "passloginTB";
            this.passloginTB.PasswordChar = '*';
            this.passloginTB.Size = new System.Drawing.Size(198, 20);
            this.passloginTB.TabIndex = 3;
            this.passloginTB.UseSystemPasswordChar = true;
            // 
            // unloginTB
            // 
            this.unloginTB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.unloginTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unloginTB.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unloginTB.Location = new System.Drawing.Point(288, 152);
            this.unloginTB.Name = "unloginTB";
            this.unloginTB.Size = new System.Drawing.Size(198, 22);
            this.unloginTB.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(170, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username";
            // 
            // Rrgisterpanel
            // 
            this.Rrgisterpanel.Controls.Add(this.loginlinkbtn);
            this.Rrgisterpanel.Controls.Add(this.label8);
            this.Rrgisterpanel.Controls.Add(this.label7);
            this.Rrgisterpanel.Controls.Add(this.register);
            this.Rrgisterpanel.Controls.Add(this.label5);
            this.Rrgisterpanel.Controls.Add(this.label4);
            this.Rrgisterpanel.Controls.Add(this.lastnameTB);
            this.Rrgisterpanel.Controls.Add(this.firstnameTB);
            this.Rrgisterpanel.Controls.Add(this.male);
            this.Rrgisterpanel.Controls.Add(this.age);
            this.Rrgisterpanel.Controls.Add(this.ageTB);
            this.Rrgisterpanel.Controls.Add(this.label2);
            this.Rrgisterpanel.Controls.Add(this.label1);
            this.Rrgisterpanel.Controls.Add(this.passwordTB);
            this.Rrgisterpanel.Controls.Add(this.usernameTB);
            this.Rrgisterpanel.Controls.Add(this.female);
            this.Rrgisterpanel.Location = new System.Drawing.Point(0, 0);
            this.Rrgisterpanel.Name = "Rrgisterpanel";
            this.Rrgisterpanel.Size = new System.Drawing.Size(681, 422);
            this.Rrgisterpanel.TabIndex = 15;
            // 
            // loginlinkbtn
            // 
            this.loginlinkbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginlinkbtn.AutoSize = true;
            this.loginlinkbtn.LinkColor = System.Drawing.Color.Teal;
            this.loginlinkbtn.Location = new System.Drawing.Point(388, 393);
            this.loginlinkbtn.Name = "loginlinkbtn";
            this.loginlinkbtn.Size = new System.Drawing.Size(38, 17);
            this.loginlinkbtn.TabIndex = 16;
            this.loginlinkbtn.TabStop = true;
            this.loginlinkbtn.Text = "login";
            this.loginlinkbtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginlinkbtn_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Already have an acount ?";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Gender";
            // 
            // readermain
            // 
            this.readermain.Controls.Add(this.button2);
            this.readermain.Controls.Add(this.serachbarTB);
            this.readermain.Controls.Add(this.mainnewspanel);
            this.readermain.Controls.Add(this.searchpanel);
            this.readermain.Location = new System.Drawing.Point(0, 0);
            this.readermain.Name = "readermain";
            this.readermain.Size = new System.Drawing.Size(678, 417);
            this.readermain.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(377, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // serachbarTB
            // 
            this.serachbarTB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.serachbarTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serachbarTB.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.serachbarTB.Location = new System.Drawing.Point(93, 17);
            this.serachbarTB.MaximumSize = new System.Drawing.Size(300, 20);
            this.serachbarTB.Name = "serachbarTB";
            this.serachbarTB.Size = new System.Drawing.Size(278, 15);
            this.serachbarTB.TabIndex = 1;
            this.serachbarTB.Text = "EX . #brekingnews";
            // 
            // mainnewspanel
            // 
            this.mainnewspanel.Location = new System.Drawing.Point(0, 39);
            this.mainnewspanel.Name = "mainnewspanel";
            this.mainnewspanel.Size = new System.Drawing.Size(681, 380);
            this.mainnewspanel.TabIndex = 0;
            this.mainnewspanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // searchpanel
            // 
            this.searchpanel.Location = new System.Drawing.Point(3, 42);
            this.searchpanel.Name = "searchpanel";
            this.searchpanel.Size = new System.Drawing.Size(677, 377);
            this.searchpanel.TabIndex = 0;
            // 
            // moderator
            // 
            this.moderator.Location = new System.Drawing.Point(0, 0);
            this.moderator.Name = "moderator";
            this.moderator.Size = new System.Drawing.Size(679, 423);
            this.moderator.TabIndex = 17;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(678, 421);
            this.Controls.Add(this.Rrgisterpanel);
            this.Controls.Add(this.loginpanel);
            this.Controls.Add(this.moderator);
            this.Controls.Add(this.readermain);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.Rrgisterpanel.ResumeLayout(false);
            this.Rrgisterpanel.PerformLayout();
            this.readermain.ResumeLayout(false);
            this.readermain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.TextBox firstnameTB;
        private System.Windows.Forms.TextBox lastnameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Rrgisterpanel;
        private System.Windows.Forms.TextBox passloginTB;
        private System.Windows.Forms.TextBox unloginTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel loginlinkbtn;
        private System.Windows.Forms.Panel readermain;
        private System.Windows.Forms.FlowLayoutPanel mainnewspanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox serachbarTB;
        private System.Windows.Forms.FlowLayoutPanel searchpanel;
        private System.Windows.Forms.Panel moderator;
    }
}


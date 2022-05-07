
namespace QA_Projects
{
    partial class RegisterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelPasswordRe = new System.Windows.Forms.Label();
            this.LabelConPassword = new System.Windows.Forms.Label();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.LinkLabelHaveAcc = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButtonReg = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TextboxPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TextboxCpass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TextboxEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TextboxFname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TextboxUser = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButtonReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-81, -83);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 750);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(671, 146);
            this.LabelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(77, 17);
            this.LabelName.TabIndex = 16;
            this.LabelName.Text = "FullName:";
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.Location = new System.Drawing.Point(668, 195);
            this.LabelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(80, 17);
            this.LabelUsername.TabIndex = 17;
            this.LabelUsername.Text = "Username:";
            this.LabelUsername.Click += new System.EventHandler(this.LabelUsername_Click);
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.Location = new System.Drawing.Point(642, 244);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(107, 17);
            this.LabelEmail.TabIndex = 18;
            this.LabelEmail.Text = "Email Address:";
            // 
            // LabelPasswordRe
            // 
            this.LabelPasswordRe.AutoSize = true;
            this.LabelPasswordRe.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPasswordRe.Location = new System.Drawing.Point(670, 292);
            this.LabelPasswordRe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPasswordRe.Name = "LabelPasswordRe";
            this.LabelPasswordRe.Size = new System.Drawing.Size(74, 17);
            this.LabelPasswordRe.TabIndex = 19;
            this.LabelPasswordRe.Text = "Password:";
            // 
            // LabelConPassword
            // 
            this.LabelConPassword.AutoSize = true;
            this.LabelConPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConPassword.Location = new System.Drawing.Point(619, 341);
            this.LabelConPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelConPassword.Name = "LabelConPassword";
            this.LabelConPassword.Size = new System.Drawing.Size(132, 17);
            this.LabelConPassword.TabIndex = 20;
            this.LabelConPassword.Text = "Confirm Password:";
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.ButtonRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegister.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRegister.Location = new System.Drawing.Point(718, 399);
            this.ButtonRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(125, 36);
            this.ButtonRegister.TabIndex = 21;
            this.ButtonRegister.Text = "Register";
            this.ButtonRegister.UseVisualStyleBackColor = false;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // LinkLabelHaveAcc
            // 
            this.LinkLabelHaveAcc.AutoSize = true;
            this.LinkLabelHaveAcc.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelHaveAcc.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.LinkLabelHaveAcc.Location = new System.Drawing.Point(848, 452);
            this.LinkLabelHaveAcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LinkLabelHaveAcc.Name = "LinkLabelHaveAcc";
            this.LinkLabelHaveAcc.Size = new System.Drawing.Size(48, 18);
            this.LinkLabelHaveAcc.TabIndex = 22;
            this.LinkLabelHaveAcc.TabStop = true;
            this.LinkLabelHaveAcc.Text = "Login";
            this.LinkLabelHaveAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelHaveAcc_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 455);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Already Have an Account?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.label2.Location = new System.Drawing.Point(602, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 38);
            this.label2.TabIndex = 24;
            this.label2.Text = "Create Your Account";
            // 
            // ExitButtonReg
            // 
            this.ExitButtonReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(205)))));
            this.ExitButtonReg.Image = ((System.Drawing.Image)(resources.GetObject("ExitButtonReg.Image")));
            this.ExitButtonReg.ImageActive = ((System.Drawing.Image)(resources.GetObject("ExitButtonReg.ImageActive")));
            this.ExitButtonReg.Location = new System.Drawing.Point(909, 2);
            this.ExitButtonReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitButtonReg.Name = "ExitButtonReg";
            this.ExitButtonReg.Size = new System.Drawing.Size(49, 26);
            this.ExitButtonReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButtonReg.TabIndex = 25;
            this.ExitButtonReg.TabStop = false;
            this.ExitButtonReg.Zoom = 10;
            this.ExitButtonReg.Click += new System.EventHandler(this.ExitButtonReg_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // TextboxPassword
            // 
            this.TextboxPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxPassword.BorderThickness = 3;
            this.TextboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxPassword.isPassword = true;
            this.TextboxPassword.Location = new System.Drawing.Point(772, 292);
            this.TextboxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.Size = new System.Drawing.Size(178, 29);
            this.TextboxPassword.TabIndex = 26;
            this.TextboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxCpass
            // 
            this.TextboxCpass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxCpass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxCpass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxCpass.BorderThickness = 3;
            this.TextboxCpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxCpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxCpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxCpass.isPassword = true;
            this.TextboxCpass.Location = new System.Drawing.Point(771, 341);
            this.TextboxCpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextboxCpass.Name = "TextboxCpass";
            this.TextboxCpass.Size = new System.Drawing.Size(178, 29);
            this.TextboxCpass.TabIndex = 27;
            this.TextboxCpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxEmail
            // 
            this.TextboxEmail.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxEmail.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxEmail.BorderThickness = 3;
            this.TextboxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxEmail.isPassword = false;
            this.TextboxEmail.Location = new System.Drawing.Point(772, 244);
            this.TextboxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextboxEmail.Name = "TextboxEmail";
            this.TextboxEmail.Size = new System.Drawing.Size(178, 29);
            this.TextboxEmail.TabIndex = 28;
            this.TextboxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxFname
            // 
            this.TextboxFname.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxFname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxFname.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxFname.BorderThickness = 3;
            this.TextboxFname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxFname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxFname.isPassword = false;
            this.TextboxFname.Location = new System.Drawing.Point(771, 146);
            this.TextboxFname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextboxFname.Name = "TextboxFname";
            this.TextboxFname.Size = new System.Drawing.Size(178, 29);
            this.TextboxFname.TabIndex = 29;
            this.TextboxFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxUser
            // 
            this.TextboxUser.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxUser.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxUser.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxUser.BorderThickness = 3;
            this.TextboxUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxUser.isPassword = false;
            this.TextboxUser.Location = new System.Drawing.Point(772, 195);
            this.TextboxUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextboxUser.Name = "TextboxUser";
            this.TextboxUser.Size = new System.Drawing.Size(178, 29);
            this.TextboxUser.TabIndex = 30;
            this.TextboxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QA_Projects.Properties.Resources.Key;
            this.pictureBox4.Location = new System.Drawing.Point(744, 341);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QA_Projects.Properties.Resources.Key;
            this.pictureBox2.Location = new System.Drawing.Point(744, 292);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.TextboxUser);
            this.Controls.Add(this.TextboxFname);
            this.Controls.Add(this.TextboxEmail);
            this.Controls.Add(this.TextboxCpass);
            this.Controls.Add(this.TextboxPassword);
            this.Controls.Add(this.ExitButtonReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LinkLabelHaveAcc);
            this.Controls.Add(this.ButtonRegister);
            this.Controls.Add(this.LabelConPassword);
            this.Controls.Add(this.LabelPasswordRe);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButtonReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelPasswordRe;
        private System.Windows.Forms.Label LabelConPassword;
        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.LinkLabel LinkLabelHaveAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton ExitButtonReg;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextboxUser;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextboxFname;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextboxEmail;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextboxCpass;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextboxPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
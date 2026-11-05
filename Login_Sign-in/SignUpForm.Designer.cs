using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

#nullable disable
namespace Login_Sign_in
{
    partial class SignUpForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            txtUser = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            btnRegister = new Button();
            linkLogin = new LinkLabel();
            SuspendLayout();
            
            
            
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(284, 59);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(87, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Tag = "title";
            lblTitle.Text = "Create account";

            
            
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(321, 116);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(120, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Tag = "muted";
            lblSubtitle.Text = "Sign up to get started";
            
            
            
            txtUser.Location = new Point(232, 182);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Username";
            txtUser.Size = new Size(300, 23);
            txtUser.TabIndex = 0;
            
            
            
            txtEmail.Location = new Point(232, 232);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(300, 23);
            txtEmail.TabIndex = 1;
            
            
            
            txtPassword.Location = new Point(232, 276);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password (min 8 characters)";
            txtPassword.Size = new Size(300, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            
            
            
            txtConfirm.Location = new Point(232, 323);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PlaceholderText = "Confirm password";
            txtConfirm.Size = new Size(300, 23);
            txtConfirm.TabIndex = 3;
            txtConfirm.UseSystemPasswordChar = true;
            
            
            
            btnRegister.Location = new Point(232, 367);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(300, 42);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Create account";
            btnRegister.Click += btnRegister_Click;
            
            
            
            linkLogin.AutoSize = true;
            linkLogin.LinkArea = new LinkArea(25, 6);
            linkLogin.Location = new Point(293, 428);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(181, 21);
            linkLogin.TabIndex = 5;
            linkLogin.TabStop = true;
            linkLogin.Text = "Already have an account? Log in";
            linkLogin.UseCompatibleTextRendering = true;
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            
            
            
            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 483);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(txtUser);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtConfirm);
            Controls.Add(btnRegister);
            Controls.Add(linkLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LGSI - Sign up";
            Load += SignUpForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblSubtitle;
        private TextBox txtUser;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirm;
        private Button btnRegister;
        private LinkLabel linkLogin;
    }
}
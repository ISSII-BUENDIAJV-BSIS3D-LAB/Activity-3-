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
    partial class Form1
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
            txtPassword = new TextBox();
            btnLogin = new Button();
            linkForgot = new LinkLabel();
            linkSignUp = new LinkLabel();
            SuspendLayout();



            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(283, 60);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(85, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Tag = "title";
            lblTitle.Text = "Welcome back";



            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(317, 139);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(127, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Tag = "muted";
            lblSubtitle.Text = "Log in to your account";
             
            
            
            txtUser.Location = new Point(232, 200);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Username";
            txtUser.Size = new Size(300, 23);
            txtUser.TabIndex = 0;
             
            
            
            txtPassword.Location = new Point(232, 257);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(300, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            
            
            
            btnLogin.Location = new Point(232, 314);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 42);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Log in";
            btnLogin.Click += btnLogin_Click;
            
            
            
            linkForgot.AutoSize = true;
            linkForgot.Location = new Point(336, 374);
            linkForgot.Name = "linkForgot";
            linkForgot.Size = new Size(100, 15);
            linkForgot.TabIndex = 3;
            linkForgot.TabStop = true;
            linkForgot.Text = "Forgot password?";
            linkForgot.LinkClicked += linkForgot_LinkClicked;
            
            
            
            linkSignUp.AutoSize = true;
            linkSignUp.LinkArea = new LinkArea(23, 7);
            linkSignUp.Location = new Point(297, 401);
            linkSignUp.Name = "linkSignUp";
            linkSignUp.Size = new Size(177, 21);
            linkSignUp.TabIndex = 4;
            linkSignUp.TabStop = true;
            linkSignUp.Text = "Don't have an account? Sign up";
            linkSignUp.UseCompatibleTextRendering = true;
            linkSignUp.LinkClicked += linkSignUp_LinkClicked;
            
            
            
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 484);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(txtUser);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(linkForgot);
            Controls.Add(linkSignUp);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LGSI - Log in";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblSubtitle;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel linkForgot;
        private LinkLabel linkSignUp;
    }
}
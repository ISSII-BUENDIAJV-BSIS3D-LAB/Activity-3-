using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace Login_Sign_in
{
    partial class ForgotPasswordForm
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
            txtNewPassword = new TextBox();
            txtConfirm = new TextBox();
            btnReset = new Button();
            linkBack = new LinkLabel();
            SuspendLayout();
            
            
            
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(294, 49);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(88, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Tag = "title";
            lblTitle.Text = "Reset password";
            
            
            
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(307, 97);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(171, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Tag = "muted";
            lblSubtitle.Text = "Enter your username and email";
            
            
            
            txtUser.Location = new Point(240, 149);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Username";
            txtUser.Size = new Size(300, 23);
            txtUser.TabIndex = 0;
         


            txtEmail.Location = new Point(240, 200);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email on your account";
            txtEmail.Size = new Size(300, 23);
            txtEmail.TabIndex = 1;
            


            txtNewPassword.Location = new Point(240, 252);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PlaceholderText = "New password (min 8 characters)";
            txtNewPassword.Size = new Size(300, 23);
            txtNewPassword.TabIndex = 2;
            txtNewPassword.UseSystemPasswordChar = true;
         


            txtConfirm.Location = new Point(240, 304);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PlaceholderText = "Confirm new password";
            txtConfirm.Size = new Size(300, 23);
            txtConfirm.TabIndex = 3;
            txtConfirm.UseSystemPasswordChar = true;
         


            btnReset.Location = new Point(240, 358);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(300, 42);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset password";
            btnReset.Click += btnReset_Click;
            


            linkBack.AutoSize = true;
            linkBack.Location = new Point(354, 420);
            linkBack.Name = "linkBack";
            linkBack.Size = new Size(79, 15);
            linkBack.TabIndex = 5;
            linkBack.TabStop = true;
            linkBack.Text = "Back to log in";
            linkBack.LinkClicked += linkBack_LinkClicked;
           


            AcceptButton = btnReset;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 500);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(txtUser);
            Controls.Add(txtEmail);
            Controls.Add(txtNewPassword);
            Controls.Add(txtConfirm);
            Controls.Add(btnReset);
            Controls.Add(linkBack);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LGSI - Reset password";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblSubtitle;
        private TextBox txtUser;
        private TextBox txtEmail;
        private TextBox txtNewPassword;
        private TextBox txtConfirm;
        private Button btnReset;
        private LinkLabel linkBack;
    }
}
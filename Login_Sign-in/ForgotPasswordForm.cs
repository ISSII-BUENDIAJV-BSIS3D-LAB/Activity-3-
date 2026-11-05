using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
using System.Drawing;
using System.Net.Mail;

namespace Login_Sign_in
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
            Theme.Apply(this);
        }

        private static bool ValidEmail(string email)
        {
            try { return new MailAddress(email).Address == email; }
            catch { return false; }
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string email = txtEmail.Text.Trim();
            string pass = txtNewPassword.Text;

            if (user == "" || !ValidEmail(email)) { MessageBox.Show("Enter your username and a valid email."); return; }
            if (pass.Length < 8) { MessageBox.Show("Password must be at least 8 characters."); return; }
            if (pass != txtConfirm.Text) { MessageBox.Show("Passwords do not match."); return; }

            try
            {
                if (Db.ResetPassword(user, email, pass))
                {
                    MessageBox.Show("Password updated! You can now log in.");
                    Close();
                }
                else
                {
                    MessageBox.Show("No account matches that username and email.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }
    }
}
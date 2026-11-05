using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Mail;

namespace Login_Sign_in
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            Theme.Apply(this);

        }

        private static bool ValidEmail(string email)
        {
            try { return new MailAddress(email).Address == email; }
            catch { return false; }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string email = txtEmail.Text.Trim();
            string pass = txtPassword.Text;

            if (user.Length < 3) { MessageBox.Show("Username must be at least 3 characters."); return; }
            if (!ValidEmail(email)) { MessageBox.Show("Please enter a valid email."); return; }
            if (pass.Length < 8) { MessageBox.Show("Password must be at least 8 characters."); return; }
            if (pass != txtConfirm.Text) { MessageBox.Show("Passwords do not match."); return; }

            try
            {
                if (Db.Exists(user, email))
                {
                    MessageBox.Show("That username or email is already registered.");
                    return;
                }
                Db.Register(user, email, pass);
                MessageBox.Show("Account created! You can now log in.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }
    }
}   
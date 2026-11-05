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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Theme.Apply(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPassword.Text;

            if (user == "" || pass == "")
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            try
            {
                if (Db.Login(user, pass))
                {
                    var dash = new DashboardForm(user);
                    dash.FormClosed += (s, args) => Close();
                    Hide();
                    dash.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                    txtPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using var f = new SignUpForm();
            f.ShowDialog(this);
        }

        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using var f = new ForgotPasswordForm();
            f.ShowDialog(this);
        }

    }
}
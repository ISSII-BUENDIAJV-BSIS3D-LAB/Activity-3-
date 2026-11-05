using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace Login_Sign_in
{
    public partial class DashboardForm : Form
    {
        public DashboardForm(string userName)
        {
            InitializeComponent();
            Theme.Apply(this);
            lblWelcome.Text = $"Welcome, {userName}!";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
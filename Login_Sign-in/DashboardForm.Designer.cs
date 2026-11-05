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
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            lblBrand = new Label();
            btnLogout = new Button();
            lblWelcome = new Label();
            lblSubtitle = new Label();
            pnlSidebar.SuspendLayout();
            SuspendLayout();

            pnlSidebar.Controls.Add(lblBrand);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(200, 450);
            pnlSidebar.Tag = "sidebar";

            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(24, 30);
            lblBrand.Name = "lblBrand";
            lblBrand.Tag = "brand";
            lblBrand.Text = "LGSI";

            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.Location = new Point(24, 392);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(152, 38);
            btnLogout.Tag = "secondary";
            btnLogout.Text = "Log out";
            btnLogout.Click += btnLogout_Click;

            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(240, 60);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Tag = "title";
            lblWelcome.Text = "Welcome!";

            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(242, 112);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Tag = "muted";
            lblSubtitle.Text = "You're signed in.";

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 450);
            Controls.Add(lblWelcome);
            Controls.Add(lblSubtitle);
            Controls.Add(pnlSidebar);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LGSI - Dashboard";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel pnlSidebar;
        private Label lblBrand;
        private Button btnLogout;
        private Label lblWelcome;
        private Label lblSubtitle;
    }
}
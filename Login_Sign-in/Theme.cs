using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
using System.Drawing;

namespace Login_Sign_in
{
    public static class Theme
    {
        
        public static readonly Color Accent = Color.FromArgb(79, 70, 229);
        public static readonly Color AccentHover = Color.FromArgb(67, 56, 202);
        public static readonly Color Background = Color.White;
        public static readonly Color TextDark = Color.FromArgb(17, 24, 39);
        public static readonly Color TextMuted = Color.FromArgb(107, 114, 128);
        public static readonly Color InputBack = Color.FromArgb(249, 250, 251);
        public static readonly Color Sidebar = Color.FromArgb(30, 27, 75);

        private static System.Drawing.Font F(string name, float size) =>
            new System.Drawing.Font(name, size);

        public static void Apply(Form form)
        {
            form.BackColor = Background;
            form.ForeColor = TextDark;
            Style(form.Controls);
        }

        private static void Style(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                string tag = c.Tag as string;

                switch (c)
                {
                    case Button b:
                        StyleButton(b);
                        break;

                    case TextBox t:
                        t.BorderStyle = BorderStyle.FixedSingle;
                        t.BackColor = InputBack;
                        t.Font = F("Segoe UI", 11F);
                        break;

                    case LinkLabel l:
                        l.LinkColor = Accent;
                        l.ActiveLinkColor = AccentHover;
                        l.VisitedLinkColor = Accent;
                        l.LinkBehavior = LinkBehavior.HoverUnderline;
                        l.ForeColor = TextMuted;
                        break;

                    case Label l:
                        if (tag == "title") { l.Font = F("Segoe UI Semibold", 22F); l.ForeColor = TextDark; }
                        else if (tag == "muted") { l.Font = F("Segoe UI", 10F); l.ForeColor = TextMuted; }
                        else if (tag == "brand") { l.Font = F("Segoe UI Semibold", 18F); l.ForeColor = Color.White; }
                        break;

                    case Panel p:
                        if (tag == "sidebar") p.BackColor = Sidebar;
                        break;
                }

                if (c.HasChildren) Style(c.Controls);
            }
        }

        private static void StyleButton(Button b)
        {
            bool secondary = (b.Tag as string) == "secondary";
            Color normal = secondary ? Color.FromArgb(229, 231, 235) : Accent;
            Color hover = secondary ? Color.FromArgb(209, 213, 219) : AccentHover;

            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.UseVisualStyleBackColor = false;
            b.BackColor = normal;
            b.ForeColor = secondary ? TextDark : Color.White;
            b.Font = F("Segoe UI Semibold", 10.5F);
            b.Cursor = Cursors.Hand;
            b.MouseEnter += (s, e) => b.BackColor = hover;
            b.MouseLeave += (s, e) => b.BackColor = normal;
        }
    }
}
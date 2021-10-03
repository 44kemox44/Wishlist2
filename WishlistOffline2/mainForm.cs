using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace WishlistOffline2
{
    public partial class mainForm : Form
    {

        Color photoColor1= Color.FromArgb(132, 132, 132);

        #region Mouse Drag
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        /*
         
        if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

         */

        #endregion


        // replace one color with another
        private void ChangeColor(Bitmap s, System.Drawing.Color source, System.Drawing.Color target)
        {
            for (int x = 0; x < s.Width; x++)
            {
                for (int y = 0; y < s.Height; y++)
                {
                    if (s.GetPixel(x, y) == source)
                        s.SetPixel(x, y, target);
                }
            }
        }

        public mainForm()
        {
            InitializeComponent();
        }

        private void cursorChange(object sender)
        {
            homeButton.Cursor = Cursors.Hand;
            settingsButton.Cursor = Cursors.Hand;
            wishlistButton.Cursor = Cursors.Hand;

            ((Guna2Button)sender).Cursor = Cursors.Arrow;

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

            homeButton.PerformClick();

            ChangeColor((Bitmap)homeButton.Image, Color.FromArgb(255, 94, 151, 246), photoColor1);

            usernameLabel.Text = Global.username;

        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void wishlistButton_Click(object sender, EventArgs e)
        {
            //Active button panel teleported to the button's location
            activeButtonPanel.Location = wishlistButton.Location;

            //Cursor settings
            cursorChange(sender);

            //Create settings user control
            if (!userControlPanel.Controls.Contains(wishlistUserControl.instance))
            {
                userControlPanel.Controls.Add(wishlistUserControl.instance);
                wishlistUserControl.instance.Dock = DockStyle.Fill;
                wishlistUserControl.instance.BringToFront();
            }
            else
            {
                wishlistUserControl.instance.BringToFront();
            }


        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            //Active button panel teleported to the button's location
            activeButtonPanel.Location = homeButton.Location;

            //Cursor settings
            cursorChange(sender);

            //Create settings user control
            if (!userControlPanel.Controls.Contains(homeUserControl.instance))
            {
                userControlPanel.Controls.Add(homeUserControl.instance);
                homeUserControl.instance.Dock = DockStyle.Fill;
                homeUserControl.instance.BringToFront();
            }
            else
            {
                homeUserControl.instance.BringToFront();
            }

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            //Active button panel teleported to the button's location
            activeButtonPanel.Location = settingsButton.Location;

            //Cursor settings
            cursorChange(sender);

            //Create settings user control
            if (!userControlPanel.Controls.Contains(settingsUserControl.instance))
            {
                userControlPanel.Controls.Add(settingsUserControl.instance);
                settingsUserControl.instance.Dock = DockStyle.Fill;
                settingsUserControl.instance.BringToFront();
            }
            else
            {
                settingsUserControl.instance.BringToFront();
            }

            settingsUserControl.instance.main_form = this;

        }

    }
}

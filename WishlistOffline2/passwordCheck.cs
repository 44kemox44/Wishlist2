using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WishlistOffline2
{
    public partial class passwordCheck : Form
    {

        public settingsUserControl settings_userControl;
        public bool isCorrect;


        #region Mouse Drag
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        public passwordCheck()
        {
            InitializeComponent();
        }

        private void closeBox_Click(object sender, EventArgs e)
        {

            settings_userControl.editButton.Enabled = true;
            settings_userControl.saveButton.Enabled = false;

            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

            //If password is correct
            if(Global.password == confirmPasswordTextbox.Text)
            {
                isCorrect = true;
                errorLabel.Visible = false;

                this.Close();

                settings_userControl.confirmButtonNoError_Click();
            }
            else //Else / error
            {
                isCorrect = false;
                errorLabel.Visible = true;
            }

        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}

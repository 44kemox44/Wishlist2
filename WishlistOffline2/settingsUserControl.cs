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
    public partial class settingsUserControl : UserControl
    {

        passwordCheck password_check;

        public mainForm main_form;

        private static settingsUserControl _instance;

        public static settingsUserControl instance
        {
            get 
            {
                if (_instance == null)
                {
                    _instance = new settingsUserControl();
                }
                return _instance;
            }
        }

        public settingsUserControl()
        {
            InitializeComponent();
        }

        private void settingsUserControl_Load(object sender, EventArgs e)
        {

            usernameTextbox.Text = Global.username;
            emailTextbox.Text = Global.email;
            passwordTextbox.Text = Global.password;
        }

        private void editButton_Click(object sender, EventArgs e)
        {

            password_check = new passwordCheck();
            password_check.settings_userControl = this;
            password_check.Show();

            editButton.Enabled = false;

        }

        //Password check form for whether confirm button clicked
        public void confirmButtonNoError_Click()
        {

            errorLabel.Visible = false;

            saveButton.Enabled = true;
            saveButton.Cursor = Cursors.Hand;

            usernameTextbox.Enabled = true;
            emailTextbox.Enabled = true;
            passwordTextbox.Enabled = true;

            passwordTextbox.Text = "";
            passwordTextbox.PasswordChar = '\0';
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            //If any textbox is empty
            if(String.IsNullOrEmpty(usernameTextbox.Text) || String.IsNullOrEmpty(emailTextbox.Text) || String.IsNullOrEmpty(passwordTextbox.Text))
            {
                usernameTextbox.Text = Global.username;
                emailTextbox.Text = Global.email;
                passwordTextbox.Text = Global.password;

                usernameTextbox.Enabled = false;
                emailTextbox.Enabled = false;
                passwordTextbox.Enabled = false;

                passwordTextbox.PasswordChar = '*';

                errorLabel.Text = "No field can be empty";
                errorLabel.Visible = true;

                editButton.Enabled = true;
                saveButton.Enabled = false;
                saveButton.Cursor = Cursors.Arrow;
                editButton.Cursor = Cursors.Hand;

            }else
            {

            }

        }

        private void enableDeveloperTools_CheckedChanged(object sender, EventArgs e)
        {

            if(enableDeveloperTools.Checked == true) //checked
            {

                var confirmResult = MessageBox.Show("Are you sure to enable?","Enable Developer Tools", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // If 'Yes', do something here.
                    main_form.developerButton.Visible = true; //show developer button
                }
                else
                {
                    // If 'No', do something here.
                    enableDeveloperTools.Checked = false;
                    main_form.developerButton.Visible = false; //hide developer button
                }

            }else //not checked
            {
                main_form.developerButton.Visible = false; //hide developer button
            }

           

        }

    }
}

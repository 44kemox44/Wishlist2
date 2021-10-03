using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;


namespace WishlistOffline2
{
    public partial class authForm : Form
    {

        private int passwordSecurity;
        bool[] isDone = new bool[5];
        public bool isLoggedIn  { get; set; }

        #region Sql Variables

        static string database = Global.database;
        static string table = Global.usersTable;

        string createDatabaseString = "CREATE DATABASE " + database;
        string createTableString = "CREATE TABLE " + table + " (" +
                                                    "\nUsername varchar(15)," +
                                                    "\nPassword varchar(30)," +
                                                    "\n Email varchar(50)" +
                                                    "\n);";
        #endregion

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

        public authForm()
        {
            InitializeComponent();
            //Resize form and tabpages
            signPages.Size = new Size(378, 379);
            this.Size = new Size(435, 545);


        }

        private void authTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void loginSelectButton_Click(object sender, EventArgs e)
        {

            //Change cursor and select tab
            signupSelectButton.Cursor = Cursors.Hand;
            loginSelectButton.Cursor = Cursors.Arrow;
            signPages.SelectTab(0);

            //Resize form and tabpages
            signPages.Size = new Size(378, 379);
            this.Size = new Size(435, 545);

        }

        private void signupSelectButton_Click(object sender, EventArgs e)
        {

            //Change cursor and select tab
            signupSelectButton.Cursor = Cursors.Arrow;
            loginSelectButton.Cursor = Cursors.Hand;
            signPages.SelectTab(1);

            //Resize form and tabpages
            signPages.Size = new Size(378, 501);
            this.Size = new Size(435, 666);

        }

        //check has special char function
        private bool HasSpecialChars(string yourString)
        {
            return yourString.Any(ch => !Char.IsLetterOrDigit(ch));
        }

        private void signupPasswordTextbox_TextChanged(object sender, EventArgs e)
        {

            //Is done?
            isDone[0] = HasSpecialChars(signupPasswordTextbox.Text); //has special char
            isDone[1] = Regex.IsMatch(signupPasswordTextbox.Text, @"[a-z]"); //has lowercase letter
            isDone[2] = Regex.IsMatch(signupPasswordTextbox.Text, @"[A-Z]"); //has uppercase letter
            isDone[3] = Regex.IsMatch(signupPasswordTextbox.Text, @"[1-9]"); // has numbers
            isDone[4] = signupPasswordTextbox.Text.Length > 7; //length is bigger than 7

            //Security calculator
            passwordSecurity = Convert.ToInt32(isDone[0]) * 30 + Convert.ToInt32(isDone[1]) * 10 + Convert.ToInt32(isDone[2]) * 30 + Convert.ToInt32(isDone[3]) * 10 + Convert.ToInt32(isDone[4]) * 20;

            //Strength bar value = security
            passwordStrengthBar.Value = passwordSecurity;

            #region Progress Color
            if (passwordSecurity >= 10 &&  passwordSecurity < 40)
            {
                passwordStrengthBar.ProgressColor = Color.Red;
                passwordStrengthBar.ProgressColor2 = Color.Red;
            }
            else if(passwordSecurity >= 40 && passwordSecurity < 70)
            {
                passwordStrengthBar.ProgressColor = Color.Goldenrod;
                passwordStrengthBar.ProgressColor2 = Color.Goldenrod;
            }
            else if(passwordSecurity >= 70 && passwordSecurity < 90)
            {
                passwordStrengthBar.ProgressColor = Color.DodgerBlue;
                passwordStrengthBar.ProgressColor2 = Color.DodgerBlue;
            }
            else if (passwordSecurity >= 90 && passwordSecurity <= 100)
            {
                passwordStrengthBar.ProgressColor = Color.DarkOliveGreen;
                passwordStrengthBar.ProgressColor2 = Color.DarkOliveGreen;
            }
            #endregion


        }

        public void CreateDatabaseIfNotExists(string connectionString, string dbName)
        {
            SqlCommand cmd = null;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (cmd = new SqlCommand($"If(db_id(N'{dbName}') IS NULL) CREATE DATABASE [{dbName}]", connection))
                {
                    cmd.ExecuteNonQuery();
                    Global.database = dbName;
                }
                connection.Close();
            }
        }

        public void CreateTableIfNotExists(string connectionString , string tableName)
        {

            string cmdString = "IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME='" + tableName + "')" +
                                  "\nBEGIN" +
                                  "\n   CREATE TABLE " + tableName + " (" +
                                  "\n   Username varchar(20)," +
                                  "\n   Email varchar(50)," +
                                  "\n   Password varchar(30)" +
                                  "\n   ); END";

                using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(cmdString, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }


        }

      

        private void authForm_Load(object sender, EventArgs e)
        {

            rememberCheckbox.Checked = Properties.Settings.Default.Remember;

            if (Properties.Settings.Default.Remember)
            {
                loginUsernameTextbox.Text = Properties.Settings.Default.Username;
            }


            CreateDatabaseIfNotExists("Server=.;Database=;User Id=muz;Password=muz;","Wishlist");
            CreateTableIfNotExists(Global.connectionString,Global.usersTable);

        }

        private bool checkSignUp()
        {

            //Simple errors
            if(signupUsernameTextbox.Text.Length < 5 || String.IsNullOrEmpty(signupPasswordTextbox.Text) || String.IsNullOrEmpty(signupEmailTextbox.Text))
            {
                signupErrorLabel.Text = "Please complete all areas before signing up.";
                return false;
            }

            //Password not confirmed
            if (signupPasswordTextbox.Text != signupConfirmPasswordTextbox.Text)
            {
                signupErrorLabel.Text = "Passwords are not same.";
                return false;
            }

            //Password not secure
            if (passwordSecurity < 30)
            {
                signupErrorLabel.Text = "Password is not secure enough!";
                return false;
            }

            //If there is already user signed with this name/email , return false
            using(var connection = new SqlConnection(Global.connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM "+ Global.usersTable,connection);
                connection.Open();
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    
                    while(reader.Read())
                    {

                        if(signupUsernameTextbox.Text == reader.GetString(0) || signupEmailTextbox.Text == reader.GetString(1))
                        {
                            signupErrorLabel.Text = "There is an already user registered with this username/email.";
                            return false;
                        }

                    }

                }

            }

            return true;
        }

        private void insertIntoSql(string username,string email,string password)
        {
            string cmdString = "INSERT INTO " + table + " (Username, Email, Password)" +
                                "\nVALUES('" + username + "', '" + email + "', '" + password + "'); ";

            using (var connection = new SqlConnection(Global.connectionString))
            {
                SqlCommand cmd = new SqlCommand(cmdString, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {

            if(checkSignUp() == false) //Failure
            {
                signupErrorLabel.Visible = true;
            }
            else //Signup successful
            {
                signupErrorLabel.Visible = false;

                #region Send Email
                #endregion

                insertIntoSql(signupUsernameTextbox.Text,signupEmailTextbox.Text,signupPasswordTextbox.Text);
                signupUsernameTextbox.Text = "";
                signupEmailTextbox.Text = "";
                signupConfirmPasswordTextbox.Text = "";
                signupPasswordTextbox.Text = "";

                MessageBox.Show("User Created Successfuly");

            }



        }

        public bool checkLogin()
        {
            Properties.Settings.Default.Remember = rememberCheckbox.Checked;
            Properties.Settings.Default.Save();

            using (var connection = new SqlConnection(Global.connectionString))
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM " + table, connection);
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        //Successful login
                        if (reader.GetString(0) == loginUsernameTextbox.Text && reader.GetString(2) == loginPasswordTextbox.Text)
                        {

                            Properties.Settings.Default.Username = reader.GetString(0);
                            Properties.Settings.Default.Save();

                            Global.username = reader.GetString(0);
                            Global.email = reader.GetString(1);
                            Global.password = reader.GetString(2);

                            loginErrorLabel.Visible = false;
                            connection.Close();
                            isLoggedIn = true;
                            return true;
                        }

                    }

                }

                //Error
                loginErrorLabel.Visible = true;
                loginErrorLabel.Text = "No User Found";
                connection.Close();
                isLoggedIn = false;
                return false;
            }


        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            //If login
            if(checkLogin()==true)
            {
                MessageBox.Show("You logged in successfully!");


                this.Close();
            }else //If failure
            {

            }

        }

    }

}

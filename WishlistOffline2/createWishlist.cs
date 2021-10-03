using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WishlistOffline2
{
    public partial class createWishlist : Form
    {

        public wishlistUserControl wishlist_userControl;

        #region Mouse Drag
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        

        public createWishlist()
        {
            InitializeComponent();
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            wishlist_userControl.addWishlist.Enabled = true;
            this.Close();           
        }

        public bool CreateTableIfNotExists(string connectionString, string tableName)
        {
            // bool 
            bool success=true;

            var dateString = DateTime.Now.ToString("dd_MM_yyyy");

            string cmdString = "IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME='" + tableName + "')" +
                                  "\nBEGIN" +
                                  "\n   CREATE TABLE " + tableName + " (" +
                                  "\n   ItemName varchar(20)," +                                
                                  "\n   Website varchar(30)," +
                                   "\n   Url varchar(max)," +
                                   "\n   Image varbinary(max)," +
                                   "\n   Price varchar(20)" +
                                  "\n   ); END";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(cmdString, connection);
                try
                {
                    cmd.ExecuteNonQuery();
                }catch
                {
                    MessageBox.Show("Invalid Table Name");
                    success = false; //Failure
                }
                
                connection.Close();
            }

            return success;
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void insertInto(string text , SqlConnection connection)
        {
            string cmdString = "INSERT INTO " + Global.wishlistNamesTable + " (WishlistNames,WishlistCreator) VALUES('" + text + "','" + Global.username + "'); ";
            SqlCommand cmd = new SqlCommand(cmdString, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            wishlist_userControl.addWishlist.Enabled = true;

            using(SqlConnection connection = new SqlConnection(Global.connectionString))
            {
                try
                {

                    //Select all from table
                    SqlCommand cmd = new SqlCommand("SELECT * FROM " + Global.wishlistNamesTable,connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    //If there is already , throw error
                    while(reader.Read())
                    {
                        if(reader.GetString(0) == createWishlistTextbox.Text)
                        {
                            throw new InvalidOperationException("There is a wishlist already with this name.");
                        }

                    }

                    connection.Close();

                    //If table creating not failure
                    if (CreateTableIfNotExists(Global.connectionString, createWishlistTextbox.Text) == true)
                    {
                        //insert data to database
                        insertInto(createWishlistTextbox.Text, connection);
                        //create wishlist display with 70 padding
                        wishlist_userControl.createWishlistDisplay(70, createWishlistTextbox.Text);

                    }



                }
                catch(Exception Ex)
                {

                    Console.WriteLine(Ex.Message);

                    if(Ex.Message == "There is a wishlist already with this name.")
                    {
                        MessageBox.Show(Ex.Message);
                    }
                   


                }

            }
            this.Close();

        }



    }
}

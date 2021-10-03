using LiveCharts;
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
    public partial class wishlistUserControl : UserControl
    {

        private static wishlistUserControl _instance;

        public List<wishlistDisplay> wishlist_displayList = new List<wishlistDisplay>();

        public static wishlistUserControl instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new wishlistUserControl();
                }
                return _instance;
            }
        }

        public wishlistUserControl()
        {
            InitializeComponent();
        }

        private void searchTextbox_IconRightClick(object sender, EventArgs e)
        {
            MessageBox.Show("a");
        }

        public void createWishlistDisplay(int space,string wishlistName)
        {
            //Create wishlist display with settings
            Panel panel = new Panel();
            wishlistMainPanel.Controls.Add(panel);
            panel.Dock = DockStyle.Top;
            panel.Size = new Size(panel.Size.Width, space);

            wishlistDisplay wishlist_display = new wishlistDisplay();

            wishlist_displayList.Add(wishlist_display);

            wishlist_display.wishlist_userControl = this;
            wishlist_display.wishlistName.Text = wishlistName;
            wishlistMainPanel.Controls.Add(wishlist_display);
            wishlist_display.Dock = DockStyle.Top;
            wishlist_display.Show();

        }

        public void CreateTableIfNotExists(string connectionString, string tableName)
        {

            string cmdString = "IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME='" + tableName + "')" +
                                  "\nBEGIN" +
                                  "\n   CREATE TABLE " + tableName + " (" +
                                  "\n   WishlistNames varchar(20)," +
                                   "\n   WishlistCreator varchar(30)" +
                                  "\n   ); END";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(cmdString, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }


        }

        private void wishlistUserControl_Load(object sender, EventArgs e)
        {

            //Create table if not exists
            CreateTableIfNotExists(Global.connectionString, Global.wishlistNamesTable);

            //Select all wishlist names
            using (SqlConnection connection = new SqlConnection(Global.connectionString))
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM "+ Global.wishlistNamesTable + " WHERE WishlistCreator='" + Global.username + "';",connection);
                connection.Open();

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    for(int i =0;  reader.Read(); i++) //add wishlist display as much as we have
                    {
                        createWishlistDisplay(70, reader.GetString(0));
                    }
                }

                connection.Close();
            }

        }

        private void addWishlist_Click(object sender, EventArgs e)
        {

            //Add Wishlist 
            addWishlist.Enabled = false;

            //New create wishlist form
            createWishlist create_wishlist = new createWishlist();
            create_wishlist.wishlist_userControl = this;
            create_wishlist.Show();
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {


            //If search box is empty
            if(string.IsNullOrEmpty(searchTextbox.Text))
            {

                //Show every wishlistdisplay
                foreach(wishlistDisplay display in wishlist_displayList)
                {
                    display.Show();
                }

            }else //If search box is not empty
            {

                //For every control
                foreach (wishlistDisplay display in wishlist_displayList)
                {

                    //Hide display
                    display.Hide();
                    //If display contains
                    if(display.wishlistName.Text.Contains(searchTextbox.Text))
                    {
                        display.Show(); //if display contains the search content , show it
                    }

                }

            }

        }

    }
}

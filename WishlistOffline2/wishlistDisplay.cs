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
    public partial class wishlistDisplay : UserControl
    {

        public wishlistUserControl wishlist_userControl;

        public wishlistDisplay()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Are you sure to delete this item ?",
                                     "Delete Wishlist",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes) //delete
            {
                // If 'Yes', do something here.
                using (SqlConnection connection = new SqlConnection(Global.connectionString))
                {
                    //Delete table name from wishlistnames
                    SqlCommand cmd = new SqlCommand("DELETE FROM " + Global.wishlistNamesTable + " WHERE WishlistNames='" + wishlistName.Text + "';", connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    //Delete table itself
                    cmd = new SqlCommand("DROP TABLE " + wishlistName.Text, connection);
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }

                //MessageBox.Show(wishlistName.Text);
                this.Dispose(); //Destroy object
                                // wishlist_userControl.Controls.Remove(wishlistName);
            }
            else //dont delete
            {
                // If 'No', do something here.
            }



        }

        private void showButton_Click(object sender, EventArgs e)
        {

            //Disable button
            showButton.Enabled = false;
            deleteButton.Enabled = false;

            //Create wishlist form
            Wishlist wishlist = new Wishlist();
            wishlist.wishlist_display = this;
            wishlist.wishlist_userControl = wishlist_userControl;
            wishlist.Show();

        }

    }
}

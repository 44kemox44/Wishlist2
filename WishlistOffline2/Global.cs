using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WishlistOffline2
{
    class Global
    {

        static public string database = "Wishlist";
        static public string usersTable = "users";
        static public string wishlistNamesTable = "Wishlist_Name";
        static public string connectionString = "Server=.;Database="+ database + ";User Id=muz;Password=muz;";

        static private string _username;
        static private string _password;
        static private string _email;

        public static string username
        {
            get { return _username; }
            set { _username = value; }
        }

        public static string password
        {
            get { return _password; }
            set { _password = value; }
        }

        public static string email
        {
            get { return _email; }
            set { _email = value; }
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WishlistOffline2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            authForm auth_form = new authForm();
            Application.Run(auth_form);

            if(auth_form.isLoggedIn)
            {
                mainForm main_form = new mainForm();
                Application.Run(main_form);

            }

        }

    }
}

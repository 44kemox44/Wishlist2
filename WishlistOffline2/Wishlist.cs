using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WishlistOffline2
{
    public partial class Wishlist : Form
    {

        #region variables
        public static string n11_price = "\"lowPrice\": \"";

        public wishlistUserControl wishlist_userControl;
        public wishlistDisplay wishlist_display;

        public bool currentPageNotFull = true;

        private static int differenceX = 180;
        private static int differenceY = 250;

        #endregion

        #region Mouse Drag
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion


        public Wishlist()
        {
            InitializeComponent();
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public string GetHTML(string url)
        {
            //Create request for given url
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);

            //Create response-object
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Take response stream
            StreamReader sr = new StreamReader(response.GetResponseStream());

            //Read response stream (html code)
            string html = sr.ReadToEnd();

            //Close streamreader and response
            sr.Close();
            response.Close();

            //return source
            return html;
        }

        private string JsScrap(string website,string url,string split1)
        {

            //If website is n11
            if(website=="n11")
            {
                try
                {
                    string[] a = Regex.Split(GetHTML(url), split1);

                    string[] b = a[1].Split('\"');

                    return b[0]; //return price
                }
                catch (Exception Ex)
                {
                    //MessageBox.Show("Link is not valid!");
                    return "ERROR"; //error
                }

            }


            return "Website not found!"; //website not found
        }

        private string WebsiteCheck(string url)
        {

            return null;
        }



        //Auto Fill
        private void AutoFillButton_Click(object sender, EventArgs e)
        {
            string url = urlTextbox.Text;


            #region Image Fill
            try
            {
                itemPictureBox.Load(imageUrlTextbox.Text);
            }catch
            {
                errorLabel.Text = "Image couldn't find!";
                errorLabel.Visible = true;
            }
            
            #endregion

            #region Price Fill

            if (websiteCombobox.SelectedItem == "n11.com")
            {
                string scrapString = JsScrap("n11", url, n11_price);

                //if website not found , error
                if (scrapString == "Website not found!")
                {
                    errorLabel.Text = "Website not found!";
                    errorLabel.Visible = true;
                }else
                {
                    priceTextbox.Text = scrapString;
                }
                

            }


            #endregion

        }


        private void AddProductUserControl(System.Drawing.Point position,string productName,string price,Image image ,TabPage page)
        {

            //add wishlist product user control and change its variables
            wishlistProductUserControl wishlist_productUserControl = new wishlistProductUserControl();
            wishlist_productUserControl.Location = position;



            try
            {
                wishlist_productUserControl.productNameLabel.Text = productName;
                wishlist_productUserControl.priceLabel.Text = price;
                wishlist_productUserControl.productPicturebox.Image = image;
            }catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            page.Controls.Add(wishlist_productUserControl);

        }


        //BE CAREFUL -- IT OPENS CONNECTION BUT NOT CLOSE
        public void UserControlOrganizer(SqlConnection connection,TabPage page)
        {

            Image tempImage = null;
            bool end = false;

            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM " + wishlistNameTextbox.Text, connection);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {

                    //while read all items
                    for (int positionY = 10; !end; positionY += differenceY)
                    {

                        for (int positionX = 6; positionX + differenceX < page.Width; positionX += differenceX)
                        {

                            //if there is still item
                            if (reader.Read())
                            {

                                //MessageBox.Show(reader.GetString(0) + " " + positionX.ToString());
                                //add product user control

                                if (!Convert.IsDBNull(reader["Image"]))
                                {
                                    Byte[] data = new Byte[0];
                                    data = (Byte[])(reader["Image"]);
                                    MemoryStream mem = new MemoryStream(data);
                                    tempImage = Image.FromStream(mem);
                                }
                                else
                                {

                                }

                                AddProductUserControl(new Point(positionX, positionY), reader.GetString(0), reader.GetString(4), tempImage, page);

                            }else //if not read
                            {
                            end = true;
                            }

                        }

                    }


                

            }

        }

        private void Wishlist_Load(object sender, EventArgs e)
        {

            //Add wishlist page --> wishlist name textbox is wishlist name
            wishlistNameTextbox.Text = wishlist_display.wishlistName.Text;

            using(SqlConnection connection = new SqlConnection(Global.connectionString))
            {

                //opens connection but dont close
                UserControlOrganizer(connection,tabPage1);
                connection.Close();

            }

        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            wishlist_display.showButton.Enabled = true;
            wishlist_display.deleteButton.Enabled = true;
            this.Close();

        }

        //convert image to binary array
        public byte[] ImageToByteArray(System.Drawing.Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        //Clean form after adding product
        private void CleanForm()
        {
            itemNameTextbox.Text = "";
            imageUrlTextbox.Text = "";
            websiteCombobox.SelectedItem = "Other";
            urlTextbox.Text = "";
            priceTextbox.Text = "";

            itemPictureBox.Image = null;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

            //If there is empty field --> failure
            if(string.IsNullOrEmpty(itemNameTextbox.Text) || 
                string.IsNullOrEmpty(priceTextbox.Text) || 
                itemPictureBox.Image == null ||
                string.IsNullOrEmpty(urlTextbox.Text) ||
                websiteCombobox.SelectedItem == null)
            {
                //No field can be empty error
                errorLabel.Text = "No field can be empty!";
                errorLabel.Visible = true;
            }
            else
            {
                //success
                errorLabel.Visible = false;                

                //Insert information to sql server
                using (SqlConnection connection = new SqlConnection(Global.connectionString))
                {
                    var dateString = DateTime.Now.ToString("dd_MM_yyyy");

                    string cmdString = "INSERT INTO " + wishlistNameTextbox.Text +  "(ItemName, Website, Url, Image, Price)" +
                                                   "VALUES('" + itemNameTextbox.Text + "', '" + websiteCombobox.SelectedItem.ToString() + "', '" + urlTextbox.Text + "', @Image, '" + priceTextbox.Text +  "'" + ");";

                    //MessageBox.Show(cmdString);

                    //Connect , execute command and close connection
                    SqlCommand cmd = new SqlCommand(cmdString,connection);
                    cmd.Parameters.Add(new SqlParameter("@Image", ImageToByteArray(itemPictureBox.Image)));
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    //All data inserted

                    CleanForm();

                    //Create new tab page for added product
                    TabPage tabPageTemp = new TabPage();

                    pageControl.Controls.Clear();
                    pageControl.Controls.Add(tabPageTemp);

                    //Organize user control
                    // opens connection but not close
                    UserControlOrganizer(new SqlConnection(Global.connectionString), tabPageTemp);
                    connection.Close();

                }



            }

        }

        private void wishlistPages_SelectedIndexChanged(object sender, EventArgs e)
        {

           

        }

    }
}
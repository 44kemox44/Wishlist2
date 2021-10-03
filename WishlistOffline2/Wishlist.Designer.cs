
namespace WishlistOffline2
{
    partial class Wishlist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wishlist));
            this.titleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.closeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.wishlistPages = new Guna.UI2.WinForms.Guna2TabControl();
            this.viewWishlistItemsPage = new System.Windows.Forms.TabPage();
            this.pageControl = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.searchTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.previousPageButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.nextPageButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.addWishlistItemPage = new System.Windows.Forms.TabPage();
            this.errorLabel = new System.Windows.Forms.Label();
            this.imageUrlLabel = new System.Windows.Forms.Label();
            this.imageUrlTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.websiteLabel = new System.Windows.Forms.Label();
            this.websiteCombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.wishlistNameLabel = new System.Windows.Forms.Label();
            this.wishlistNameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.confirmButton = new Guna.UI2.WinForms.Guna2Button();
            this.autoFillButton = new Guna.UI2.WinForms.Guna2Button();
            this.urlTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemNameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.itemPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.titleBar.SuspendLayout();
            this.wishlistPages.SuspendLayout();
            this.viewWishlistItemsPage.SuspendLayout();
            this.pageControl.SuspendLayout();
            this.addWishlistItemPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.Controls.Add(this.guna2ControlBox1);
            this.titleBar.Controls.Add(this.closeBox);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.FillColor = System.Drawing.Color.DarkGray;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.ShadowDecoration.Parent = this.titleBar;
            this.titleBar.Size = new System.Drawing.Size(991, 18);
            this.titleBar.TabIndex = 2;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Firebrick;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(901, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 18);
            this.guna2ControlBox1.TabIndex = 5;
            // 
            // closeBox
            // 
            this.closeBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBox.FillColor = System.Drawing.Color.Firebrick;
            this.closeBox.HoverState.Parent = this.closeBox;
            this.closeBox.IconColor = System.Drawing.Color.White;
            this.closeBox.Location = new System.Drawing.Point(946, 0);
            this.closeBox.Name = "closeBox";
            this.closeBox.ShadowDecoration.Parent = this.closeBox;
            this.closeBox.Size = new System.Drawing.Size(45, 18);
            this.closeBox.TabIndex = 4;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            // 
            // wishlistPages
            // 
            this.wishlistPages.Controls.Add(this.viewWishlistItemsPage);
            this.wishlistPages.Controls.Add(this.addWishlistItemPage);
            this.wishlistPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wishlistPages.ItemSize = new System.Drawing.Size(180, 40);
            this.wishlistPages.Location = new System.Drawing.Point(0, 18);
            this.wishlistPages.Name = "wishlistPages";
            this.wishlistPages.SelectedIndex = 0;
            this.wishlistPages.Size = new System.Drawing.Size(991, 631);
            this.wishlistPages.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.wishlistPages.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.wishlistPages.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.wishlistPages.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.wishlistPages.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.wishlistPages.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.wishlistPages.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.wishlistPages.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.wishlistPages.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.wishlistPages.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.wishlistPages.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.wishlistPages.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.wishlistPages.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.wishlistPages.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.wishlistPages.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.wishlistPages.TabButtonSize = new System.Drawing.Size(180, 40);
            this.wishlistPages.TabIndex = 3;
            this.wishlistPages.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.wishlistPages.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.wishlistPages.SelectedIndexChanged += new System.EventHandler(this.wishlistPages_SelectedIndexChanged);
            // 
            // viewWishlistItemsPage
            // 
            this.viewWishlistItemsPage.AutoScroll = true;
            this.viewWishlistItemsPage.Controls.Add(this.pageControl);
            this.viewWishlistItemsPage.Controls.Add(this.searchTextbox);
            this.viewWishlistItemsPage.Controls.Add(this.previousPageButton);
            this.viewWishlistItemsPage.Controls.Add(this.nextPageButton);
            this.viewWishlistItemsPage.Location = new System.Drawing.Point(4, 44);
            this.viewWishlistItemsPage.Name = "viewWishlistItemsPage";
            this.viewWishlistItemsPage.Padding = new System.Windows.Forms.Padding(20, 35, 20, 20);
            this.viewWishlistItemsPage.Size = new System.Drawing.Size(983, 583);
            this.viewWishlistItemsPage.TabIndex = 0;
            this.viewWishlistItemsPage.Text = "View Wishlist Items";
            this.viewWishlistItemsPage.UseVisualStyleBackColor = true;
            // 
            // pageControl
            // 
            this.pageControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pageControl.AllowTransitions = true;
            this.pageControl.Controls.Add(this.tabPage1);
            this.pageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageControl.Location = new System.Drawing.Point(20, 35);
            this.pageControl.Multiline = true;
            this.pageControl.Name = "pageControl";
            this.pageControl.Page = this.tabPage1;
            this.pageControl.PageIndex = 0;
            this.pageControl.PageName = "tabPage1";
            this.pageControl.PageTitle = "page1";
            this.pageControl.SelectedIndex = 0;
            this.pageControl.Size = new System.Drawing.Size(943, 528);
            this.pageControl.TabIndex = 7;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.pageControl.Transition = animation1;
            this.pageControl.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(935, 502);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "page1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // searchTextbox
            // 
            this.searchTextbox.BorderColor = System.Drawing.Color.Gray;
            this.searchTextbox.BorderRadius = 10;
            this.searchTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextbox.DefaultText = "";
            this.searchTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextbox.DisabledState.Parent = this.searchTextbox;
            this.searchTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextbox.FocusedState.Parent = this.searchTextbox;
            this.searchTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTextbox.ForeColor = System.Drawing.Color.Black;
            this.searchTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextbox.HoverState.Parent = this.searchTextbox;
            this.searchTextbox.IconRight = global::WishlistOffline2.Properties.Resources.magnifying_glass;
            this.searchTextbox.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.searchTextbox.IconRightOffset = new System.Drawing.Point(0, -1);
            this.searchTextbox.IconRightSize = new System.Drawing.Size(15, 15);
            this.searchTextbox.Location = new System.Drawing.Point(8, 4);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.PasswordChar = '\0';
            this.searchTextbox.PlaceholderText = "Search";
            this.searchTextbox.SelectedText = "";
            this.searchTextbox.ShadowDecoration.Parent = this.searchTextbox;
            this.searchTextbox.Size = new System.Drawing.Size(171, 28);
            this.searchTextbox.TabIndex = 3;
            // 
            // previousPageButton
            // 
            this.previousPageButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.previousPageButton.CheckedState.Parent = this.previousPageButton;
            this.previousPageButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.previousPageButton.HoverState.Parent = this.previousPageButton;
            this.previousPageButton.Image = global::WishlistOffline2.Properties.Resources.arrowhead_pointing_to_the_left;
            this.previousPageButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.previousPageButton.ImageRotate = 0F;
            this.previousPageButton.ImageSize = new System.Drawing.Size(18, 18);
            this.previousPageButton.Location = new System.Drawing.Point(23, 434);
            this.previousPageButton.Name = "previousPageButton";
            this.previousPageButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.previousPageButton.PressedState.Parent = this.previousPageButton;
            this.previousPageButton.ShadowDecoration.Parent = this.previousPageButton;
            this.previousPageButton.Size = new System.Drawing.Size(18, 18);
            this.previousPageButton.TabIndex = 6;
            // 
            // nextPageButton
            // 
            this.nextPageButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.nextPageButton.CheckedState.Parent = this.nextPageButton;
            this.nextPageButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.nextPageButton.HoverState.Parent = this.nextPageButton;
            this.nextPageButton.Image = global::WishlistOffline2.Properties.Resources.arrowhead_pointing_to_the_right;
            this.nextPageButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.nextPageButton.ImageRotate = 0F;
            this.nextPageButton.ImageSize = new System.Drawing.Size(18, 18);
            this.nextPageButton.Location = new System.Drawing.Point(42, 434);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.nextPageButton.PressedState.Parent = this.nextPageButton;
            this.nextPageButton.ShadowDecoration.Parent = this.nextPageButton;
            this.nextPageButton.Size = new System.Drawing.Size(18, 18);
            this.nextPageButton.TabIndex = 5;
            // 
            // addWishlistItemPage
            // 
            this.addWishlistItemPage.Controls.Add(this.errorLabel);
            this.addWishlistItemPage.Controls.Add(this.imageUrlLabel);
            this.addWishlistItemPage.Controls.Add(this.imageUrlTextbox);
            this.addWishlistItemPage.Controls.Add(this.label2);
            this.addWishlistItemPage.Controls.Add(this.websiteLabel);
            this.addWishlistItemPage.Controls.Add(this.websiteCombobox);
            this.addWishlistItemPage.Controls.Add(this.wishlistNameLabel);
            this.addWishlistItemPage.Controls.Add(this.wishlistNameTextbox);
            this.addWishlistItemPage.Controls.Add(this.confirmButton);
            this.addWishlistItemPage.Controls.Add(this.autoFillButton);
            this.addWishlistItemPage.Controls.Add(this.urlTextbox);
            this.addWishlistItemPage.Controls.Add(this.label1);
            this.addWishlistItemPage.Controls.Add(this.priceLabel);
            this.addWishlistItemPage.Controls.Add(this.priceTextbox);
            this.addWishlistItemPage.Controls.Add(this.itemNameLabel);
            this.addWishlistItemPage.Controls.Add(this.itemNameTextbox);
            this.addWishlistItemPage.Controls.Add(this.itemPictureBox);
            this.addWishlistItemPage.Location = new System.Drawing.Point(4, 44);
            this.addWishlistItemPage.Name = "addWishlistItemPage";
            this.addWishlistItemPage.Padding = new System.Windows.Forms.Padding(3);
            this.addWishlistItemPage.Size = new System.Drawing.Size(983, 583);
            this.addWishlistItemPage.TabIndex = 1;
            this.addWishlistItemPage.Text = "Add Wishlist Item";
            this.addWishlistItemPage.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Adobe Hebrew", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(34, 538);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(44, 20);
            this.errorLabel.TabIndex = 143;
            this.errorLabel.Text = "Error";
            this.errorLabel.Visible = false;
            // 
            // imageUrlLabel
            // 
            this.imageUrlLabel.AutoSize = true;
            this.imageUrlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.imageUrlLabel.Location = new System.Drawing.Point(564, 303);
            this.imageUrlLabel.Name = "imageUrlLabel";
            this.imageUrlLabel.Size = new System.Drawing.Size(95, 20);
            this.imageUrlLabel.TabIndex = 142;
            this.imageUrlLabel.Text = "Image URL:";
            // 
            // imageUrlTextbox
            // 
            this.imageUrlTextbox.BorderColor = System.Drawing.Color.DimGray;
            this.imageUrlTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.imageUrlTextbox.DefaultText = "";
            this.imageUrlTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.imageUrlTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.imageUrlTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.imageUrlTextbox.DisabledState.Parent = this.imageUrlTextbox;
            this.imageUrlTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.imageUrlTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.imageUrlTextbox.FocusedState.Parent = this.imageUrlTextbox;
            this.imageUrlTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.imageUrlTextbox.ForeColor = System.Drawing.Color.Black;
            this.imageUrlTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.imageUrlTextbox.HoverState.Parent = this.imageUrlTextbox;
            this.imageUrlTextbox.Location = new System.Drawing.Point(665, 298);
            this.imageUrlTextbox.Name = "imageUrlTextbox";
            this.imageUrlTextbox.PasswordChar = '\0';
            this.imageUrlTextbox.PlaceholderText = "Put Image Url Here";
            this.imageUrlTextbox.SelectedText = "";
            this.imageUrlTextbox.ShadowDecoration.Parent = this.imageUrlTextbox;
            this.imageUrlTextbox.Size = new System.Drawing.Size(300, 25);
            this.imageUrlTextbox.TabIndex = 141;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(140, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 140;
            this.label2.Text = "URL:";
            // 
            // websiteLabel
            // 
            this.websiteLabel.AutoSize = true;
            this.websiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.websiteLabel.Location = new System.Drawing.Point(66, 250);
            this.websiteLabel.Name = "websiteLabel";
            this.websiteLabel.Size = new System.Drawing.Size(71, 20);
            this.websiteLabel.TabIndex = 139;
            this.websiteLabel.Text = "Website:";
            // 
            // websiteCombobox
            // 
            this.websiteCombobox.BackColor = System.Drawing.Color.Transparent;
            this.websiteCombobox.BorderColor = System.Drawing.Color.DimGray;
            this.websiteCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.websiteCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.websiteCombobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.websiteCombobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.websiteCombobox.FocusedState.Parent = this.websiteCombobox;
            this.websiteCombobox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.websiteCombobox.ForeColor = System.Drawing.Color.Black;
            this.websiteCombobox.HoverState.Parent = this.websiteCombobox;
            this.websiteCombobox.ItemHeight = 30;
            this.websiteCombobox.Items.AddRange(new object[] {
            "n11.com",
            "trendyol.com",
            "hepsiburada.com",
            "gittigidiyor.com",
            "amazon.com",
            "amazon.com.tr",
            "Other"});
            this.websiteCombobox.ItemsAppearance.Parent = this.websiteCombobox;
            this.websiteCombobox.Location = new System.Drawing.Point(141, 240);
            this.websiteCombobox.Name = "websiteCombobox";
            this.websiteCombobox.ShadowDecoration.Parent = this.websiteCombobox;
            this.websiteCombobox.Size = new System.Drawing.Size(163, 36);
            this.websiteCombobox.TabIndex = 138;
            // 
            // wishlistNameLabel
            // 
            this.wishlistNameLabel.AutoSize = true;
            this.wishlistNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wishlistNameLabel.Location = new System.Drawing.Point(25, 151);
            this.wishlistNameLabel.Name = "wishlistNameLabel";
            this.wishlistNameLabel.Size = new System.Drawing.Size(113, 20);
            this.wishlistNameLabel.TabIndex = 137;
            this.wishlistNameLabel.Text = "Wishlist Name:";
            // 
            // wishlistNameTextbox
            // 
            this.wishlistNameTextbox.BorderColor = System.Drawing.Color.DimGray;
            this.wishlistNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.wishlistNameTextbox.DefaultText = "";
            this.wishlistNameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.wishlistNameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.wishlistNameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.wishlistNameTextbox.DisabledState.Parent = this.wishlistNameTextbox;
            this.wishlistNameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.wishlistNameTextbox.Enabled = false;
            this.wishlistNameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.wishlistNameTextbox.FocusedState.Parent = this.wishlistNameTextbox;
            this.wishlistNameTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.wishlistNameTextbox.ForeColor = System.Drawing.Color.Black;
            this.wishlistNameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.wishlistNameTextbox.HoverState.Parent = this.wishlistNameTextbox;
            this.wishlistNameTextbox.Location = new System.Drawing.Point(141, 147);
            this.wishlistNameTextbox.Name = "wishlistNameTextbox";
            this.wishlistNameTextbox.PasswordChar = '\0';
            this.wishlistNameTextbox.PlaceholderText = "Wishlist Name";
            this.wishlistNameTextbox.SelectedText = "";
            this.wishlistNameTextbox.ShadowDecoration.Parent = this.wishlistNameTextbox;
            this.wishlistNameTextbox.Size = new System.Drawing.Size(97, 27);
            this.wishlistNameTextbox.TabIndex = 136;
            // 
            // confirmButton
            // 
            this.confirmButton.CheckedState.Parent = this.confirmButton;
            this.confirmButton.CustomImages.Parent = this.confirmButton;
            this.confirmButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.confirmButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.confirmButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.confirmButton.DisabledState.Parent = this.confirmButton;
            this.confirmButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.HoverState.Parent = this.confirmButton;
            this.confirmButton.Location = new System.Drawing.Point(819, 513);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.ShadowDecoration.Parent = this.confirmButton;
            this.confirmButton.Size = new System.Drawing.Size(146, 45);
            this.confirmButton.TabIndex = 135;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // autoFillButton
            // 
            this.autoFillButton.CheckedState.Parent = this.autoFillButton;
            this.autoFillButton.CustomImages.Parent = this.autoFillButton;
            this.autoFillButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.autoFillButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.autoFillButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.autoFillButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.autoFillButton.DisabledState.Parent = this.autoFillButton;
            this.autoFillButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.autoFillButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.autoFillButton.ForeColor = System.Drawing.Color.White;
            this.autoFillButton.HoverState.Parent = this.autoFillButton;
            this.autoFillButton.Location = new System.Drawing.Point(676, 462);
            this.autoFillButton.Name = "autoFillButton";
            this.autoFillButton.ShadowDecoration.Parent = this.autoFillButton;
            this.autoFillButton.Size = new System.Drawing.Size(55, 22);
            this.autoFillButton.TabIndex = 134;
            this.autoFillButton.Text = "Fill";
            this.autoFillButton.Click += new System.EventHandler(this.AutoFillButton_Click);
            // 
            // urlTextbox
            // 
            this.urlTextbox.BorderColor = System.Drawing.Color.DimGray;
            this.urlTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.urlTextbox.DefaultText = "";
            this.urlTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.urlTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.urlTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.urlTextbox.DisabledState.Parent = this.urlTextbox;
            this.urlTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.urlTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.urlTextbox.FocusedState.Parent = this.urlTextbox;
            this.urlTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.urlTextbox.ForeColor = System.Drawing.Color.Black;
            this.urlTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.urlTextbox.HoverState.Parent = this.urlTextbox;
            this.urlTextbox.Location = new System.Drawing.Point(141, 462);
            this.urlTextbox.Name = "urlTextbox";
            this.urlTextbox.PasswordChar = '\0';
            this.urlTextbox.PlaceholderText = "Url";
            this.urlTextbox.SelectedText = "";
            this.urlTextbox.ShadowDecoration.Parent = this.urlTextbox;
            this.urlTextbox.Size = new System.Drawing.Size(529, 22);
            this.urlTextbox.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(192, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 132;
            this.label1.Text = "₺";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.priceLabel.Location = new System.Drawing.Point(90, 98);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 20);
            this.priceLabel.TabIndex = 131;
            this.priceLabel.Text = "Price:";
            // 
            // priceTextbox
            // 
            this.priceTextbox.BorderColor = System.Drawing.Color.DimGray;
            this.priceTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTextbox.DefaultText = "";
            this.priceTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTextbox.DisabledState.Parent = this.priceTextbox;
            this.priceTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTextbox.FocusedState.Parent = this.priceTextbox;
            this.priceTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.priceTextbox.ForeColor = System.Drawing.Color.Black;
            this.priceTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTextbox.HoverState.Parent = this.priceTextbox;
            this.priceTextbox.Location = new System.Drawing.Point(141, 94);
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.PasswordChar = '\0';
            this.priceTextbox.PlaceholderText = "Price";
            this.priceTextbox.SelectedText = "";
            this.priceTextbox.ShadowDecoration.Parent = this.priceTextbox;
            this.priceTextbox.Size = new System.Drawing.Size(45, 27);
            this.priceTextbox.TabIndex = 130;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.itemNameLabel.Location = new System.Drawing.Point(46, 45);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(91, 20);
            this.itemNameLabel.TabIndex = 128;
            this.itemNameLabel.Text = "Item Name:";
            // 
            // itemNameTextbox
            // 
            this.itemNameTextbox.BorderColor = System.Drawing.Color.DimGray;
            this.itemNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itemNameTextbox.DefaultText = "";
            this.itemNameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.itemNameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.itemNameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemNameTextbox.DisabledState.Parent = this.itemNameTextbox;
            this.itemNameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemNameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemNameTextbox.FocusedState.Parent = this.itemNameTextbox;
            this.itemNameTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.itemNameTextbox.ForeColor = System.Drawing.Color.Black;
            this.itemNameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemNameTextbox.HoverState.Parent = this.itemNameTextbox;
            this.itemNameTextbox.Location = new System.Drawing.Point(141, 41);
            this.itemNameTextbox.Name = "itemNameTextbox";
            this.itemNameTextbox.PasswordChar = '\0';
            this.itemNameTextbox.PlaceholderText = "Please Enter Item Name";
            this.itemNameTextbox.SelectedText = "";
            this.itemNameTextbox.ShadowDecoration.Parent = this.itemNameTextbox;
            this.itemNameTextbox.Size = new System.Drawing.Size(163, 27);
            this.itemNameTextbox.TabIndex = 127;
            // 
            // itemPictureBox
            // 
            this.itemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPictureBox.ImageRotate = 0F;
            this.itemPictureBox.Location = new System.Drawing.Point(665, 15);
            this.itemPictureBox.Name = "itemPictureBox";
            this.itemPictureBox.ShadowDecoration.Parent = this.itemPictureBox;
            this.itemPictureBox.Size = new System.Drawing.Size(300, 275);
            this.itemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemPictureBox.TabIndex = 129;
            this.itemPictureBox.TabStop = false;
            // 
            // Wishlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(991, 649);
            this.Controls.Add(this.wishlistPages);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Wishlist";
            this.Text = "Wishlist";
            this.Load += new System.EventHandler(this.Wishlist_Load);
            this.titleBar.ResumeLayout(false);
            this.wishlistPages.ResumeLayout(false);
            this.viewWishlistItemsPage.ResumeLayout(false);
            this.pageControl.ResumeLayout(false);
            this.addWishlistItemPage.ResumeLayout(false);
            this.addWishlistItemPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel titleBar;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox closeBox;
        private Guna.UI2.WinForms.Guna2TabControl wishlistPages;
        private System.Windows.Forms.TabPage viewWishlistItemsPage;
        private System.Windows.Forms.TabPage addWishlistItemPage;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label imageUrlLabel;
        private Guna.UI2.WinForms.Guna2TextBox imageUrlTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label websiteLabel;
        private Guna.UI2.WinForms.Guna2ComboBox websiteCombobox;
        private System.Windows.Forms.Label wishlistNameLabel;
        private Guna.UI2.WinForms.Guna2TextBox wishlistNameTextbox;
        private Guna.UI2.WinForms.Guna2Button confirmButton;
        private Guna.UI2.WinForms.Guna2Button autoFillButton;
        private Guna.UI2.WinForms.Guna2TextBox urlTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label priceLabel;
        private Guna.UI2.WinForms.Guna2TextBox priceTextbox;
        private Guna.UI2.WinForms.Guna2PictureBox itemPictureBox;
        private System.Windows.Forms.Label itemNameLabel;
        private Guna.UI2.WinForms.Guna2TextBox itemNameTextbox;
        private Guna.UI2.WinForms.Guna2TextBox searchTextbox;
        private Guna.UI2.WinForms.Guna2ImageButton nextPageButton;
        private Guna.UI2.WinForms.Guna2ImageButton previousPageButton;
        private Bunifu.UI.WinForms.BunifuPages pageControl;
        private System.Windows.Forms.TabPage tabPage1;
    }
}
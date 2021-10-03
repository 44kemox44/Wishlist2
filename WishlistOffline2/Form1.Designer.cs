
namespace WishlistOffline2
{
    partial class authForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authForm));
            this.authTitleBar = new System.Windows.Forms.Panel();
            this.minimizeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.closeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginSelectButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.signupSelectButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.signPages = new Bunifu.UI.WinForms.BunifuPages();
            this.signInPage = new System.Windows.Forms.TabPage();
            this.rememberCheckbox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.loginButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginPasswordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginUsernameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.signUpPage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.signupConfirmPasswordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.signupEmailTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordStrengthLabel = new System.Windows.Forms.Label();
            this.passwordStrengthBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.signupButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.signupPasswordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.signupUsernameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.signupErrorLabel = new System.Windows.Forms.Label();
            this.loginErrorLabel = new System.Windows.Forms.Label();
            this.authTitleBar.SuspendLayout();
            this.signPages.SuspendLayout();
            this.signInPage.SuspendLayout();
            this.signUpPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // authTitleBar
            // 
            this.authTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(217)))));
            this.authTitleBar.Controls.Add(this.minimizeBox);
            this.authTitleBar.Controls.Add(this.closeBox);
            this.authTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.authTitleBar.Location = new System.Drawing.Point(0, 0);
            this.authTitleBar.Name = "authTitleBar";
            this.authTitleBar.Size = new System.Drawing.Size(472, 25);
            this.authTitleBar.TabIndex = 0;
            this.authTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.authTitleBar_MouseDown);
            // 
            // minimizeBox
            // 
            this.minimizeBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimizeBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeBox.FillColor = System.Drawing.Color.DarkBlue;
            this.minimizeBox.HoverState.Parent = this.minimizeBox;
            this.minimizeBox.IconColor = System.Drawing.Color.White;
            this.minimizeBox.Location = new System.Drawing.Point(382, 0);
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.ShadowDecoration.Parent = this.minimizeBox;
            this.minimizeBox.Size = new System.Drawing.Size(45, 25);
            this.minimizeBox.TabIndex = 1;
            // 
            // closeBox
            // 
            this.closeBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBox.FillColor = System.Drawing.Color.DarkBlue;
            this.closeBox.HoverState.Parent = this.closeBox;
            this.closeBox.IconColor = System.Drawing.Color.White;
            this.closeBox.Location = new System.Drawing.Point(427, 0);
            this.closeBox.Name = "closeBox";
            this.closeBox.ShadowDecoration.Parent = this.closeBox;
            this.closeBox.Size = new System.Drawing.Size(45, 25);
            this.closeBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(122, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login Form";
            // 
            // loginSelectButton
            // 
            this.loginSelectButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.loginSelectButton.BorderRadius = 5;
            this.loginSelectButton.BorderThickness = 1;
            this.loginSelectButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.loginSelectButton.Checked = true;
            this.loginSelectButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(98)))), ((int)(((byte)(180)))));
            this.loginSelectButton.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(217)))));
            this.loginSelectButton.CheckedState.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loginSelectButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.loginSelectButton.CheckedState.Parent = this.loginSelectButton;
            this.loginSelectButton.Cursor = System.Windows.Forms.Cursors.No;
            this.loginSelectButton.CustomImages.Parent = this.loginSelectButton;
            this.loginSelectButton.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.loginSelectButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginSelectButton.DisabledState.FillColor = System.Drawing.Color.White;
            this.loginSelectButton.DisabledState.FillColor2 = System.Drawing.Color.White;
            this.loginSelectButton.DisabledState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginSelectButton.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.loginSelectButton.DisabledState.Parent = this.loginSelectButton;
            this.loginSelectButton.FillColor = System.Drawing.Color.White;
            this.loginSelectButton.FillColor2 = System.Drawing.Color.White;
            this.loginSelectButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loginSelectButton.ForeColor = System.Drawing.Color.Black;
            this.loginSelectButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.loginSelectButton.HoverState.Parent = this.loginSelectButton;
            this.loginSelectButton.Location = new System.Drawing.Point(78, 98);
            this.loginSelectButton.Name = "loginSelectButton";
            this.loginSelectButton.ShadowDecoration.Parent = this.loginSelectButton;
            this.loginSelectButton.Size = new System.Drawing.Size(131, 44);
            this.loginSelectButton.TabIndex = 2;
            this.loginSelectButton.Text = "Log In";
            this.loginSelectButton.Click += new System.EventHandler(this.loginSelectButton_Click);
            // 
            // signupSelectButton
            // 
            this.signupSelectButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.signupSelectButton.BorderRadius = 5;
            this.signupSelectButton.BorderThickness = 1;
            this.signupSelectButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.signupSelectButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(98)))), ((int)(((byte)(180)))));
            this.signupSelectButton.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(217)))));
            this.signupSelectButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.signupSelectButton.CheckedState.Parent = this.signupSelectButton;
            this.signupSelectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupSelectButton.CustomImages.Parent = this.signupSelectButton;
            this.signupSelectButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signupSelectButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signupSelectButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signupSelectButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signupSelectButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signupSelectButton.DisabledState.Parent = this.signupSelectButton;
            this.signupSelectButton.FillColor = System.Drawing.Color.White;
            this.signupSelectButton.FillColor2 = System.Drawing.Color.White;
            this.signupSelectButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.signupSelectButton.ForeColor = System.Drawing.Color.Black;
            this.signupSelectButton.HoverState.Parent = this.signupSelectButton;
            this.signupSelectButton.Location = new System.Drawing.Point(209, 98);
            this.signupSelectButton.Name = "signupSelectButton";
            this.signupSelectButton.ShadowDecoration.Parent = this.signupSelectButton;
            this.signupSelectButton.Size = new System.Drawing.Size(131, 44);
            this.signupSelectButton.TabIndex = 3;
            this.signupSelectButton.Text = "Sign Up";
            this.signupSelectButton.Click += new System.EventHandler(this.signupSelectButton_Click);
            // 
            // signPages
            // 
            this.signPages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.signPages.AllowTransitions = true;
            this.signPages.Controls.Add(this.signInPage);
            this.signPages.Controls.Add(this.signUpPage);
            this.signPages.Location = new System.Drawing.Point(22, 152);
            this.signPages.Multiline = true;
            this.signPages.Name = "signPages";
            this.signPages.Page = this.signInPage;
            this.signPages.PageIndex = 0;
            this.signPages.PageName = "signInPage";
            this.signPages.PageTitle = "sign_in";
            this.signPages.SelectedIndex = 0;
            this.signPages.Size = new System.Drawing.Size(435, 545);
            this.signPages.TabIndex = 8;
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
            this.signPages.Transition = animation1;
            this.signPages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // signInPage
            // 
            this.signInPage.Controls.Add(this.loginErrorLabel);
            this.signInPage.Controls.Add(this.rememberCheckbox);
            this.signInPage.Controls.Add(this.loginButton);
            this.signInPage.Controls.Add(this.label3);
            this.signInPage.Controls.Add(this.label2);
            this.signInPage.Controls.Add(this.loginPasswordTextbox);
            this.signInPage.Controls.Add(this.loginUsernameTextbox);
            this.signInPage.Location = new System.Drawing.Point(4, 4);
            this.signInPage.Name = "signInPage";
            this.signInPage.Padding = new System.Windows.Forms.Padding(3);
            this.signInPage.Size = new System.Drawing.Size(427, 519);
            this.signInPage.TabIndex = 0;
            this.signInPage.Text = "sign_in";
            this.signInPage.UseVisualStyleBackColor = true;
            // 
            // rememberCheckbox
            // 
            this.rememberCheckbox.AutoSize = true;
            this.rememberCheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rememberCheckbox.CheckedState.BorderRadius = 0;
            this.rememberCheckbox.CheckedState.BorderThickness = 0;
            this.rememberCheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rememberCheckbox.Location = new System.Drawing.Point(50, 221);
            this.rememberCheckbox.Name = "rememberCheckbox";
            this.rememberCheckbox.Size = new System.Drawing.Size(95, 17);
            this.rememberCheckbox.TabIndex = 12;
            this.rememberCheckbox.Text = "Remember Me";
            this.rememberCheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rememberCheckbox.UncheckedState.BorderRadius = 0;
            this.rememberCheckbox.UncheckedState.BorderThickness = 0;
            this.rememberCheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // loginButton
            // 
            this.loginButton.BorderRadius = 5;
            this.loginButton.CheckedState.Parent = this.loginButton;
            this.loginButton.CustomImages.Parent = this.loginButton;
            this.loginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginButton.DisabledState.Parent = this.loginButton;
            this.loginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(98)))), ((int)(((byte)(180)))));
            this.loginButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(217)))));
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.loginButton.HoverState.Parent = this.loginButton;
            this.loginButton.Location = new System.Drawing.Point(50, 291);
            this.loginButton.Name = "loginButton";
            this.loginButton.ShadowDecoration.Parent = this.loginButton;
            this.loginButton.Size = new System.Drawing.Size(271, 45);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Log In";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(54, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(55, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username:";
            // 
            // loginPasswordTextbox
            // 
            this.loginPasswordTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.loginPasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginPasswordTextbox.DefaultText = "";
            this.loginPasswordTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginPasswordTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginPasswordTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginPasswordTextbox.DisabledState.Parent = this.loginPasswordTextbox;
            this.loginPasswordTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginPasswordTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginPasswordTextbox.FocusedState.Parent = this.loginPasswordTextbox;
            this.loginPasswordTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginPasswordTextbox.ForeColor = System.Drawing.Color.Black;
            this.loginPasswordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginPasswordTextbox.HoverState.Parent = this.loginPasswordTextbox;
            this.loginPasswordTextbox.Location = new System.Drawing.Point(49, 164);
            this.loginPasswordTextbox.Name = "loginPasswordTextbox";
            this.loginPasswordTextbox.PasswordChar = '*';
            this.loginPasswordTextbox.PlaceholderText = "Enter Password";
            this.loginPasswordTextbox.SelectedText = "";
            this.loginPasswordTextbox.ShadowDecoration.Parent = this.loginPasswordTextbox;
            this.loginPasswordTextbox.Size = new System.Drawing.Size(271, 42);
            this.loginPasswordTextbox.TabIndex = 9;
            // 
            // loginUsernameTextbox
            // 
            this.loginUsernameTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.loginUsernameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginUsernameTextbox.DefaultText = "";
            this.loginUsernameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginUsernameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginUsernameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginUsernameTextbox.DisabledState.Parent = this.loginUsernameTextbox;
            this.loginUsernameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginUsernameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginUsernameTextbox.FocusedState.Parent = this.loginUsernameTextbox;
            this.loginUsernameTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginUsernameTextbox.ForeColor = System.Drawing.Color.Black;
            this.loginUsernameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginUsernameTextbox.HoverState.Parent = this.loginUsernameTextbox;
            this.loginUsernameTextbox.Location = new System.Drawing.Point(50, 75);
            this.loginUsernameTextbox.Name = "loginUsernameTextbox";
            this.loginUsernameTextbox.PasswordChar = '\0';
            this.loginUsernameTextbox.PlaceholderText = "Enter Username";
            this.loginUsernameTextbox.SelectedText = "";
            this.loginUsernameTextbox.ShadowDecoration.Parent = this.loginUsernameTextbox;
            this.loginUsernameTextbox.Size = new System.Drawing.Size(271, 42);
            this.loginUsernameTextbox.TabIndex = 8;
            // 
            // signUpPage
            // 
            this.signUpPage.Controls.Add(this.signupErrorLabel);
            this.signUpPage.Controls.Add(this.label6);
            this.signUpPage.Controls.Add(this.signupConfirmPasswordTextbox);
            this.signUpPage.Controls.Add(this.label7);
            this.signUpPage.Controls.Add(this.signupEmailTextbox);
            this.signUpPage.Controls.Add(this.passwordStrengthLabel);
            this.signUpPage.Controls.Add(this.passwordStrengthBar);
            this.signUpPage.Controls.Add(this.signupButton);
            this.signUpPage.Controls.Add(this.label4);
            this.signUpPage.Controls.Add(this.label5);
            this.signUpPage.Controls.Add(this.signupPasswordTextbox);
            this.signUpPage.Controls.Add(this.signupUsernameTextbox);
            this.signUpPage.Location = new System.Drawing.Point(4, 4);
            this.signUpPage.Name = "signUpPage";
            this.signUpPage.Padding = new System.Windows.Forms.Padding(3);
            this.signUpPage.Size = new System.Drawing.Size(427, 519);
            this.signUpPage.TabIndex = 1;
            this.signUpPage.Text = "sign_up";
            this.signUpPage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(55, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Confirm Password:";
            // 
            // signupConfirmPasswordTextbox
            // 
            this.signupConfirmPasswordTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.signupConfirmPasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signupConfirmPasswordTextbox.DefaultText = "";
            this.signupConfirmPasswordTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.signupConfirmPasswordTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.signupConfirmPasswordTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signupConfirmPasswordTextbox.DisabledState.Parent = this.signupConfirmPasswordTextbox;
            this.signupConfirmPasswordTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signupConfirmPasswordTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signupConfirmPasswordTextbox.FocusedState.Parent = this.signupConfirmPasswordTextbox;
            this.signupConfirmPasswordTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.signupConfirmPasswordTextbox.ForeColor = System.Drawing.Color.Black;
            this.signupConfirmPasswordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signupConfirmPasswordTextbox.HoverState.Parent = this.signupConfirmPasswordTextbox;
            this.signupConfirmPasswordTextbox.Location = new System.Drawing.Point(50, 239);
            this.signupConfirmPasswordTextbox.Name = "signupConfirmPasswordTextbox";
            this.signupConfirmPasswordTextbox.PasswordChar = '*';
            this.signupConfirmPasswordTextbox.PlaceholderText = "Confirm Password";
            this.signupConfirmPasswordTextbox.SelectedText = "";
            this.signupConfirmPasswordTextbox.ShadowDecoration.Parent = this.signupConfirmPasswordTextbox;
            this.signupConfirmPasswordTextbox.Size = new System.Drawing.Size(271, 42);
            this.signupConfirmPasswordTextbox.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(56, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "E-mail Address:";
            // 
            // signupEmailTextbox
            // 
            this.signupEmailTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.signupEmailTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signupEmailTextbox.DefaultText = "";
            this.signupEmailTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.signupEmailTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.signupEmailTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signupEmailTextbox.DisabledState.Parent = this.signupEmailTextbox;
            this.signupEmailTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signupEmailTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signupEmailTextbox.FocusedState.Parent = this.signupEmailTextbox;
            this.signupEmailTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.signupEmailTextbox.ForeColor = System.Drawing.Color.Black;
            this.signupEmailTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signupEmailTextbox.HoverState.Parent = this.signupEmailTextbox;
            this.signupEmailTextbox.Location = new System.Drawing.Point(50, 331);
            this.signupEmailTextbox.Name = "signupEmailTextbox";
            this.signupEmailTextbox.PasswordChar = '\0';
            this.signupEmailTextbox.PlaceholderText = "Enter Email";
            this.signupEmailTextbox.SelectedText = "";
            this.signupEmailTextbox.ShadowDecoration.Parent = this.signupEmailTextbox;
            this.signupEmailTextbox.Size = new System.Drawing.Size(271, 42);
            this.signupEmailTextbox.TabIndex = 23;
            // 
            // passwordStrengthLabel
            // 
            this.passwordStrengthLabel.AutoSize = true;
            this.passwordStrengthLabel.Location = new System.Drawing.Point(55, 198);
            this.passwordStrengthLabel.Name = "passwordStrengthLabel";
            this.passwordStrengthLabel.Size = new System.Drawing.Size(0, 13);
            this.passwordStrengthLabel.TabIndex = 22;
            // 
            // passwordStrengthBar
            // 
            this.passwordStrengthBar.Location = new System.Drawing.Point(50, 177);
            this.passwordStrengthBar.Name = "passwordStrengthBar";
            this.passwordStrengthBar.ShadowDecoration.Parent = this.passwordStrengthBar;
            this.passwordStrengthBar.Size = new System.Drawing.Size(271, 18);
            this.passwordStrengthBar.TabIndex = 21;
            this.passwordStrengthBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // signupButton
            // 
            this.signupButton.BorderRadius = 5;
            this.signupButton.CheckedState.Parent = this.signupButton;
            this.signupButton.CustomImages.Parent = this.signupButton;
            this.signupButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signupButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signupButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signupButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signupButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signupButton.DisabledState.Parent = this.signupButton;
            this.signupButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(98)))), ((int)(((byte)(180)))));
            this.signupButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(58)))), ((int)(((byte)(217)))));
            this.signupButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.signupButton.ForeColor = System.Drawing.Color.White;
            this.signupButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.signupButton.HoverState.Parent = this.signupButton;
            this.signupButton.Location = new System.Drawing.Point(50, 423);
            this.signupButton.Name = "signupButton";
            this.signupButton.ShadowDecoration.Parent = this.signupButton;
            this.signupButton.Size = new System.Drawing.Size(271, 45);
            this.signupButton.TabIndex = 17;
            this.signupButton.Text = "Sign Up";
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(55, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(55, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Username:";
            // 
            // signupPasswordTextbox
            // 
            this.signupPasswordTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.signupPasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signupPasswordTextbox.DefaultText = "";
            this.signupPasswordTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.signupPasswordTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.signupPasswordTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signupPasswordTextbox.DisabledState.Parent = this.signupPasswordTextbox;
            this.signupPasswordTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signupPasswordTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signupPasswordTextbox.FocusedState.Parent = this.signupPasswordTextbox;
            this.signupPasswordTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.signupPasswordTextbox.ForeColor = System.Drawing.Color.Black;
            this.signupPasswordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signupPasswordTextbox.HoverState.Parent = this.signupPasswordTextbox;
            this.signupPasswordTextbox.Location = new System.Drawing.Point(50, 129);
            this.signupPasswordTextbox.Name = "signupPasswordTextbox";
            this.signupPasswordTextbox.PasswordChar = '*';
            this.signupPasswordTextbox.PlaceholderText = "Enter Password";
            this.signupPasswordTextbox.SelectedText = "";
            this.signupPasswordTextbox.ShadowDecoration.Parent = this.signupPasswordTextbox;
            this.signupPasswordTextbox.Size = new System.Drawing.Size(271, 42);
            this.signupPasswordTextbox.TabIndex = 18;
            this.signupPasswordTextbox.TextChanged += new System.EventHandler(this.signupPasswordTextbox_TextChanged);
            // 
            // signupUsernameTextbox
            // 
            this.signupUsernameTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.signupUsernameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signupUsernameTextbox.DefaultText = "";
            this.signupUsernameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.signupUsernameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.signupUsernameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signupUsernameTextbox.DisabledState.Parent = this.signupUsernameTextbox;
            this.signupUsernameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signupUsernameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signupUsernameTextbox.FocusedState.Parent = this.signupUsernameTextbox;
            this.signupUsernameTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.signupUsernameTextbox.ForeColor = System.Drawing.Color.Black;
            this.signupUsernameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signupUsernameTextbox.HoverState.Parent = this.signupUsernameTextbox;
            this.signupUsernameTextbox.Location = new System.Drawing.Point(50, 43);
            this.signupUsernameTextbox.Name = "signupUsernameTextbox";
            this.signupUsernameTextbox.PasswordChar = '\0';
            this.signupUsernameTextbox.PlaceholderText = "Enter Username";
            this.signupUsernameTextbox.SelectedText = "";
            this.signupUsernameTextbox.ShadowDecoration.Parent = this.signupUsernameTextbox;
            this.signupUsernameTextbox.Size = new System.Drawing.Size(271, 42);
            this.signupUsernameTextbox.TabIndex = 16;
            // 
            // signupErrorLabel
            // 
            this.signupErrorLabel.AutoSize = true;
            this.signupErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.signupErrorLabel.Location = new System.Drawing.Point(47, 390);
            this.signupErrorLabel.Name = "signupErrorLabel";
            this.signupErrorLabel.Size = new System.Drawing.Size(35, 13);
            this.signupErrorLabel.TabIndex = 28;
            this.signupErrorLabel.Text = "label8";
            this.signupErrorLabel.Visible = false;
            // 
            // loginErrorLabel
            // 
            this.loginErrorLabel.AutoSize = true;
            this.loginErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.loginErrorLabel.Location = new System.Drawing.Point(49, 256);
            this.loginErrorLabel.Name = "loginErrorLabel";
            this.loginErrorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginErrorLabel.Size = new System.Drawing.Size(35, 13);
            this.loginErrorLabel.TabIndex = 13;
            this.loginErrorLabel.Text = "label8";
            this.loginErrorLabel.Visible = false;
            // 
            // authForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 713);
            this.Controls.Add(this.signPages);
            this.Controls.Add(this.signupSelectButton);
            this.Controls.Add(this.loginSelectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "authForm";
            this.Load += new System.EventHandler(this.authForm_Load);
            this.authTitleBar.ResumeLayout(false);
            this.signPages.ResumeLayout(false);
            this.signInPage.ResumeLayout(false);
            this.signInPage.PerformLayout();
            this.signUpPage.ResumeLayout(false);
            this.signUpPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel authTitleBar;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton loginSelectButton;
        private Guna.UI2.WinForms.Guna2GradientButton signupSelectButton;
        private Bunifu.UI.WinForms.BunifuPages signPages;
        private System.Windows.Forms.TabPage signInPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox loginPasswordTextbox;
        private Guna.UI2.WinForms.Guna2TextBox loginUsernameTextbox;
        private Guna.UI2.WinForms.Guna2GradientButton loginButton;
        private Guna.UI2.WinForms.Guna2ControlBox minimizeBox;
        private Guna.UI2.WinForms.Guna2ControlBox closeBox;
        private System.Windows.Forms.TabPage signUpPage;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox signupEmailTextbox;
        private System.Windows.Forms.Label passwordStrengthLabel;
        private Guna.UI2.WinForms.Guna2ProgressBar passwordStrengthBar;
        private Guna.UI2.WinForms.Guna2GradientButton signupButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox signupPasswordTextbox;
        private Guna.UI2.WinForms.Guna2TextBox signupUsernameTextbox;
        private Guna.UI2.WinForms.Guna2CheckBox rememberCheckbox;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox signupConfirmPasswordTextbox;
        private System.Windows.Forms.Label signupErrorLabel;
        private System.Windows.Forms.Label loginErrorLabel;
    }
}


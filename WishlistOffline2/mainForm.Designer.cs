
namespace WishlistOffline2
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.elipseForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.sidePanel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.menuBar = new Guna.UI2.WinForms.Guna2Panel();
            this.developerButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.activeButtonPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.wishlistButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.homeButton = new Guna.UI2.WinForms.Guna2Button();
            this.accountPanel = new System.Windows.Forms.Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.accountPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.titleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.closeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.userControlPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.sidePanel1.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.accountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountPicture)).BeginInit();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipseForm
            // 
            this.elipseForm.BorderRadius = 20;
            this.elipseForm.TargetControl = this;
            // 
            // sidePanel1
            // 
            this.sidePanel1.BackColor = System.Drawing.Color.White;
            this.sidePanel1.Controls.Add(this.menuBar);
            this.sidePanel1.Controls.Add(this.accountPanel);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.ShadowDecoration.Parent = this.sidePanel1;
            this.sidePanel1.Size = new System.Drawing.Size(88, 768);
            this.sidePanel1.TabIndex = 0;
            // 
            // menuBar
            // 
            this.menuBar.Controls.Add(this.developerButton);
            this.menuBar.Controls.Add(this.panel2);
            this.menuBar.Controls.Add(this.activeButtonPanel);
            this.menuBar.Controls.Add(this.wishlistButton);
            this.menuBar.Controls.Add(this.panel1);
            this.menuBar.Controls.Add(this.settingsButton);
            this.menuBar.Controls.Add(this.homeButton);
            this.menuBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuBar.Location = new System.Drawing.Point(0, 105);
            this.menuBar.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.menuBar.ShadowDecoration.Parent = this.menuBar;
            this.menuBar.Size = new System.Drawing.Size(88, 663);
            this.menuBar.TabIndex = 1;
            // 
            // developerButton
            // 
            this.developerButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.developerButton.CheckedState.Parent = this.developerButton;
            this.developerButton.CustomImages.Parent = this.developerButton;
            this.developerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.developerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.developerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.developerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.developerButton.DisabledState.Parent = this.developerButton;
            this.developerButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.developerButton.FillColor = System.Drawing.Color.Transparent;
            this.developerButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.developerButton.ForeColor = System.Drawing.Color.White;
            this.developerButton.HoverState.Parent = this.developerButton;
            this.developerButton.Image = global::WishlistOffline2.Properties.Resources.wrench;
            this.developerButton.ImageSize = new System.Drawing.Size(30, 30);
            this.developerButton.Location = new System.Drawing.Point(0, 437);
            this.developerButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.developerButton.Name = "developerButton";
            this.developerButton.ShadowDecoration.Parent = this.developerButton;
            this.developerButton.Size = new System.Drawing.Size(88, 49);
            this.developerButton.TabIndex = 13;
            this.developerButton.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 486);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(88, 128);
            this.panel2.TabIndex = 12;
            // 
            // activeButtonPanel
            // 
            this.activeButtonPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.activeButtonPanel.Location = new System.Drawing.Point(0, 30);
            this.activeButtonPanel.Name = "activeButtonPanel";
            this.activeButtonPanel.ShadowDecoration.Parent = this.activeButtonPanel;
            this.activeButtonPanel.Size = new System.Drawing.Size(4, 49);
            this.activeButtonPanel.TabIndex = 8;
            // 
            // wishlistButton
            // 
            this.wishlistButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.wishlistButton.CheckedState.Parent = this.wishlistButton;
            this.wishlistButton.CustomImages.Parent = this.wishlistButton;
            this.wishlistButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.wishlistButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.wishlistButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.wishlistButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.wishlistButton.DisabledState.Parent = this.wishlistButton;
            this.wishlistButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.wishlistButton.FillColor = System.Drawing.Color.Transparent;
            this.wishlistButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.wishlistButton.ForeColor = System.Drawing.Color.White;
            this.wishlistButton.HoverState.Parent = this.wishlistButton;
            this.wishlistButton.Image = global::WishlistOffline2.Properties.Resources.image2;
            this.wishlistButton.ImageSize = new System.Drawing.Size(30, 30);
            this.wishlistButton.Location = new System.Drawing.Point(0, 104);
            this.wishlistButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.wishlistButton.Name = "wishlistButton";
            this.wishlistButton.ShadowDecoration.Parent = this.wishlistButton;
            this.wishlistButton.Size = new System.Drawing.Size(88, 49);
            this.wishlistButton.TabIndex = 11;
            this.wishlistButton.Click += new System.EventHandler(this.wishlistButton_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 25);
            this.panel1.TabIndex = 10;
            // 
            // settingsButton
            // 
            this.settingsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.settingsButton.CheckedState.Parent = this.settingsButton;
            this.settingsButton.CustomImages.Parent = this.settingsButton;
            this.settingsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.settingsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.settingsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.settingsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.settingsButton.DisabledState.Parent = this.settingsButton;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsButton.FillColor = System.Drawing.Color.Transparent;
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.HoverState.Parent = this.settingsButton;
            this.settingsButton.Image = global::WishlistOffline2.Properties.Resources.image3;
            this.settingsButton.ImageSize = new System.Drawing.Size(30, 30);
            this.settingsButton.Location = new System.Drawing.Point(0, 614);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.ShadowDecoration.Parent = this.settingsButton;
            this.settingsButton.Size = new System.Drawing.Size(88, 49);
            this.settingsButton.TabIndex = 9;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.homeButton.CheckedState.Parent = this.homeButton;
            this.homeButton.CustomImages.Parent = this.homeButton;
            this.homeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homeButton.DisabledState.Parent = this.homeButton;
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FillColor = System.Drawing.Color.Transparent;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.HoverState.Parent = this.homeButton;
            this.homeButton.Image = global::WishlistOffline2.Properties.Resources.image1;
            this.homeButton.ImageSize = new System.Drawing.Size(30, 30);
            this.homeButton.Location = new System.Drawing.Point(0, 30);
            this.homeButton.Name = "homeButton";
            this.homeButton.ShadowDecoration.Parent = this.homeButton;
            this.homeButton.Size = new System.Drawing.Size(88, 49);
            this.homeButton.TabIndex = 8;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // accountPanel
            // 
            this.accountPanel.Controls.Add(this.guna2Separator1);
            this.accountPanel.Controls.Add(this.usernameLabel);
            this.accountPanel.Controls.Add(this.accountPicture);
            this.accountPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountPanel.Location = new System.Drawing.Point(0, 0);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(88, 105);
            this.accountPanel.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Separator1.Location = new System.Drawing.Point(8, 88);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(68, 10);
            this.guna2Separator1.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(3, 72);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(35, 13);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "label1";
            // 
            // accountPicture
            // 
            this.accountPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountPicture.Image = global::WishlistOffline2.Properties.Resources.account;
            this.accountPicture.ImageRotate = 0F;
            this.accountPicture.Location = new System.Drawing.Point(21, 12);
            this.accountPicture.Name = "accountPicture";
            this.accountPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.accountPicture.ShadowDecoration.Parent = this.accountPicture;
            this.accountPicture.Size = new System.Drawing.Size(45, 45);
            this.accountPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.accountPicture.TabIndex = 1;
            this.accountPicture.TabStop = false;
            // 
            // titleBar
            // 
            this.titleBar.Controls.Add(this.guna2ControlBox1);
            this.titleBar.Controls.Add(this.closeBox);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.FillColor = System.Drawing.Color.White;
            this.titleBar.Location = new System.Drawing.Point(88, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.ShadowDecoration.Parent = this.titleBar;
            this.titleBar.Size = new System.Drawing.Size(936, 23);
            this.titleBar.TabIndex = 1;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Firebrick;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(846, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 23);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // closeBox
            // 
            this.closeBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBox.FillColor = System.Drawing.Color.Firebrick;
            this.closeBox.HoverState.Parent = this.closeBox;
            this.closeBox.IconColor = System.Drawing.Color.White;
            this.closeBox.Location = new System.Drawing.Point(891, 0);
            this.closeBox.Name = "closeBox";
            this.closeBox.ShadowDecoration.Parent = this.closeBox;
            this.closeBox.Size = new System.Drawing.Size(45, 23);
            this.closeBox.TabIndex = 0;
            // 
            // userControlPanel
            // 
            this.userControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlPanel.Location = new System.Drawing.Point(88, 23);
            this.userControlPanel.Name = "userControlPanel";
            this.userControlPanel.ShadowDecoration.Parent = this.userControlPanel;
            this.userControlPanel.Size = new System.Drawing.Size(936, 745);
            this.userControlPanel.TabIndex = 2;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.userControlPanel);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.sidePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.sidePanel1.ResumeLayout(false);
            this.menuBar.ResumeLayout(false);
            this.accountPanel.ResumeLayout(false);
            this.accountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountPicture)).EndInit();
            this.titleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipseForm;
        private Guna.UI2.WinForms.Guna2Panel sidePanel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox accountPicture;
        private System.Windows.Forms.Panel accountPanel;
        private Guna.UI2.WinForms.Guna2Panel titleBar;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox closeBox;
        private Guna.UI2.WinForms.Guna2Panel menuBar;
        private Guna.UI2.WinForms.Guna2Panel activeButtonPanel;
        private Guna.UI2.WinForms.Guna2Button wishlistButton;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button settingsButton;
        private Guna.UI2.WinForms.Guna2Button homeButton;
        private Guna.UI2.WinForms.Guna2Panel userControlPanel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Panel panel2;
        public Guna.UI2.WinForms.Guna2Button developerButton;
        public System.Windows.Forms.Label usernameLabel;
    }
}

namespace WishlistOffline2
{
    partial class settingsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.saveButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.editButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.passwordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.panel1Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.accountPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.enableDeveloperTools = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Panel1.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(936, 32);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(385, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Settings";
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.White;
            this.settingsPanel.Controls.Add(this.enableDeveloperTools);
            this.settingsPanel.Controls.Add(this.errorLabel);
            this.settingsPanel.Controls.Add(this.saveButton);
            this.settingsPanel.Controls.Add(this.editButton);
            this.settingsPanel.Controls.Add(this.passwordTextbox);
            this.settingsPanel.Controls.Add(this.passwordLabel);
            this.settingsPanel.Controls.Add(this.emailTextbox);
            this.settingsPanel.Controls.Add(this.emailLabel);
            this.settingsPanel.Controls.Add(this.usernameTextbox);
            this.settingsPanel.Controls.Add(this.usernameLabel);
            this.settingsPanel.Location = new System.Drawing.Point(206, 62);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.ShadowDecoration.Parent = this.settingsPanel;
            this.settingsPanel.Size = new System.Drawing.Size(648, 386);
            this.settingsPanel.TabIndex = 1;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(16, 218);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(54, 13);
            this.errorLabel.TabIndex = 12;
            this.errorLabel.Text = "errorLabel";
            this.errorLabel.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.saveButton.CheckedState.Parent = this.saveButton;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.No;
            this.saveButton.Enabled = false;
            this.saveButton.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.saveButton.HoverState.Parent = this.saveButton;
            this.saveButton.Image = global::WishlistOffline2.Properties.Resources.save_file_option;
            this.saveButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.saveButton.ImageRotate = 0F;
            this.saveButton.ImageSize = new System.Drawing.Size(30, 30);
            this.saveButton.Location = new System.Drawing.Point(592, 20);
            this.saveButton.Name = "saveButton";
            this.saveButton.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.saveButton.PressedState.Parent = this.saveButton;
            this.saveButton.ShadowDecoration.Parent = this.saveButton;
            this.saveButton.Size = new System.Drawing.Size(30, 30);
            this.saveButton.TabIndex = 11;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // editButton
            // 
            this.editButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.editButton.CheckedState.Parent = this.editButton;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.editButton.HoverState.Parent = this.editButton;
            this.editButton.Image = global::WishlistOffline2.Properties.Resources.pencil;
            this.editButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.editButton.ImageRotate = 0F;
            this.editButton.ImageSize = new System.Drawing.Size(30, 30);
            this.editButton.Location = new System.Drawing.Point(592, 335);
            this.editButton.Name = "editButton";
            this.editButton.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.editButton.PressedState.Parent = this.editButton;
            this.editButton.ShadowDecoration.Parent = this.editButton;
            this.editButton.Size = new System.Drawing.Size(30, 30);
            this.editButton.TabIndex = 10;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BorderColor = System.Drawing.Color.Gray;
            this.passwordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextbox.DefaultText = "";
            this.passwordTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextbox.DisabledState.Parent = this.passwordTextbox;
            this.passwordTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextbox.Enabled = false;
            this.passwordTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextbox.FocusedState.Parent = this.passwordTextbox;
            this.passwordTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextbox.HoverState.Parent = this.passwordTextbox;
            this.passwordTextbox.Location = new System.Drawing.Point(109, 150);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.passwordTextbox.PlaceholderText = "Enter Password";
            this.passwordTextbox.SelectedText = "";
            this.passwordTextbox.ShadowDecoration.Parent = this.passwordTextbox;
            this.passwordTextbox.Size = new System.Drawing.Size(200, 36);
            this.passwordTextbox.TabIndex = 7;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passwordLabel.Location = new System.Drawing.Point(15, 158);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(84, 20);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password:";
            // 
            // emailTextbox
            // 
            this.emailTextbox.BorderColor = System.Drawing.Color.Gray;
            this.emailTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextbox.DefaultText = "";
            this.emailTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextbox.DisabledState.Parent = this.emailTextbox;
            this.emailTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextbox.Enabled = false;
            this.emailTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextbox.FocusedState.Parent = this.emailTextbox;
            this.emailTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextbox.HoverState.Parent = this.emailTextbox;
            this.emailTextbox.Location = new System.Drawing.Point(109, 89);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.PasswordChar = '\0';
            this.emailTextbox.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.emailTextbox.PlaceholderText = "Enter Email";
            this.emailTextbox.SelectedText = "";
            this.emailTextbox.ShadowDecoration.Parent = this.emailTextbox;
            this.emailTextbox.Size = new System.Drawing.Size(200, 36);
            this.emailTextbox.TabIndex = 5;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.emailLabel.Location = new System.Drawing.Point(44, 95);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(53, 20);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email:";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.BorderColor = System.Drawing.Color.Gray;
            this.usernameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextbox.DefaultText = "";
            this.usernameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextbox.DisabledState.Parent = this.usernameTextbox;
            this.usernameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextbox.Enabled = false;
            this.usernameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextbox.FocusedState.Parent = this.usernameTextbox;
            this.usernameTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextbox.HoverState.Parent = this.usernameTextbox;
            this.usernameTextbox.Location = new System.Drawing.Point(109, 22);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.PasswordChar = '\0';
            this.usernameTextbox.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.usernameTextbox.PlaceholderText = "Enter Username";
            this.usernameTextbox.SelectedText = "";
            this.usernameTextbox.ShadowDecoration.Parent = this.usernameTextbox;
            this.usernameTextbox.Size = new System.Drawing.Size(200, 36);
            this.usernameTextbox.TabIndex = 3;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.usernameLabel.Location = new System.Drawing.Point(15, 30);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(88, 20);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username:";
            // 
            // panel1Elipse
            // 
            this.panel1Elipse.BorderRadius = 25;
            this.panel1Elipse.TargetControl = this.settingsPanel;
            // 
            // accountPicture
            // 
            this.accountPicture.Image = global::WishlistOffline2.Properties.Resources.account;
            this.accountPicture.ImageRotate = 0F;
            this.accountPicture.Location = new System.Drawing.Point(21, 62);
            this.accountPicture.Name = "accountPicture";
            this.accountPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.accountPicture.ShadowDecoration.Parent = this.accountPicture;
            this.accountPicture.Size = new System.Drawing.Size(150, 150);
            this.accountPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.accountPicture.TabIndex = 2;
            this.accountPicture.TabStop = false;
            // 
            // enableDeveloperTools
            // 
            this.enableDeveloperTools.AutoSize = true;
            this.enableDeveloperTools.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.enableDeveloperTools.CheckedState.BorderRadius = 0;
            this.enableDeveloperTools.CheckedState.BorderThickness = 0;
            this.enableDeveloperTools.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.enableDeveloperTools.Location = new System.Drawing.Point(19, 348);
            this.enableDeveloperTools.Name = "enableDeveloperTools";
            this.enableDeveloperTools.Size = new System.Drawing.Size(140, 17);
            this.enableDeveloperTools.TabIndex = 13;
            this.enableDeveloperTools.Text = "Enable Developer Tools";
            this.enableDeveloperTools.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.enableDeveloperTools.UncheckedState.BorderRadius = 0;
            this.enableDeveloperTools.UncheckedState.BorderThickness = 0;
            this.enableDeveloperTools.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.enableDeveloperTools.CheckedChanged += new System.EventHandler(this.enableDeveloperTools_CheckedChanged);
            // 
            // settingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.accountPicture);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "settingsUserControl";
            this.Size = new System.Drawing.Size(936, 745);
            this.Load += new System.EventHandler(this.settingsUserControl_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel settingsPanel;
        private System.Windows.Forms.Label usernameLabel;
        private Guna.UI2.WinForms.Guna2TextBox usernameTextbox;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextbox;
        private System.Windows.Forms.Label passwordLabel;
        private Guna.UI2.WinForms.Guna2TextBox emailTextbox;
        private System.Windows.Forms.Label emailLabel;
        private Guna.UI2.WinForms.Guna2Elipse panel1Elipse;
        public Guna.UI2.WinForms.Guna2ImageButton editButton;
        public Guna.UI2.WinForms.Guna2ImageButton saveButton;
        private Guna.UI2.WinForms.Guna2CirclePictureBox accountPicture;
        private System.Windows.Forms.Label errorLabel;
        private Guna.UI2.WinForms.Guna2CheckBox enableDeveloperTools;
    }
}

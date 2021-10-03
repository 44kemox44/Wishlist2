
namespace WishlistOffline2
{
    partial class createWishlist
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
            this.titleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.closeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.submitButton = new Guna.UI2.WinForms.Guna2Button();
            this.createWishlistTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.Controls.Add(this.closeBox);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.FillColor = System.Drawing.Color.Gray;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.ShadowDecoration.Parent = this.titleBar;
            this.titleBar.Size = new System.Drawing.Size(365, 31);
            this.titleBar.TabIndex = 0;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // closeBox
            // 
            this.closeBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.closeBox.HoverState.Parent = this.closeBox;
            this.closeBox.IconColor = System.Drawing.Color.White;
            this.closeBox.Location = new System.Drawing.Point(320, 0);
            this.closeBox.Name = "closeBox";
            this.closeBox.ShadowDecoration.Parent = this.closeBox;
            this.closeBox.Size = new System.Drawing.Size(45, 31);
            this.closeBox.TabIndex = 0;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            // 
            // submitButton
            // 
            this.submitButton.CheckedState.Parent = this.submitButton;
            this.submitButton.CustomImages.Parent = this.submitButton;
            this.submitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.submitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.submitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.submitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.submitButton.DisabledState.Parent = this.submitButton;
            this.submitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.HoverState.Parent = this.submitButton;
            this.submitButton.Location = new System.Drawing.Point(211, 181);
            this.submitButton.Name = "submitButton";
            this.submitButton.ShadowDecoration.Parent = this.submitButton;
            this.submitButton.Size = new System.Drawing.Size(125, 36);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // createWishlistTextbox
            // 
            this.createWishlistTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.createWishlistTextbox.DefaultText = "";
            this.createWishlistTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.createWishlistTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.createWishlistTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createWishlistTextbox.DisabledState.Parent = this.createWishlistTextbox;
            this.createWishlistTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.createWishlistTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createWishlistTextbox.FocusedState.Parent = this.createWishlistTextbox;
            this.createWishlistTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createWishlistTextbox.ForeColor = System.Drawing.Color.Black;
            this.createWishlistTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.createWishlistTextbox.HoverState.Parent = this.createWishlistTextbox;
            this.createWishlistTextbox.Location = new System.Drawing.Point(55, 104);
            this.createWishlistTextbox.Name = "createWishlistTextbox";
            this.createWishlistTextbox.PasswordChar = '\0';
            this.createWishlistTextbox.PlaceholderText = "Please Enter Wishlist Name";
            this.createWishlistTextbox.SelectedText = "";
            this.createWishlistTextbox.ShadowDecoration.Parent = this.createWishlistTextbox;
            this.createWishlistTextbox.Size = new System.Drawing.Size(225, 36);
            this.createWishlistTextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wishlist Name:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(52, 153);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(46, 17);
            this.errorLabel.TabIndex = 4;
            this.errorLabel.Text = "label2";
            this.errorLabel.Visible = false;
            // 
            // elipse1
            // 
            this.elipse1.BorderRadius = 15;
            this.elipse1.TargetControl = this;
            // 
            // createWishlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(365, 259);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createWishlistTextbox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "createWishlist";
            this.Text = "createWishlist";
            this.titleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel titleBar;
        private Guna.UI2.WinForms.Guna2ControlBox closeBox;
        private Guna.UI2.WinForms.Guna2Button submitButton;
        private Guna.UI2.WinForms.Guna2TextBox createWishlistTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorLabel;
        private Guna.UI2.WinForms.Guna2Elipse elipse1;
    }
}
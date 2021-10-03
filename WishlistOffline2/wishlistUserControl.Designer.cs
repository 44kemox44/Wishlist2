
namespace WishlistOffline2
{
    partial class wishlistUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.wishlistMainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.addWishlist = new Guna.UI2.WinForms.Guna2Button();
            this.searchTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(385, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wishlist";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(936, 32);
            this.guna2Panel1.TabIndex = 1;
            // 
            // wishlistMainPanel
            // 
            this.wishlistMainPanel.BackColor = System.Drawing.Color.White;
            this.wishlistMainPanel.Location = new System.Drawing.Point(22, 109);
            this.wishlistMainPanel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.wishlistMainPanel.Name = "wishlistMainPanel";
            this.wishlistMainPanel.Padding = new System.Windows.Forms.Padding(70, 20, 60, 20);
            this.wishlistMainPanel.ShadowDecoration.Parent = this.wishlistMainPanel;
            this.wishlistMainPanel.Size = new System.Drawing.Size(894, 610);
            this.wishlistMainPanel.TabIndex = 3;
            // 
            // addWishlist
            // 
            this.addWishlist.CheckedState.Parent = this.addWishlist;
            this.addWishlist.CustomImages.Parent = this.addWishlist;
            this.addWishlist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addWishlist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addWishlist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addWishlist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addWishlist.DisabledState.Parent = this.addWishlist;
            this.addWishlist.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.addWishlist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addWishlist.ForeColor = System.Drawing.Color.White;
            this.addWishlist.HoverState.Parent = this.addWishlist;
            this.addWishlist.Location = new System.Drawing.Point(199, 47);
            this.addWishlist.Name = "addWishlist";
            this.addWishlist.ShadowDecoration.Parent = this.addWishlist;
            this.addWishlist.Size = new System.Drawing.Size(123, 28);
            this.addWishlist.TabIndex = 4;
            this.addWishlist.Text = "Add Wishlist";
            this.addWishlist.Click += new System.EventHandler(this.addWishlist_Click);
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
            this.searchTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextbox.HoverState.Parent = this.searchTextbox;
            this.searchTextbox.IconRight = global::WishlistOffline2.Properties.Resources.magnifying_glass;
            this.searchTextbox.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.searchTextbox.IconRightOffset = new System.Drawing.Point(0, -1);
            this.searchTextbox.IconRightSize = new System.Drawing.Size(15, 15);
            this.searchTextbox.Location = new System.Drawing.Point(22, 47);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.PasswordChar = '\0';
            this.searchTextbox.PlaceholderText = "Search";
            this.searchTextbox.SelectedText = "";
            this.searchTextbox.ShadowDecoration.Parent = this.searchTextbox;
            this.searchTextbox.Size = new System.Drawing.Size(171, 28);
            this.searchTextbox.TabIndex = 2;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            this.searchTextbox.IconRightClick += new System.EventHandler(this.searchTextbox_IconRightClick);
            // 
            // wishlistUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.addWishlist);
            this.Controls.Add(this.wishlistMainPanel);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "wishlistUserControl";
            this.Size = new System.Drawing.Size(936, 745);
            this.Load += new System.EventHandler(this.wishlistUserControl_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox searchTextbox;
        private Guna.UI2.WinForms.Guna2Panel wishlistMainPanel;
        public Guna.UI2.WinForms.Guna2Button addWishlist;
    }
}

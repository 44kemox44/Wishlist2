
namespace WishlistOffline2
{
    partial class wishlistDisplay
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
            this.wishlistDisplayPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.deleteButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.showButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.wishlistName = new System.Windows.Forms.Label();
            this.wishlistDisplayPanel.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wishlistDisplayPanel
            // 
            this.wishlistDisplayPanel.BackColor = System.Drawing.Color.Transparent;
            this.wishlistDisplayPanel.Controls.Add(this.guna2Panel3);
            this.wishlistDisplayPanel.Controls.Add(this.guna2Panel2);
            this.wishlistDisplayPanel.Controls.Add(this.guna2Panel1);
            this.wishlistDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wishlistDisplayPanel.FillColor = System.Drawing.Color.White;
            this.wishlistDisplayPanel.Location = new System.Drawing.Point(0, 0);
            this.wishlistDisplayPanel.Name = "wishlistDisplayPanel";
            this.wishlistDisplayPanel.ShadowColor = System.Drawing.Color.Black;
            this.wishlistDisplayPanel.Size = new System.Drawing.Size(774, 139);
            this.wishlistDisplayPanel.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel3.Location = new System.Drawing.Point(447, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Padding = new System.Windows.Forms.Padding(30, 0, 10, 10);
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(153, 139);
            this.guna2Panel3.TabIndex = 6;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.deleteButton);
            this.guna2Panel2.Controls.Add(this.showButton);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel2.Location = new System.Drawing.Point(600, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(174, 139);
            this.guna2Panel2.TabIndex = 4;
            // 
            // deleteButton
            // 
            this.deleteButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.deleteButton.CheckedState.Parent = this.deleteButton;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteButton.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.deleteButton.HoverState.Parent = this.deleteButton;
            this.deleteButton.Image = global::WishlistOffline2.Properties.Resources.trash;
            this.deleteButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.deleteButton.ImageRotate = 0F;
            this.deleteButton.ImageSize = new System.Drawing.Size(32, 32);
            this.deleteButton.Location = new System.Drawing.Point(132, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.deleteButton.PressedState.Parent = this.deleteButton;
            this.deleteButton.ShadowDecoration.Parent = this.deleteButton;
            this.deleteButton.Size = new System.Drawing.Size(32, 84);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // showButton
            // 
            this.showButton.BorderRadius = 5;
            this.showButton.CheckedState.Parent = this.showButton;
            this.showButton.CustomImages.Parent = this.showButton;
            this.showButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showButton.DisabledState.Parent = this.showButton;
            this.showButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showButton.FillColor = System.Drawing.Color.Teal;
            this.showButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.showButton.ForeColor = System.Drawing.Color.White;
            this.showButton.HoverState.Parent = this.showButton;
            this.showButton.Location = new System.Drawing.Point(10, 84);
            this.showButton.Name = "showButton";
            this.showButton.ShadowDecoration.Parent = this.showButton;
            this.showButton.Size = new System.Drawing.Size(154, 45);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show";
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.dateLabel);
            this.guna2Panel1.Controls.Add(this.wishlistName);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(172, 139);
            this.guna2Panel1.TabIndex = 3;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(11, 116);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(61, 13);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "11.02.2017";
            // 
            // wishlistName
            // 
            this.wishlistName.AutoSize = true;
            this.wishlistName.Dock = System.Windows.Forms.DockStyle.Top;
            this.wishlistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wishlistName.Location = new System.Drawing.Point(10, 10);
            this.wishlistName.Name = "wishlistName";
            this.wishlistName.Size = new System.Drawing.Size(109, 20);
            this.wishlistName.TabIndex = 0;
            this.wishlistName.Text = "Wishlist Name";
            // 
            // wishlistDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wishlistDisplayPanel);
            this.Name = "wishlistDisplay";
            this.Size = new System.Drawing.Size(774, 139);
            this.wishlistDisplayPanel.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel wishlistDisplayPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public System.Windows.Forms.Label wishlistName;
        public Guna.UI2.WinForms.Guna2ImageButton deleteButton;
        public Guna.UI2.WinForms.Guna2Button showButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label dateLabel;
    }
}

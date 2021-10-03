
namespace WishlistOffline2
{
    partial class wishlistProductUserControl
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
            this.backgroundPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.inspectButton = new Guna.UI2.WinForms.Guna2Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productPicturebox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ellipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.Color.Transparent;
            this.backgroundPanel.Controls.Add(this.inspectButton);
            this.backgroundPanel.Controls.Add(this.priceLabel);
            this.backgroundPanel.Controls.Add(this.productNameLabel);
            this.backgroundPanel.Controls.Add(this.productPicturebox);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.FillColor = System.Drawing.Color.White;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Radius = 6;
            this.backgroundPanel.ShadowColor = System.Drawing.Color.Black;
            this.backgroundPanel.ShadowShift = 4;
            this.backgroundPanel.Size = new System.Drawing.Size(163, 235);
            this.backgroundPanel.TabIndex = 0;
            // 
            // inspectButton
            // 
            this.inspectButton.CheckedState.Parent = this.inspectButton;
            this.inspectButton.CustomImages.Parent = this.inspectButton;
            this.inspectButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.inspectButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.inspectButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.inspectButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.inspectButton.DisabledState.Parent = this.inspectButton;
            this.inspectButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.inspectButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inspectButton.ForeColor = System.Drawing.Color.White;
            this.inspectButton.HoverState.Parent = this.inspectButton;
            this.inspectButton.Location = new System.Drawing.Point(15, 188);
            this.inspectButton.Name = "inspectButton";
            this.inspectButton.ShadowDecoration.Parent = this.inspectButton;
            this.inspectButton.Size = new System.Drawing.Size(136, 30);
            this.inspectButton.TabIndex = 7;
            this.inspectButton.Text = "Inspect/Edit";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.priceLabel.Location = new System.Drawing.Point(120, 52);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "Price";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productNameLabel.Location = new System.Drawing.Point(12, 11);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(75, 13);
            this.productNameLabel.TabIndex = 5;
            this.productNameLabel.Text = "Product Name";
            // 
            // productPicturebox
            // 
            this.productPicturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPicturebox.ImageRotate = 0F;
            this.productPicturebox.Location = new System.Drawing.Point(15, 68);
            this.productPicturebox.Name = "productPicturebox";
            this.productPicturebox.ShadowDecoration.Parent = this.productPicturebox;
            this.productPicturebox.Size = new System.Drawing.Size(136, 114);
            this.productPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPicturebox.TabIndex = 4;
            this.productPicturebox.TabStop = false;
            // 
            // ellipse1
            // 
            this.ellipse1.TargetControl = this;
            // 
            // wishlistProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.backgroundPanel);
            this.Name = "wishlistProductUserControl";
            this.Size = new System.Drawing.Size(163, 235);
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel backgroundPanel;
        private Guna.UI2.WinForms.Guna2Elipse ellipse1;
        private Guna.UI2.WinForms.Guna2Button inspectButton;
        public System.Windows.Forms.Label priceLabel;
        public System.Windows.Forms.Label productNameLabel;
        public Guna.UI2.WinForms.Guna2PictureBox productPicturebox;
    }
}

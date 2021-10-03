
namespace WishlistOffline2
{
    partial class homeUserControl
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
            this.homeTitleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.homeWishlistChart = new LiveCharts.WinForms.CartesianChart();
            this.panel2Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel3Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel4Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.homeTitleBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeTitleBar
            // 
            this.homeTitleBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.homeTitleBar.Controls.Add(this.label1);
            this.homeTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeTitleBar.Location = new System.Drawing.Point(0, 0);
            this.homeTitleBar.Name = "homeTitleBar";
            this.homeTitleBar.ShadowDecoration.Parent = this.homeTitleBar;
            this.homeTitleBar.Size = new System.Drawing.Size(936, 32);
            this.homeTitleBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(385, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(36, 59);
            this.panel1.Name = "panel1";
            this.panel1.ShadowDecoration.Parent = this.panel1;
            this.panel1.Size = new System.Drawing.Size(860, 249);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(36, 339);
            this.panel2.Name = "panel2";
            this.panel2.ShadowDecoration.Parent = this.panel2;
            this.panel2.Size = new System.Drawing.Size(256, 174);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(18, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Newest Wishlists:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(36, 544);
            this.panel3.Name = "panel3";
            this.panel3.ShadowDecoration.Parent = this.panel3;
            this.panel3.Size = new System.Drawing.Size(256, 174);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(18, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Biggest Wishlists:";
            // 
            // panel1Elipse
            // 
            this.panel1Elipse.BorderRadius = 20;
            this.panel1Elipse.TargetControl = this.panel1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.homeWishlistChart);
            this.panel4.Location = new System.Drawing.Point(341, 339);
            this.panel4.Name = "panel4";
            this.panel4.ShadowDecoration.Parent = this.panel4;
            this.panel4.Size = new System.Drawing.Size(555, 379);
            this.panel4.TabIndex = 4;
            // 
            // homeWishlistChart
            // 
            this.homeWishlistChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeWishlistChart.Location = new System.Drawing.Point(0, 0);
            this.homeWishlistChart.Name = "homeWishlistChart";
            this.homeWishlistChart.Size = new System.Drawing.Size(555, 379);
            this.homeWishlistChart.TabIndex = 0;
            // 
            // panel2Elipse
            // 
            this.panel2Elipse.BorderRadius = 20;
            this.panel2Elipse.TargetControl = this.panel2;
            // 
            // panel3Elipse
            // 
            this.panel3Elipse.BorderRadius = 20;
            this.panel3Elipse.TargetControl = this.panel3;
            // 
            // panel4Elipse
            // 
            this.panel4Elipse.BorderRadius = 20;
            this.panel4Elipse.TargetControl = this.panel4;
            // 
            // homeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.homeTitleBar);
            this.Name = "homeUserControl";
            this.Size = new System.Drawing.Size(936, 745);
            this.homeTitleBar.ResumeLayout(false);
            this.homeTitleBar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel homeTitleBar;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel panel3;
        private Guna.UI2.WinForms.Guna2Elipse panel1Elipse;
        private Guna.UI2.WinForms.Guna2Panel panel4;
        private Guna.UI2.WinForms.Guna2Elipse panel2Elipse;
        private Guna.UI2.WinForms.Guna2Elipse panel3Elipse;
        private Guna.UI2.WinForms.Guna2Elipse panel4Elipse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private LiveCharts.WinForms.CartesianChart homeWishlistChart;
    }
}

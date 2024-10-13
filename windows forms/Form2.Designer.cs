namespace WindowsFormsApplication1
{
    partial class frmMDI
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
            this.userInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routeManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stationManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userInformationToolStripMenuItem
            // 
            this.userInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManageToolStripMenuItem});
            this.userInformationToolStripMenuItem.Name = "userInformationToolStripMenuItem";
            this.userInformationToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.userInformationToolStripMenuItem.Text = "User Information";
            // 
            // userManageToolStripMenuItem
            // 
            this.userManageToolStripMenuItem.Name = "userManageToolStripMenuItem";
            this.userManageToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.userManageToolStripMenuItem.Text = "User Manage";
            this.userManageToolStripMenuItem.Click += new System.EventHandler(this.userManageToolStripMenuItem_Click);
            // 
            // stationsToolStripMenuItem
            // 
            this.stationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.routeManagementToolStripMenuItem,
            this.stationManagementToolStripMenuItem});
            this.stationsToolStripMenuItem.Name = "stationsToolStripMenuItem";
            this.stationsToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.stationsToolStripMenuItem.Text = "Routes";
            // 
            // routeManagementToolStripMenuItem
            // 
            this.routeManagementToolStripMenuItem.Name = "routeManagementToolStripMenuItem";
            this.routeManagementToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.routeManagementToolStripMenuItem.Text = "Route Management";
            this.routeManagementToolStripMenuItem.Click += new System.EventHandler(this.routeManagementToolStripMenuItem_Click);
            // 
            // stationManagementToolStripMenuItem
            // 
            this.stationManagementToolStripMenuItem.Name = "stationManagementToolStripMenuItem";
            this.stationManagementToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.stationManagementToolStripMenuItem.Text = "Station Management";
            this.stationManagementToolStripMenuItem.Click += new System.EventHandler(this.stationManagementToolStripMenuItem_Click);
            // 
            // trainsToolStripMenuItem
            // 
            this.trainsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainManagementToolStripMenuItem});
            this.trainsToolStripMenuItem.Name = "trainsToolStripMenuItem";
            this.trainsToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.trainsToolStripMenuItem.Text = "Trains";
            // 
            // trainManagementToolStripMenuItem
            // 
            this.trainManagementToolStripMenuItem.Name = "trainManagementToolStripMenuItem";
            this.trainManagementToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.trainManagementToolStripMenuItem.Text = "Train Management";
            this.trainManagementToolStripMenuItem.Click += new System.EventHandler(this.trainManagementToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInformationToolStripMenuItem,
            this.stationsToolStripMenuItem,
            this.trainsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("AmphionExtrabold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(380, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Panel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(917, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMDI";
            this.Text = "SL Train Seat Booking System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem userInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem routeManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stationManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainManagementToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
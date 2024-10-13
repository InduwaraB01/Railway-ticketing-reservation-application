namespace WindowsFormsApplication1
{
    partial class userhome
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.Ticketreservationbtn = new System.Windows.Forms.Button();
            this.trains = new System.Windows.Forms.Button();
            this.trainschedulebtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(38, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(671, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome To Sri Lankan Railways";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.Ticketreservationbtn);
            this.panel1.Controls.Add(this.trains);
            this.panel1.Controls.Add(this.trainschedulebtn);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-5, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 134);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_reservation_64;
            this.pictureBox4.Location = new System.Drawing.Point(513, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(87, 85);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_train_96;
            this.pictureBox3.Location = new System.Drawing.Point(310, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_train_schedule_100;
            this.pictureBox2.Location = new System.Drawing.Point(112, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.logoutbtn.Location = new System.Drawing.Point(720, 86);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(64, 37);
            this.logoutbtn.TabIndex = 4;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // Ticketreservationbtn
            // 
            this.Ticketreservationbtn.BackColor = System.Drawing.Color.Thistle;
            this.Ticketreservationbtn.Location = new System.Drawing.Point(479, 97);
            this.Ticketreservationbtn.Name = "Ticketreservationbtn";
            this.Ticketreservationbtn.Size = new System.Drawing.Size(158, 37);
            this.Ticketreservationbtn.TabIndex = 2;
            this.Ticketreservationbtn.Text = "Ticket Reservations";
            this.Ticketreservationbtn.UseVisualStyleBackColor = false;
            this.Ticketreservationbtn.Click += new System.EventHandler(this.Ticketreservationbtn_Click);
            // 
            // trains
            // 
            this.trains.BackColor = System.Drawing.Color.Thistle;
            this.trains.Location = new System.Drawing.Point(310, 97);
            this.trains.Name = "trains";
            this.trains.Size = new System.Drawing.Size(96, 37);
            this.trains.TabIndex = 1;
            this.trains.Text = "Trains";
            this.trains.UseVisualStyleBackColor = false;
            this.trains.Click += new System.EventHandler(this.trains_Click);
            // 
            // trainschedulebtn
            // 
            this.trainschedulebtn.BackColor = System.Drawing.Color.Thistle;
            this.trainschedulebtn.Location = new System.Drawing.Point(89, 97);
            this.trainschedulebtn.Name = "trainschedulebtn";
            this.trainschedulebtn.Size = new System.Drawing.Size(141, 37);
            this.trainschedulebtn.TabIndex = 0;
            this.trainschedulebtn.Text = "Train Schedules";
            this.trainschedulebtn.UseVisualStyleBackColor = false;
            this.trainschedulebtn.Click += new System.EventHandler(this.trainschedulebtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.sri_lanka_photos_0251;
            this.pictureBox1.Location = new System.Drawing.Point(3, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(795, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // userhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Name = "userhome";
            this.Text = "userhome";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button Ticketreservationbtn;
        private System.Windows.Forms.Button trains;
        private System.Windows.Forms.Button trainschedulebtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
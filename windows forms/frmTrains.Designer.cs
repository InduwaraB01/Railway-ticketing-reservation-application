namespace WindowsFormsApplication1
{
    partial class frmTrains
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt1stclassSeat = new System.Windows.Forms.TextBox();
            this.txttName = new System.Windows.Forms.TextBox();
            this.txt2ndclassSeat = new System.Windows.Forms.TextBox();
            this.cmbsStation = new System.Windows.Forms.ComboBox();
            this.cmbdStation = new System.Windows.Forms.ComboBox();
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btntClear = new System.Windows.Forms.Button();
            this.btntUpdate = new System.Windows.Forms.Button();
            this.btntAdd = new System.Windows.Forms.Button();
            this.txttID = new System.Windows.Forms.MaskedTextBox();
            this.mcDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1509, 175);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_locomotive_100;
            this.pictureBox2.Location = new System.Drawing.Point(1069, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_locomotive_100;
            this.pictureBox1.Location = new System.Drawing.Point(66, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(316, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Train Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Schedule ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "No Of 2nd Class Seats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 319);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Starting Station";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Train Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 372);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Destination Station";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(645, 319);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Route";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(645, 371);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Starting Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(645, 212);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(262, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "No Of 1st Class Seats";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(645, 426);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Date";
            // 
            // txt1stclassSeat
            // 
            this.txt1stclassSeat.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1stclassSeat.Location = new System.Drawing.Point(952, 208);
            this.txt1stclassSeat.Margin = new System.Windows.Forms.Padding(4);
            this.txt1stclassSeat.Name = "txt1stclassSeat";
            this.txt1stclassSeat.Size = new System.Drawing.Size(132, 30);
            this.txt1stclassSeat.TabIndex = 4;
            // 
            // txttName
            // 
            this.txttName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttName.Location = new System.Drawing.Point(257, 255);
            this.txttName.Margin = new System.Windows.Forms.Padding(4);
            this.txttName.Name = "txttName";
            this.txttName.Size = new System.Drawing.Size(292, 30);
            this.txttName.TabIndex = 1;
            // 
            // txt2ndclassSeat
            // 
            this.txt2ndclassSeat.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2ndclassSeat.Location = new System.Drawing.Point(952, 253);
            this.txt2ndclassSeat.Margin = new System.Windows.Forms.Padding(4);
            this.txt2ndclassSeat.Name = "txt2ndclassSeat";
            this.txt2ndclassSeat.Size = new System.Drawing.Size(132, 30);
            this.txt2ndclassSeat.TabIndex = 5;
            // 
            // cmbsStation
            // 
            this.cmbsStation.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsStation.FormattingEnabled = true;
            this.cmbsStation.Location = new System.Drawing.Point(257, 310);
            this.cmbsStation.Margin = new System.Windows.Forms.Padding(4);
            this.cmbsStation.Name = "cmbsStation";
            this.cmbsStation.Size = new System.Drawing.Size(292, 31);
            this.cmbsStation.TabIndex = 2;
            this.cmbsStation.SelectedIndexChanged += new System.EventHandler(this.cmbsStation_SelectedIndexChanged);
            // 
            // cmbdStation
            // 
            this.cmbdStation.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdStation.FormattingEnabled = true;
            this.cmbdStation.Location = new System.Drawing.Point(257, 369);
            this.cmbdStation.Margin = new System.Windows.Forms.Padding(4);
            this.cmbdStation.Name = "cmbdStation";
            this.cmbdStation.Size = new System.Drawing.Size(292, 31);
            this.cmbdStation.TabIndex = 3;
            this.cmbdStation.SelectedIndexChanged += new System.EventHandler(this.cmbdStation_SelectedIndexChanged);
            // 
            // cmbRoute
            // 
            this.cmbRoute.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(952, 310);
            this.cmbRoute.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(417, 31);
            this.cmbRoute.TabIndex = 6;
            // 
            // dtpTime
            // 
            this.dtpTime.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(952, 369);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(207, 30);
            this.dtpTime.TabIndex = 7;
            // 
            // btntClear
            // 
            this.btntClear.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntClear.Location = new System.Drawing.Point(348, 418);
            this.btntClear.Margin = new System.Windows.Forms.Padding(4);
            this.btntClear.Name = "btntClear";
            this.btntClear.Size = new System.Drawing.Size(147, 73);
            this.btntClear.TabIndex = 11;
            this.btntClear.Text = "&Clear";
            this.btntClear.UseVisualStyleBackColor = true;
            this.btntClear.Click += new System.EventHandler(this.btntClear_Click);
            // 
            // btntUpdate
            // 
            this.btntUpdate.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntUpdate.Location = new System.Drawing.Point(180, 418);
            this.btntUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btntUpdate.Name = "btntUpdate";
            this.btntUpdate.Size = new System.Drawing.Size(147, 73);
            this.btntUpdate.TabIndex = 10;
            this.btntUpdate.Text = "&Search Train";
            this.btntUpdate.UseVisualStyleBackColor = true;
            this.btntUpdate.Click += new System.EventHandler(this.btntUpdate_Click);
            // 
            // btntAdd
            // 
            this.btntAdd.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntAdd.Location = new System.Drawing.Point(418, 206);
            this.btntAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btntAdd.Name = "btntAdd";
            this.btntAdd.Size = new System.Drawing.Size(91, 36);
            this.btntAdd.TabIndex = 9;
            this.btntAdd.Text = "&Add Train";
            this.btntAdd.UseVisualStyleBackColor = true;
            this.btntAdd.Click += new System.EventHandler(this.btntAdd_Click);
            // 
            // txttID
            // 
            this.txttID.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttID.Location = new System.Drawing.Point(257, 209);
            this.txttID.Margin = new System.Windows.Forms.Padding(4);
            this.txttID.Mask = "000";
            this.txttID.Name = "txttID";
            this.txttID.Size = new System.Drawing.Size(132, 30);
            this.txttID.TabIndex = 0;
            // 
            // mcDate
            // 
            this.mcDate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcDate.Location = new System.Drawing.Point(952, 420);
            this.mcDate.Margin = new System.Windows.Forms.Padding(4);
            this.mcDate.Name = "mcDate";
            this.mcDate.Size = new System.Drawing.Size(445, 30);
            this.mcDate.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 27);
            this.button1.TabIndex = 12;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(533, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmTrains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1405, 522);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mcDate);
            this.Controls.Add(this.txttID);
            this.Controls.Add(this.btntClear);
            this.Controls.Add(this.btntUpdate);
            this.Controls.Add(this.btntAdd);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.cmbRoute);
            this.Controls.Add(this.cmbdStation);
            this.Controls.Add(this.cmbsStation);
            this.Controls.Add(this.txt2ndclassSeat);
            this.Controls.Add(this.txttName);
            this.Controls.Add(this.txt1stclassSeat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmTrains";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTrains";
            this.Load += new System.EventHandler(this.frmTrains_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt1stclassSeat;
        private System.Windows.Forms.TextBox txttName;
        private System.Windows.Forms.TextBox txt2ndclassSeat;
        private System.Windows.Forms.ComboBox cmbsStation;
        private System.Windows.Forms.ComboBox cmbdStation;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btntClear;
        private System.Windows.Forms.Button btntUpdate;
        private System.Windows.Forms.Button btntAdd;
        private System.Windows.Forms.MaskedTextBox txttID;
        private System.Windows.Forms.DateTimePicker mcDate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
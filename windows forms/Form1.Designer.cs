namespace WindowsFormsApplication1
{
    partial class frmuserManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmuserManage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcName = new System.Windows.Forms.TextBox();
            this.txtcAddress = new System.Windows.Forms.TextBox();
            this.txtcUsername = new System.Windows.Forms.TextBox();
            this.txtcPassword = new System.Windows.Forms.TextBox();
            this.txtcContact = new System.Windows.Forms.MaskedTextBox();
            this.btncAdd = new System.Windows.Forms.Button();
            this.btncUpdate = new System.Windows.Forms.Button();
            this.txtcNIC = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-11, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 96);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(267, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Manage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer NIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 362);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customer Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 414);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Login Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 460);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password";
            // 
            // txtcName
            // 
            this.txtcName.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcName.Location = new System.Drawing.Point(312, 162);
            this.txtcName.Margin = new System.Windows.Forms.Padding(4);
            this.txtcName.Name = "txtcName";
            this.txtcName.Size = new System.Drawing.Size(327, 37);
            this.txtcName.TabIndex = 1;
            // 
            // txtcAddress
            // 
            this.txtcAddress.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcAddress.Location = new System.Drawing.Point(312, 213);
            this.txtcAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtcAddress.Multiline = true;
            this.txtcAddress.Name = "txtcAddress";
            this.txtcAddress.Size = new System.Drawing.Size(327, 128);
            this.txtcAddress.TabIndex = 2;
            // 
            // txtcUsername
            // 
            this.txtcUsername.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcUsername.Location = new System.Drawing.Point(312, 410);
            this.txtcUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtcUsername.Name = "txtcUsername";
            this.txtcUsername.Size = new System.Drawing.Size(327, 37);
            this.txtcUsername.TabIndex = 4;
            // 
            // txtcPassword
            // 
            this.txtcPassword.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcPassword.Location = new System.Drawing.Point(312, 457);
            this.txtcPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtcPassword.Name = "txtcPassword";
            this.txtcPassword.Size = new System.Drawing.Size(327, 37);
            this.txtcPassword.TabIndex = 5;
            // 
            // txtcContact
            // 
            this.txtcContact.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcContact.Location = new System.Drawing.Point(312, 358);
            this.txtcContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtcContact.Mask = "(999) 000-0000";
            this.txtcContact.Name = "txtcContact";
            this.txtcContact.Size = new System.Drawing.Size(327, 37);
            this.txtcContact.TabIndex = 3;
            // 
            // btncAdd
            // 
            this.btncAdd.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncAdd.Location = new System.Drawing.Point(693, 208);
            this.btncAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btncAdd.Name = "btncAdd";
            this.btncAdd.Size = new System.Drawing.Size(147, 48);
            this.btncAdd.TabIndex = 6;
            this.btncAdd.Text = "&Add User";
            this.btncAdd.UseVisualStyleBackColor = true;
            this.btncAdd.Click += new System.EventHandler(this.btncAdd_Click);
            // 
            // btncUpdate
            // 
            this.btncUpdate.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncUpdate.Location = new System.Drawing.Point(693, 278);
            this.btncUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btncUpdate.Name = "btncUpdate";
            this.btncUpdate.Size = new System.Drawing.Size(147, 48);
            this.btncUpdate.TabIndex = 7;
            this.btncUpdate.Text = "&Search";
            this.btncUpdate.UseVisualStyleBackColor = true;
            this.btncUpdate.Click += new System.EventHandler(this.btncUpdate_Click);
            // 
            // txtcNIC
            // 
            this.txtcNIC.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcNIC.Location = new System.Drawing.Point(312, 116);
            this.txtcNIC.Margin = new System.Windows.Forms.Padding(4);
            this.txtcNIC.Mask = "000000000000";
            this.txtcNIC.Name = "txtcNIC";
            this.txtcNIC.Size = new System.Drawing.Size(327, 37);
            this.txtcNIC.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(693, 348);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "&Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(89, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.login;
            this.pictureBox2.Location = new System.Drawing.Point(686, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // frmuserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(872, 517);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcNIC);
            this.Controls.Add(this.btncUpdate);
            this.Controls.Add(this.btncAdd);
            this.Controls.Add(this.txtcContact);
            this.Controls.Add(this.txtcPassword);
            this.Controls.Add(this.txtcUsername);
            this.Controls.Add(this.txtcAddress);
            this.Controls.Add(this.txtcName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmuserManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Manage";
            this.Load += new System.EventHandler(this.frmuserLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcName;
        private System.Windows.Forms.TextBox txtcAddress;
        private System.Windows.Forms.TextBox txtcUsername;
        private System.Windows.Forms.TextBox txtcPassword;
        private System.Windows.Forms.MaskedTextBox txtcContact;
        private System.Windows.Forms.Button btncAdd;
        private System.Windows.Forms.Button btncUpdate;
        private System.Windows.Forms.MaskedTextBox txtcNIC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


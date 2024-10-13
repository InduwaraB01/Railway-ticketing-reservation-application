using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class paymentform : Form
    {
        MySqlConnection dbConn;

        public paymentform()
        {
            InitializeComponent();
        }

        // Constructor to receive details from bookingConfirm
        public paymentform(string trainName, string FCSeats, string SCSeats, string totalCost, string userName)

        {
            InitializeComponent();

            // Set the labels' text properties
        labeltrain.Text = trainName;
        label1stclztickets.Text = FCSeats + " First Class Tickets";
        label2ndclztickets.Text = SCSeats + " Second Class Tickets";
        labeltotalcost.Text = totalCost + " LKR ";
        labeluname.Text = userName;


        }

        private void paymentform_Load(object sender, EventArgs e)
        {
            dbConn = new MySqlConnection("Server=localhost;" + "Database=trainsystem;" + "Uid=root;" + "Pwd=123;");

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            bookingConfirm bookingConfirm = new bookingConfirm();
            bookingConfirm.Show();
            this.Hide();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cardNumber = txtcardnumber.Text;
            if (cardNumber.Length == 5)
            {
                // Display success message
                MessageBox.Show("Payment Successful! Reservation Completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userhome userhome = new userhome();
                userhome.Show();
                this.Hide();


            }
            else if (cardNumber.Length >= 6)
            {
                // Display error message
                MessageBox.Show("Card number character count exceeds . Please check and try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (cardNumber.Length < 5)

            {
                // Display error message
                MessageBox.Show("Card number character count Short . Please check and try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
       }
    }
}

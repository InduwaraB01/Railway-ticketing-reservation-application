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
    public partial class bookingConfirm : Form
    {
        private string trainName;
        private string trainDate;
        private string loggedInUsername;
        private string FCSeats;
        private string SCSeats;

        public bookingConfirm()
        {
            InitializeComponent();
        }

        // Constructor with parameters to receive train name and date
        public bookingConfirm(string trainName, string trainDate, string loggedInUsername, string FCSeats, string SCSeats)
        {
            InitializeComponent();
            // Set the received data to the corresponding controls in the form
            txtTrain.Text = trainName;
            txttrainTime.Text = trainDate;
            txtloginName.Text = loggedInUsername;
            lbl1stclzavailseats.Text = FCSeats +" available Seats";
            lbl2ndclzavailseats.Text= SCSeats + " available Seats";

            this.trainName = trainName;
            this.loggedInUsername = loggedInUsername;
            this.FCSeats = FCSeats;
            this.SCSeats = SCSeats;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Parse/store the username and selected seat counts
            int fcSeatsSelected = int.Parse(txt1stClass.Text);
            int scSeatsSelected = int.Parse(txt2ndClass.Text);
            string userName=txtloginName.Text;

            // Calculate total cost
            int totalCost = fcSeatsSelected * 400 + scSeatsSelected * 200;


            // Calculate total seats selected
            int totalSeatsSelected = fcSeatsSelected + scSeatsSelected;

            // Check if total seats selected exceed the limit
            if (totalSeatsSelected > 5)
            {
                // Show error message
                MessageBox.Show("User can reserve only 5 seats.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Proceed to payment form
                paymentform paymentform = new paymentform(trainName, fcSeatsSelected.ToString(), scSeatsSelected.ToString(), totalCost.ToString(),userName.ToString());

                paymentform.Show();
                this.Hide();
            }
        }
    }
}

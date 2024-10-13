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
    public partial class userhome : Form
    {
        public userhome()
        {
            InitializeComponent();
        }

        private void trainschedulebtn_Click(object sender, EventArgs e)
        {
            trainschedule trainsched = new trainschedule();
            trainsched.Show();
            this.Hide();
        }

        private void trains_Click(object sender, EventArgs e)
        {
            availableTrains avlbletrains = new availableTrains();
            avlbletrains.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            userloginform uselogfrm = new userloginform();
            uselogfrm.Show();
            this.Hide();
        }

        private void Ticketreservationbtn_Click(object sender, EventArgs e)
        {
            ticketBooking tickbook= new ticketBooking();    
            tickbook.Show();
            this.Hide();
        }
    }
}

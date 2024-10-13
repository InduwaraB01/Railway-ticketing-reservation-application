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
    public partial class usertype : Form
    {
        public usertype()
        {
            InitializeComponent();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            signup snup = new signup();
            snup.Show();    
            this.Hide();
        }

        private void uloginbtn_Click(object sender, EventArgs e)
        {
            userloginform userloginfrm = new userloginform();
            userloginfrm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminlogin lgadmin= new adminlogin();
            lgadmin.Show();
            this.Hide();
        }
    }
}

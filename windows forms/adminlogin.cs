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
    public partial class adminlogin : Form
    {
        MySqlConnection dbConn;
        public adminlogin()
        {
            InitializeComponent();
        }

        private void adminlogin_Load(object sender, EventArgs e)
        {
            dbConn = new MySqlConnection("Server=localhost;" + "Database=trainsystem;" + "Uid=root;" + "Pwd=123;");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usertype usertyp = new usertype();
            usertyp.Show();
            this.Close();
        }

        private void adminnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminpasswordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminloginbtn_Click(object sender, EventArgs e)
        {
            string adminUsername = adminnametxt.Text;
            string adminPassword = adminpasswordtxt.Text;

            string query = "SELECT * FROM adminlogin WHERE adminusername = @adminusername AND adminpassword = @adminpassword";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);


            cmd.Parameters.AddWithValue("@adminusername", adminUsername);
            cmd.Parameters.AddWithValue("@adminpassword", adminPassword);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Admin login successful!");
               frmMDI adminlogin = new frmMDI();
                adminlogin.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Invalid admin username or password!");
            }
            reader.Close();
            dbConn.Close();
        }


    }
}

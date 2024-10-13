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
    public partial class userloginform : Form
    {
        MySqlConnection dbConn;
        public string LoggedInUsername { get; private set; } // Property to hold the logged-in username


        public userloginform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usertype usertyp = new usertype();
            usertyp.Show();
            this.Hide();
        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string password = passwordtxt.Text;


            string query = "SELECT * FROM logintbl WHERE username = @username AND password = @password";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);


            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Login successful!");
                LoggedInUsername = reader["username"].ToString(); // Set the logged-in username
                reader.Close();
                dbConn.Close();



                userhome usehom = new userhome();
                usehom.Show();
                this.Hide();

               
                
            }

            else
            {
                MessageBox.Show("Invalid username or password!");
            }
            reader.Close();
            dbConn.Close();
        }


        private void userloginform_Load(object sender, EventArgs e)
        {
            dbConn = new MySqlConnection("Server=localhost;" + "Database=trainsystem;" + "Uid=root;" + "Pwd=123;");
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}

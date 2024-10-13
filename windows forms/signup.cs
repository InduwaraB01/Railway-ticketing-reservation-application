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
    public partial class signup : Form
    {
        MySqlConnection dbConn;
        public signup()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            usertype usertyp = new usertype();
            usertyp.Show();
            this.Hide();
        }

        private void signup_Load(object sender, EventArgs e)
        {
            dbConn = new MySqlConnection("Server=localhost;" + "Database=trainsystem;" + "Uid=root;" + "Pwd=123;");
            if (dbConn.State != ConnectionState.Open)
            {
                dbConn.Open();
            }


        }

        private void signupsubmitbtn_Click(object sender, EventArgs e)
        {
            if (dbConn.State != ConnectionState.Open)
            {
                dbConn.Open();
            }
            try
            {
                // Get values from text fields
                string name = signupnametxt.Text;
                string contactNumber = signupcontactnotxt.Text;
                string email = signupemailtxt.Text;
                DateTime birthdate = signupbdaydatepicker.Value;
                string gender = signupmaleradiobtn.Checked ? "Male" : "Female";
                string userName = signupusernametxt.Text;
                string password = signuppasswordtxt.Text;
                string cusNIC = nictxt.Text;

                // Construct SQL query to insert data into newUserDetailstbl
                string SQLsignupNewUsers = "INSERT INTO newUserDetailstbl (name, contactNumber, email, birthdate, gender) VALUES (@name, @contactNumber, @email, @birthdate, @gender)";
                // MySqlCommand object to execute the query
                MySqlCommand cmdNewUser = new MySqlCommand(SQLsignupNewUsers, dbConn);

                // Add parameters to the query to prevent SQL injection
                cmdNewUser.Parameters.AddWithValue("@name", name);
                cmdNewUser.Parameters.AddWithValue("@contactNumber", contactNumber);
                cmdNewUser.Parameters.AddWithValue("@email", email);
                cmdNewUser.Parameters.AddWithValue("@birthdate", birthdate);
                cmdNewUser.Parameters.AddWithValue("@gender", gender);

                // Execute the query for newUserDetailstbl
                cmdNewUser.ExecuteNonQuery();

                // Construct SQL query to insert data into logintbl
                string SQLaddnewLogin = "INSERT INTO logintbl (userName, password, cusNIC) VALUES (@userName, @password, @cusNIC)";
                // MySqlCommand object to execute the query
                MySqlCommand cmdLogin = new MySqlCommand(SQLaddnewLogin, dbConn);

                // Add parameters to the query to prevent SQL injection
                cmdLogin.Parameters.AddWithValue("@userName", userName);
                cmdLogin.Parameters.AddWithValue("@password", password);
                cmdLogin.Parameters.AddWithValue("@cusNIC", cusNIC);

                // Execute the query for logintbl
                cmdLogin.ExecuteNonQuery();

                // Show success message
                MessageBox.Show("Signup successful!");

                // Clear input fields
                signupnametxt.Text = "";
                signupcontactnotxt.Text = "";
                signupemailtxt.Text = "";
                signupbdaydatepicker.Value = DateTime.Now;
                signupmaleradiobtn.Checked = false;
                signupfemaleradiobtn.Checked = false;
                signupusernametxt.Text = "";
                signuppasswordtxt.Text = "";
                nictxt.Text = "";
            }
            catch (Exception ex)
            {
                // Show error message if an exception occurs
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                dbConn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            signupnametxt.Text = "";
            signupcontactnotxt.Text = "";
            signupemailtxt.Text = "";
            signupbdaydatepicker.Value = DateTime.Now;
            signupmaleradiobtn.Checked = false;
            signupfemaleradiobtn.Checked = false;
            signupusernametxt.Text = "";
            signuppasswordtxt.Text = "";
            nictxt.Text = "";


        }
    }
}

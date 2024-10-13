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
    public partial class trainschedule : Form
    {
        MySqlConnection dbConn;
        DataTable trainDataTable;
        public trainschedule()
        {
            InitializeComponent();

            dbConn = new MySqlConnection("Server=localhost;" + "Database=trainsystem;" + "Uid=root;" + "Pwd=123;");

            trainDataTable = new DataTable();

        }

        private void trainschedule_Load(object sender, EventArgs e)
        {
            LoadTrainData();
        }

        private void LoadTrainData()

        {
            try
            {
                // Open database connection
                dbConn.Open();

                // Define the SQL query to select columns from the train table
                string query = "SELECT tScheduleID, tName, sStation, dStation, tRoute, sTime, sDate FROM train";

                // Create MySqlCommand object
                MySqlCommand cmd = new MySqlCommand(query, dbConn);

                // Create MySqlDataAdapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                // Clear existing data in DataTable
                trainDataTable.Clear();

                // Fill the DataTable with data from the database
                adapter.Fill(trainDataTable);

                // Bind the DataTable to the dataGridView1
                dataGridView1.DataSource = trainDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                dbConn.Close();
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            userhome usehom = new userhome();
            usehom.Show();
            this.Hide();
        }

        
    }
}

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
    public partial class availableTrains : Form
    {
        MySqlConnection dbConn;
        DataTable trainDataTable;

        public availableTrains()
        {
            InitializeComponent();

            // Initialize MySqlConnection object
            dbConn = new MySqlConnection("Server=localhost;" + "Database=trainsystem;" + "Uid=root;" + "Pwd=123;");
            // Initialize DataTable
            trainDataTable = new DataTable();
        }

        private void availableTrains_Load(object sender, EventArgs e)
        {
            LoadTrainData();
        }
        private void LoadTrainData()
        {
            try
            {
                // Open database connection
                dbConn.Open();

                // Define the SQL query to select specific columns from the train table
                string query = "SELECT tName, sStation, dStation, FSeatcount, SSeatcount, tRoute FROM train";

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

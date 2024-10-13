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
    public partial class ticketBooking : Form
    {
        MySqlConnection dbConn;
        int fromT;
        int toT;
        private string selectedTrainName;
        private string selectedTrainDate;
        private string loggedInUsername;
        // Constructor to receive userloginform reference
        public ticketBooking(string loggedInUsername)
        {
            InitializeComponent();
            this.loggedInUsername = loggedInUsername;
        }
        public ticketBooking()
        {
            InitializeComponent();
        }

        private void ticketBooking_Load(object sender, EventArgs e)
        {
            dbConn = new MySqlConnection("Server=localhost;" + "Database=trainsystem;" + "Uid=root;" + "Pwd=123;");

            if (dbConn.State != ConnectionState.Open)
            {
                dbConn.Open();
            }

            this.fillStations();
        }

        private void fillStations()
        {
            cmbfStation.Items.Clear();
            cmbtStation.Items.Clear();

            DataSet getStatioins = new DataSet();
            string SQLgetStations = "SELECT stationName FROM station";
            MySqlDataAdapter dagetRoute = new MySqlDataAdapter(SQLgetStations, dbConn);
            dagetRoute.Fill(getStatioins, "TBLstationname");

            if (getStatioins.Tables["TBLstationname"].Rows.Count > 0)
            {
                for (int count = getStatioins.Tables["TBLstationname"].Rows.Count - 1; count >= 0; count--)
                {
                    cmbfStation.Items.Add(getStatioins.Tables["TBLstationname"].Rows[count][0].ToString());
                    cmbtStation.Items.Add(getStatioins.Tables["TBLstationname"].Rows[count][0].ToString());
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }

                // Getting route for selected stations
                DataSet getRoute = new DataSet();
                string SQLgetRoute1 = "SELECT routs FROM station where stationName='" + cmbfStation.Text.Trim() + "'";
                MySqlDataAdapter dagetRoute = new MySqlDataAdapter(SQLgetRoute1, dbConn);
                dagetRoute.Fill(getRoute, "TBLroute1");

                string route1 = getRoute.Tables["TBLroute1"].Rows[0][0].ToString();

                string SQLgetRoute2 = "SELECT routs FROM station where stationName='" + cmbtStation.Text.Trim() + "'";
                dagetRoute = new MySqlDataAdapter(SQLgetRoute2, dbConn);
                dagetRoute.Fill(getRoute, "TBLroute2");
                string route2 = getRoute.Tables["TBLroute2"].Rows[0][0].ToString();

                // Finding common routes
                var commonValues = route1.Split(',').Intersect(route2.Split(','));

                // Creating a DataTable to hold searched trains data
                DataTable dtsearchedTrains = new DataTable();
                dtsearchedTrains.Columns.Add("Train Name");
                dtsearchedTrains.Columns.Add("Start Station");
                dtsearchedTrains.Columns.Add("Destination Station");
                dtsearchedTrains.Columns.Add("FC Seats");
                dtsearchedTrains.Columns.Add("SC Seats");
                dtsearchedTrains.Columns.Add("Start Time");

                // Loop through common routes
                foreach (var value in commonValues)
                {
                    // Get trains for the common route and selected date
                    DataSet getTrain = new DataSet();
                    string SQLgetTrain = "SELECT tName, sStation, dStation, FSeatcount, SSeatcount, sTime FROM train WHERE tRoute = '" + value + "' AND sDate = '" + datBdate.Text.Trim() + "'";
                    MySqlDataAdapter dagetTrain = new MySqlDataAdapter(SQLgetTrain, dbConn);
                    dagetTrain.Fill(getTrain, "TBLgetTrains");

                    // Add trains data to the DataTable
                    foreach (DataRow row in getTrain.Tables["TBLgetTrains"].Rows)
                    {
                        dtsearchedTrains.Rows.Add(row["tName"], row["sStation"], row["dStation"], row["FSeatcount"], row["SSeatcount"], row["sTime"]);
                    }
                }

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dtsearchedTrains;

                // Adjust column widths
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
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

        private void cmbfStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string startst = cmbfStation.Text.Trim();

            DataSet dsSS = new DataSet();
            string SQLgetstationID1 = "SELECT stationID FROM station where stationName='" + startst + "'";
            MySqlDataAdapter dagetstationID = new MySqlDataAdapter(SQLgetstationID1, dbConn);
            dagetstationID.Fill(dsSS, "TBLStationID");

            fromT = int.Parse(dsSS.Tables["TBLStationID"].Rows[0][0].ToString());
        }


        private void cmbtStation_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string desst = cmbtStation.Text.Trim();

            DataSet dsSS2 = new DataSet();
            string SQLgetstationID2 = "SELECT stationID FROM station where stationName='" + desst + "'";
            MySqlDataAdapter dagetstationID2 = new MySqlDataAdapter(SQLgetstationID2, dbConn);
            dagetstationID2.Fill(dsSS2, "TBLStationID");

            toT = int.Parse(dsSS2.Tables["TBLStationID"].Rows[0][0].ToString());
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the selected row's data
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                selectedTrainName = selectedRow.Cells["Train Name"].Value.ToString();
                selectedTrainDate = selectedRow.Cells["Start Time"].Value.ToString();
                string FCSeats = selectedRow.Cells["FC Seats"].Value.ToString();
                string SCSeats = selectedRow.Cells["SC Seats"].Value.ToString();


                bookingConfirm bkconfirm = new bookingConfirm(selectedTrainName, selectedTrainDate, loggedInUsername, FCSeats, SCSeats);
                bkconfirm.ShowDialog();
                this.Hide();

               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userhome usehom = new userhome();
            usehom.Show();
            this.Hide();
            
        }
    }

}

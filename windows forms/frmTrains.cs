using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmTrains : Form
    {
        MySqlConnection dbConn;
        int station1;
        int station2;
        public frmTrains()
        {
            InitializeComponent();
        }

        private void frmTrains_Load(object sender, EventArgs e)
        {
            dbConn = new MySqlConnection("Server=localhost;" + "Database=trainsystem;" + "Uid=root;" + "Pwd=123;");

            if (dbConn.State != ConnectionState.Open)
            {
                dbConn.Open();
            }

            this.fillRoutes();
            this.fillStations();

            mcDate.MinDate = DateTime.Today;
            mcDate.MaxDate = DateTime.Today.AddMonths(1);

        }
        private void fillRoutes()
        {
            cmbRoute.Items.Clear();

            DataSet getRoutes = new DataSet();
            string SQLgetRoutes = "SELECT routeName FROM route";
            MySqlDataAdapter dagetRoute = new MySqlDataAdapter(SQLgetRoutes, dbConn);
            dagetRoute.Fill(getRoutes, "TBLroutesname");

            if (getRoutes.Tables["TBLroutesname"].Rows.Count > 0)
            {
                for (int count = getRoutes.Tables["TBLroutesname"].Rows.Count - 1; count >= 0; count--)
                {
                    cmbRoute.Items.Add(getRoutes.Tables["TBLroutesname"].Rows[count][0].ToString());
                }
            }
        }
        private void fillStations()
        {
            cmbsStation.Items.Clear();
            cmbdStation.Items.Clear();

            DataSet getStatioins = new DataSet();
            string SQLgetStations = "SELECT stationName FROM station";
            MySqlDataAdapter dagetRoute = new MySqlDataAdapter(SQLgetStations, dbConn);
            dagetRoute.Fill(getStatioins, "TBLstationname");

            if (getStatioins.Tables["TBLstationname"].Rows.Count > 0)
            {
                for (int count = getStatioins.Tables["TBLstationname"].Rows.Count - 1; count >= 0; count--)
                {
                    cmbsStation.Items.Add(getStatioins.Tables["TBLstationname"].Rows[count][0].ToString());
                    cmbdStation.Items.Add(getStatioins.Tables["TBLstationname"].Rows[count][0].ToString());
                }
            }
        }

        private void btntAdd_Click(object sender, EventArgs e)
        {
            dbConn = new MySqlConnection("Server=localhost;" + "Database=trainsystem;" + "Uid=root;" + "Pwd=123;");

            if (dbConn.State != ConnectionState.Open)
            {
                dbConn.Open();
            }

            try
            {
                DateTime scheduleTime = Convert.ToDateTime(dtpTime.Value);
                DateTime scheduledate = Convert.ToDateTime(mcDate.Value);

                //==============================================
                DataSet DSgetRouteID = new DataSet();
                string SQLgetRouteID = "SELECT routeNo FROM route where routeName='" + cmbRoute.Text.Trim() + "'";
                MySqlDataAdapter dagetRoute = new MySqlDataAdapter(SQLgetRouteID, dbConn);
                dagetRoute.Fill(DSgetRouteID, "TBLrouteID");
                string toDBRouteID = DSgetRouteID.Tables["TBLrouteID"].Rows[0][0].ToString();
                //==============================================

                string trainDirection = "";

                if (station1 > station2)
                {
                    trainDirection = "UP";
                }
                else
                {
                    trainDirection = "DOWN";
                }

                String SQLaddnewtrainSchedule = "INSERT INTO train VALUES('" + txttID.Text.Trim() + "','" + txttName.Text.Trim() + "','" + cmbsStation.Text.Trim() + "','" + cmbdStation.Text.Trim() + "','" + txt1stclassSeat.Text.Trim() + "','" + txt2ndclassSeat.Text.Trim() + "','" + toDBRouteID + "','" + scheduleTime.ToLongTimeString().Trim() + "','" + scheduledate.ToLongDateString().Trim() + "','" + trainDirection + "')";



                MySqlCommand cmdaddTrain = new MySqlCommand(SQLaddnewtrainSchedule, dbConn);
                cmdaddTrain.ExecuteNonQuery();

                dbConn.Close();
                MessageBox.Show("New Train Schedule Added!", "New Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
              
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbConn.Close();
            }


        }

        private void txttrainClear()
        {
            //text fields clear 

            // Clear text fields
            txttID.Clear();
            txttName.Clear();
            txt1stclassSeat.Clear();
            txt2ndclassSeat.Clear();

            // Clear combo boxes
            cmbsStation.SelectedIndex = -1;
            cmbdStation.SelectedIndex = -1;
            cmbRoute.SelectedIndex = -1;

            // Clear date picker
            mcDate.Value = DateTime.Today;
            dtpTime.Value = DateTime.Now;
        }

        private void cmbsStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string startst = cmbsStation.Text.Trim();

            DataSet dsSS = new DataSet();
            string SQLgetstationID1 = "SELECT stationID FROM station where stationName='" + startst + "'";
            MySqlDataAdapter dagetstationID = new MySqlDataAdapter(SQLgetstationID1, dbConn);
            dagetstationID.Fill(dsSS, "TBLStationID");

            
    if (dsSS.Tables["TBLStationID"].Rows.Count > 0)
                    {

                station1 = int.Parse(dsSS.Tables["TBLStationID"].Rows[0][0].ToString());
            }
        }

        private void cmbdStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string desst = cmbdStation.Text.Trim();

            DataSet dsSS2 = new DataSet();
            string SQLgetstationID2 = "SELECT stationID FROM station where stationName='" + desst + "'";
            MySqlDataAdapter dagetstationID2 = new MySqlDataAdapter(SQLgetstationID2, dbConn);
            dagetstationID2.Fill(dsSS2, "TBLStationID2");

            if (dsSS2.Tables["TBLStationID2"].Rows.Count > 0)
            {
                station2 = int.Parse(dsSS2.Tables["TBLStationID2"].Rows[0][0].ToString());
            }

        }

        private void btntClear_Click(object sender, EventArgs e)
        {
            txttrainClear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMDI mdifrm = new frmMDI();
            mdifrm.Show();
            this.Hide();
        }

        private void btntUpdate_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }

                // Get the schedule ID
                string scheduleID = txttID.Text.Trim();

                // Construct the SQL query to delete the entire row based on scheduleID
                string deleteQuery = "DELETE FROM train WHERE tScheduleID = @ScheduleID";

                // Create a MySqlCommand object
                MySqlCommand cmd = new MySqlCommand(deleteQuery, dbConn);

                // Add parameters to the command
                cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);

                // Execute the delete command
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if any rows were affected
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record with schedule ID " + scheduleID + " deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Clear the form fields after successful deletion
                    txttrainClear();
                }
                else
                {
                    MessageBox.Show("No records found with the provided schedule ID.", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConn.Close();
            }
        }
    }
}


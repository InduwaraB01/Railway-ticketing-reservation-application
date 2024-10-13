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
    public partial class frmStation : Form
    {

        MySqlConnection dbConn;

        public frmStation()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dbConn.State != ConnectionState.Open)
            {
                dbConn.Open();
            }
            String stationList="";
            foreach (string item in lstRid.SelectedItems)
            {
                DataSet getRoutesno = new DataSet();
                string SQLgetRoutes = "SELECT routeNo FROM route where routeName='"+item+"'";
                MySqlDataAdapter dagetRoute = new MySqlDataAdapter(SQLgetRoutes, dbConn);
                dagetRoute.Fill(getRoutesno, "TBLroutesno");

                stationList += getRoutesno.Tables["TBLroutesno"].Rows[0][0].ToString() + ",";
                getRoutesno.Clear();
            }

            int li=stationList.LastIndexOf(",");
            MessageBox.Show(li.ToString());
            stationList.Remove(li);

            MessageBox.Show(stationList);

            try
            {
                String SQLaddnewStation = "INSERT INTO station VALUES('" + txtStationID.Text.Trim() + "','" + txtsName.Text.Trim() + "','" + stationList.Trim() + "')";

                MySqlCommand cmdAddStation = new MySqlCommand(SQLaddnewStation, dbConn);
                cmdAddStation.ExecuteNonQuery();

                dbConn.Close();
                MessageBox.Show("New Station Added!", "New Route", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.txtClear();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbConn.Close();
            }
        }

        private void frmStation_Load(object sender, EventArgs e)
        {

            dbConn = new MySqlConnection("Server=localhost;" + "Database=trainsystem;" + "Uid=root;" + "Pwd=123;");

            if (dbConn.State != ConnectionState.Open)
            {
                dbConn.Open();
            }
            this.fillList();
        }
        private void fillList()
        {
            lstRid.Items.Clear();

            DataSet getRoutes = new DataSet();
            string SQLgetRoutes = "SELECT routeName FROM route";
            MySqlDataAdapter dagetRoute = new MySqlDataAdapter(SQLgetRoutes, dbConn);
            dagetRoute.Fill(getRoutes, "TBLroutesname");

            if (getRoutes.Tables["TBLroutesname"].Rows.Count > 0)
            {
                for (int count = getRoutes.Tables["TBLroutesname"].Rows.Count - 1; count >= 0; count--)
                {
                    lstRid.Items.Add(getRoutes.Tables["TBLroutesname"].Rows[count][0].ToString());
                }
            }
        }

        private void txtClear()
        {
            txtsName.ResetText();
            txtStationID.ResetText();
            lstRid.Items.Clear();
            txtStationID.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.fillList();
        }
    }
}

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
    public partial class frmTrainRoute : Form
    {

        MySqlConnection dbConn;

        public frmTrainRoute()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dbConn = new MySqlConnection("Server=localhost;" + "Database=trainsystem;" + "Uid=root;" + "Pwd=123;");

            if (dbConn.State != ConnectionState.Open)
            {
                dbConn.Open();
            }

            try
            {
                String SQLaddnewRoute = "INSERT INTO route VALUES('" + txtRNo.Text.Trim() + "','" + txtRName.Text.Trim() + "')";

                MySqlCommand cmd1 = new MySqlCommand(SQLaddnewRoute, dbConn);
                cmd1.ExecuteNonQuery();
              
                dbConn.Close();
                MessageBox.Show("New Route Added!", "New Route", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                txtRName.ResetText();
                txtRNo.ResetText();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbConn.Close();
            }
        }

        private void frmTrainRoute_Load(object sender, EventArgs e)
        {

            dbConn = new MySqlConnection("Server=localhost;" + "Database=trainsystem;" + "Uid=root;" + "Pwd=123;");

            if (dbConn.State != ConnectionState.Open)
            {
                dbConn.Open();
            }
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            txtRName.ResetText();
            txtRNo.ResetText();
        }

        
    }
}

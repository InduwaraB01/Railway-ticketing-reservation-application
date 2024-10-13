using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//calling mysql.data namesapace in to solution
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmuserManage : Form
    {

        MySqlConnection dbConn;

        public frmuserManage()
        {
            InitializeComponent();
        }

        private void txtClear()
        {
            txtcNIC.ResetText();
            txtcName.ResetText();
            txtcAddress.ResetText();
            txtcContact.ResetText();
            txtcUsername.ResetText();
            txtcPassword.ResetText();
        }

        private void frmuserLogin_Load(object sender, EventArgs e)
        {
            dbConn = new MySqlConnection("Server=localhost;" + "Database=trainsystem;" + "Uid=root;" + "Pwd=123;");

            if (dbConn.State != ConnectionState.Open)
            {
                dbConn.Open();
            }
        }

        private void btncAdd_Click(object sender, EventArgs e)
        {
            if (dbConn.State != ConnectionState.Open)
            {
                dbConn.Open();
            }
            try
            {
                String SQLaddnewUser= "INSERT INTO cusdetailstbl VALUES('" + txtcNIC.Text.Trim() + "','" + txtcName.Text.Trim() + "','" + txtcAddress.Text.Trim() + "','" + txtcContact.Text.Trim() + "')";
                String SQLaddnewLogin= "INSERT INTO logintbl VALUES('" + txtcUsername.Text.Trim() + "','" + txtcPassword.Text.Trim() + "','" + txtcNIC.Text.Trim() + "' )";

                MySqlCommand cmd1 = new MySqlCommand(SQLaddnewUser, dbConn);
                cmd1.ExecuteNonQuery();
                MySqlCommand cmd2 = new MySqlCommand(SQLaddnewLogin, dbConn);
                cmd2.ExecuteNonQuery();
                dbConn.Close();
                MessageBox.Show("Welcome to Train Ticket Booking System!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.txtClear();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbConn.Close();
            }
        }

        private void btncUpdate_Click(object sender, EventArgs e)
        {
            string userID = txtcNIC.Text;

            if (btncUpdate.Text.Equals("&Search"))
            {
                string SQLSearchUser = "SELECT * FROM cusdetailstbl WHERE cusNIC='" + txtcNIC.Text + "'";
                string SQLoginSearch = "SELECT * FROM logintbl WHERE cusNIC='" + txtcNIC.Text + "'";

                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }

                DataSet userSearch = new DataSet();

                MySqlDataAdapter da = new MySqlDataAdapter(SQLSearchUser, dbConn);
                da.Fill(userSearch, "TBLuserInfo");

                if (userSearch.Tables["TBLuserInfo"].Rows.Count > 0)
                {
                    txtcName.Text = userSearch.Tables["TBLuserInfo"].Rows[0][1].ToString();
                    txtcAddress.Text = userSearch.Tables["TBLuserInfo"].Rows[0][2].ToString();
                    txtcContact.Text = userSearch.Tables["TBLuserInfo"].Rows[0][3].ToString();

                    da = new MySqlDataAdapter(SQLoginSearch, dbConn);
                    da.Fill(userSearch, "TBLloginsearch");

                    txtcUsername.Text = userSearch.Tables["TBLloginsearch"].Rows[0][0].ToString();
                    txtcPassword.Text = userSearch.Tables["TBLloginsearch"].Rows[0][1].ToString();

                    DialogResult respond = MessageBox.Show("Do you really want to Update ?\nor Delete information for user " + txtcName.Text + "!", "Update\\Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respond == DialogResult.Yes)
                    {
                        btncUpdate.Text = "&Update";
                    }
                    else
                    {
                        btncUpdate.Text = "&Delete";
                    }

                }
                else
                {
                    MessageBox.Show("No Such Customer for " + txtcNIC.Text + " No..", "No User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcNIC.Text = "";
                    txtcNIC.Focus();
                    userSearch.Clear();
                }
            }
            else if (btncUpdate.Text.Equals("&Update"))
            {
                DialogResult respond = MessageBox.Show("Do you really want to Update this information for user " + txtcName.Text + "!", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respond == DialogResult.Yes)
                {
                    string SQLUserinfoUpdate = "UPDATE cusdetailstbl SET cusName='" + txtcName.Text.Trim() + "',cusAdd='" + txtcAddress.Text.Trim() + "',contact='" + txtcContact.Text.Trim() + "'where cusNIC='" + userID + "'";
                    MySqlCommand cmd = new MySqlCommand(SQLUserinfoUpdate, dbConn);
                    cmd.ExecuteNonQuery();

                    string SQLlogininfoUpdate = "UPDATE logintbl SET userName='" + txtcUsername.Text.Trim() + "',password='" + txtcPassword.Text.Trim() + "'where cusNIC='" + userID + "'";
                    MySqlCommand cmdloginUpdate = new MySqlCommand(SQLlogininfoUpdate, dbConn);
                    cmdloginUpdate.ExecuteNonQuery();
                    this.txtClear();

                    MessageBox.Show("Customert Details for " + userID + "is Successfully updated.!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btncUpdate.Text = "&Search";

                }
                else
                {
                    this.txtClear();
                }
            }

            else if (btncUpdate.Text.Equals("&Delete"))
            {
                DialogResult respond = MessageBox.Show("Do you really want to Delete this information for user " + txtcName.Text + "!", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respond == DialogResult.Yes)
                {
                    string SQLUserinfoDelete = "DELETE FROM cusdetailstbl where cusNIC='" + userID + "'";
                    MySqlCommand cmd = new MySqlCommand(SQLUserinfoDelete, dbConn);
                    cmd.ExecuteNonQuery();

                    string SQLlogininfoUpdate = "DELETE FROM logintbl where cusNIC='" + userID + "'";
                    MySqlCommand cmdloginUpdate = new MySqlCommand(SQLlogininfoUpdate, dbConn);
                    cmdloginUpdate.ExecuteNonQuery();
                    this.txtClear();

                    MessageBox.Show("Customert Details for " + userID + "is Successfully Deleted.!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btncUpdate.Text = "&Search";

                }
                else
                {
                    this.txtClear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtClear();
            btncUpdate.Text = "&Search";
        }

       
    }
}


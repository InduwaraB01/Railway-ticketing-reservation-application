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
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void userManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmuserManage>().Any())
            {
                MessageBox.Show("User Management form allready opened", "Form Opened", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmuserManage usermng = new frmuserManage();
                usermng.MdiParent = this;
                usermng.Show();

            }            
            
        }

        private void routeManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmTrainRoute>().Any())
            {
                MessageBox.Show("Route Management form allready opened", "Form Opened", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmTrainRoute routemng = new frmTrainRoute();
                routemng.MdiParent = this;
                routemng.Show();
                
            }
        }

        private void stationManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmStation>().Any())
            {
                MessageBox.Show("Station Management form allready opened", "Form Opened", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmStation stationmng = new frmStation();
                stationmng.MdiParent = this;
                stationmng.Show();

            }
        }

        private void trainManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<frmTrains>().Any())
            {
                MessageBox.Show("Station Management form allready opened", "Form Opened", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmTrains trainmng = new frmTrains();
                trainmng.MdiParent = this;
                trainmng.Show();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminlogin adlgin = new adminlogin();
            adlgin.Show();
            this.Close();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {

        }
    }
}

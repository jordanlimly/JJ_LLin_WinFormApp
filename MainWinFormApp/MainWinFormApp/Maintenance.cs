using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;


namespace MainWinFormApp
{
    public partial class frmMaintenance : Form
    {
        //retrieve connection information
        string strConnectionString = 
            ConfigurationManager.ConnectionStrings["JJLLinDBConnection"].ConnectionString;
        public frmMaintenance()
        {
            InitializeComponent();
        }

        private void tbCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int result = 0;
            //create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            //create command
            String strCommandText =
                "INSERT GameMachineMaintenance (GameMachineID, MaintenanceDate, MaintenanceFee, Remarks)" +
                " VALUES (@NewMachineID, @NewDate, @NewFee, @NewRemarks)";

            SqlCommand addValue = new SqlCommand(strCommandText, myConnect);
            addValue.Parameters.AddWithValue("@NewMachineID", tbMachineID.Text);
            addValue.Parameters.AddWithValue("@NewDate", tbDate.Text);
            addValue.Parameters.AddWithValue("@NewFee", tbCost.Text);
            addValue.Parameters.AddWithValue("@NewRemarks", tbRemarks.Text);

            //open connection and retrieve data by calling ExecuteReader
            myConnect.Open();

            //execute command
            //result indicates number of records created
            result = addValue.ExecuteNonQuery();

            if (result > 0)
                MessageBox.Show("New Maintenance Record Added!");
            else
                MessageBox.Show("Failed to add new Maintenance record.");

            //close connection
            myConnect.Close();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

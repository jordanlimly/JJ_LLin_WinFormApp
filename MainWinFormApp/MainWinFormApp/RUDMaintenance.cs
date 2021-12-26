using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace MainWinFormApp
{
    public partial class RUDMaintenance : Form
    {
        //retrieve connection information from App.config
        private string strConnectionString =
            ConfigurationManager.ConnectionStrings["JJLLinDBConnection"].ConnectionString;

        public RUDMaintenance()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            bool blnfound = false;

            //create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //create command
            string StrCommandText = "SELECT MaintenanceFee, Remarks FROM GameMachineMaintenance ";

            //adding a WHERE claus
            StrCommandText += "WHERE GameMachineID = @GMachineID AND MaintenanceDate = @MtnceDate";
            SqlCommand retrieveValue = new SqlCommand(StrCommandText, myConnect);
            retrieveValue.Parameters.AddWithValue("@GMachineID", tbGameMachineID.Text);
            retrieveValue.Parameters.AddWithValue("@MtnceDate", DTPickerRUDMaintenance.Text);

            //open connection
            myConnect.Open();

            //access data
            SqlDataReader reader = retrieveValue.ExecuteReader();

            if (reader.Read())
            {
                tbCost.Text = reader["MaintenanceFee"].ToString();
                tbRemarks.Text = reader["Remarks"].ToString();
                blnfound = true;
            }
            else
                MessageBox.Show("No Maintenance Record Found!");

            reader.Close();
            myConnect.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (ModifyMaintenanceRecord() > 0)
                MessageBox.Show("Maintenance Record Successfully Modified!");
            else
                MessageBox.Show("Maintenance Record Modification Failed!");
        }

        private int ModifyMaintenanceRecord()
        {
            // create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText = "UPDATE GameMachineMaintenance SET MaintenanceFee = @NewMtnceFee, Remarks = @NewMtnceRemarks WHERE GameMachineID = @GMachineID AND MaintenanceDate = @MtnceDate";
            SqlCommand modifyValue = new SqlCommand(strCommandText, myConnect);

            //creating command
            modifyValue.Parameters.AddWithValue("GMachineID", tbGameMachineID.Text);
            modifyValue.Parameters.AddWithValue("MtnceDate", DTPickerRUDMaintenance.Text);
            modifyValue.Parameters.AddWithValue("NewMtnceFee", tbCost.Text);
            modifyValue.Parameters.AddWithValue("NewMtnceRemarks", tbRemarks.Text);

            //open connection
            myConnect.Open();
            //execute command
            //indicate number of records modified
            int result = modifyValue.ExecuteNonQuery();

            //close
            myConnect.Close();
            return result;
        }

        private int DeleteMaintenanceRecord(string strGameMachineID, string strMaintenanceDate)
        {
            int result = 0;

            //create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //create command
            String strCommandText = "DELETE FROM GameMachineMaintenance WHERE GameMachineID = @GMachineID AND MaintenanceDate = @MtnceDate";
            SqlCommand deleteValue = new SqlCommand(strCommandText, myConnect);
            deleteValue.Parameters.AddWithValue("@GMachineID", strGameMachineID);
            deleteValue.Parameters.AddWithValue("@MtnceDate", strMaintenanceDate);

            //open connection
            myConnect.Open();

            //execute command
            result = deleteValue.ExecuteNonQuery();

            //close connection
            myConnect.Close();

            return result;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //prompt admin to confirm deletion of maintenance record
            if (MessageBox.Show("Confirm Delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (DeleteMaintenanceRecord(tbGameMachineID.Text, DTPickerRUDMaintenance.Text) > 0)
                    MessageBox.Show("Maintenance Record for Game Machine " + tbGameMachineID.Text + " on " + DTPickerRUDMaintenance.Text + " has been deleted");
                else
                    MessageBox.Show("Maintenance Record could not be deleted!");
            }

            tbGameMachineID.Text = String.Empty;
            DTPickerRUDMaintenance.Text = String.Empty;
            tbCost.Text = String.Empty;
            tbRemarks.Text = String.Empty;
        }
    }
}

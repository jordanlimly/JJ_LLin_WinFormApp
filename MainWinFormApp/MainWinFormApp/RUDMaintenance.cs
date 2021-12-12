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
            retrieveValue.Parameters.AddWithValue("@MtnceDate", tbDate.Text);

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
    }
}

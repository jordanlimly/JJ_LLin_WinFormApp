﻿using System;
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

            String strCheckText = "SELECT GameMachineID FROM GameMachine";
            strCheckText += " WHERE GameMachineID=@GMID";

            String strUpdateUsageText =
                "UPDATE GameMachine" +
                " SET UsageCount = @NewUsageCount" +
                " WHERE GameMachineID = @gmid";

            SqlCommand addValue = new SqlCommand(strCommandText, myConnect);
            addValue.Parameters.AddWithValue("@NewMachineID", tbMachineID.Text);
            addValue.Parameters.AddWithValue("@NewDate", DTPickerMaintenance.Text);
            addValue.Parameters.AddWithValue("@NewFee", tbCost.Text);
            addValue.Parameters.AddWithValue("@NewRemarks", tbRemarks.Text);

            SqlCommand checkValue = new SqlCommand(strCheckText, myConnect);
            checkValue.Parameters.AddWithValue("@GMID", tbMachineID.Text);

            SqlCommand updateUsage = new SqlCommand(strUpdateUsageText, myConnect);
            updateUsage.Parameters.AddWithValue("@NewUsageCount", 10);
            updateUsage.Parameters.AddWithValue("@gmid", tbMachineID.Text);

            try
            {
                myConnect.Open();

                SqlDataReader reader = checkValue.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    result = addValue.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("New Maintenance Record Added!");
                        updateUsage.ExecuteNonQuery();
                    }
                    else
                        MessageBox.Show("Failed to add new Maintenance record.");

                }

                else
                    MessageBox.Show("Failed to add new Maintenance record.");

                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }

            finally
            {
                myConnect.Close();
                Close();
            }

            //open connection and retrieve data by calling ExecuteReader
            

            //execute command
            //result indicates number of records created
            //result = addValue.ExecuteNonQuery();

            //if (result > 0)
            //    MessageBox.Show("New Maintenance Record Added!");
            //else
            //    MessageBox.Show("Failed to add new Maintenance record.");

            //close connection
            //myConnect.Close();
            //Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

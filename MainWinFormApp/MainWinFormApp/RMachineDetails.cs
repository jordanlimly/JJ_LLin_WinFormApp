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
    public partial class RMachineDetails : Form
    {
        //retrieve connection from App.config
        private string StrConnectionString = 
            ConfigurationManager.ConnectionStrings["JJLLinDBConnection"].ConnectionString;


        public RMachineDetails()
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
            SqlConnection myConnect = new SqlConnection(StrConnectionString);

            //create command
            string strCommandText = "SELECT GameMachineID, UsageCount FROM GameMachine ";
            //WHERE claus
            strCommandText += "WHERE GameMachineName = @GMachineName";
            SqlCommand retrieveValues = new SqlCommand(strCommandText, myConnect);
            retrieveValues.Parameters.AddWithValue("@GMachineName", tbGMachineName.Text);

            //open connection
            myConnect.Open();

            //access data
            SqlDataReader reader = retrieveValues.ExecuteReader();

            if (reader.Read())
            {
                tbGMachineID.Text = reader["GameMachineID"].ToString();
                tbUsageCount.Text = reader["UsageCount"].ToString();
                blnfound = true;
            }
            else
                MessageBox.Show("Game Machine does not exist!");

            reader.Close();
            myConnect.Close();
        }
    }
}

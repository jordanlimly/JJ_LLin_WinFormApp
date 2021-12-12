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
    public partial class GameMachineDetails : Form
    {
        //retrieve connection from App.config
        string strConnectionString = ConfigurationManager.ConnectionStrings["JJLLinDBConnection"].ConnectionString;

        public GameMachineDetails()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result = 0;

            //create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //create command
            String strCommandText =
                "INSERT GameMachine (GameMachineID, GameMachineName, UsageCount)" +
                " VALUES (@NewGMachineID, @NewGMachineName, @NewUsageCount)";

            SqlCommand addValue = new SqlCommand(strCommandText, myConnect);
            addValue.Parameters.AddWithValue("@NewGMachineID", tbGMachineID.Text);
            addValue.Parameters.AddWithValue("@NewGMachineName", tbGMachineName.Text);
            addValue.Parameters.AddWithValue("@NewUsageCount", 10);

            //open connection
            myConnect.Open();

            //execute command
            //indicate number of records created
            result = addValue.ExecuteNonQuery();

            if (result > 0)
                MessageBox.Show("New Game Machine has been added successfully!");
            else
                MessageBox.Show("Could not add Game Machine!");

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

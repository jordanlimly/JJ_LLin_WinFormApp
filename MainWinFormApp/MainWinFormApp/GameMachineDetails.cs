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

            String strCheckMachine = "SELECT GameMachineID, GameMachineName FROM GameMachine" +
                " WHERE GameMachineID = @gmid OR GameMachineName = @gmName";

            SqlCommand addValue = new SqlCommand(strCommandText, myConnect);
            addValue.Parameters.AddWithValue("@NewGMachineID", tbGMachineID.Text);
            addValue.Parameters.AddWithValue("@NewGMachineName", tbGMachineName.Text);
            addValue.Parameters.AddWithValue("@NewUsageCount", 10);

            SqlCommand checkMachines = new SqlCommand(strCheckMachine, myConnect);
            checkMachines.Parameters.AddWithValue("@gmid", tbGMachineID.Text);
            checkMachines.Parameters.AddWithValue("@gmName", tbGMachineName.Text);

            try
            {
                //open connection
                myConnect.Open();

                SqlDataReader reader = checkMachines.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Game machine already exists! ");
                }

                else
                {
                    reader.Close();

                    result = addValue.ExecuteNonQuery();

                    if (result > 0)
                        MessageBox.Show("New game machine has been added successfully!");
                    else
                        MessageBox.Show("Could not add game machine!");
                }
                    

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


            //execute command
            //indicate number of records created




            //close connection
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

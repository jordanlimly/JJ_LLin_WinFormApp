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
    public partial class CustLoginForm : Form
    {
        // retrieve connection information from App.Config
        private string strConnectionString = ConfigurationManager.ConnectionStrings["JJLLinDBConnection"].ConnectionString;

        public CustLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Open Connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Create COmmand
            string strCommandText = "SELECT Email, Password FROM UserAccount";

            //WHERE clause
            strCommandText += " WHERE Email=@email AND Password=@pw";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@email", tbLoginEmail.Text);
            cmd.Parameters.AddWithValue("@pw", tbLoginPw.Text);

            try
            {
                //Step 3: Open connection and retrieve data by calling ExecuteReader
                myConnect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    MessageBox.Show("Login Successful");
                else
                    MessageBox.Show("Login Fail");
                //Step 5: Close connection
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
            finally
            {
                //Step 5: Close connection
                myConnect.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

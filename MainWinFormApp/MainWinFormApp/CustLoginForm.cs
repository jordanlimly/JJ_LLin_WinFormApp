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
//using System.Web.HttpContext.Current.Session;


namespace MainWinFormApp
{
    public partial class CustLoginForm : Form
    {
        // retrieve connection information from App.Config
        private string strConnectionString = ConfigurationManager.ConnectionStrings["JJLLinDBConnection"].ConnectionString;

        public CustLoginForm()
        {
            InitializeComponent();

            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string updGCommandText = "UPDATE UserAccount SET MembershipTier='Gold' WHERE AccumulatedPoints>1000 ";
            string updSCommandText = "UPDATE UserAccount SET MembershipTier='Silver' WHERE AccumulatedPoints>499 AND AccumulatedPoints<999 ";

            SqlCommand updateGComd = new SqlCommand(updGCommandText, myConnect);
            SqlCommand updateSComd = new SqlCommand(updSCommandText, myConnect);

            myConnect.Open();
            int result = updateGComd.ExecuteNonQuery();
            int results = updateSComd.ExecuteNonQuery();
            myConnect.Close();

        }


        //public static string UserEmail = "";
        //public static string UserRFID = "";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            //Open Connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Create COmmand
            string strCommandText = "SELECT RFID_ID, Email, Password FROM UserAccount";

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
                {
                    MessageBox.Show("Login Successful!");
                    new UserDashboard(tbLoginEmail.Text).Show();
                    this.Hide();
                }
                    
                else
                    MessageBox.Show("Login Fail");
                    tbLoginEmail.Clear();
                    tbLoginPw.Clear();

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

        private void lblHere_Click(object sender, EventArgs e)
        {
            new frmCreateuserAcc().Show();
            this.Hide();
        }

        private void lnklblForgetPw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmforgetpw().Show();
            
        }
    }
}

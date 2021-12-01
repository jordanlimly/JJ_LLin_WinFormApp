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
    public partial class frmCreateuserAcc : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["JJLLinDBConnection"].ConnectionString;

        public frmCreateuserAcc()
        {
            InitializeComponent();
        }

        // i accidentally clicked the title im so sworryy :(((((
        private void lblCreateUserAcc_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int result = 0;
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            string strCommandText = "INSERT INTO UserAccount (RFID_ID, Name, Email, Password, CurrentCredits, CurrentPoints, AccumulatedPoints, MembershipTier, AirHockey, DDR, StreetFighter, SecurityQn1, SecurityQn1Ans, SecurityQn2, SecurityQn2Ans)" +
                " VALUES (@cardid, @name, @email, @pw, @ccredits, @cpoints, @apoints, @mtier, @ahockey, @ddr, @sfighter, @secqn1, @secqn1ans, @secqn2, @secqn2ans)";

            //WHERE clause
            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@name", tbFullName.Text);
            updateCmd.Parameters.AddWithValue("@email", tbEmail.Text);
            updateCmd.Parameters.AddWithValue("@pw", tbPassword.Text);
            updateCmd.Parameters.AddWithValue("@cardid", tbCardID.Text);
            updateCmd.Parameters.AddWithValue("@ccredits", 0);
            updateCmd.Parameters.AddWithValue("@cpoints", 0);
            updateCmd.Parameters.AddWithValue("@apoints", 0);
            updateCmd.Parameters.AddWithValue("@mtier", "Bronze");
            updateCmd.Parameters.AddWithValue("@ahockey", 0);
            updateCmd.Parameters.AddWithValue("@ddr", 0);
            updateCmd.Parameters.AddWithValue("@sfighter", 0);
            updateCmd.Parameters.AddWithValue("@secqn1", combSQ1);
            updateCmd.Parameters.AddWithValue("@secqn1ans", tbSQ1.Text);
            updateCmd.Parameters.AddWithValue("@secqn2", combSQ2);
            updateCmd.Parameters.AddWithValue("@secqn2ans", tbSQ2.Text);

            myConnect.Open();

            result = updateCmd.ExecuteNonQuery();
            if (result > 0)
                MessageBox.Show("Account created successfully!");
            else
                MessageBox.Show("Account creation unsuccessful!");

            myConnect.Close();
            Close();
        
            }
    }
}

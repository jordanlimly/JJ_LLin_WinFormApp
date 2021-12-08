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

            string strCommandText = "INSERT INTO UserAccount (RFID_ID, Name, Email, Password, MembershipTier, SecurityQn1, SecurityQn1Ans, SecurityQn2, SecurityQn2Ans)" +
                " VALUES (@cardid, @name, @email, @pw, @mtier, @secqn1, @secqn1ans, @secqn2, @secqn2ans)";

            //WHERE clause
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@cardid", tbCardID.Text);
            cmd.Parameters.AddWithValue("@name", tbFullName.Text);
            cmd.Parameters.AddWithValue("@email", tbEmail.Text);
            cmd.Parameters.AddWithValue("@pw", tbPassword.Text);
            cmd.Parameters.AddWithValue("@mtier", "Bronze");
            cmd.Parameters.AddWithValue("@secqn1", combSQ1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@secqn1ans", tbSQ1.Text);
            cmd.Parameters.AddWithValue("@secqn2", combSQ2.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@secqn2ans", tbSQ2.Text);

            myConnect.Open();
            result = cmd.ExecuteNonQuery();

            if (result > 0)
            {
                MessageBox.Show("Account Created!");
                Application.Run(new CustLoginForm());
            }
                
            else
                MessageBox.Show("Account Creation unsuccessful!");

            myConnect.Close();
            Close();

        }
    }
}

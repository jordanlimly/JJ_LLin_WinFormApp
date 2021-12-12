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
    public partial class CustUpdateForm : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["JJLLinDBConnection"].ConnectionString;

        public CustUpdateForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (updateProfile() > 0)
                MessageBox.Show("Update Successful!");
            else
                MessageBox.Show("Update Not Successful!");
        }

        private int updateProfile()
        {

            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText = " UPDATE UserAccount SET SecurityQn1=@newsq1, SecurityQn1Ans=@newsq1ans, SecurityQn2=@newsq2, SecurityQn2Ans=@newsq2ans WHERE RFID_ID=@cardid";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);

            updateCmd.Parameters.AddWithValue("@cardid", tbuCardID.Text);
            updateCmd.Parameters.AddWithValue("@newsq1", combSQ1.SelectedItem.ToString());
            updateCmd.Parameters.AddWithValue("@newsq1ans", tbSQ1.Text);
            updateCmd.Parameters.AddWithValue("@newsq2", combSQ2.SelectedItem.ToString());
            updateCmd.Parameters.AddWithValue("@newsq2ans", tbSQ2.Text);


            myConnect.Open();

            int result = updateCmd.ExecuteNonQuery();
            myConnect.Close();
            return result;
        }
    }
}

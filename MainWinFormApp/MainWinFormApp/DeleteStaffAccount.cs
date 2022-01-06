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
    public partial class DeleteStaffAccount : Form
    {
        //retrieve connection information
        string strConnectionString =
            ConfigurationManager.ConnectionStrings["JJLLinDBConnection"].ConnectionString;

        public DeleteStaffAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            String DeleteAccText = "DELETE FROM StaffAccounts WHERE StaffID = @StaffID";

            String CheckManagerText = "SELECT StaffID, Position, Password FROM StaffAccounts" +
                " WHERE StaffID = @MstaffID AND Position = @MPosition AND Password = @Mpassword";

            //String CheckManagerText2 = "SELECT StaffID, Password FROM StaffAccounts" +
            //    " WHERE StaffID = @MstaffID2 AND Password = @Mpassword";

            SqlCommand deletecmd = new SqlCommand(DeleteAccText, myConnect);
            deletecmd.Parameters.AddWithValue("@StaffID", tbStaffID.Text);

            SqlCommand checkcmd = new SqlCommand(CheckManagerText, myConnect);
            checkcmd.Parameters.AddWithValue("@MstaffID", tbMID.Text);
            checkcmd.Parameters.AddWithValue("@MPosition", "Manager");
            checkcmd.Parameters.AddWithValue("@Mpassword", tbMPW.Text);

            //SqlCommand checkcmd2 = new SqlCommand(CheckManagerText2, myConnect);
            //checkcmd2.Parameters.AddWithValue("MstaffID2", tbMID.Text);
            //checkcmd2.Parameters.AddWithValue("Mpassword", tbMPW.Text);

            try
            {
                myConnect.Open();

                SqlDataReader reader = checkcmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();

                    if (MessageBox.Show("Confirm delete?", "Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        
                        result = deletecmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show(tbStaffID.Text + "'s account has been deleted!");
                        }
                        else
                            MessageBox.Show(tbStaffID.Text + "'s account could not be deleted!");
                    }

                    tbStaffID.Text = String.Empty;
                    tbMID.Text = String.Empty;
                    tbMPW.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Manager details are incorrect!");
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

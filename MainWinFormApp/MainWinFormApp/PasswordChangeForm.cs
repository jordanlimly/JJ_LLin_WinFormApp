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
    public partial class PasswordChangeForm : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["JJLLinDBConnection"].ConnectionString;

        public PasswordChangeForm()
        {
            InitializeComponent();
        }

        private void lblOldpw_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            int result = 0;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            String StrCheckOldTxt = "SELECT Email, Password FROM UserAccount" +
                " WHERE Email=@email AND Password=@pwd";

            String StrChangeTxt = "UPDATE UserAccount SET Password=@newpwd" +
                " WHERE Email=@email";

            SqlCommand cmd = new SqlCommand(StrCheckOldTxt, myConnect);
            cmd.Parameters.AddWithValue("@email", tbEMail.Text);
            cmd.Parameters.AddWithValue("@pwd", tbOldpw.Text);

            SqlCommand cmd2 = new SqlCommand(StrChangeTxt, myConnect);
            cmd2.Parameters.AddWithValue("@newpwd", tbNewpw.Text);
            cmd2.Parameters.AddWithValue("@email", tbEMail.Text);

            //To check if old pw is correct
            if (tbCfmpw.Text == String.Empty || tbEMail.Text == String.Empty || tbNewpw.Text == String.Empty || tbOldpw.Text == String.Empty)
            {
                MessageBox.Show("Error! No Input!");
            }
            else
            {
                try
                {
                    //check if old pw is in db
                    myConnect.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        reader.Close();

                        //if newpw = cfmpw
                        if (tbNewpw.Text != tbCfmpw.Text)
                        {
                            MessageBox.Show("Passwords do not Match!");
                        }
                        else
                        {
                            //execute cmd2
                            result = cmd2.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Your Password Has Been Changed.");
                                btnCancel.PerformClick();
                            }
                            else
                            {
                                MessageBox.Show("Password not changed.");
                            }
                        }
                            
                            
                    }
                    else
                    {
                        MessageBox.Show("Old password is incorrect!");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message.ToString());
                }
                finally
                {
                    myConnect.Close();
                    
                }
            }

            
        }
    }
}

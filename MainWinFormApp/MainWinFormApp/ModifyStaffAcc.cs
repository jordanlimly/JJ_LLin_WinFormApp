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
    public partial class ModifyStaffAcc : Form
    {
        private string strConnectionString =
            ConfigurationManager.ConnectionStrings["JJLLinDBConnection"].ConnectionString;

        public ModifyStaffAcc()
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

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            String StrRetrieveText = "SELECT FirstName, LastName, Position FROM StaffAccounts ";

            StrRetrieveText += "WHERE StaffID = @SID";

            SqlCommand retrieveCmd = new SqlCommand(StrRetrieveText, myConnect);
            retrieveCmd.Parameters.AddWithValue("@SID", tbStaffID.Text);


        if (tbStaffID.Text == String.Empty)
            {
                MessageBox.Show("Staff ID input is required!");
            }
        else
            {
                myConnect.Open();

                SqlDataReader reader = retrieveCmd.ExecuteReader();

                if (reader.Read())
                {
                    tbFname.Text = reader["FirstName"].ToString();
                    tbLname.Text = reader["LastName"].ToString();
                    tbPosition.Text = reader["Position"].ToString();
                    blnfound = true;
                }
                else
                    MessageBox.Show("Staff account not found!");

                reader.Close();
                myConnect.Close();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int result = 0;
            int result2 = 0;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            String StrModifyText = "UPDATE StaffAccounts SET Position = @NewPosition, Password = @NewPass WHERE StaffID = @StaffID";
            String StrModifyText2 = "UPDATE StaffAccounts Set Position = @NewPos WHERE StaffID = @SID";
            String StrCheckManagerText = "SELECT StaffID, Position, Password FROM StaffAccounts" +
                " WHERE StaffID = @MstaffID AND Position = @Mpos AND Password = @Mpass";

            SqlCommand modifyCmd = new SqlCommand(StrModifyText, myConnect);
            modifyCmd.Parameters.AddWithValue("@NewPosition", char.ToUpper(tbPosition.Text[0]) + tbPosition.Text.Substring(1));
            modifyCmd.Parameters.AddWithValue("@NewPass", tbNewPassword.Text);
            modifyCmd.Parameters.AddWithValue("@StaffID", tbStaffID.Text);

            SqlCommand modifyCmd2 = new SqlCommand(StrModifyText2, myConnect);
            modifyCmd2.Parameters.AddWithValue("@NewPos", char.ToUpper(tbPosition.Text[0]) + tbPosition.Text.Substring(1));
            modifyCmd2.Parameters.AddWithValue("@SID", tbStaffID.Text);

            SqlCommand checkmngerCmd = new SqlCommand(StrCheckManagerText, myConnect);
            checkmngerCmd.Parameters.AddWithValue("@MstaffID", tbMID.Text);
            checkmngerCmd.Parameters.AddWithValue("@Mpos", "Manager");
            checkmngerCmd.Parameters.AddWithValue("@Mpass", tbMPass.Text);
            
            if (tbNewPassword.Text == String.Empty)
            {
                try
                {
                    myConnect.Open();

                    SqlDataReader reader1 = checkmngerCmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        reader1.Close();

                        result2 = modifyCmd2.ExecuteNonQuery();

                        if (result2 > 0)
                        {
                            MessageBox.Show(tbStaffID.Text + "'s account details have been modified!");
                        }
                        else
                        {
                            MessageBox.Show(tbStaffID.Text + "'s account details modification failed!");
                        }

                    }
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
            else
            {
                if (tbNewPassword.Text != tbCfmPassword.Text)
                {
                    MessageBox.Show("The new passwords do not match!");
                }
                else
                {
                    if (tbNewPassword.Text.Length > 10)
                    {
                        MessageBox.Show("Password must be within 10 characters!");
                    }
                    else
                    {
                        try
                        {
                            myConnect.Open();

                            SqlDataReader reader = checkmngerCmd.ExecuteReader();
                            if (reader.Read())
                            {
                                reader.Close();

                                result = modifyCmd.ExecuteNonQuery();

                                if (result > 0)
                                {
                                    MessageBox.Show(tbStaffID.Text + "'s account details have been modified!");
                                }
                                else
                                {
                                    MessageBox.Show(tbStaffID.Text + "'s account details modification failed!");
                                }
                            
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
                }
            }
            
        }
    }
}

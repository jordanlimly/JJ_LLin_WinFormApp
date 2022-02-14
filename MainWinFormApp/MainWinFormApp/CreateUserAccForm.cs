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
using System.Text.RegularExpressions;

namespace MainWinFormApp
{
    public partial class frmCreateuserAcc : Form
    {
       
        private string strConnectionString = ConfigurationManager.ConnectionStrings["JJLLinDBConnection"].ConnectionString;

        public frmCreateuserAcc()
        {
            InitializeComponent();
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int result = 0;
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            string strCommandText = "INSERT INTO UserAccount (RFID_ID, Name, Email, Password, MembershipTier, SecurityQn1, SecurityQn1Ans, SecurityQn2, SecurityQn2Ans)" +
                " VALUES (@cardid, @name, @email, @pw, @mtier, @secqn1, @secqn1ans, @secqn2, @secqn2ans)";

            //WHERE clause
            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@cardid", tbCardID.Text);
            updateCmd.Parameters.AddWithValue("@name", tbFullName.Text);
            updateCmd.Parameters.AddWithValue("@email", tbEmail.Text);
            updateCmd.Parameters.AddWithValue("@pw", tbPassword.Text);
            updateCmd.Parameters.AddWithValue("@mtier", "Bronze");
            updateCmd.Parameters.AddWithValue("@secqn1", combSQ1.SelectedItem.ToString());
            updateCmd.Parameters.AddWithValue("@secqn1ans", tbSQ1.Text);
            updateCmd.Parameters.AddWithValue("@secqn2", combSQ2.SelectedItem.ToString());
            updateCmd.Parameters.AddWithValue("@secqn2ans", tbSQ2.Text);

            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(tbEmail.Text.Trim());

            if (isValid || !string.IsNullOrEmpty(tbEmail.Text))
            {
                if (!string.IsNullOrEmpty(tbPassword.Text))
                {
                    if (!string.IsNullOrEmpty(tbCardID.Text))
                    {
                        if (!string.IsNullOrEmpty(tbCardID.Text))
                        {
                            if (tbPassword.Text == tbCfmPassword.Text)
                            {
                                myConnect.Open();
                                result = updateCmd.ExecuteNonQuery();

                                if (result > 0)
                                {
                                    MessageBox.Show("Account Created!");
                                    CustLoginForm frm = new CustLoginForm();
                                    this.Hide();
                                    frm.ShowDialog();
                                    this.Close();
                                }

                                else
                                    MessageBox.Show("Account Creation unsuccessful!");

                                myConnect.Close();
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Passwords not matching!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter Security Question inputs!");
                        }
                            
                    }
                    else
                    {
                        MessageBox.Show("Please enter Card ID!");
                    }
                        
                }
                else
                {
                    MessageBox.Show("Please enter password!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Email!");
                tbEmail.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        


    }
}

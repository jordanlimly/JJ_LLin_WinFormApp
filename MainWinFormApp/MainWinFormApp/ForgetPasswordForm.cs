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
    public partial class frmforgetpw : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["JJLLinDBConnection"].ConnectionString;

        public frmforgetpw()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            int result = 0;
            int result2 = 0;
            int result3 = 0;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            String StrCheckQnTxt = "SELECT Email, SecurityQn1Ans, SecurityQn2Ans FROM UserAccount" +
                " WHERE Email=@email AND SecurityQn1Ans=@secQn1ans AND SecurityQn2Ans=@secQn2ans";

            String StrChangePwTxt = "UPDATE UserAccount SET Password=@Newpw WHERE Email=@email";

            SqlCommand checkcmd = new SqlCommand(StrCheckQnTxt, myConnect);
            checkcmd.Parameters.AddWithValue("@email", tbForgetEmail.Text);
            checkcmd.Parameters.AddWithValue("@secQn1ans", tbSecQn1Ans.Text);
            checkcmd.Parameters.AddWithValue("@secQn2ans", tbSecQn2Ans.Text);

            SqlCommand changecmd = new SqlCommand(StrChangePwTxt, myConnect);
            changecmd.Parameters.AddWithValue("@Newpw", tbNewpw.Text);
            changecmd.Parameters.AddWithValue("@email", tbForgetEmail.Text);

            if (tbSecQn1Ans.Text == String.Empty || tbSecQn2Ans.Text == String.Empty || tbNewpw.Text == String.Empty || tbCfmpw.Text == String.Empty)
            {
                MessageBox.Show("Please fill in all the required inputs!");
            }
            else
            {

                try
                {
                    myConnect.Open();

                    SqlDataReader reader = checkcmd.ExecuteReader();
                    if (reader.Read())
                    {
                        reader.Close();
                        if(tbNewpw.Text != tbCfmpw.Text) //chk if new pw and cfm pw
                        {
                            MessageBox.Show("Passwords entered do not match!");
                            result3 += 1;
                        }
                        else
                        {
                            result = changecmd.ExecuteNonQuery(); // execute change pw cmd
                            if (result > 0)
                            {
                                MessageBox.Show("Password Changed.");
                                btnCancel.PerformClick();
                                
                            }
                            else
                            {
                                MessageBox.Show("Password Change Failed.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Answers!");
                        result2 += 1;
                        
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message.ToString());
                }
                finally
                {
                    myConnect.Close();
                    
                    if (result2 > 0)
                    {
                        tbSecQn1Ans.Text = String.Empty;
                        tbSecQn2Ans.Text = String.Empty;
                    }
                    else if (result3 > 0)
                    {
                        tbNewpw.Text = String.Empty;
                        tbCfmpw.Text = String.Empty;
                    }
                    
                }
            }
        }

        private void btnGetSecQn_Click(object sender, EventArgs e)
        {
            bool blnfound = false;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            String StrRetrieveTxt = "SELECT SecurityQn1, SecurityQn2 FROM UserAccount ";
            StrRetrieveTxt += "WHERE Email=@email";

            SqlCommand retrievecmd = new SqlCommand(StrRetrieveTxt, myConnect);
            retrievecmd.Parameters.AddWithValue("@email", tbForgetEmail.Text);

            if (tbForgetEmail.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Email.");
            }
            else
            {
                myConnect.Open();
                SqlDataReader reader = retrievecmd.ExecuteReader();

                if (reader.Read())
                {
                    //retrieve sec qn from db put at tb
                    tbSecQn1.Text = reader["SecurityQn1"].ToString();
                    tbSecQn2.Text = reader["SecurityQn2"].ToString();

                    blnfound = true;
                }
                else
                {
                    MessageBox.Show("Account does not Exist!");
                }
                reader.Close();
                myConnect.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

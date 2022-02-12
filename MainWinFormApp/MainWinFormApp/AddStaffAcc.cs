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
    public partial class AddStaffAcc : Form
    {
        //retrieve connection information
        string strConnectionString =
            ConfigurationManager.ConnectionStrings["JJLLinDBConnection"].ConnectionString;

        public AddStaffAcc()
        {
            InitializeComponent();
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            int result = 0;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            String strAddAccText = "INSERT StaffAccounts (FirstName, LastName, Position, Password, StaffID)" +
                " VALUES (@NewFname, @NewLname, @NewPosition, @NewPassword, @NewStaffID)";

            int minIdNumber = 1000;
            int maxIdNumber = 9999;

            Random rndm = new Random();
            int Idnumbers = rndm.Next(minIdNumber, maxIdNumber);

            SqlCommand addAccount = new SqlCommand(strAddAccText, myConnect);
            addAccount.Parameters.AddWithValue("@NewFname", tbFname.Text);
            addAccount.Parameters.AddWithValue("@NewLname", tbLname.Text);
            addAccount.Parameters.AddWithValue("@NewPosition", char.ToUpper(tbPosition.Text[0]) + tbPosition.Text.Substring(1));
            addAccount.Parameters.AddWithValue("@NewPassword", tbPassword.Text);
            addAccount.Parameters.AddWithValue("@NewStaffID", (tbFname.Text.Substring(0,1)).ToUpper() + Idnumbers.ToString());
            

            if (tbFname.Text == String.Empty || tbPassword.Text == String.Empty || tbCfmPassword.Text == String.Empty
                || tbPosition.Text == String.Empty)
            {
                MessageBox.Show("Missing necessary inputs!");
            }
            else
            {
                if (tbPassword.Text.Length > 10)
                {
                    MessageBox.Show("Password must be within 10 characters!");
                }

                else
                {
                    if (tbPassword.Text == tbCfmPassword.Text)
                    {
                        myConnect.Open();

                        result = addAccount.ExecuteNonQuery();

                        if (result > 0)
                            MessageBox.Show("New staff account has been added successfully!");
                        else
                            MessageBox.Show("Could not add staff account!");

                        myConnect.Close();
                        Close();
                    }

                    else
                    {
                        MessageBox.Show("Passwords do not match!");

                        tbPassword.Text = String.Empty;
                        tbCfmPassword.Text = String.Empty;
                    }
                }
               
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

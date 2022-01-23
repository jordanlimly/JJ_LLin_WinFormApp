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
    public partial class AdminLoginForm : Form
    {

        private string strConnectionString =
            ConfigurationManager.ConnectionStrings["JJLLinDBConnection"].ConnectionString;

        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void lblAdminLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //create command
            String strCheckManagerLogin = "SELECT StaffID, Password, Position FROM StaffAccounts" +
                " WHERE StaffID = @staffid AND Password = @pw AND Position = @Pos";
            String strCheckStaffLogin = "SELECT StaffID, Password, Position FROM StaffAccounts" +
                " WHERE StaffID = @SID AND Password = @pass";

            SqlCommand checkManager = new SqlCommand(strCheckManagerLogin, myConnect);
            checkManager.Parameters.AddWithValue("@staffid", tbStaffID.Text);
            checkManager.Parameters.AddWithValue("@pw", tbPassword.Text);
            checkManager.Parameters.AddWithValue("@Pos", "Manager");

            SqlCommand checkStaff = new SqlCommand(strCheckStaffLogin, myConnect);
            checkStaff.Parameters.AddWithValue("@SID", tbStaffID.Text);
            checkStaff.Parameters.AddWithValue("@pass", tbPassword.Text);

            if (tbStaffID.Text == String.Empty || tbPassword.Text == String.Empty)
            {
                MessageBox.Show("Required inputs are missing!");
            }
            else
            {
                try
                {
                    myConnect.Open();

                    SqlDataReader manager = checkManager.ExecuteReader();
                    SqlDataReader staff = checkStaff.ExecuteReader();

                    if (manager.Read())
                    {
                        manager.Close();
                        staff.Close();

                        MessageBox.Show("Login Successful!");

                        AdminMainpage frm = new AdminMainpage();
                        frm.Show();

                        this.Hide();
                    }
                    else if (staff.Read())
                    {
                        staff.Close();
                        manager.Close();

                        MessageBox.Show("Login Successful!");

                        AdminMainpage frm = new AdminMainpage();
                        frm.Show();

                        this.Hide(); 
                    }
                    else
                    {
                        MessageBox.Show("Invalid Account! Login Failed.");
                    }

                }
                catch(SqlException ex)
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

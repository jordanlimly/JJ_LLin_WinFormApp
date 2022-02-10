using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;

namespace MainWinFormApp
{
    public partial class UserDashboard : Form
    {
        // retrieve connection information from App.Config
        private string strConnectionString = ConfigurationManager.ConnectionStrings["JJLLinDBConnection"].ConnectionString;



        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );


        public UserDashboard(string Email)
        {
            InitializeComponent();
            lblEmail.Text = Email;

            SqlConnection myConnect = new SqlConnection(strConnectionString);

            string strCommandText = "SELECT CurrentCredits, CurrentPoints, AccumulatedPoints, MembershipTier FROM UserAccount WHERE Email=@email";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@email", Email);

            myConnect.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                aPoint.Text = reader["AccumulatedPoints"].ToString();
                cCredit.Text = reader["CurrentCredits"].ToString();
                cPoint.Text = reader["CurrentPoints"].ToString();
                lblmTier.Text = reader["MembershipTier"].ToString();
                int creditValue = int.Parse(cCredit.Text);
                if (creditValue >= 50)
                {
                    lblcWarning.Visible = false;
                }

                int barValue = int.Parse(aPoint.Text);
                if (barValue > 1000)
                {
                    barValue = 1000;
                }
                progressBar2.Value = barValue;
                progressPanel.Width = progressBar2.Width * barValue / 1000;
                if (barValue < 500)
                {
                    progressPanel.BackColor = Color.Peru;
                    lblmTier.ForeColor = Color.Peru;
                }
                else if (barValue < 1000)
                {
                    progressPanel.BackColor = Color.FromArgb(168, 169, 173);
                    lblmTier.ForeColor = Color.FromArgb(168, 169, 173);
                }
                else
                {
                    progressPanel.BackColor = Color.FromArgb(255, 215, 0);
                    lblmTier.ForeColor = Color.FromArgb(255, 215, 0);
                }
            }

            reader.Close();
            myConnect.Close();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }
        private void UserDashboard_Load(object sender, EventArgs e)
        {
            //lblEmail.Text = CustLoginForm.UserEmail;
            loadchart();
            pnlAccumPoints.Visible = true;
            pnlCurrCreds.Visible = true;
            pnlCurrPoints.Visible = true;
            //pnlMemTier.Visible = true;
            panel2.Visible = true;
            panel1.Visible = true;
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            loadchart();
        }

        private void Dashboard()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "SELECT Name FROM UserAccount ";


            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            myConnect.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblEmail.Text = reader["Name"].ToString();
            }
            else
                MessageBox.Show("Invalid Access");

            reader.Close();
            myConnect.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            pnlAccumPoints.Visible = true;
            pnlCurrCreds.Visible = true;
            pnlCurrPoints.Visible = true;
            //pnlMemTier.Visible = true;
            panelGMU.Visible = false;
            panel2.Visible = true;
            panel1.Visible = true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
            CustUpdateForm frm = new CustUpdateForm(lblEmail.Text);
            frm.ShowDialog();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLogout.Height;
            pnlNav.Top = btnLogout.Top;
            pnlNav.Left = btnLogout.Left;
            btnLogout.BackColor = Color.FromArgb(46, 51, 73);
            LogoutForm frm = new LogoutForm();
            frm.ShowDialog();
        }

        private void btnGameMachineUsage_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnGameMachineUsage.Height;
            pnlNav.Top = btnGameMachineUsage.Top;
            pnlNav.Left = btnGameMachineUsage.Left;
            btnGameMachineUsage.BackColor = Color.FromArgb(46, 51, 73);
            panelGMU.Visible = true;
            panel1.Visible = true;
            pnlAccumPoints.Visible = false;
            pnlCurrCreds.Visible = false;
            panel2.Visible = false;
            pnlCurrPoints.Visible = false;
            //pnlMemTier.Visible = false;
        }

        private void btnGameMachineUsage_Leave(object sender, EventArgs e)
        {
            btnGameMachineUsage.BackColor = Color.FromArgb(0, 0, 0);
        }

        private Color getColor(int r, int g, int b, int transparent = 255)
        {
            return System.Drawing.Color.FromArgb(transparent, r, g, b);
        }

        private void loadchart()
        {

            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String queryTxt = "SELECT b.GameMachineName, COUNT(a.GameMachineID) Usage FROM GameRecord a INNER JOIN GameMachine b on(a.GameMachineID = b.GameMachineID) INNER JOIN UserAccount u on(a.RFID_ID = u.RFID_ID) WHERE u.Email = '" + lblEmail.Text + "'  group by b.GameMachineName; ";


            DataTable dt = GetData(queryTxt);

            string[] x = (from p in dt.AsEnumerable() orderby p.Field<string>("GameMachineName") ascending select p.Field<string>("GameMachineName")).ToArray();
            int[] y = (from p in dt.AsEnumerable() orderby p.Field<string>("GameMachineName") ascending select p.Field<int>("Usage")).ToArray();

            chart1.Series[0].ChartType = SeriesChartType.Column;
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].Points.DataBindXY(x, y);
        }

        private static DataTable GetData(string query)
        {
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\temp\JJLLinDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }
    }

}

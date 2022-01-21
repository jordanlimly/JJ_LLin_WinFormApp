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


        public UserDashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }
        private void UserDashboard_Load(object sender, EventArgs e)
        {
            //initChartProperties();
            tbUsername.Text = CustLoginForm.UserEmail;
            loadchart();
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
                tbUsername.Text = reader["Name"].ToString();
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
            pnlMemTier.Visible = true;
            panelGMU.Visible = false;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
            CustUpdateForm frm = new CustUpdateForm();
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
            this.Close();
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
            pnlAccumPoints.Visible = false;
            pnlCurrCreds.Visible = false;
            pnlMemTier.Visible = false;
        }

        private void btnGameMachineUsage_Leave(object sender, EventArgs e)
        {
            btnGameMachineUsage.BackColor = Color.FromArgb(0, 0, 0);


        }

        private Color getColor(int r, int g, int b, int transparent = 255)
        {
            return System.Drawing.Color.FromArgb(transparent, r, g, b);
        }

        //private DateTime getDateTime(int year, int month, int day, int hour, int min, int sec, int millesecs = 0)
        //{
        //    DateTime dt = new DateTime(year, month, day, hour, min, sec, millesecs);
        //    Console.WriteLine(dt.ToString("MM/dd/yyyy hh:mm:ss.fff"));
        //    return dt;
        //}

        //private void setXAxisDisplayRange(Chart cht, DateTime dtStart, DateTime dtEnd)
        //{
        //    DateTime minDate = dtStart.AddSeconds(-1);
        //    DateTime maxDate = dtEnd;

        //    Console.WriteLine("Settings AxisX.Minimum =" + minDate.ToOADate());
        //    Console.WriteLine("Settings AxisX.Maximum =" + maxDate.ToOADate());

        //    cht.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
        //    cht.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();
        //    cht.Series[0].IsXValueIndexed = false;
        //}

        //private void initChartProperties()
        //{
        //    chart1.BackColor = getColor(243, 223, 193);
        //    chart1.BackGradientStyle = GradientStyle.TopBottom;
        //    chart1.BorderlineColor = getColor(181, 64, 1);
        //    chart1.BorderlineDashStyle = ChartDashStyle.Solid;
        //    chart1.BorderlineWidth = 2;

        //    //Title
        //    Title title1 = new Title();
        //    title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
        //    title1.Text = "Arcade Game Machine Usage";
        //    chart1.Titles.Add(title1);

        //    Font labelFont = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);

        //    //Graph Legend
        //    Legend legend1 = chart1.Legends[0];
        //    legend1.BackColor = Color.Transparent;
        //    legend1.Enabled = true;
        //    legend1.Font = labelFont;

        //    //Chart Area is the whole X-Y axis area
        //    Color colorGridLines = getColor(64, 64, 64, 64);
        //    ChartArea chartArea1 = chart1.ChartAreas[0];
        //    chartArea1.BackColor = Color.OldLace;
        //    chartArea1.BackGradientStyle = GradientStyle.TopBottom;
        //    chartArea1.BorderColor = colorGridLines;
        //    chartArea1.BorderDashStyle = ChartDashStyle.Solid;
        //    chartArea1.ShadowColor = Color.Transparent;

        //    //X-Axis Settings
        //    chartArea1.AxisX.LabelStyle.Font = labelFont;
        //    chartArea1.AxisX.LineColor = colorGridLines;
        //    chartArea1.AxisX.MajorGrid.LineColor = colorGridLines;

        //    chartArea1.AxisX.IntervalType = DateTimeIntervalType.Minutes;
        //    chartArea1.AxisX.Interval = 1;
        //    DateTime minDate = getDateTime(2022, 01, 01, 15, 0, 0);
        //    DateTime maxDate = getDateTime(2022, 12, 31, 15, 0, 0);
        //    setXAxisDisplayRange(chart1, minDate, maxDate);

        //    chartArea1.AxisX.LabelStyle.Format = "MMM dd HH:mm";
        //    //cahrtArea1.AxisX.LabelStyle.Format = "MMM dd";
        //    //chartArea1.AxisX.LabelStyle.Format = "HH:mm";
        //    //chartArea1.AxisX.LabelStyle.Format = "yyy MMM dd HH:mm";
        //    //chartArea1.AxisX.LabelStyle.Format = "MMM dd HH:mm:ss";

        //    //Y-Axis Settings
        //    chartArea1.AxisY.LabelStyle.Font = labelFont;
        //    chartArea1.AxisY.LineColor = colorGridLines;
        //    chartArea1.AxisY.MajorGrid.LineColor = colorGridLines;
        //    //chartArea1.AxisY.Interval = 10;
        //    chartArea1.AxisY.IsStartedFromZero = true;

        //    //Line Graph Data Points
        //    Series series1 = chart1.Series[0];
        //    series1.Name = "Times Used"; //This will show up in the legend text
        //    Color lineColor = getColor(26, 59, 105, 180);
        //    series1.BorderColor = lineColor;
        //    series1.ChartType = SeriesChartType.Bar;
        //    series1.XValueType = ChartValueType.DateTime;
        //    series1.YValueType = ChartValueType.Int32;
        //    series1.MarkerStyle = MarkerStyle.Circle;
        //    series1.MarkerSize = 6;
        //    series1.MarkerBorderColor = lineColor;
        //    series1.MarkerColor = lineColor;
        //    //Hover cursor on point to show
        //    series1.ToolTip = "Timestamp: #VALX{d MMM yyyy H:mm:ss}, Value : #VAL";

        //} //End of initChartProperties

        //private void loadDBtoChart()
        //{
        //    SqlConnection myConnect = new SqlConnection(strConnectionString);

        //    string strCommandText = "SELECT COUNT(*) FROM GameRecord INNER JOIN GameMachine ON GameRecord.GameMachineID = GameMachine.GameMachineName WHERE RFID_ID = ''";

        //    try
        //    {
        //        SqlDataAdapter adapter = new SqlDataAdapter(strCommandText, myConnect);
        //        SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);

        //        DataSet ds = new DataSet();
        //        adapter.Fill(ds);
        //        Console.WriteLine("Dataset Rows = " + ds.Tables[0].Rows.Count);
        //        chart1.DataSource = ds;

        //        //Chart X-Axis take from this Database field
        //        chart1.Series[0].XValueMember = "GameMachineID";

        //        //Chart Y-Axis take from this Database field
        //        //chart1.Series[0].YValueMembers = "";

        //        //clears and reload series data if there are existing data on chart
        //        chart1.DataBind();
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show("Error:" + ex.Message.ToString());
        //    }
        //    finally
        //    {
        //        myConnect.Close();
        //    }
        //} // End of loadDBtoChart()


        //private void loadchart()
        //{
        //    string RFID_ID = CustLoginForm.UserRFID;
        //    SqlConnection myConnect = new SqlConnection(strConnectionString);
        //    string query = "SELECT GameMachineName, COUNT(*) usagecount FROM GameRecord INNER JOIN GameMachine ON GameRecord.GameMachineID = GameMachine.GameMachineName WHERE RFID_ID = @username";

        //    SqlCommand cmd = new SqlCommand(query, myConnect);
        //    cmd.Parameters.AddWithValue("@username", RFID_ID);

        //    DataTable dt = GetData(query);

        //    string[] x = (from p in dt.AsEnumerable() orderby p.Field<string>("GameMachineName") ascending select p.Field<string>("GameMachineName")).ToArray();
        //    int[] y = (from p in dt.AsEnumerable() orderby p.Field<string>("GameMachineName") ascending select p.Field<int>("usagecount")).ToArray();

        //    chart1.Series[0].ChartType = SeriesChartType.Bar;
        //    chart1.Series[0].IsValueShownAsLabel = true;
        //    chart1.Series[0].Points.DataBindXY(x, y);
        //}

        private void loadchart()
        {

            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String queryTxt = "SELECT b.GameMachineName, COUNT(a.GameMachineID) Usage FROM GameRecord a INNER JOIN GameMachine b on(a.GameMachineID = b.GameMachineID) INNER JOIN UserAccount u on(a.RFID_ID = u.RFID_ID) WHERE u.Email = '" + tbUsername.Text + "'  group by b.GameMachineName; ";


            //SqlCommand cmd = new SqlCommand(queryTxt, myConnect);
            //cmd.Parameters.AddWithValue("@Newemil", tbUsername.Text);

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

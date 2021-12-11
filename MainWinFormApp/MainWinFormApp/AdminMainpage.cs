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

using System.Windows.Forms.DataVisualization.Charting;

namespace MainWinFormApp
{
    public partial class AdminMainpage : Form
    {
        //===Crowd Level codes===
        string strConnectionString =
            ConfigurationManager.ConnectionStrings["JJLLinDBConnection"].ConnectionString;

        DataComms dataComms;

        public delegate void myprocessDataDelegate(String strData);

        private void addCrowdRecord(DateTime curDateTime, int enterExit)
        {
            int result = 0;
            //create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //create command
            DateTime curDate = DateTime.Now.Date;
            String strCommandText =
                "INSERT CrowdLevelTable (DateOnly, DateTime, EnterExit) " +
                " VALUES (@curDate, @NewDateTime, @NewEnterExit)";

            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@curDate", curDate);
            updateCmd.Parameters.AddWithValue("@NewDateTime", curDateTime);
            updateCmd.Parameters.AddWithValue("@NewEnterExit", enterExit);

            // open connection
            myConnect.Open();

            // execute command
            result = updateCmd.ExecuteNonQuery();

            //close connection
            myConnect.Close();
        }


        //utility method, you should not need to edit this
        private string extractStringValue(string strData, string ID)
        {
            string result = strData.Substring(strData.IndexOf(ID) + ID.Length);
            return result;
        }

        //utility method, you should not need to edit this
        private float extractFloatValue(string strData, string ID)
        {
            return (float.Parse(extractStringValue(strData, ID)));
        }


        //create your own data handler for your project needs
        private void handledDistanceSensorData(string strData, string strTime, string ID)
        {
            string strDistanceValue = extractStringValue(strData, ID);

            if (strDistanceValue == "In")
            {
                string strMessage = "=== Entry Captured at " + strTime.Replace("T", " ") + " ===";
                lbDataComms.Items.Insert(0, strMessage);
                int current = Convert.ToInt32(lbCurCrowdCount.Text);
                lbCurCrowdCount.Text = Convert.ToString(current + 1);

                //update database
                addCrowdRecord(Convert.ToDateTime(strTime), 1);
                loadDBtoChart();
            }
            else if (strDistanceValue == "Out")
            {
                if (Convert.ToInt32(lbCurCrowdCount.Text) != 0)
                {
                    string strMessage = "=== Exit Captured at " + strTime.Replace("T", " ") + " ===";
                    lbDataComms.Items.Insert(0, strMessage);
                    int current = Convert.ToInt32(lbCurCrowdCount.Text);
                    lbCurCrowdCount.Text = Convert.ToString(current - 1);

                    //update database
                    addCrowdRecord(Convert.ToDateTime(strTime), -1);
                }
            }

            //float fLightValue = extractFloatValue(strData, ID);
            //string status = "";
            //if (fLightValue <= 500)
            //    status = "Dark";
            //else
            //    status = "Bright";
            //tbRoomStatus.Text = status;

            //update database
            //addCrowdRecord(strTime, status);
        }

        private void handledSensorTriggeredData(string strData, string strTime, string ID)
        {
            string strSensorTriggered = extractStringValue(strData, ID);

            if (strSensorTriggered == "Sensor1")
            {
                string strMessage = "Distance Sensor 1 was triggered";              
                lbDataComms.Items.Insert(0, strMessage);
                
            }
            else if (strSensorTriggered == "Sensor2")
            {
                string strMessage = "Distance Sensor 2 was triggered";     
                lbDataComms.Items.Insert(0, strMessage);
                
            }
        }

        private void deductMaintenanceCount(string machineID)
        {
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Step 2: Create command
            String strCommandText =
                "UPDATE GameMachine SET UsageCount = (UsageCount - 1) WHERE GameMachineID = @machineID";

            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@machineID", machineID);

            //Step 3: Open Connection myConnect.Open();
            myConnect.Open();

            //Step 4: ExecuteCommand
            int result = updateCmd.ExecuteNonQuery();

            //Step 5: Close connection
            myConnect.Close();
        }


        private void addGameRecord(string machineID, DateTime curDT, string detectedRFID)
        {
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            
            //Step 2: Create command
            String strCommandText =
                "INSERT INTO GameRecord (GameMachineID, DateTime, RFID_ID) VALUES (@machineID, @curDT, @detectedRFID)";

            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@machineID", machineID);
            updateCmd.Parameters.AddWithValue("@curDT", curDT);
            updateCmd.Parameters.AddWithValue("@detectedRFID", detectedRFID);
            
            //Step 3: Open Connection myConnect.Open();
            myConnect.Open();

            //Step 4: ExecuteCommand
            int result = updateCmd.ExecuteNonQuery();

            //Step 5: Close connection
            myConnect.Close();
        }

        private int generateGamePoints()
        {
            Random rnd = new Random();
            // Since we are not coding the game logic for this project, we will randomly generated a number
            // and assume it is the no. of points earned in a game round
            int pointsEarnedCurRound = rnd.Next(5, 100);
            Console.WriteLine("Player earned " + Convert.ToString(pointsEarnedCurRound) + " points");
            return pointsEarnedCurRound;            
            
        }

        private void addUserPoints(int pointsEarned, string detectedRFID)
        {
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Step 2: Create command
            String strCommandText =
                "UPDATE UserAccount SET CurrentPoints = (CurrentPoints + @pointsEarned), AccumulatedPoints = (AccumulatedPoints + @pointsEarned) WHERE RFID_ID = @rfid_id";

            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@pointsEarned", pointsEarned);
            updateCmd.Parameters.AddWithValue("@rfid_id", detectedRFID);

            //Step 3: Open Connection myConnect.Open();
            myConnect.Open();

            //Step 4: ExecuteCommand
            int result = updateCmd.ExecuteNonQuery();

            //Step 5: Close connection
            myConnect.Close();
        }

        private void handleGameMode(string strData, string ID)
        {
            string detectedRFID = extractStringValue(strData, ID);

            //update DB
            deductMaintenanceCount("G001");
            DateTime curDT = DateTime.Now;
            addGameRecord("G001", curDT, detectedRFID);
            addUserPoints(generateGamePoints(), detectedRFID);
      
        }

        //create your own data handler for your project needs
        //private void handleButtonData(string strData, string strTime, string ID)
        //{
        //    string strbuttonValue = extractStringValue(strData, ID);

        //    //update GUI component in any tabs
        //    tbButtonValue.Text = strbuttonValue;
        //    tbDoorBell.Text = strbuttonValue;

        //    //do your own update of database
        //}


        //You need to edit here to suite your project needs
        private void extractSensorData(string strData, string strTime)
        {
            //Any type of data may be send over by hardware
            //so you need t always check what data is received
            //before extracting the information

            //check whether Light value is send
            if (strData.IndexOf("SENSORTRIGGERED=") != -1) //check sensor triggered status
                handledSensorTriggeredData(strData, strTime, "SENSORTRIGGERED=");    
            if (strData.IndexOf("DIRECTION=") != -1)
                handledDistanceSensorData(strData, strTime, "DIRECTION=");
            if (strData.IndexOf("RFIDGAMESTART=") != -1) //check button status
                handleGameMode(strData, "RFIDGAMESTART=");
        }

        private void handleSensorData(String strData)
        {
            string dt = DateTime.Now.ToString("s"); //get current time
            extractSensorData(strData, dt); // get sensor values out

            // update raw data received to listbox
            //string strMessage = dt + ":" + strData;
            //lbDataComms.Items.Insert(0, strMessage);
        }


        //This method is automatically called when data is received
        public void processDataReceive(String strData)
        {
            myprocessDataDelegate d = new myprocessDataDelegate(handleSensorData);
            lbDataComms.Invoke(d, new object[] { strData });
        }

        //This method is automatically called when data is received
        public void commsDataReceive(string dataReceived)
        {
            processDataReceive(dataReceived);
        }

        //This method is automatically called when there is error
        public void commsSendError(string errMsg)
        {
            MessageBox.Show(errMsg);
            processDataReceive(errMsg);
        }

        //This method must be called right at the start for data communications
        private void InitComms()
        {
            dataComms = new DataComms();
            dataComms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsDataReceive);
            dataComms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);
        }

        // ===End of Crowd lvl codes===


        public AdminMainpage()
        {
            InitializeComponent();
            CurCrowdPanel.BackColor = Color.FromArgb(200, Color.White);
        }

        private void button1_Click(object sender, EventArgs e) // Current crowd btn click
        {
            tabControl1.SelectTab(0);
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            loadDBtoChart();
            
            
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPopularity_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            panel3.Visible = true;
            panel2.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;

        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            panel4.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;

        }

        private void AdminMainpage_Load(object sender, EventArgs e)
        {
            InitComms();
            initChartProperties();
            loadDBtoChart();
        }

        private void lbDataComms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

        }

        private void btnAddMaintenanceRecord_Click(object sender, EventArgs e)
        {
            frmMaintenance frm = new frmMaintenance();
            frm.ShowDialog();
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrowdLvl_Leave(object sender, EventArgs e)
        {
            btnCrowdLvl.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void btnPopularity_Leave(object sender, EventArgs e)
        {
            btnPopularity.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void btnMaintenance_Leave(object sender, EventArgs e)
        {
            btnMaintenance.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void btnLogout_Leave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(0, 0, 0);
        }

        private Color getColor(int r, int g, int b, int transparent = 255)
        {
            return System.Drawing.Color.FromArgb(transparent, r, g, b);
        }

        private DateTime getDateTime(int year, int month, int day, int hour, int min, int sec, int millesecs = 0)
        {
            DateTime dt = new DateTime(year, month, day, hour, min, sec, millesecs);
            Console.WriteLine("MM/dd/yyyy hh:mm:ss.fff");
            return dt;
        }

        private void setXAxisDisplayRange(Chart cht, DateTime dtStart, DateTime dtEnd)
        {
            DateTime minDate = dtStart.AddSeconds(-1);
            DateTime maxDate = dtEnd;

            Console.WriteLine("Setting AxisX.Minimum =" + minDate.ToOADate());
            Console.WriteLine("Setting AxisX.Maximum =" + maxDate.ToOADate());

            cht.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
            cht.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();
            cht.Series[0].IsXValueIndexed = false; //This must be false for AxisX max and min to work
        } //End of setXAxisDisplayRange()

        private void initChartProperties()
        {
            TotalCrowdCht.BackColor = getColor(243, 223, 193);
            TotalCrowdCht.BackGradientStyle = GradientStyle.TopBottom;
            TotalCrowdCht.BorderlineColor = getColor(181, 64, 1);
            TotalCrowdCht.BorderlineDashStyle = ChartDashStyle.Solid;
            TotalCrowdCht.BorderlineWidth = 2;

            //Title
            Title title1 = new Title();
            title1.Font = new System.Drawing.Font("Trebuchet MS", 7.25F, System.Drawing.FontStyle.Bold);
            title1.Text = "Daily Number of Visitors for the past week";
            TotalCrowdCht.Titles.Add(title1);

            Font labelFont = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);

            //Graph legend
            //Legend legend1 = chart1.Legends[0];
            //legend1.BackColor = Color.Transparent;
            //legend1.Enabled = true;
            //legend1.Font = labelFont;

            //Chart area is the whole X-Y axis area
            Color colorGridLines = getColor(64, 64, 64, 64);
            ChartArea chartArea1 = TotalCrowdCht.ChartAreas[0];
            chartArea1.BackColor = Color.OldLace;
            chartArea1.BackGradientStyle = GradientStyle.TopBottom;
            chartArea1.BorderColor = colorGridLines;
            chartArea1.BorderDashStyle = ChartDashStyle.Solid;
            chartArea1.ShadowColor = Color.Transparent;

            //X-Axis settings
            chartArea1.AxisX.LabelStyle.Font = labelFont;
            chartArea1.AxisX.LineColor = colorGridLines;
            chartArea1.AxisX.MajorGrid.LineColor = colorGridLines;

            chartArea1.AxisX.IntervalType = DateTimeIntervalType.Days;
            chartArea1.AxisX.Interval = 1;
            //DateTime minDate = getDateTime(2021, 12, 5, 0, 0, 0);
            DateTime maxDate = DateTime.Now;
            //DateTime maxDate = getDateTime(2021, 12, 12, 0, 0, 0);
            DateTime minDate = maxDate.AddDays(-7);


            setXAxisDisplayRange(TotalCrowdCht, minDate, maxDate);

            //chartArea1.AxisX.LabelStyle.Format = "hh:ss";
            // You can change to the below formats as well depending on your needs. 
            chartArea1.AxisX.LabelStyle.Format = "MMM dd";
            //chartAreal. AxisX.Label5tyle.Format="HH:mm"
            //chartAreal.AxisX.LabelStyle.Format "yyyy MMM dd HH:mm";
            //chartAreal.AxisX.LabelStyle.Format="MMM dd HH:mm:ss";

            // Y-Axis Settings
            chartArea1.AxisY.LabelStyle.Font = labelFont;
            chartArea1.AxisY.LineColor = colorGridLines;
            chartArea1.AxisY.MajorGrid.LineColor = colorGridLines;
            chartArea1.AxisY.Interval = 2;
            chartArea1.AxisY.IsStartedFromZero = true;

            // Line Graph Data points

            Series series1 = TotalCrowdCht.Series[0];
            series1.Name = "Temp"; // This will show up in the legend text
            Color lineColor = getColor(26, 59, 185, 180);
            series1.BorderColor = lineColor; series1.ChartType = SeriesChartType.Column;
            series1.XValueType = ChartValueType.DateTime;
            series1.YValueType = ChartValueType.Double;
            //series1.MarkerStyle = MarkerStyle.Circle;
            //series1.MarkerSize = 6;
            //series1.MarkerBorderColor = lineColor;
            //series1.MarkerColor = lineColor;
            //Hover cursor on point to show
            //series1.ToolTip = "Timestamp: #VALX{d MMM yyyy H:mm:ss}, Value : #VAL";


        }//End of initChartProperties()

        private void loadDBtoChart()
        {
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Step 2: Create SQL command
            //string curDate = DateTime.Now.ToString("dd/MM/yyyy");
            string now = DateTime.Now.Date.ToString();
            string startdate = (DateTime.Now.Date.AddDays(-6)).ToString();
            //String strCommandText = "Select * from CrowdLevelTable where CONVERT(VARCHAR, DateTime , 103) = '5/12/2021'";
            //String strCommandText = "Select * from CrowdLevelTable WHERE Year(DateTime) = " + curYear + "AND Month(DateTime) = " + curMonth +
            //    "AND Day(DateTime) = " + curDay + "AND Hour(DateTime) = " + curHour + "AND Minute(DateTime) = " + curMin;
            String strCommandText = "Select DateOnly, sum(EnterExit) sumCol from CrowdLevelTable WHERE EnterExit = 1 group by DateOnly";


            try
            {
                //Step 3. Create a Data Adapter to retrieve data from Table in Database
                SqlDataAdapter adapter = new SqlDataAdapter(strCommandText, myConnect);
                // create SELECT, DELETE, INSERT, UPDATE commands for data adapter
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);

                // STEP 4: Access data: Pill the Dataset using Data Adapter Fill method
                // Note: We do NOT need to open database connection
                // as data adapter does it internally
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                Console.WriteLine("Dataset Rows = " + ds.Tables[0].Rows.Count);
                TotalCrowdCht.DataSource = ds;

                // Chart X - Axis take from this Database field
                TotalCrowdCht.Series[0].XValueMember = "DateOnly";

                //Chart Y-Axis take from this Database field.
                TotalCrowdCht.Series[0].YValueMembers = "sumCol";

                //clears and reload series data if there are existing data on chart
                TotalCrowdCht.DataBind();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message.ToString());
            }
            finally
            {
                //Step 5: Close connection
                myConnect.Close();
            }
        }
    }
}

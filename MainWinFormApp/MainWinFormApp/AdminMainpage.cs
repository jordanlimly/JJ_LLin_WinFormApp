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
        int PW;
        bool hiddenMinPanel;
        bool sensor1triggered = false;
        bool sensor2triggered = false;
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
                loadDBtoTotalCrowdCht();
                loadDBtoHourlyCht();
                int curYear = Convert.ToInt32(DateTime.Now.Year);
                int curMonth = Convert.ToInt32(DateTime.Now.Month);
                int curDay = Convert.ToInt32(DateTime.Now.Day);
                int curHour = Convert.ToInt32(DateTime.Now.Hour);
                int curMin = Convert.ToInt32(DateTime.Now.Minute);
                DateTime maxDate = getDateTime(curYear, curMonth, curDay, curHour, (curMin + 1), 0);
                DateTime minDate = maxDate.AddMinutes(-2);
                setXAxisDisplayRange(MinCrowdCht, minDate, maxDate);
                loadDBtoMinuteCht();
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
                    loadDBtoHourlyCht();
                    int curYear = Convert.ToInt32(DateTime.Now.Year);
                    int curMonth = Convert.ToInt32(DateTime.Now.Month);
                    int curDay = Convert.ToInt32(DateTime.Now.Day);
                    int curHour = Convert.ToInt32(DateTime.Now.Hour);
                    int curMin = Convert.ToInt32(DateTime.Now.Minute);
                    DateTime maxDate = getDateTime(curYear, curMonth, curDay, curHour, (curMin + 1), 0);
                    DateTime minDate = maxDate.AddMinutes(-2);
                    setXAxisDisplayRange(MinCrowdCht, minDate, maxDate);
                    loadDBtoMinuteCht();
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
                if (sensor2triggered == true)
                {
                    // man walking out
                    exitS1.Visible = true;
                    timerMan.Stop();
                    timerMan.Start();
                }
                else
                {
                    //man walking in
                    enterS1.Visible = true;
                    timerMan.Stop();
                    timerMan.Start();
                }
                string strMessage = "Distance Sensor 1 was triggered";              
                lbDataComms.Items.Insert(0, strMessage);
                sensor1triggered = true;
            }
            else if (strSensorTriggered == "Sensor2")
            {
                if (sensor1triggered == true)
                {
                    // man walking in
                    enterS2.Visible = true;
                    timerMan.Stop();
                    timerMan.Start();
                }
                else
                {
                    //man walking out
                    exitS2.Visible = true;
                    timerMan.Stop();
                    timerMan.Start();
                }
                string strMessage = "Distance Sensor 2 was triggered";     
                lbDataComms.Items.Insert(0, strMessage);
                sensor2triggered = true;
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

        private void addLBItem(string detectedRFID, int pointsEarned, string machineID)
        {
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Step 2: Create command
            String strCommandText =
                "SELECT GameMachineName FROM GameMachine WHERE GameMachineID = '" + machineID + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(strCommandText, myConnect);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
           
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            string machineName = Convert.ToString(ds.Tables[0].Rows[0]["GameMachineName"]);

            //Step 2: Create command
            String strCommandText2 =
                "SELECT Name FROM UserAccount WHERE RFID_ID = '" + detectedRFID + "'";

            SqlDataAdapter adapter2 = new SqlDataAdapter(strCommandText2, myConnect);
            SqlCommandBuilder cmdBuilder2 = new SqlCommandBuilder(adapter2);

            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2);
            string custName = Convert.ToString(ds2.Tables[0].Rows[0]["Name"]);

            string strMsg = custName + " (RFID: " + detectedRFID + ") earned " + Convert.ToString(pointsEarned) + " points from " + machineName + " (" + machineID + ")";
            lbCustomerActivity.Items.Insert(0, strMsg);
            lbCustomerActivity.Items.Insert(0, "---------------------------------------------------------------------------------------------------------------------------");
        }

        private void handleGameMode(string strData, string ID)
        {
            string detectedRFID = extractStringValue(strData, ID);

            //update DB
            deductMaintenanceCount("G001");
            DateTime curDT = DateTime.Now;
            addGameRecord("G001", curDT, detectedRFID);
            int pointsEarned = generateGamePoints();
            addUserPoints(pointsEarned, detectedRFID);
            addLBItem(detectedRFID, pointsEarned, "G001");
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
            {
                handledSensorTriggeredData(strData, strTime, "SENSORTRIGGERED=");
                if (sensor1triggered == true && sensor2triggered == true)
                {
                    sensor1triggered = false;
                    sensor2triggered = false;
                }
            } 
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
            panel6.BackColor = Color.FromArgb(200, Color.White);
            PW = panel7.Width;
            hiddenMinPanel = false;
        }

        private void button1_Click(object sender, EventArgs e) // Current crowd btn click
        {
            tabControl1.SelectTab(0);
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel8.Visible = false;
            loadDBtoTotalCrowdCht();
            loadDBtoHourlyCht();
            int curYear = Convert.ToInt32(DateTime.Now.Year);
            int curMonth = Convert.ToInt32(DateTime.Now.Month);
            int curDay = Convert.ToInt32(DateTime.Now.Day);
            int curHour = Convert.ToInt32(DateTime.Now.Hour);
            int curMin = Convert.ToInt32(DateTime.Now.Minute);
            DateTime maxDate = getDateTime(curYear, curMonth, curDay, curHour, (curMin + 1), 0);
            DateTime minDate = maxDate.AddMinutes(-2);
            setXAxisDisplayRange(MinCrowdCht, minDate, maxDate);
            loadDBtoMinuteCht();

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
            panel8.Visible = false;
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            panel4.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
            panel8.Visible = false;

        }

        private void btnUserActivity_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
            panel8.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void AdminMainpage_Load(object sender, EventArgs e)
        {
            InitComms();
            initTotalCrowdChtProperties();
            loadDBtoTotalCrowdCht();
            initHourlyCrowdChtProperties();
            loadDBtoHourlyCht();
            initMinCrowdChtProperties();
            loadDBtoMinuteCht();
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed; ;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                lblDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
                lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            }));

        }


        private void lbDataComms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AdminLogoutForm frm = new AdminLogoutForm(); //redirect to logout window
            frm.ShowDialog(); 

            panel5.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel8.Visible = false;
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

        private void initTotalCrowdChtProperties()
        {
            TotalCrowdCht.BackColor = getColor(243, 223, 193);
            TotalCrowdCht.BackGradientStyle = GradientStyle.TopBottom;
            TotalCrowdCht.BorderlineColor = getColor(181, 64, 1);
            TotalCrowdCht.BorderlineDashStyle = ChartDashStyle.Solid;
            TotalCrowdCht.BorderlineWidth = 2;

            //Title
            Title title1 = new Title();
            title1.Font = new System.Drawing.Font("Trebuchet MS", 8.50F, System.Drawing.FontStyle.Bold);
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
            chartArea1.AxisY.Interval = 5;
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


        }//End of initTotalCrowdChtProperties()

        private void loadDBtoTotalCrowdCht()
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

                // get value for total crowd counter
                string todaydate = DateTime.Now.Date.ToString("dd/MM/yyyy");
                String strCommandText2 = "Select Convert(varchar, [DateOnly], 103), sum(EnterExit) sumCol from CrowdLevelTable WHERE EnterExit = 1 AND Convert(varchar, [DateTime], 103) = '" + todaydate + "' group by DateOnly";
                SqlDataAdapter adapter2 = new SqlDataAdapter(strCommandText2, myConnect);
                ////// create SELECT, DELETE, INSERT, UPDATE commands for data adapter
                SqlCommandBuilder cmdBuilder2 = new SqlCommandBuilder(adapter2);

                ////// STEP 4: Access data: Pill the Dataset using Data Adapter Fill method
                ////// Note: We do NOT need to open database connection
                ////// as data adapter does it internally
                DataSet ds2 = new DataSet();
                adapter2.Fill(ds2);

                if (ds2.Tables[0].Rows.Count == 1)
                {
                    int extractedCounterValue = Convert.ToInt32(ds2.Tables[0].Rows[0]["sumCol"]);
                    lbTotalCrowdCount.Text = Convert.ToString(extractedCounterValue);
                }
                else
                {
                    int extractedCounterValue = 0;
                    lbTotalCrowdCount.Text = Convert.ToString(extractedCounterValue);
                }


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

        private void initMinCrowdChtProperties()
        {
            MinCrowdCht.BackColor = getColor(243, 223, 193);
            MinCrowdCht.BackGradientStyle = GradientStyle.TopBottom;
            MinCrowdCht.BorderlineColor = getColor(181, 64, 1);
            MinCrowdCht.BorderlineDashStyle = ChartDashStyle.Solid;
            MinCrowdCht.BorderlineWidth = 2;

            //Title
            Title title1 = new Title();
            title1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            title1.Text = "Current 2 Minutes Crowd";
            MinCrowdCht.Titles.Add(title1);

            Font labelFont = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);

            //Graph legend
            //Legend legend1 = chart1.Legends[0];
            //legend1.BackColor = Color.Transparent;
            //legend1.Enabled = true;
            //legend1.Font = labelFont;

            //Chart area is the whole X-Y axis area
            Color colorGridLines = getColor(64, 64, 64, 64);
            ChartArea chartArea1 = MinCrowdCht.ChartAreas[0];
            chartArea1.BackColor = Color.OldLace;
            chartArea1.BackGradientStyle = GradientStyle.TopBottom;
            chartArea1.BorderColor = colorGridLines;
            chartArea1.BorderDashStyle = ChartDashStyle.Solid;
            chartArea1.ShadowColor = Color.Transparent;

            //X-Axis settings
            chartArea1.AxisX.LabelStyle.Font = labelFont;
            chartArea1.AxisX.LineColor = colorGridLines;
            chartArea1.AxisX.MajorGrid.LineColor = colorGridLines;

            chartArea1.AxisX.IntervalType = DateTimeIntervalType.Minutes;
            chartArea1.AxisX.Interval = 1;
            //DateTime minDate = getDateTime(2021, 12, 5, 0, 0, 0);
            //DateTime maxDate = getDateTime(2021, 12, 12, 0, 0, 0);
            int curYear = Convert.ToInt32(DateTime.Now.Year);
            int curMonth = Convert.ToInt32(DateTime.Now.Month);
            int curDay = Convert.ToInt32(DateTime.Now.Day);
            int curHour = Convert.ToInt32(DateTime.Now.Hour);
            int curMin = Convert.ToInt32(DateTime.Now.Minute);
            DateTime maxDate = getDateTime(curYear, curMonth, curDay, curHour, (curMin + 1), 0);
            DateTime minDate = maxDate.AddMinutes(-2);
            //DateTime maxDate = getDateTime(curYear, curMonth, curDay, curHour, (curMin + 5), 0);
            //DateTime minDate = maxDate.AddMinutes(-10);


            setXAxisDisplayRange(MinCrowdCht, minDate, maxDate);

            //chartArea1.AxisX.LabelStyle.Format = "hh:ss";
            // You can change to the below formats as well depending on your needs. 
            //chartArea1.AxisX.LabelStyle.Format = "MMM dd";
            chartArea1.AxisX.LabelStyle.Format = "HH:mm";
            //chartAreal.AxisX.LabelStyle.Format "yyyy MMM dd HH:mm";
            //chartAreal.AxisX.LabelStyle.Format="MMM dd HH:mm:ss";

            // Y-Axis Settings
            chartArea1.AxisY.LabelStyle.Font = labelFont;
            chartArea1.AxisY.LineColor = colorGridLines;
            chartArea1.AxisY.MajorGrid.LineColor = colorGridLines;
            chartArea1.AxisY.Interval = 2;
            chartArea1.AxisY.IsStartedFromZero = true;

            // Line Graph Data points

            Series series1 = MinCrowdCht.Series[0];
            series1.Name = "Temp"; // This will show up in the legend text
            Color lineColor = getColor(26, 59, 185, 180);
            series1.BorderColor = lineColor; series1.ChartType = SeriesChartType.Line;
            series1.XValueType = ChartValueType.DateTime;
            series1.YValueType = ChartValueType.Double;
            series1.MarkerStyle = MarkerStyle.Circle;
            series1.MarkerSize = 6;
            series1.MarkerBorderColor = lineColor;
            series1.MarkerColor = lineColor;
            //Hover cursor on point to show
            //series1.ToolTip = "Timestamp: #VALX{d MMM yyyy H:mm:ss}, Value : #VAL";


        }//End of initMinCrowdChtProperties()

        private void loadDBtoMinuteCht()
        {
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Step 2: Create SQL command
            //string curDate = DateTime.Now.ToString("dd/MM/yyyy");
            string todaydate = DateTime.Now.Date.ToString("dd/MM/yyyy");
            string curHour = DateTime.Now.Hour.ToString();
            Console.WriteLine("curHour = " + curHour);
            //String strCommandText = "Select * from CrowdLevelTable where CONVERT(VARCHAR, DateTime , 103) = '5/12/2021'";
            //String strCommandText = "Select * from CrowdLevelTable WHERE Year(DateTime) = " + curYear + "AND Month(DateTime) = " + curMonth +
            //    "AND Day(DateTime) = " + curDay + "AND Hour(DateTime) = " + curHour + "AND Minute(DateTime) = " + curMin;
            //String strCommandText = "Select Datepart(Hour, [DateTime]) byHourly, sum(EnterExit) sumCol from CrowdLevelTable WHERE DateOnly = Convert(Date, '" + todaydate + "', 103) Group By Datepart(Hour, [DateTime])";
            //String strCommandText = "Select Datepart(Hour, [DateTime]) byHourly, Convert(DateTime, (Convert(Varchar, DateOnly)+ ' ' + Convert(Varchar, Datepart(Hour, [DateTime]))+':00:00')) newDate, sum(EnterExit) sumCol from CrowdLevelTable WHERE DateOnly = Convert(Date, '" + todaydate + "', 103) Group By Datepart(Hour, [DateTime]), DateOnly";
            String strCommandText = "Select Datepart(Hour, [DateTime]) byHourly, Datepart(Minute, [DateTime]) byMinute, [DateTime], sum(EnterExit) sumCol, sum(EnterExit) over (order by [DateTime] asc rows between unbounded preceding and current row) cumulEnterExit from CrowdLevelTable WHERE DateOnly = Convert(Date, '" + todaydate + "', 103) AND Convert(varchar, Datepart(Hour, [DateTime])) = " + curHour + " Group By Datepart(Hour, [DateTime]), Datepart(Minute, [DateTime]), DateOnly, [DateTime], EnterExit ORDER BY [byHourly], [byMinute]";

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
                Console.WriteLine("The Dataset Rows (Minute)= " + ds.Tables[0].Rows.Count);
                MinCrowdCht.DataSource = ds;

                // Chart X - Axis take from this Database field
                MinCrowdCht.Series[0].XValueMember = "DateTime";

                //Chart Y-Axis take from this Database field.
                MinCrowdCht.Series[0].YValueMembers = "cumulEnterExit";

                //clears and reload series data if there are existing data on chart
                MinCrowdCht.DataBind();


                //// get value for current crowd counter
                //String strCommandText2 = "Select Top 1 sum(EnterExit) over (order by [DateTime] asc rows between unbounded preceding and current row) cumulEnterExit from CrowdLevelTable WHERE DateOnly = Convert(Date, '21/12/2021', 103) AND Convert(varchar, Datepart(Hour, [DateTime])) = 15 Group By Datepart(Hour, [DateTime]), Datepart(Minute, [DateTime]), DateOnly, [DateTime], EnterExit ORDER BY [DateTime] desc";
                String strCommandText2 = "Select sum(EnterExit) counterSum from CrowdLevelTable WHERE DateOnly = Convert(Date, '" + todaydate + "', 103) AND Convert(varchar, Datepart(Hour, [DateTime])) = " + curHour + "";
                SqlDataAdapter adapter2 = new SqlDataAdapter(strCommandText2, myConnect);
                ////// create SELECT, DELETE, INSERT, UPDATE commands for data adapter
                SqlCommandBuilder cmdBuilder2 = new SqlCommandBuilder(adapter2);

                ////// STEP 4: Access data: Pill the Dataset using Data Adapter Fill method
                ////// Note: We do NOT need to open database connection
                ////// as data adapter does it internally
                DataSet ds2 = new DataSet();
                adapter2.Fill(ds2);

                if (ds2.Tables[0].Rows[0]["counterSum"] is DBNull)
                {
                    int extractedCounterValue = 0;
                    lbCurCrowdCount.Text = Convert.ToString(extractedCounterValue);
                }
                else if (ds2.Tables[0].Rows.Count > 0)
                {
                    Console.WriteLine(ds2.Tables[0].Rows[0]["counterSum"].ToString());
                    int extractedCounterValue = Convert.ToInt32(ds2.Tables[0].Rows[0]["counterSum"]);
                    lbCurCrowdCount.Text = Convert.ToString(extractedCounterValue);                                  
                }
                else
                {
                    int extractedCounterValue = 0;
                    lbCurCrowdCount.Text = Convert.ToString(extractedCounterValue);
                }
                //Console.WriteLine(ds2.Tables[0].Rows[0]["counterSum"].ToString());

                //Console.WriteLine("ds2 Dataset Rows = " + ds2.Tables[0].Rows.Count);
                ////Console.WriteLine(ds2.Tables[0].Rows[0]["cumulEnterExit"].ToString());
                //lbCurCrowdCount.Text = Convert.ToString(ds2);
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


        private void initHourlyCrowdChtProperties()
        {
            HourlyCrowdCht.BackColor = getColor(243, 223, 193);
            HourlyCrowdCht.BackGradientStyle = GradientStyle.TopBottom;
            HourlyCrowdCht.BorderlineColor = getColor(181, 64, 1);
            HourlyCrowdCht.BorderlineDashStyle = ChartDashStyle.Solid;
            HourlyCrowdCht.BorderlineWidth = 2;

            //Title
            Title title1 = new Title();
            title1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            title1.Text = "Hourly Crowd";
            HourlyCrowdCht.Titles.Add(title1);

            Font labelFont = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);

            //Graph legend
            //Legend legend1 = chart1.Legends[0];
            //legend1.BackColor = Color.Transparent;
            //legend1.Enabled = true;
            //legend1.Font = labelFont;

            //Chart area is the whole X-Y axis area
            Color colorGridLines = getColor(64, 64, 64, 64);
            ChartArea chartArea1 = HourlyCrowdCht.ChartAreas[0];
            chartArea1.BackColor = Color.OldLace;
            chartArea1.BackGradientStyle = GradientStyle.TopBottom;
            chartArea1.BorderColor = colorGridLines;
            chartArea1.BorderDashStyle = ChartDashStyle.Solid;
            chartArea1.ShadowColor = Color.Transparent;

            //X-Axis settings
            chartArea1.AxisX.LabelStyle.Font = labelFont;
            chartArea1.AxisX.LineColor = colorGridLines;
            chartArea1.AxisX.MajorGrid.LineColor = colorGridLines;

            chartArea1.AxisX.IntervalType = DateTimeIntervalType.Hours;
            chartArea1.AxisX.Interval = 1;
            //DateTime minDate = getDateTime(2021, 12, 5, 0, 0, 0);
            int curYear = Convert.ToInt32(DateTime.Now.Year);
            int curMonth = Convert.ToInt32(DateTime.Now.Month);
            int curDay = Convert.ToInt32(DateTime.Now.Day);
            int curHour = Convert.ToInt32(DateTime.Now.Hour);
            DateTime maxDate = getDateTime(curYear, curMonth, curDay, curHour, 0, 0);
            //DateTime maxDate = getDateTime(2021, 12, 12, 0, 0, 0);
            DateTime minDate = maxDate.AddHours(-8);


            setXAxisDisplayRange(HourlyCrowdCht, minDate, maxDate);

            //chartArea1.AxisX.LabelStyle.Format = "hh:ss";
            // You can change to the below formats as well depending on your needs. 
            //chartArea1.AxisX.LabelStyle.Format = "MMM dd";
            chartArea1.AxisX.LabelStyle.Format = "h tt";
            //chartAreal.AxisX.LabelStyle.Format "yyyy MMM dd HH:mm";
            //chartAreal.AxisX.LabelStyle.Format="MMM dd HH:mm:ss";

            // Y-Axis Settings
            chartArea1.AxisY.LabelStyle.Font = labelFont;
            chartArea1.AxisY.LineColor = colorGridLines;
            chartArea1.AxisY.MajorGrid.LineColor = colorGridLines;
            chartArea1.AxisY.Interval = 2;
            chartArea1.AxisY.IsStartedFromZero = true;

            // Line Graph Data points

            Series series1 = HourlyCrowdCht.Series[0];
            series1.Name = "Temp"; // This will show up in the legend text
            Color lineColor = getColor(26, 59, 185, 180);
            series1.BorderColor = lineColor; series1.ChartType = SeriesChartType.Spline;
            series1.XValueType = ChartValueType.DateTime;
            series1.YValueType = ChartValueType.Double;
            series1.MarkerStyle = MarkerStyle.Circle;
            series1.MarkerSize = 6;
            series1.MarkerBorderColor = lineColor;
            series1.MarkerColor = lineColor;
            //Hover cursor on point to show
            //series1.ToolTip = "Timestamp: #VALX{d MMM yyyy H:mm:ss}, Value : #VAL";


        }//End of initTotalCrowdChtProperties()

        private void loadDBtoHourlyCht()
        {
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            //Step 2: Create SQL command
            //string curDate = DateTime.Now.ToString("dd/MM/yyyy");
            string todaydate = DateTime.Now.Date.ToString("dd/MM/yyyy");
            //String strCommandText = "Select * from CrowdLevelTable where CONVERT(VARCHAR, DateTime , 103) = '5/12/2021'";
            //String strCommandText = "Select * from CrowdLevelTable WHERE Year(DateTime) = " + curYear + "AND Month(DateTime) = " + curMonth +
            //    "AND Day(DateTime) = " + curDay + "AND Hour(DateTime) = " + curHour + "AND Minute(DateTime) = " + curMin;
            //String strCommandText = "Select Datepart(Hour, [DateTime]) byHourly, sum(EnterExit) sumCol from CrowdLevelTable WHERE DateOnly = Convert(Date, '" + todaydate + "', 103) Group By Datepart(Hour, [DateTime])";
            String strCommandText = "Select Datepart(Hour, [DateTime]) byHourly, Convert(DateTime, (Convert(Varchar, DateOnly)+ ' ' + Convert(Varchar, Datepart(Hour, [DateTime]))+':00:00')) newDate, sum(EnterExit) sumCol from CrowdLevelTable WHERE DateOnly = Convert(Date, '" + todaydate + "', 103) Group By Datepart(Hour, [DateTime]), DateOnly";

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
                Console.WriteLine("The Dataset Rows = " + ds.Tables[0].Rows.Count);
                HourlyCrowdCht.DataSource = ds;

                // Chart X - Axis take from this Database field
                HourlyCrowdCht.Series[0].XValueMember = "newDate";

                //Chart Y-Axis take from this Database field.
                HourlyCrowdCht.Series[0].YValueMembers = "sumCol";

                //clears and reload series data if there are existing data on chart
                HourlyCrowdCht.DataBind();
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

        private void btnRetrieveMaintenanceRecord_Click(object sender, EventArgs e)
        {
            RUDMaintenance frm = new RUDMaintenance();
            frm.ShowDialog();
        }

        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            GameMachineDetails frm = new GameMachineDetails();
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RMachineDetails frm = new RMachineDetails();
            frm.ShowDialog();
        }

        private void curCrowdbtn_Click(object sender, EventArgs e)
        {
            if (hiddenMinPanel)
            {
                curCrowdbtn.Text = "By Hour";
                curCrowdbtn.BackColor = Color.FromArgb(209, 146, 13); ;
                curCrowdbtn.ForeColor = Color.Black;
                curCrowdbtn.FlatAppearance.BorderSize = 0;
            }
            else
            {
                curCrowdbtn.Text = "By Minute";
                curCrowdbtn.BackColor = Color.Black;
                curCrowdbtn.ForeColor = Color.FromArgb(209, 146, 13);
                curCrowdbtn.FlatAppearance.BorderSize = 1;
                curCrowdbtn.FlatAppearance.BorderColor = Color.FromArgb(209, 146, 13);
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hiddenMinPanel)
            {
                panel7.Width += 15;
                if (panel7.Width >= PW)
                {
                    timer1.Stop();
                    hiddenMinPanel = false;
                    this.Refresh();
                }
            }
            else
            {
                panel7.Width -= 15;
                if (panel7.Width <= 0)
                {
                    timer1.Stop();
                    hiddenMinPanel = true;
                    this.Refresh();
                }
            }
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timerMan_Tick(object sender, EventArgs e)
        {
            enterS1.Visible = false;
            enterS2.Visible = false;
            exitS1.Visible = false;
            exitS2.Visible = false;
        }

        
    }
}

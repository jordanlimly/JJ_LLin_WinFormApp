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
            String strCommandText =
                "INSERT CrowdLevelTable (DateTime, EnterExit) " +
                " VALUES (@NewDateTime, @NewEnterExit)";

            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
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
            }
            else if (strDistanceValue == "Out")
            {
                string strMessage = "=== Exit Captured at " + strTime.Replace("T", " ") + " ===";
                lbDataComms.Items.Insert(0, strMessage);
                int current = Convert.ToInt32(lbCurCrowdCount.Text);
                lbCurCrowdCount.Text = Convert.ToString(current - 1);

                //update database
                addCrowdRecord(Convert.ToDateTime(strTime), -1);
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
    }
}

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
    public partial class frmCurrentCrowd : Form
    {
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
                int current = Convert.ToInt32(lbCurCrowdCount.Text);
                lbCurCrowdCount.Text = Convert.ToString(current + 1);

                //update database
                addCrowdRecord(Convert.ToDateTime(strTime), 1);
            }
            else if (strDistanceValue == "Out")
            {
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
            if (strData.IndexOf("DIRECTION=") != -1)
                handledDistanceSensorData(strData, strTime, "DIRECTION=");
            //else if (strData.IndexOf("BUTTON=") != -1) //check button status
            //    handleButtonData(strData, strTime, "BUTTON=");
        }

        private void handleSensorData(String strData)
        {
            string dt = DateTime.Now.ToString("s"); //get current time
            extractSensorData(strData, dt); // get sensor values out

            // update raw data received to listbox
            string strMessage = dt + ":" + strData;
            lbDataComms.Items.Insert(0, strMessage);
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

        public frmCurrentCrowd()
        {
            InitializeComponent();
        }

        private void frmCurrentCrowd_Load(object sender, EventArgs e)
        {
            InitComms();
        }
    }
}

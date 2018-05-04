using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AsterNET.Manager;
using AsterNET.Manager.Event;
using System.Diagnostics;
using RestSharp;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using Asterisk.NET.WinForm;
using Asterisk.NET.WinForm.Properties;

namespace AsterNET.WinForm
{

    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private Dictionary<String,String> ami_settings=  new Dictionary<String,String>();
        private ManagerConnection manager = null;
        private enum IconState {RED,GREEN,ORANGE};

        private void connect2AMI()
        {
            manager = new ManagerConnection(ami_settings["AMI_IP"], Int32.Parse(ami_settings["AMI_PORT"]), ami_settings["AMI_LOGIN"], ami_settings["AMI_PASSWORD"]);
            manager.UnhandledEvent += new ManagerEventHandler(manager_Events);
            manager.ConnectionState += new ConnectionStateEventHandler(manager_ConnectionState);
            manager.Dial += new DialEventHandler(manager_DialEvent);
            manager.Bridge += new BridgeEventHandler(manager_BridgeEvent);
            manager.Hangup += new HangupEventHandler(manager_HangupEvent);
            
                       
            manager.FireAllEvents = true;

            try
            {
                manager.Login();
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                btnConfirm.Enabled = !Settings.Default.CONFIRMED;
                setStatus("Connection established",IconState.GREEN);
            }
            catch (Exception ex)
            {
                setStatus("Connection failed: " + ex.Message,IconState.RED);
                manager.Logoff();
            }
            
        }

        void manager_AgentConnect(object sender, AgentConnectEvent e)
        {
            MessageBox.Show("asdf");
        }
        public void setConfirmState(bool state)
        {
            Settings.Default.CONFIRMED = state;
            Settings.Default.Save();
            btnConfirm.Enabled = !state;
        }
        void execApp(string app, string args = "")
        {
            //If it's web page
            if (app.Substring(0, 4) == "http")
            {
                app += "?"+args;
                args = "";
            }
            new Process()
            {
                StartInfo =
                {
                    FileName = app,
                    Arguments = args
                }
            }.Start();
        }
        void manager_ConnectionState(object sender, ConnectionStateEvent e)
        {

            if (e.Reconnect == true)
            {
                    setStatus("Connection lost. Trying to reconnect...",IconState.ORANGE);
            }
        }

        void manager_DialEvent(object sender, DialEvent e)
        {
            if (e.SubEvent == "Begin" && tbNumber.Text == e.DialString)
            {
                string arg = ami_settings["EXEC_BEFORE_ANSWER_ARG"].Replace("{callerid}", e.CallerIdNum);
                if (ami_settings["EXEC_BEFORE_ANSWER"] != "")
                    execApp(ami_settings["EXEC_BEFORE_ANSWER"], arg);
            }
        }

        void manager_BridgeEvent(object sender, BridgeEvent e)
        {
            string arg = ami_settings["EXEC_AFTER_ANSWER_ARG"].Replace("{callerid}", e.CallerId1);
            if (tbNumber.Text == e.CallerId2 && e.BridgeState == BridgeEvent.BridgeStates.BRIDGE_STATE_LINK)
            {
                if (ami_settings["EXEC_AFTER_ANSWER"] != "")
                    execApp(ami_settings["EXEC_AFTER_ANSWER"], arg);
            }
        }

        void manager_HangupEvent(object sender, HangupEvent e)
        {
                string arg = ami_settings["EXEC_AFTER_CALL_ARG"].Replace("{callerid}", e.CallerIdNum);
                if (tbNumber.Text == e.Connectedlinenum)
                {
                    if (ami_settings["EXEC_AFTER_CALL"] != "")
                        execApp(ami_settings["EXEC_AFTER_CALL"], arg);
                }
        }

        void manager_Events(object sender, ManagerEvent e)
        {

            
        }

        public static string Encrypt(string phrase)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(phrase));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                    sBuilder.Append(data[i].ToString("x2"));
                return sBuilder.ToString();
            }
        }

        private void loadSettings(MatchCollection mc)
        {
            
            //{"AMI_LOGIN":"YWRtaW4=","AMI_PASSWORD":"YXNzZW1ibGVy","PHONE_PATTERN":"WFhY","EXEC_BEFORE":"Qzpcd2luZG93c1xub3RlcGFkLmV4ZQ==","EXEC_BEFORE_ARG":"e251bX0=","EXEC_AFTER":"Qzpcd2luZG93c1xub3RlcGFkLmV4ZQ==","EXEC_AFTER_ARG":"e251bX0="}            
            
            ami_settings.Clear();
            foreach (Match m in mc)
            {
                ami_settings.Add(m.Groups[1].Value, Encoding.UTF8.GetString(Convert.FromBase64String(m.Groups[2].Value)));
            }

            phonePattern.Text = ami_settings["PHONE_PATTERN"];
            execBeforeAnswer.Text = ami_settings["EXEC_BEFORE_ANSWER"] + (ami_settings["EXEC_BEFORE_ANSWER"].Substring(0,4)=="http" ? "?" : " ") + ami_settings["EXEC_BEFORE_ANSWER_ARG"];
            execAfterAnswer.Text = ami_settings["EXEC_AFTER_ANSWER"] + (ami_settings["EXEC_AFTER_ANSWER"].Substring(0, 4) == "http" ? "?" : " ") + ami_settings["EXEC_AFTER_ANSWER_ARG"];
            execAfterCall.Text = ami_settings["EXEC_AFTER_CALL"] + (ami_settings["EXEC_AFTER_CALL"].Substring(0, 4) == "http" ? "?" : " ") + ami_settings["EXEC_AFTER_CALL_ARG"];
            connect2AMI();
        }

        public void alServerRequest(string command)
        {
            var client = new RestClient(tbServerURI.Text +Settings.Default.AMI_LAUNCHER_URI);
           
            var request = new RestRequest(Method.GET);
            request.AddParameter("hash", Encrypt(tbMasterPassword.Text)); // adds to POST or URL querystring based on Method
            request.AddParameter("command", command); // adds to POST or URL querystring based on Method

            // easy async support
            client.ExecuteAsync(request, responsea =>
            {
                Regex reg = new Regex(@"""([^""]+)"":""([^""]+)""");
                string json = responsea.Content;
                MatchCollection mc = reg.Matches(json);
                Console.WriteLine(responsea.Content);
                this.backgroundWorker1.RunWorkerAsync(mc);
            });
        }

        private void setStatus(string status, IconState Icon_Color = IconState.GREEN)
        {
            switch(Icon_Color)
            {
                case IconState.GREEN:
                    notifyIcon1.Icon = Asterisk.NET.WinForm.Properties.Resources.phone_green;
                    break;
                case IconState.RED:
                    notifyIcon1.Icon = Asterisk.NET.WinForm.Properties.Resources.phone_red;
                    break;
                case IconState.ORANGE:
                    notifyIcon1.Icon = Asterisk.NET.WinForm.Properties.Resources.phone_orange;
                    break;
            }
                

            
            statusLabel.Text = status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alServerRequest("LOAD_SETTINGS");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Match m in (MatchCollection)e.Result)
            {
                if(m.Groups[1].Value == "COMMAND" && Encoding.UTF8.GetString(Convert.FromBase64String(m.Groups[2].Value))=="LOAD_SETTINGS")
                    loadSettings((MatchCollection)e.Result);
                if (m.Groups[1].Value == "COMMAND" && Encoding.UTF8.GetString(Convert.FromBase64String(m.Groups[2].Value)) == "CONFIRM_NUM")
                {
                    PhoneConfirmation f = new PhoneConfirmation((MatchCollection)e.Result,this);
                    f.Show();
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = (MatchCollection)e.Argument;
        }

        private void btnDisconnect_Click_1(object sender, EventArgs e)
        {
            btnConnect.Enabled = true;
            if (this.manager != null)
            {
                manager.Logoff();
                this.manager = null;
            }
            btnDisconnect.Enabled = false;
            setStatus("Disconnected",IconState.RED);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            alServerRequest("CONFIRM_NUM");
        }

        private void tbNumber_TextChanged(object sender, EventArgs e)
        {
            btnSaveSettings.Enabled = true;
            setConfirmState(false);

        }

         private void textBoxURL_TextChanged(object sender, EventArgs e)
        {
            setConfirmState(false);
            btnSaveSettings.Enabled = true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Settings.Default.NUMBER = tbNumber.Text;
            Settings.Default.SERVER = tbServerURI.Text;
            Settings.Default.MASTER_PASSWORD = tbMasterPassword.Text;
            Settings.Default.START_ON_BOOT = cbAutostart.Checked;
            Settings.Default.CONNECT_AT_LOGON = cbAutoLogin.Checked;
            Settings.Default.Save();
            btnSaveSettings.Enabled = false;
        }

        private void tbMasterPassword_TextChanged(object sender, EventArgs e)
        {
            btnSaveSettings.Enabled = true;
        }

   

        private void FormMain_Load(object sender, EventArgs e)
        {
            tbServerURI.Text = Settings.Default.SERVER;
            tbNumber.Text = Settings.Default.NUMBER;
            tbMasterPassword.Text = Settings.Default.MASTER_PASSWORD;
            cbAutoLogin.Checked = Settings.Default.CONNECT_AT_LOGON;
            cbAutostart.Checked = Settings.Default.START_ON_BOOT;
            if(Settings.Default.CONNECT_AT_LOGON)
                alServerRequest("LOAD_SETTINGS");
        }

  

        private void cbAutostart_Click(object sender, EventArgs e)
        {
            btnSaveSettings.Enabled = true;
        }

        private void cbAutoLogin_Click(object sender, EventArgs e)
        {
            btnSaveSettings.Enabled = true;
        }
    }
}

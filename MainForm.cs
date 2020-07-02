using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NeuroSky.ThinkGear;

namespace NeuroSkyMindWaveMobileConnector
{
    public partial class MainForm : Form
    {
        private Connector neuroSkyConnector;
        private volatile Device neursoSkyHeadset;

        private delegate void AttentionLevelCallback(double attentionLevel);
        private delegate void MeditationLevelCallback(double meditationLevel);
        private delegate void PoorSignalCallback(int poorSignal);
        //private delegate void AttentionLevelCallback(int attentionLevel);

        private double deltaPower = 0.0;
        private double thetaPower = 0.0;
        private double alphaLowPower = 0.0;
        private double alphaHighPower = 0.0;
        private double betaLowPower = 0.0;
        private double betaHighPower = 0.0;
        private double gammaLowPower = 0.0;
        private double gammaHighPower = 0.0;

        private double attentionLevel = 0.0;
        private double medtitationLevel = 0.0;
        private double poorSignal = 200;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Initialize()
        {
            this.neuroSkyConnector = new Connector();
            this.neuroSkyConnector.DeviceConnected += new EventHandler(this.OnDeviceConnected);
            this.neuroSkyConnector.DeviceDisconnected += new EventHandler(this.OnDeviceDisconnected);
            this.neuroSkyConnector.DeviceFound += new EventHandler(this.OnDeviceFound);
            this.neuroSkyConnector.DeviceNotFound += new EventHandler(this.OnDeviceNotFound);
            this.neuroSkyConnector.DeviceConnectFail += new EventHandler(this.OnDeviceConnectFail);
            this.neuroSkyConnector.DeviceValidating += new EventHandler(this.OnDeviceValidating);

            this.neuroSkyConnector.setBlinkDetectionEnabled(true);
            this.neuroSkyConnector.StartEnergyLevel();
            this.neuroSkyConnector.enableTaskDifficulty();
            this.neuroSkyConnector.enableTaskFamiliarity();
            this.neuroSkyConnector.getBlinkDetectionEnabled();
        }

        private void Connect()
        {
            this.neuroSkyConnector.ConnectScan();
        }

        private void Disconnect()
        {
            this.neuroSkyConnector.Disconnect();
            this.neuroSkyConnector.Close();
        }

        private void UpdateAttentionLevel(double level)
        {
            if (this.lblAttentionLevel.InvokeRequired)
            {
                AttentionLevelCallback cb = new AttentionLevelCallback(this.UpdateAttentionLevel);
                this.Invoke(cb, new object[] { level });
            }
            else
            {
                this.lblAttentionLevel.Text = level.ToString();
            }
        }

        private void UpdateMeditationLevel(double level)
        {
            if (this.lblMeditationLevelValue.InvokeRequired)
            {
                MeditationLevelCallback cb = new MeditationLevelCallback(this.UpdateMeditationLevel);
                this.Invoke(cb, new object[] { level });
            }
            else
            {
                this.lblMeditationLevelValue.Text = level.ToString();
            }
        }

        private void UpdatePoorSignal(int poorSignal)
        {
            if (this.pbHeasetStatus.InvokeRequired)
            {
                PoorSignalCallback cb = new PoorSignalCallback(this.UpdatePoorSignal);
                this.Invoke(cb, new object[] { poorSignal });
            }
            else
            {
                if (this.poorSignal < 200)
                {
                    this.pbHeasetStatus.BackgroundImage = Properties.Resources.NeuroSky_Signal_Fitting;
                } 
                else
                {
                    this.pbHeasetStatus.BackgroundImage = Properties.Resources.NeuroSky_Signal_Connected;
                }
            }
        }

        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void btnConnectDisconnect_Click(object sender, EventArgs e)
        {
            if (this.btnConnectDisconnect.Text.Equals("CONNECT"))
            {
                this.btnConnectDisconnect.Text = "DISCONNECT";
                this.Connect();
            } else
            {
                this.btnConnectDisconnect.Text = "CONNECT";
                this.Disconnect();
            }
        }

        private void OnDeviceConnected(object sender, EventArgs e)
        {
            Connector.DeviceEventArgs deviceEventArgs = (Connector.DeviceEventArgs)e;
            deviceEventArgs.Device.DataReceived += new EventHandler(this.OnDataReceived);
        }

        private void OnDataReceived(object sender, EventArgs e)
        {
            // Cast the event sender as a Device object, and e as the Device's DataEventArgs
            this.neursoSkyHeadset = (Device)sender;
            Device.DataEventArgs deviceDataEventArgs = (Device.DataEventArgs)e;

            // Create a TGParser to parse the Device's DataRowArray[]
            TGParser tgParser = new TGParser();

            if (tgParser == null)
            {
                this.Disconnect();
            }
            else
            {
                tgParser.Read(deviceDataEventArgs.DataRowArray);

                for (int i = 0; i < tgParser.ParsedData.Length; i++)
                {
                    if (tgParser.ParsedData[i].ContainsKey("EegPowerDelta"))
                    {
                        this.deltaPower = tgParser.ParsedData[i]["EegPowerDelta"];
                    }
                    if (tgParser.ParsedData[i].ContainsKey("EegPowerTheta"))
                    {
                        this.thetaPower = tgParser.ParsedData[i]["EegPowerTheta"];
                    }
                    if (tgParser.ParsedData[i].ContainsKey("EegPowerAlpha1"))
                    {
                        this.alphaLowPower = tgParser.ParsedData[i]["EegPowerAlpha1"];
                    }
                    if (tgParser.ParsedData[i].ContainsKey("EegPowerAlpha2"))
                    {
                        this.alphaHighPower = tgParser.ParsedData[i]["EegPowerAlpha2"];
                    }
                    if (tgParser.ParsedData[i].ContainsKey("EegPowerBeta1"))
                    {
                        this.betaLowPower = tgParser.ParsedData[i]["EegPowerBeta1"];
                    }
                    if (tgParser.ParsedData[i].ContainsKey("EegPowerBeta2"))
                    {
                        this.betaHighPower = tgParser.ParsedData[i]["EegPowerBeta2"];
                    }
                    if (tgParser.ParsedData[i].ContainsKey("EegPowerGamma1"))
                    {
                        this.gammaLowPower = tgParser.ParsedData[i]["EegPowerGamma1"];
                    }
                    if (tgParser.ParsedData[i].ContainsKey("EegPowerGamma2"))
                    {
                        this.gammaHighPower = tgParser.ParsedData[i]["EegPowerGamma2"];
                    }
                    if (tgParser.ParsedData[i].ContainsKey("Attention"))
                    {
                        this.attentionLevel = tgParser.ParsedData[i]["Attention"];
                        this.UpdateAttentionLevel(this.attentionLevel);
                    }
                    if (tgParser.ParsedData[i].ContainsKey("Meditation"))
                    {
                        this.medtitationLevel = tgParser.ParsedData[i]["Meditation"];
                        this.UpdateMeditationLevel(this.medtitationLevel);
                    }
                    if (tgParser.ParsedData[i].ContainsKey("PoorSignal"))
                    {
                        this.poorSignal = tgParser.ParsedData[i]["PoorSignal"];
                        this.UpdatePoorSignal((int)this.poorSignal);
                    }
                }
            }
        }

        private void OnDeviceDisconnected(object sender, EventArgs e)
        {
            this.pbHeasetStatus.Image = Properties.Resources.NeuroSky_Signal_Disconnected;
        }

        private void OnDeviceFound(object sender, EventArgs e)
        {

        }

        private void OnDeviceNotFound(object sender, EventArgs e)
        {
            this.pbHeasetStatus.Image = Properties.Resources.NeuroSky_Signal_Disconnected;
        }

        private void OnDeviceConnectFail(object sender, EventArgs e)
        {
            this.pbHeasetStatus.Image = Properties.Resources.NeuroSky_Signal_Disconnected;
        }

        private void OnDeviceValidating(object sender, EventArgs e)
        {

        }
        #endregion Events
    } // class
} // namespace

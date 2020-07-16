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
        private Connector neuroSkyConnector = null;
        //private volatile Device neursoSkyHeadset = null;

        private delegate void AttentionLevelCallback(double attentionLevel);
        private delegate void MeditationLevelCallback(double meditationLevel);
        private delegate void PoorSignalCallback(int poorSignal);
        private delegate void DeltaPowerCallback(double deltaPower);
        private delegate void ThetaPowerCallback(double thetaPower);
        private delegate void AlphaLowPowerCallback(double alphaLowPower);
        private delegate void AlphaHighPowerCallback(double betaLowPower);
        private delegate void BetaLowPowerCallback(double betaHighPower);
        private delegate void BetaHighPowerCallback(double deltaPower);
        private delegate void GammaLowPowerCallback(double gammaLowPower);
        private delegate void GammaHighPowerCallback(double gammaHighPower);

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
            if (this.lblAttentionLevelValue.InvokeRequired)
            {
                AttentionLevelCallback cb = new AttentionLevelCallback(this.UpdateAttentionLevel);
                this.Invoke(cb, new object[] { level });
            }
            else
            {
                this.lblAttentionLevelValue.Text = "Attention: " + level.ToString();
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
                this.lblMeditationLevelValue.Text = "Meditation: " + level.ToString();
            }
        }

        private void UpdateDeltaPower(double power)
        {
            if (this.lblDeltaValue.InvokeRequired)
            {
                DeltaPowerCallback cb = new DeltaPowerCallback(this.UpdateDeltaPower);
                this.Invoke(cb, new object[] { power });
            }
            else
            {
                this.lblDeltaValue.Text = "Delta: " + power.ToString();
            }
        }

        private void UpdateThetaPower(double power)
        {
            if (this.lblThetaValue.InvokeRequired)
            {
                ThetaPowerCallback cb = new ThetaPowerCallback(this.UpdateThetaPower);
                this.Invoke(cb, new object[] { power });
            }
            else
            {
                this.lblThetaValue.Text = "Theta: " + power.ToString();
            }
        }

        private void UpdateAlphaLowPower(double power)
        {
            if (this.lblAlphaLowValue.InvokeRequired)
            {
                AlphaLowPowerCallback cb = new AlphaLowPowerCallback(this.UpdateAlphaLowPower);
                this.Invoke(cb, new object[] { power });
            }
            else
            {
                this.lblAlphaLowValue.Text = "Alpha Low: " + power.ToString();
            }
        }

        private void UpdateAlphaHighPower(double power)
        {
            if (this.lblAlphaHighValue.InvokeRequired)
            {
                AlphaHighPowerCallback cb = new AlphaHighPowerCallback(this.UpdateAlphaHighPower);
                this.Invoke(cb, new object[] { power });
            }
            else
            {
                this.lblAlphaHighValue.Text = "Alpha High: " + power.ToString();
            }
        }

        private void UpdateBetaLowPower(double power)
        {
            if (this.lblBetaLowValue.InvokeRequired)
            {
                BetaLowPowerCallback cb = new BetaLowPowerCallback(this.UpdateBetaLowPower);
                this.Invoke(cb, new object[] { power });
            }
            else
            {
                this.lblBetaLowValue.Text = "Beta Low: " + power.ToString();
            }
        }

        private void UpdateBetaHighPower(double power)
        {
            if (this.lblBetaHighValue.InvokeRequired)
            {
                BetaHighPowerCallback cb = new BetaHighPowerCallback(this.UpdateBetaHighPower);
                this.Invoke(cb, new object[] { power });
            }
            else
            {
                this.lblBetaHighValue.Text = "Beta High: " + power.ToString();
            }
        }

        private void UpdateGammaLowPower(double power)
        {
            if (this.lblGammaLowValue.InvokeRequired)
            {
                GammaLowPowerCallback cb = new GammaLowPowerCallback(this.UpdateGammaLowPower);
                this.Invoke(cb, new object[] { power });
            }
            else
            {
                this.lblGammaLowValue.Text = "Gamma Low: " + power.ToString();
            }
        }

        private void UpdateGammaHighPower(double power)
        {
            if (this.lblGammaHighValue.InvokeRequired)
            {
                GammaHighPowerCallback cb = new GammaHighPowerCallback(this.UpdateGammaHighPower);
                this.Invoke(cb, new object[] { power });
            }
            else
            {
                this.lblGammaHighValue.Text = "Gamma High: " + power.ToString();
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
                if (this.poorSignal == 200)
                {
                    this.pbHeasetStatus.BackgroundImage = Properties.Resources.NeuroSky_Signal_Disconnected;
                } 
                else if (this.poorSignal == 0)
                {
                    this.pbHeasetStatus.BackgroundImage = Properties.Resources.NeuroSky_Signal_Connected;
                }
                else
                {
                    this.pbHeasetStatus.BackgroundImage = Properties.Resources.NeuroSky_Signal_Fitting;
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
            //this.neursoSkyHeadset = (Device)sender;
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
                        this.UpdateDeltaPower((int)this.deltaPower);
                    }
                    if (tgParser.ParsedData[i].ContainsKey("EegPowerTheta"))
                    {
                        this.thetaPower = tgParser.ParsedData[i]["EegPowerTheta"];
                        this.UpdateThetaPower((int)this.thetaPower);
                    }
                    if (tgParser.ParsedData[i].ContainsKey("EegPowerAlpha1"))
                    {
                        this.alphaLowPower = tgParser.ParsedData[i]["EegPowerAlpha1"];
                        this.UpdateAlphaLowPower((int)this.alphaLowPower);
                    }
                    if (tgParser.ParsedData[i].ContainsKey("EegPowerAlpha2"))
                    {
                        this.alphaHighPower = tgParser.ParsedData[i]["EegPowerAlpha2"];
                        this.UpdateAlphaHighPower((int)this.alphaHighPower);
                    }
                    if (tgParser.ParsedData[i].ContainsKey("EegPowerBeta1"))
                    {
                        this.betaLowPower = tgParser.ParsedData[i]["EegPowerBeta1"];
                        this.UpdateBetaLowPower((int)this.betaLowPower);
                    }
                    if (tgParser.ParsedData[i].ContainsKey("EegPowerBeta2"))
                    {
                        this.betaHighPower = tgParser.ParsedData[i]["EegPowerBeta2"];
                        this.UpdateBetaHighPower((int)this.betaHighPower);
                    }
                    if (tgParser.ParsedData[i].ContainsKey("EegPowerGamma1"))
                    {
                        this.gammaLowPower = tgParser.ParsedData[i]["EegPowerGamma1"];
                        this.UpdateGammaLowPower((int)this.gammaLowPower);
                    }
                    if (tgParser.ParsedData[i].ContainsKey("EegPowerGamma2"))
                    {
                        this.gammaHighPower = tgParser.ParsedData[i]["EegPowerGamma2"];
                        this.UpdateGammaHighPower((int)this.gammaHighPower);
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
            this.pbHeasetStatus.Image = Properties.Resources.NeuroSky_Signal_Connected;
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
            this.pbHeasetStatus.Image = Properties.Resources.NeuroSky_Signal_Fitting;
        }
        #endregion Events
    } // class
} // namespace

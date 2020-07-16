namespace NeuroSkyMindWaveMobileConnector
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnectDisconnect = new System.Windows.Forms.Button();
            this.lblAttentionLevel = new System.Windows.Forms.Label();
            this.lblBandPower = new System.Windows.Forms.Label();
            this.lblMeditationLevel = new System.Windows.Forms.Label();
            this.lblAttentionLevelValue = new System.Windows.Forms.Label();
            this.lblAlphaLowValue = new System.Windows.Forms.Label();
            this.lblDeltaValue = new System.Windows.Forms.Label();
            this.lblThetaValue = new System.Windows.Forms.Label();
            this.lblBetaLowValue = new System.Windows.Forms.Label();
            this.lblGammaLowValue = new System.Windows.Forms.Label();
            this.lblMeditationLevelValue = new System.Windows.Forms.Label();
            this.pbHeasetStatus = new System.Windows.Forms.PictureBox();
            this.lblAlphaHighValue = new System.Windows.Forms.Label();
            this.lblBetaHighValue = new System.Windows.Forms.Label();
            this.lblGammaHighValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeasetStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnectDisconnect
            // 
            this.btnConnectDisconnect.Location = new System.Drawing.Point(80, 30);
            this.btnConnectDisconnect.Name = "btnConnectDisconnect";
            this.btnConnectDisconnect.Size = new System.Drawing.Size(104, 35);
            this.btnConnectDisconnect.TabIndex = 0;
            this.btnConnectDisconnect.Text = "CONNECT";
            this.btnConnectDisconnect.UseVisualStyleBackColor = true;
            this.btnConnectDisconnect.Click += new System.EventHandler(this.btnConnectDisconnect_Click);
            // 
            // lblAttentionLevel
            // 
            this.lblAttentionLevel.AutoSize = true;
            this.lblAttentionLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblAttentionLevel.Location = new System.Drawing.Point(12, 98);
            this.lblAttentionLevel.Name = "lblAttentionLevel";
            this.lblAttentionLevel.Size = new System.Drawing.Size(110, 16);
            this.lblAttentionLevel.TabIndex = 1;
            this.lblAttentionLevel.Text = "Attention Level";
            // 
            // lblBandPower
            // 
            this.lblBandPower.AutoSize = true;
            this.lblBandPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblBandPower.Location = new System.Drawing.Point(12, 148);
            this.lblBandPower.Name = "lblBandPower";
            this.lblBandPower.Size = new System.Drawing.Size(91, 16);
            this.lblBandPower.TabIndex = 2;
            this.lblBandPower.Text = "Band Power";
            // 
            // lblMeditationLevel
            // 
            this.lblMeditationLevel.AutoSize = true;
            this.lblMeditationLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblMeditationLevel.Location = new System.Drawing.Point(12, 307);
            this.lblMeditationLevel.Name = "lblMeditationLevel";
            this.lblMeditationLevel.Size = new System.Drawing.Size(122, 16);
            this.lblMeditationLevel.TabIndex = 3;
            this.lblMeditationLevel.Text = "Meditation Level";
            // 
            // lblAttentionLevelValue
            // 
            this.lblAttentionLevelValue.AutoSize = true;
            this.lblAttentionLevelValue.Location = new System.Drawing.Point(12, 124);
            this.lblAttentionLevelValue.Name = "lblAttentionLevelValue";
            this.lblAttentionLevelValue.Size = new System.Drawing.Size(52, 13);
            this.lblAttentionLevelValue.TabIndex = 4;
            this.lblAttentionLevelValue.Text = "Attention:";
            // 
            // lblAlphaLowValue
            // 
            this.lblAlphaLowValue.AutoSize = true;
            this.lblAlphaLowValue.Location = new System.Drawing.Point(12, 175);
            this.lblAlphaLowValue.Name = "lblAlphaLowValue";
            this.lblAlphaLowValue.Size = new System.Drawing.Size(60, 13);
            this.lblAlphaLowValue.TabIndex = 5;
            this.lblAlphaLowValue.Text = "Alpha Low:";
            // 
            // lblDeltaValue
            // 
            this.lblDeltaValue.AutoSize = true;
            this.lblDeltaValue.Location = new System.Drawing.Point(12, 201);
            this.lblDeltaValue.Name = "lblDeltaValue";
            this.lblDeltaValue.Size = new System.Drawing.Size(35, 13);
            this.lblDeltaValue.TabIndex = 6;
            this.lblDeltaValue.Text = "Delta:";
            // 
            // lblThetaValue
            // 
            this.lblThetaValue.AutoSize = true;
            this.lblThetaValue.Location = new System.Drawing.Point(12, 228);
            this.lblThetaValue.Name = "lblThetaValue";
            this.lblThetaValue.Size = new System.Drawing.Size(38, 13);
            this.lblThetaValue.TabIndex = 7;
            this.lblThetaValue.Text = "Theta:";
            // 
            // lblBetaLowValue
            // 
            this.lblBetaLowValue.AutoSize = true;
            this.lblBetaLowValue.Location = new System.Drawing.Point(12, 254);
            this.lblBetaLowValue.Name = "lblBetaLowValue";
            this.lblBetaLowValue.Size = new System.Drawing.Size(55, 13);
            this.lblBetaLowValue.TabIndex = 8;
            this.lblBetaLowValue.Text = "Beta Low:";
            // 
            // lblGammaLowValue
            // 
            this.lblGammaLowValue.AutoSize = true;
            this.lblGammaLowValue.Location = new System.Drawing.Point(12, 281);
            this.lblGammaLowValue.Name = "lblGammaLowValue";
            this.lblGammaLowValue.Size = new System.Drawing.Size(69, 13);
            this.lblGammaLowValue.TabIndex = 9;
            this.lblGammaLowValue.Text = "Gamma Low:";
            // 
            // lblMeditationLevelValue
            // 
            this.lblMeditationLevelValue.AutoSize = true;
            this.lblMeditationLevelValue.Location = new System.Drawing.Point(12, 334);
            this.lblMeditationLevelValue.Name = "lblMeditationLevelValue";
            this.lblMeditationLevelValue.Size = new System.Drawing.Size(59, 13);
            this.lblMeditationLevelValue.TabIndex = 10;
            this.lblMeditationLevelValue.Text = "Meditation:";
            // 
            // pbHeasetStatus
            // 
            this.pbHeasetStatus.BackgroundImage = global::NeuroSkyMindWaveMobileConnector.Properties.Resources.NeuroSky_Signal_Disconnected;
            this.pbHeasetStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHeasetStatus.Location = new System.Drawing.Point(206, 12);
            this.pbHeasetStatus.Name = "pbHeasetStatus";
            this.pbHeasetStatus.Size = new System.Drawing.Size(80, 70);
            this.pbHeasetStatus.TabIndex = 11;
            this.pbHeasetStatus.TabStop = false;
            // 
            // lblAlphaHighValue
            // 
            this.lblAlphaHighValue.AutoSize = true;
            this.lblAlphaHighValue.Location = new System.Drawing.Point(150, 175);
            this.lblAlphaHighValue.Name = "lblAlphaHighValue";
            this.lblAlphaHighValue.Size = new System.Drawing.Size(62, 13);
            this.lblAlphaHighValue.TabIndex = 12;
            this.lblAlphaHighValue.Text = "Alpha High:";
            // 
            // lblBetaHighValue
            // 
            this.lblBetaHighValue.AutoSize = true;
            this.lblBetaHighValue.Location = new System.Drawing.Point(150, 254);
            this.lblBetaHighValue.Name = "lblBetaHighValue";
            this.lblBetaHighValue.Size = new System.Drawing.Size(57, 13);
            this.lblBetaHighValue.TabIndex = 13;
            this.lblBetaHighValue.Text = "Beta High:";
            // 
            // lblGammaHighValue
            // 
            this.lblGammaHighValue.AutoSize = true;
            this.lblGammaHighValue.Location = new System.Drawing.Point(150, 281);
            this.lblGammaHighValue.Name = "lblGammaHighValue";
            this.lblGammaHighValue.Size = new System.Drawing.Size(71, 13);
            this.lblGammaHighValue.TabIndex = 14;
            this.lblGammaHighValue.Text = "Gamma High:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 362);
            this.Controls.Add(this.lblGammaHighValue);
            this.Controls.Add(this.lblBetaHighValue);
            this.Controls.Add(this.lblAlphaHighValue);
            this.Controls.Add(this.pbHeasetStatus);
            this.Controls.Add(this.lblMeditationLevelValue);
            this.Controls.Add(this.lblGammaLowValue);
            this.Controls.Add(this.lblBetaLowValue);
            this.Controls.Add(this.lblThetaValue);
            this.Controls.Add(this.lblDeltaValue);
            this.Controls.Add(this.lblAlphaLowValue);
            this.Controls.Add(this.lblAttentionLevelValue);
            this.Controls.Add(this.lblMeditationLevel);
            this.Controls.Add(this.lblBandPower);
            this.Controls.Add(this.lblAttentionLevel);
            this.Controls.Add(this.btnConnectDisconnect);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NeuroSky MindWave Mobile Connector";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeasetStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnectDisconnect;
        private System.Windows.Forms.Label lblAttentionLevel;
        private System.Windows.Forms.Label lblBandPower;
        private System.Windows.Forms.Label lblMeditationLevel;
        private System.Windows.Forms.Label lblAttentionLevelValue;
        private System.Windows.Forms.Label lblAlphaLowValue;
        private System.Windows.Forms.Label lblDeltaValue;
        private System.Windows.Forms.Label lblThetaValue;
        private System.Windows.Forms.Label lblBetaLowValue;
        private System.Windows.Forms.Label lblGammaLowValue;
        private System.Windows.Forms.Label lblMeditationLevelValue;
        private System.Windows.Forms.PictureBox pbHeasetStatus;
        private System.Windows.Forms.Label lblAlphaHighValue;
        private System.Windows.Forms.Label lblBetaHighValue;
        private System.Windows.Forms.Label lblGammaHighValue;
    }
}


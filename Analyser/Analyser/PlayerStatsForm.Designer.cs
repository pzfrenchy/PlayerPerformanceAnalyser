namespace Analyser
{
    partial class PlayerStatsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.speedLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.pitchPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.fastForwardBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.rewindBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sprintsLbl = new System.Windows.Forms.Label();
            this.paceLbl = new System.Windows.Forms.Label();
            this.distanceLbl = new System.Windows.Forms.Label();
            this.breakdownChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playerCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateCombo = new System.Windows.Forms.ComboBox();
            this.movementTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pitchPictureBox)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breakdownChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 730);
            this.panel1.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.speedLbl);
            this.groupBox3.Controls.Add(this.timeLbl);
            this.groupBox3.Controls.Add(this.pitchPictureBox);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(23, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 679);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Position";
            // 
            // speedLbl
            // 
            this.speedLbl.AutoSize = true;
            this.speedLbl.Location = new System.Drawing.Point(386, 624);
            this.speedLbl.Name = "speedLbl";
            this.speedLbl.Size = new System.Drawing.Size(80, 25);
            this.speedLbl.TabIndex = 6;
            this.speedLbl.Text = "Normal";
            this.speedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.BackColor = System.Drawing.Color.LimeGreen;
            this.timeLbl.Location = new System.Drawing.Point(23, 561);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(54, 25);
            this.timeLbl.TabIndex = 5;
            this.timeLbl.Text = "0:00";
            // 
            // pitchPictureBox
            // 
            this.pitchPictureBox.BackColor = System.Drawing.Color.LimeGreen;
            this.pitchPictureBox.Location = new System.Drawing.Point(16, 41);
            this.pitchPictureBox.Name = "pitchPictureBox";
            this.pitchPictureBox.Size = new System.Drawing.Size(450, 550);
            this.pitchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pitchPictureBox.TabIndex = 3;
            this.pitchPictureBox.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.fastForwardBtn);
            this.groupBox4.Controls.Add(this.pauseBtn);
            this.groupBox4.Controls.Add(this.playBtn);
            this.groupBox4.Controls.Add(this.rewindBtn);
            this.groupBox4.Location = new System.Drawing.Point(87, 589);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(281, 82);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // fastForwardBtn
            // 
            this.fastForwardBtn.Location = new System.Drawing.Point(200, 22);
            this.fastForwardBtn.Name = "fastForwardBtn";
            this.fastForwardBtn.Size = new System.Drawing.Size(55, 50);
            this.fastForwardBtn.TabIndex = 4;
            this.fastForwardBtn.Text = ">>";
            this.fastForwardBtn.UseVisualStyleBackColor = true;
            this.fastForwardBtn.Click += new System.EventHandler(this.fastForwardBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(88, 22);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(50, 50);
            this.pauseBtn.TabIndex = 3;
            this.pauseBtn.Text = "II";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(144, 22);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(50, 50);
            this.playBtn.TabIndex = 4;
            this.playBtn.Text = ">";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // rewindBtn
            // 
            this.rewindBtn.Location = new System.Drawing.Point(27, 22);
            this.rewindBtn.Name = "rewindBtn";
            this.rewindBtn.Size = new System.Drawing.Size(55, 50);
            this.rewindBtn.TabIndex = 3;
            this.rewindBtn.Text = "<<";
            this.rewindBtn.UseVisualStyleBackColor = true;
            this.rewindBtn.Click += new System.EventHandler(this.rewindBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sprintsLbl);
            this.groupBox2.Controls.Add(this.paceLbl);
            this.groupBox2.Controls.Add(this.distanceLbl);
            this.groupBox2.Controls.Add(this.breakdownChart);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(522, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 519);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stats";
            // 
            // sprintsLbl
            // 
            this.sprintsLbl.AutoSize = true;
            this.sprintsLbl.Location = new System.Drawing.Point(169, 174);
            this.sprintsLbl.Name = "sprintsLbl";
            this.sprintsLbl.Size = new System.Drawing.Size(19, 25);
            this.sprintsLbl.TabIndex = 8;
            this.sprintsLbl.Text = "-";
            // 
            // paceLbl
            // 
            this.paceLbl.AutoSize = true;
            this.paceLbl.Location = new System.Drawing.Point(169, 128);
            this.paceLbl.Name = "paceLbl";
            this.paceLbl.Size = new System.Drawing.Size(19, 25);
            this.paceLbl.TabIndex = 7;
            this.paceLbl.Text = "-";
            // 
            // distanceLbl
            // 
            this.distanceLbl.AutoSize = true;
            this.distanceLbl.Location = new System.Drawing.Point(169, 79);
            this.distanceLbl.Name = "distanceLbl";
            this.distanceLbl.Size = new System.Drawing.Size(19, 25);
            this.distanceLbl.TabIndex = 6;
            this.distanceLbl.Text = "-";
            // 
            // breakdownChart
            // 
            this.breakdownChart.BackColor = System.Drawing.Color.Transparent;
            this.breakdownChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.breakdownChart.BackImageTransparentColor = System.Drawing.SystemColors.ControlLight;
            this.breakdownChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.breakdownChart.ChartAreas.Add(chartArea1);
            this.breakdownChart.Location = new System.Drawing.Point(0, 271);
            this.breakdownChart.Name = "breakdownChart";
            this.breakdownChart.Size = new System.Drawing.Size(556, 240);
            this.breakdownChart.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(159, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "5 Minute Breakdown";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sprints";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Avg. Pace";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Distance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Overview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.playerCombo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateCombo);
            this.groupBox1.Location = new System.Drawing.Point(522, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 153);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Player";
            // 
            // playerCombo
            // 
            this.playerCombo.FormattingEnabled = true;
            this.playerCombo.Location = new System.Drawing.Point(169, 41);
            this.playerCombo.Name = "playerCombo";
            this.playerCombo.Size = new System.Drawing.Size(245, 33);
            this.playerCombo.TabIndex = 1;
            this.playerCombo.SelectedIndexChanged += new System.EventHandler(this.PlayerComboIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Date";
            // 
            // dateCombo
            // 
            this.dateCombo.FormattingEnabled = true;
            this.dateCombo.Location = new System.Drawing.Point(169, 95);
            this.dateCombo.Name = "dateCombo";
            this.dateCombo.Size = new System.Drawing.Size(245, 33);
            this.dateCombo.TabIndex = 2;
            this.dateCombo.SelectedIndexChanged += new System.EventHandler(this.DateComboIndexChanged);
            // 
            // movementTimer
            // 
            this.movementTimer.Tick += new System.EventHandler(this.movementTimer_Tick);
            // 
            // PlayerStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1133, 761);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PlayerStatsForm";
            this.Text = "TrackFit - Player Statistics";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pitchPictureBox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breakdownChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button rewindBtn;
        private System.Windows.Forms.PictureBox pitchPictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label sprintsLbl;
        private System.Windows.Forms.Label paceLbl;
        private System.Windows.Forms.Label distanceLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart breakdownChart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox playerCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dateCombo;
        private System.Windows.Forms.Timer movementTimer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button fastForwardBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Label speedLbl;
        private System.Windows.Forms.Label timeLbl;
    }
}
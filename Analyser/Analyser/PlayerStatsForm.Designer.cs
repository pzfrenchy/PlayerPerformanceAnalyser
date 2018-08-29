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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerStatsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.effortZonesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.zoneToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effortZonesChart)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pitchPictureBox)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breakdownChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.effortZonesChart);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(11, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 1014);
            this.panel1.TabIndex = 4;
            // 
            // effortZonesChart
            // 
            this.effortZonesChart.BackColor = System.Drawing.Color.Transparent;
            this.effortZonesChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.effortZonesChart.BackImageTransparentColor = System.Drawing.SystemColors.ControlLight;
            this.effortZonesChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.effortZonesChart.ChartAreas.Add(chartArea1);
            this.effortZonesChart.Location = new System.Drawing.Point(511, 709);
            this.effortZonesChart.Name = "effortZonesChart";
            this.effortZonesChart.Size = new System.Drawing.Size(498, 230);
            this.effortZonesChart.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.speedLbl);
            this.groupBox3.Controls.Add(this.timeLbl);
            this.groupBox3.Controls.Add(this.pitchPictureBox);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(21, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 652);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Position";
            // 
            // speedLbl
            // 
            this.speedLbl.AutoSize = true;
            this.speedLbl.Location = new System.Drawing.Point(364, 599);
            this.speedLbl.Name = "speedLbl";
            this.speedLbl.Size = new System.Drawing.Size(74, 25);
            this.speedLbl.TabIndex = 6;
            this.speedLbl.Text = "Normal";
            this.speedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.BackColor = System.Drawing.Color.LimeGreen;
            this.timeLbl.Location = new System.Drawing.Point(21, 539);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(51, 25);
            this.timeLbl.TabIndex = 5;
            this.timeLbl.Text = "0:00";
            // 
            // pitchPictureBox
            // 
            this.pitchPictureBox.BackColor = System.Drawing.Color.LimeGreen;
            this.pitchPictureBox.Location = new System.Drawing.Point(15, 39);
            this.pitchPictureBox.Name = "pitchPictureBox";
            this.pitchPictureBox.Size = new System.Drawing.Size(431, 528);
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
            this.groupBox4.Location = new System.Drawing.Point(90, 565);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 79);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // fastForwardBtn
            // 
            this.fastForwardBtn.Location = new System.Drawing.Point(183, 21);
            this.fastForwardBtn.Name = "fastForwardBtn";
            this.fastForwardBtn.Size = new System.Drawing.Size(50, 48);
            this.fastForwardBtn.TabIndex = 4;
            this.fastForwardBtn.Text = ">>";
            this.fastForwardBtn.UseVisualStyleBackColor = true;
            this.fastForwardBtn.Click += new System.EventHandler(this.fastForwardBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(81, 21);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(46, 48);
            this.pauseBtn.TabIndex = 3;
            this.pauseBtn.Text = "II";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(132, 21);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(46, 48);
            this.playBtn.TabIndex = 4;
            this.playBtn.Text = ">";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // rewindBtn
            // 
            this.rewindBtn.Location = new System.Drawing.Point(25, 21);
            this.rewindBtn.Name = "rewindBtn";
            this.rewindBtn.Size = new System.Drawing.Size(50, 48);
            this.rewindBtn.TabIndex = 3;
            this.rewindBtn.Text = "<<";
            this.rewindBtn.UseVisualStyleBackColor = true;
            this.rewindBtn.Click += new System.EventHandler(this.rewindBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.sprintsLbl);
            this.groupBox2.Controls.Add(this.paceLbl);
            this.groupBox2.Controls.Add(this.distanceLbl);
            this.groupBox2.Controls.Add(this.breakdownChart);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(505, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 806);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stats";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(217, 757);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Zones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(194, 502);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Effort Zones";
            // 
            // sprintsLbl
            // 
            this.sprintsLbl.AutoSize = true;
            this.sprintsLbl.Location = new System.Drawing.Point(155, 167);
            this.sprintsLbl.Name = "sprintsLbl";
            this.sprintsLbl.Size = new System.Drawing.Size(19, 25);
            this.sprintsLbl.TabIndex = 8;
            this.sprintsLbl.Text = "-";
            // 
            // paceLbl
            // 
            this.paceLbl.AutoSize = true;
            this.paceLbl.Location = new System.Drawing.Point(155, 123);
            this.paceLbl.Name = "paceLbl";
            this.paceLbl.Size = new System.Drawing.Size(19, 25);
            this.paceLbl.TabIndex = 7;
            this.paceLbl.Text = "-";
            // 
            // distanceLbl
            // 
            this.distanceLbl.AutoSize = true;
            this.distanceLbl.Location = new System.Drawing.Point(155, 76);
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
            chartArea2.Name = "ChartArea1";
            this.breakdownChart.ChartAreas.Add(chartArea2);
            this.breakdownChart.Location = new System.Drawing.Point(6, 260);
            this.breakdownChart.Name = "breakdownChart";
            this.breakdownChart.Size = new System.Drawing.Size(498, 230);
            this.breakdownChart.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(158, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "5 Minute Breakdown";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sprints";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Avg. Pace";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Distance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Overview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.playerCombo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateCombo);
            this.groupBox1.Location = new System.Drawing.Point(505, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 147);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Player";
            // 
            // playerCombo
            // 
            this.playerCombo.FormattingEnabled = true;
            this.playerCombo.Location = new System.Drawing.Point(155, 39);
            this.playerCombo.Name = "playerCombo";
            this.playerCombo.Size = new System.Drawing.Size(225, 32);
            this.playerCombo.TabIndex = 1;
            this.playerCombo.SelectedIndexChanged += new System.EventHandler(this.PlayerComboIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Date";
            // 
            // dateCombo
            // 
            this.dateCombo.FormattingEnabled = true;
            this.dateCombo.Location = new System.Drawing.Point(155, 91);
            this.dateCombo.Name = "dateCombo";
            this.dateCombo.Size = new System.Drawing.Size(225, 32);
            this.dateCombo.TabIndex = 2;
            this.dateCombo.SelectedIndexChanged += new System.EventHandler(this.DateComboIndexChanged);
            // 
            // movementTimer
            // 
            this.movementTimer.Tick += new System.EventHandler(this.movementTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1061, 38);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(56, 34);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(154, 34);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(154, 34);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(117, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 38);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog1";
            this.printPreviewDialog.Visible = false;
            // 
            // zoneToolTip
            // 
            this.zoneToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Freestyle Script", 27.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 826);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(469, 78);
            this.label10.TabIndex = 10;
            this.label10.Text = "Great work, keep it up!";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(79, 714);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(343, 96);
            this.label11.TabIndex = 11;
            this.label11.Text = "TrackFit";
            // 
            // PlayerStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1061, 1076);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PlayerStatsForm";
            this.Text = "TrackFit - Player Statistics";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effortZonesChart)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pitchPictureBox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breakdownChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.DataVisualization.Charting.Chart effortZonesChart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip zoneToolTip;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}
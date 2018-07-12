namespace Analyser
{
    partial class AdminForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.playerTab = new System.Windows.Forms.TabPage();
            this.registerPlayerBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.playersLstBox = new System.Windows.Forms.ListBox();
            this.dobDtp = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.forenameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pitchTab = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.pitchWLonTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pitchSLonTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pitchELonTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pitchNLonTxt = new System.Windows.Forms.TextBox();
            this.pitchLstBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pitchWLatTxt = new System.Windows.Forms.TextBox();
            this.pitchSLatTxt = new System.Windows.Forms.TextBox();
            this.pitchELatTxt = new System.Windows.Forms.TextBox();
            this.pitchNLatTxt = new System.Windows.Forms.TextBox();
            this.pitchNameTxt = new System.Windows.Forms.TextBox();
            this.createPitchBtn = new System.Windows.Forms.Button();
            this.opponentTab = new System.Windows.Forms.TabPage();
            this.oppLstBox = new System.Windows.Forms.ListBox();
            this.oppNameTxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.createOppBtn = new System.Windows.Forms.Button();
            this.matchTab = new System.Windows.Forms.TabPage();
            this.matchLstBox = new System.Windows.Forms.ListBox();
            this.createMatchBtn = new System.Windows.Forms.Button();
            this.selectPitchCombo = new System.Windows.Forms.ComboBox();
            this.selectOppCombo = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.matchDtp = new System.Windows.Forms.DateTimePicker();
            this.lineupTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removeLineupItemBtn = new System.Windows.Forms.Button();
            this.lineupPlayersLstBox = new System.Windows.Forms.ListBox();
            this.selectPositionCombo = new System.Windows.Forms.ComboBox();
            this.selectPlayerCombo = new System.Windows.Forms.ComboBox();
            this.addPlayerToLineupBtn = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.matchSearchCombo = new System.Windows.Forms.ComboBox();
            this.matchSearchTxt = new System.Windows.Forms.TextBox();
            this.matchSearchResultsLstBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.playerTab.SuspendLayout();
            this.pitchTab.SuspendLayout();
            this.opponentTab.SuspendLayout();
            this.matchTab.SuspendLayout();
            this.lineupTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.playerTab);
            this.tabControl1.Controls.Add(this.pitchTab);
            this.tabControl1.Controls.Add(this.opponentTab);
            this.tabControl1.Controls.Add(this.matchTab);
            this.tabControl1.Controls.Add(this.lineupTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1029, 759);
            this.tabControl1.TabIndex = 9;
            // 
            // playerTab
            // 
            this.playerTab.BackColor = System.Drawing.Color.Transparent;
            this.playerTab.Controls.Add(this.registerPlayerBtn);
            this.playerTab.Controls.Add(this.label2);
            this.playerTab.Controls.Add(this.playersLstBox);
            this.playerTab.Controls.Add(this.dobDtp);
            this.playerTab.Controls.Add(this.label5);
            this.playerTab.Controls.Add(this.surnameTxt);
            this.playerTab.Controls.Add(this.label4);
            this.playerTab.Controls.Add(this.forenameTxt);
            this.playerTab.Controls.Add(this.label3);
            this.playerTab.Location = new System.Drawing.Point(8, 39);
            this.playerTab.Name = "playerTab";
            this.playerTab.Padding = new System.Windows.Forms.Padding(3);
            this.playerTab.Size = new System.Drawing.Size(1013, 712);
            this.playerTab.TabIndex = 0;
            this.playerTab.Text = "Player Details";
            // 
            // registerPlayerBtn
            // 
            this.registerPlayerBtn.Location = new System.Drawing.Point(133, 227);
            this.registerPlayerBtn.Name = "registerPlayerBtn";
            this.registerPlayerBtn.Size = new System.Drawing.Size(115, 48);
            this.registerPlayerBtn.TabIndex = 9;
            this.registerPlayerBtn.Text = "Register";
            this.registerPlayerBtn.UseVisualStyleBackColor = true;
            this.registerPlayerBtn.Click += new System.EventHandler(this.registerPlayerBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Registered Players";
            // 
            // playersLstBox
            // 
            this.playersLstBox.FormattingEnabled = true;
            this.playersLstBox.ItemHeight = 25;
            this.playersLstBox.Location = new System.Drawing.Point(412, 68);
            this.playersLstBox.Name = "playersLstBox";
            this.playersLstBox.Size = new System.Drawing.Size(410, 454);
            this.playersLstBox.TabIndex = 7;
            // 
            // dobDtp
            // 
            this.dobDtp.Location = new System.Drawing.Point(148, 162);
            this.dobDtp.Name = "dobDtp";
            this.dobDtp.Size = new System.Drawing.Size(240, 31);
            this.dobDtp.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "DOB";
            // 
            // surnameTxt
            // 
            this.surnameTxt.Location = new System.Drawing.Point(148, 113);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(240, 31);
            this.surnameTxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Surname";
            // 
            // forenameTxt
            // 
            this.forenameTxt.Location = new System.Drawing.Point(148, 68);
            this.forenameTxt.Name = "forenameTxt";
            this.forenameTxt.Size = new System.Drawing.Size(240, 31);
            this.forenameTxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Forename";
            // 
            // pitchTab
            // 
            this.pitchTab.BackColor = System.Drawing.Color.Transparent;
            this.pitchTab.Controls.Add(this.label13);
            this.pitchTab.Controls.Add(this.pitchWLonTxt);
            this.pitchTab.Controls.Add(this.label12);
            this.pitchTab.Controls.Add(this.pitchSLonTxt);
            this.pitchTab.Controls.Add(this.label11);
            this.pitchTab.Controls.Add(this.pitchELonTxt);
            this.pitchTab.Controls.Add(this.label10);
            this.pitchTab.Controls.Add(this.pitchNLonTxt);
            this.pitchTab.Controls.Add(this.pitchLstBox);
            this.pitchTab.Controls.Add(this.label9);
            this.pitchTab.Controls.Add(this.label8);
            this.pitchTab.Controls.Add(this.label7);
            this.pitchTab.Controls.Add(this.label6);
            this.pitchTab.Controls.Add(this.label1);
            this.pitchTab.Controls.Add(this.pitchWLatTxt);
            this.pitchTab.Controls.Add(this.pitchSLatTxt);
            this.pitchTab.Controls.Add(this.pitchELatTxt);
            this.pitchTab.Controls.Add(this.pitchNLatTxt);
            this.pitchTab.Controls.Add(this.pitchNameTxt);
            this.pitchTab.Controls.Add(this.createPitchBtn);
            this.pitchTab.Location = new System.Drawing.Point(8, 39);
            this.pitchTab.Name = "pitchTab";
            this.pitchTab.Size = new System.Drawing.Size(1013, 712);
            this.pitchTab.TabIndex = 2;
            this.pitchTab.Text = "Create Pitch";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 450);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 25);
            this.label13.TabIndex = 19;
            this.label13.Text = "West Point Lon";
            // 
            // pitchWLonTxt
            // 
            this.pitchWLonTxt.Location = new System.Drawing.Point(270, 444);
            this.pitchWLonTxt.Name = "pitchWLonTxt";
            this.pitchWLonTxt.Size = new System.Drawing.Size(100, 31);
            this.pitchWLonTxt.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 364);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "South Point Lon";
            // 
            // pitchSLonTxt
            // 
            this.pitchSLonTxt.Location = new System.Drawing.Point(270, 358);
            this.pitchSLonTxt.Name = "pitchSLonTxt";
            this.pitchSLonTxt.Size = new System.Drawing.Size(100, 31);
            this.pitchSLonTxt.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "East Point Lon";
            // 
            // pitchELonTxt
            // 
            this.pitchELonTxt.Location = new System.Drawing.Point(270, 263);
            this.pitchELonTxt.Name = "pitchELonTxt";
            this.pitchELonTxt.Size = new System.Drawing.Size(100, 31);
            this.pitchELonTxt.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "North Point Lon";
            // 
            // pitchNLonTxt
            // 
            this.pitchNLonTxt.Location = new System.Drawing.Point(270, 169);
            this.pitchNLonTxt.Name = "pitchNLonTxt";
            this.pitchNLonTxt.Size = new System.Drawing.Size(100, 31);
            this.pitchNLonTxt.TabIndex = 12;
            // 
            // pitchLstBox
            // 
            this.pitchLstBox.FormattingEnabled = true;
            this.pitchLstBox.ItemHeight = 25;
            this.pitchLstBox.Location = new System.Drawing.Point(413, 85);
            this.pitchLstBox.Name = "pitchLstBox";
            this.pitchLstBox.Size = new System.Drawing.Size(377, 404);
            this.pitchLstBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "West Point Lat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "South Point Lat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "East Point Lat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "North Point Lat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pitch Name";
            // 
            // pitchWLatTxt
            // 
            this.pitchWLatTxt.Location = new System.Drawing.Point(270, 407);
            this.pitchWLatTxt.Name = "pitchWLatTxt";
            this.pitchWLatTxt.Size = new System.Drawing.Size(100, 31);
            this.pitchWLatTxt.TabIndex = 5;
            // 
            // pitchSLatTxt
            // 
            this.pitchSLatTxt.Location = new System.Drawing.Point(270, 321);
            this.pitchSLatTxt.Name = "pitchSLatTxt";
            this.pitchSLatTxt.Size = new System.Drawing.Size(100, 31);
            this.pitchSLatTxt.TabIndex = 4;
            // 
            // pitchELatTxt
            // 
            this.pitchELatTxt.Location = new System.Drawing.Point(270, 226);
            this.pitchELatTxt.Name = "pitchELatTxt";
            this.pitchELatTxt.Size = new System.Drawing.Size(100, 31);
            this.pitchELatTxt.TabIndex = 3;
            // 
            // pitchNLatTxt
            // 
            this.pitchNLatTxt.Location = new System.Drawing.Point(270, 132);
            this.pitchNLatTxt.Name = "pitchNLatTxt";
            this.pitchNLatTxt.Size = new System.Drawing.Size(100, 31);
            this.pitchNLatTxt.TabIndex = 2;
            // 
            // pitchNameTxt
            // 
            this.pitchNameTxt.Location = new System.Drawing.Point(270, 85);
            this.pitchNameTxt.Name = "pitchNameTxt";
            this.pitchNameTxt.Size = new System.Drawing.Size(100, 31);
            this.pitchNameTxt.TabIndex = 1;
            // 
            // createPitchBtn
            // 
            this.createPitchBtn.Location = new System.Drawing.Point(119, 512);
            this.createPitchBtn.Name = "createPitchBtn";
            this.createPitchBtn.Size = new System.Drawing.Size(139, 51);
            this.createPitchBtn.TabIndex = 0;
            this.createPitchBtn.Text = "Create Pitch";
            this.createPitchBtn.UseVisualStyleBackColor = true;
            this.createPitchBtn.Click += new System.EventHandler(this.createPitchBtn_Click);
            // 
            // opponentTab
            // 
            this.opponentTab.BackColor = System.Drawing.Color.Transparent;
            this.opponentTab.Controls.Add(this.oppLstBox);
            this.opponentTab.Controls.Add(this.oppNameTxt);
            this.opponentTab.Controls.Add(this.label14);
            this.opponentTab.Controls.Add(this.createOppBtn);
            this.opponentTab.Location = new System.Drawing.Point(8, 39);
            this.opponentTab.Name = "opponentTab";
            this.opponentTab.Padding = new System.Windows.Forms.Padding(3);
            this.opponentTab.Size = new System.Drawing.Size(1013, 712);
            this.opponentTab.TabIndex = 1;
            this.opponentTab.Text = "Create Opponents";
            // 
            // oppLstBox
            // 
            this.oppLstBox.FormattingEnabled = true;
            this.oppLstBox.ItemHeight = 25;
            this.oppLstBox.Location = new System.Drawing.Point(388, 87);
            this.oppLstBox.Name = "oppLstBox";
            this.oppLstBox.Size = new System.Drawing.Size(393, 404);
            this.oppLstBox.TabIndex = 3;
            // 
            // oppNameTxt
            // 
            this.oppNameTxt.Location = new System.Drawing.Point(239, 92);
            this.oppNameTxt.Name = "oppNameTxt";
            this.oppNameTxt.Size = new System.Drawing.Size(100, 31);
            this.oppNameTxt.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(65, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 25);
            this.label14.TabIndex = 1;
            this.label14.Text = "Opponent Name";
            // 
            // createOppBtn
            // 
            this.createOppBtn.Location = new System.Drawing.Point(99, 152);
            this.createOppBtn.Name = "createOppBtn";
            this.createOppBtn.Size = new System.Drawing.Size(204, 54);
            this.createOppBtn.TabIndex = 0;
            this.createOppBtn.Text = "Create Opponent";
            this.createOppBtn.UseVisualStyleBackColor = true;
            this.createOppBtn.Click += new System.EventHandler(this.createOppBtn_Click);
            // 
            // matchTab
            // 
            this.matchTab.BackColor = System.Drawing.Color.Transparent;
            this.matchTab.Controls.Add(this.matchLstBox);
            this.matchTab.Controls.Add(this.createMatchBtn);
            this.matchTab.Controls.Add(this.selectPitchCombo);
            this.matchTab.Controls.Add(this.selectOppCombo);
            this.matchTab.Controls.Add(this.label17);
            this.matchTab.Controls.Add(this.label16);
            this.matchTab.Controls.Add(this.label15);
            this.matchTab.Controls.Add(this.matchDtp);
            this.matchTab.Location = new System.Drawing.Point(8, 39);
            this.matchTab.Name = "matchTab";
            this.matchTab.Size = new System.Drawing.Size(1013, 712);
            this.matchTab.TabIndex = 3;
            this.matchTab.Text = "Create Match";
            // 
            // matchLstBox
            // 
            this.matchLstBox.FormattingEnabled = true;
            this.matchLstBox.ItemHeight = 25;
            this.matchLstBox.Location = new System.Drawing.Point(464, 63);
            this.matchLstBox.Name = "matchLstBox";
            this.matchLstBox.Size = new System.Drawing.Size(360, 454);
            this.matchLstBox.TabIndex = 7;
            // 
            // createMatchBtn
            // 
            this.createMatchBtn.Location = new System.Drawing.Point(144, 248);
            this.createMatchBtn.Name = "createMatchBtn";
            this.createMatchBtn.Size = new System.Drawing.Size(160, 57);
            this.createMatchBtn.TabIndex = 6;
            this.createMatchBtn.Text = "Create Match";
            this.createMatchBtn.UseVisualStyleBackColor = true;
            this.createMatchBtn.Click += new System.EventHandler(this.createMatchBtn_Click);
            // 
            // selectPitchCombo
            // 
            this.selectPitchCombo.FormattingEnabled = true;
            this.selectPitchCombo.Location = new System.Drawing.Point(198, 165);
            this.selectPitchCombo.Name = "selectPitchCombo";
            this.selectPitchCombo.Size = new System.Drawing.Size(200, 33);
            this.selectPitchCombo.TabIndex = 5;
            this.selectPitchCombo.Click += new System.EventHandler(this.selectPitchComboClick);
            // 
            // selectOppCombo
            // 
            this.selectOppCombo.FormattingEnabled = true;
            this.selectOppCombo.Location = new System.Drawing.Point(198, 115);
            this.selectOppCombo.Name = "selectOppCombo";
            this.selectOppCombo.Size = new System.Drawing.Size(200, 33);
            this.selectOppCombo.TabIndex = 4;
            this.selectOppCombo.Click += new System.EventHandler(this.selectOppComboClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(66, 173);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 25);
            this.label17.TabIndex = 3;
            this.label17.Text = "Select Pitch";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(172, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "Select Opponent";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(62, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 25);
            this.label15.TabIndex = 1;
            this.label15.Text = "Select Date";
            // 
            // matchDtp
            // 
            this.matchDtp.Location = new System.Drawing.Point(198, 63);
            this.matchDtp.Name = "matchDtp";
            this.matchDtp.Size = new System.Drawing.Size(200, 31);
            this.matchDtp.TabIndex = 0;
            // 
            // lineupTab
            // 
            this.lineupTab.BackColor = System.Drawing.Color.Transparent;
            this.lineupTab.Controls.Add(this.groupBox2);
            this.lineupTab.Controls.Add(this.groupBox1);
            this.lineupTab.Location = new System.Drawing.Point(8, 39);
            this.lineupTab.Name = "lineupTab";
            this.lineupTab.Size = new System.Drawing.Size(1013, 712);
            this.lineupTab.TabIndex = 5;
            this.lineupTab.Text = "Create Lineup";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removeLineupItemBtn);
            this.groupBox2.Controls.Add(this.lineupPlayersLstBox);
            this.groupBox2.Controls.Add(this.selectPositionCombo);
            this.groupBox2.Controls.Add(this.selectPlayerCombo);
            this.groupBox2.Controls.Add(this.addPlayerToLineupBtn);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Location = new System.Drawing.Point(15, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(983, 403);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Players";
            // 
            // removeLineupItemBtn
            // 
            this.removeLineupItemBtn.Location = new System.Drawing.Point(82, 284);
            this.removeLineupItemBtn.Name = "removeLineupItemBtn";
            this.removeLineupItemBtn.Size = new System.Drawing.Size(123, 60);
            this.removeLineupItemBtn.TabIndex = 6;
            this.removeLineupItemBtn.Text = "Remove";
            this.removeLineupItemBtn.UseVisualStyleBackColor = true;
            this.removeLineupItemBtn.Click += new System.EventHandler(this.removeLineupItemBtn_Click);
            // 
            // lineupPlayersLstBox
            // 
            this.lineupPlayersLstBox.FormattingEnabled = true;
            this.lineupPlayersLstBox.ItemHeight = 25;
            this.lineupPlayersLstBox.Location = new System.Drawing.Point(315, 31);
            this.lineupPlayersLstBox.Name = "lineupPlayersLstBox";
            this.lineupPlayersLstBox.Size = new System.Drawing.Size(652, 354);
            this.lineupPlayersLstBox.TabIndex = 5;
            // 
            // selectPositionCombo
            // 
            this.selectPositionCombo.FormattingEnabled = true;
            this.selectPositionCombo.Location = new System.Drawing.Point(23, 156);
            this.selectPositionCombo.Name = "selectPositionCombo";
            this.selectPositionCombo.Size = new System.Drawing.Size(267, 33);
            this.selectPositionCombo.TabIndex = 4;
            this.selectPositionCombo.Click += new System.EventHandler(this.selectPositionComboClick);
            // 
            // selectPlayerCombo
            // 
            this.selectPlayerCombo.FormattingEnabled = true;
            this.selectPlayerCombo.Location = new System.Drawing.Point(23, 79);
            this.selectPlayerCombo.Name = "selectPlayerCombo";
            this.selectPlayerCombo.Size = new System.Drawing.Size(267, 33);
            this.selectPlayerCombo.TabIndex = 3;
            this.selectPlayerCombo.Click += new System.EventHandler(this.selectPlayerComboClick);
            // 
            // addPlayerToLineupBtn
            // 
            this.addPlayerToLineupBtn.Location = new System.Drawing.Point(82, 221);
            this.addPlayerToLineupBtn.Name = "addPlayerToLineupBtn";
            this.addPlayerToLineupBtn.Size = new System.Drawing.Size(123, 48);
            this.addPlayerToLineupBtn.TabIndex = 2;
            this.addPlayerToLineupBtn.Text = "Add";
            this.addPlayerToLineupBtn.UseVisualStyleBackColor = true;
            this.addPlayerToLineupBtn.Click += new System.EventHandler(this.addPlayerToLineupBtn_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 127);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 25);
            this.label22.TabIndex = 1;
            this.label22.Text = "Position";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 25);
            this.label21.TabIndex = 0;
            this.label21.Text = "Player";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.matchSearchCombo);
            this.groupBox1.Controls.Add(this.matchSearchTxt);
            this.groupBox1.Controls.Add(this.matchSearchResultsLstBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Match Search";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(24, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(155, 25);
            this.label20.TabIndex = 3;
            this.label20.Text = "Search Criteria";
            // 
            // matchSearchCombo
            // 
            this.matchSearchCombo.FormattingEnabled = true;
            this.matchSearchCombo.Items.AddRange(new object[] {
            "ID",
            "Date",
            "Opposition"});
            this.matchSearchCombo.Location = new System.Drawing.Point(23, 95);
            this.matchSearchCombo.Name = "matchSearchCombo";
            this.matchSearchCombo.Size = new System.Drawing.Size(225, 33);
            this.matchSearchCombo.TabIndex = 2;
            this.matchSearchCombo.Text = "ID";
            // 
            // matchSearchTxt
            // 
            this.matchSearchTxt.Location = new System.Drawing.Point(23, 134);
            this.matchSearchTxt.Name = "matchSearchTxt";
            this.matchSearchTxt.Size = new System.Drawing.Size(225, 31);
            this.matchSearchTxt.TabIndex = 1;
            this.matchSearchTxt.TextChanged += new System.EventHandler(this.lineupSearchTxtChanged);
            // 
            // matchSearchResultsLstBox
            // 
            this.matchSearchResultsLstBox.FormattingEnabled = true;
            this.matchSearchResultsLstBox.ItemHeight = 25;
            this.matchSearchResultsLstBox.Location = new System.Drawing.Point(315, 55);
            this.matchSearchResultsLstBox.Name = "matchSearchResultsLstBox";
            this.matchSearchResultsLstBox.Size = new System.Drawing.Size(652, 179);
            this.matchSearchResultsLstBox.TabIndex = 0;
            this.matchSearchResultsLstBox.SelectedIndexChanged += new System.EventHandler(this.matchSearchLstBoxIndexChanged);
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 788);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminScreen";
            this.Text = "Admin Screen";
            this.tabControl1.ResumeLayout(false);
            this.playerTab.ResumeLayout(false);
            this.playerTab.PerformLayout();
            this.pitchTab.ResumeLayout(false);
            this.pitchTab.PerformLayout();
            this.opponentTab.ResumeLayout(false);
            this.opponentTab.PerformLayout();
            this.matchTab.ResumeLayout(false);
            this.matchTab.PerformLayout();
            this.lineupTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage playerTab;
        private System.Windows.Forms.TabPage opponentTab;
        private System.Windows.Forms.DateTimePicker dobDtp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox forenameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerPlayerBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox playersLstBox;
        private System.Windows.Forms.TabPage pitchTab;
        private System.Windows.Forms.TabPage matchTab;
        private System.Windows.Forms.ListBox pitchLstBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pitchWLatTxt;
        private System.Windows.Forms.TextBox pitchSLatTxt;
        private System.Windows.Forms.TextBox pitchELatTxt;
        private System.Windows.Forms.TextBox pitchNLatTxt;
        private System.Windows.Forms.TextBox pitchNameTxt;
        private System.Windows.Forms.Button createPitchBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox pitchWLonTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox pitchSLonTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox pitchELonTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pitchNLonTxt;
        private System.Windows.Forms.TextBox oppNameTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button createOppBtn;
        private System.Windows.Forms.ListBox oppLstBox;
        private System.Windows.Forms.ComboBox selectPitchCombo;
        private System.Windows.Forms.ComboBox selectOppCombo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker matchDtp;
        private System.Windows.Forms.ListBox matchLstBox;
        private System.Windows.Forms.Button createMatchBtn;
        private System.Windows.Forms.TabPage lineupTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox matchSearchCombo;
        private System.Windows.Forms.TextBox matchSearchTxt;
        private System.Windows.Forms.ListBox matchSearchResultsLstBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button removeLineupItemBtn;
        private System.Windows.Forms.ListBox lineupPlayersLstBox;
        private System.Windows.Forms.ComboBox selectPositionCombo;
        private System.Windows.Forms.ComboBox selectPlayerCombo;
        private System.Windows.Forms.Button addPlayerToLineupBtn;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
    }
}


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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.updateOppBtn = new System.Windows.Forms.Button();
            this.oppLstBox = new System.Windows.Forms.ListBox();
            this.oppNameTxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.createOppBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.updatePitchBtn = new System.Windows.Forms.Button();
            this.pitchLstBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pitchNameTxt = new System.Windows.Forms.TextBox();
            this.createPitchBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.playersLstBox = new System.Windows.Forms.ListBox();
            this.updatePlayerBtn = new System.Windows.Forms.Button();
            this.forenameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registerPlayerBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dobDtp = new System.Windows.Forms.DateTimePicker();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.matchTab = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateGameBtn = new System.Windows.Forms.Button();
            this.createGameBtn = new System.Windows.Forms.Button();
            this.gameLstBox = new System.Windows.Forms.ListBox();
            this.gameDtp = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.gamePitchCombo = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.gameOppCombo = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lineupTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removeLineupItemBtn = new System.Windows.Forms.Button();
            this.lineupPlayersLstBox = new System.Windows.Forms.ListBox();
            this.lineupPositionCombo = new System.Windows.Forms.ComboBox();
            this.lineupPlayerCombo = new System.Windows.Forms.ComboBox();
            this.addPlayerToLineupBtn = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lineupGameSearchCombo = new System.Windows.Forms.ComboBox();
            this.lineupGameSearchTxt = new System.Windows.Forms.TextBox();
            this.lineupSearchResultsLstBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.playerTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.matchTab.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.lineupTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.playerTab);
            this.tabControl1.Controls.Add(this.matchTab);
            this.tabControl1.Controls.Add(this.lineupTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1030, 875);
            this.tabControl1.TabIndex = 9;
            // 
            // playerTab
            // 
            this.playerTab.BackColor = System.Drawing.Color.White;
            this.playerTab.Controls.Add(this.groupBox3);
            this.playerTab.Controls.Add(this.groupBox5);
            this.playerTab.Controls.Add(this.groupBox4);
            this.playerTab.Location = new System.Drawing.Point(8, 39);
            this.playerTab.Name = "playerTab";
            this.playerTab.Padding = new System.Windows.Forms.Padding(3);
            this.playerTab.Size = new System.Drawing.Size(1014, 828);
            this.playerTab.TabIndex = 0;
            this.playerTab.Text = "Admin";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.updateOppBtn);
            this.groupBox3.Controls.Add(this.oppLstBox);
            this.groupBox3.Controls.Add(this.oppNameTxt);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.createOppBtn);
            this.groupBox3.Location = new System.Drawing.Point(22, 552);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(975, 261);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opponent Details";
            // 
            // updateOppBtn
            // 
            this.updateOppBtn.Location = new System.Drawing.Point(219, 186);
            this.updateOppBtn.Name = "updateOppBtn";
            this.updateOppBtn.Size = new System.Drawing.Size(115, 48);
            this.updateOppBtn.TabIndex = 8;
            this.updateOppBtn.Text = "Update";
            this.updateOppBtn.UseVisualStyleBackColor = true;
            this.updateOppBtn.Click += new System.EventHandler(this.updateOppBtn_Click);
            // 
            // oppLstBox
            // 
            this.oppLstBox.FormattingEnabled = true;
            this.oppLstBox.ItemHeight = 25;
            this.oppLstBox.Location = new System.Drawing.Point(496, 30);
            this.oppLstBox.Name = "oppLstBox";
            this.oppLstBox.Size = new System.Drawing.Size(457, 204);
            this.oppLstBox.TabIndex = 7;
            this.oppLstBox.SelectedIndexChanged += new System.EventHandler(this.oppLstBox_SelectedIndexChanged);
            // 
            // oppNameTxt
            // 
            this.oppNameTxt.Location = new System.Drawing.Point(151, 44);
            this.oppNameTxt.Name = "oppNameTxt";
            this.oppNameTxt.Size = new System.Drawing.Size(240, 31);
            this.oppNameTxt.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 25);
            this.label14.TabIndex = 5;
            this.label14.Text = "Name";
            // 
            // createOppBtn
            // 
            this.createOppBtn.Location = new System.Drawing.Point(75, 189);
            this.createOppBtn.Name = "createOppBtn";
            this.createOppBtn.Size = new System.Drawing.Size(115, 48);
            this.createOppBtn.TabIndex = 4;
            this.createOppBtn.Text = "Create";
            this.createOppBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.updatePitchBtn);
            this.groupBox5.Controls.Add(this.pitchLstBox);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.pitchNameTxt);
            this.groupBox5.Controls.Add(this.createPitchBtn);
            this.groupBox5.Location = new System.Drawing.Point(22, 280);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(975, 261);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pitch Details";
            // 
            // updatePitchBtn
            // 
            this.updatePitchBtn.Location = new System.Drawing.Point(219, 189);
            this.updatePitchBtn.Name = "updatePitchBtn";
            this.updatePitchBtn.Size = new System.Drawing.Size(115, 48);
            this.updatePitchBtn.TabIndex = 24;
            this.updatePitchBtn.Text = "Update";
            this.updatePitchBtn.UseVisualStyleBackColor = true;
            this.updatePitchBtn.Click += new System.EventHandler(this.updatePitchBtn_Click);
            // 
            // pitchLstBox
            // 
            this.pitchLstBox.FormattingEnabled = true;
            this.pitchLstBox.ItemHeight = 25;
            this.pitchLstBox.Location = new System.Drawing.Point(496, 30);
            this.pitchLstBox.Name = "pitchLstBox";
            this.pitchLstBox.Size = new System.Drawing.Size(457, 204);
            this.pitchLstBox.TabIndex = 11;
            this.pitchLstBox.SelectedIndexChanged += new System.EventHandler(this.pitchLstBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name";
            // 
            // pitchNameTxt
            // 
            this.pitchNameTxt.Location = new System.Drawing.Point(151, 44);
            this.pitchNameTxt.Name = "pitchNameTxt";
            this.pitchNameTxt.Size = new System.Drawing.Size(240, 31);
            this.pitchNameTxt.TabIndex = 22;
            // 
            // createPitchBtn
            // 
            this.createPitchBtn.Location = new System.Drawing.Point(75, 189);
            this.createPitchBtn.Name = "createPitchBtn";
            this.createPitchBtn.Size = new System.Drawing.Size(115, 48);
            this.createPitchBtn.TabIndex = 21;
            this.createPitchBtn.Text = "Create";
            this.createPitchBtn.UseVisualStyleBackColor = true;
            this.createPitchBtn.Click += new System.EventHandler(this.createPitchBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.playersLstBox);
            this.groupBox4.Controls.Add(this.updatePlayerBtn);
            this.groupBox4.Controls.Add(this.forenameTxt);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.registerPlayerBtn);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.dobDtp);
            this.groupBox4.Controls.Add(this.surnameTxt);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(22, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(975, 261);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Player Details";
            // 
            // playersLstBox
            // 
            this.playersLstBox.FormattingEnabled = true;
            this.playersLstBox.ItemHeight = 25;
            this.playersLstBox.Location = new System.Drawing.Point(496, 30);
            this.playersLstBox.Name = "playersLstBox";
            this.playersLstBox.Size = new System.Drawing.Size(457, 204);
            this.playersLstBox.TabIndex = 7;
            this.playersLstBox.SelectedIndexChanged += new System.EventHandler(this.playersLstBox_SelectedIndexChanged);
            // 
            // updatePlayerBtn
            // 
            this.updatePlayerBtn.Location = new System.Drawing.Point(219, 189);
            this.updatePlayerBtn.Name = "updatePlayerBtn";
            this.updatePlayerBtn.Size = new System.Drawing.Size(115, 48);
            this.updatePlayerBtn.TabIndex = 10;
            this.updatePlayerBtn.Text = "Update";
            this.updatePlayerBtn.UseVisualStyleBackColor = true;
            this.updatePlayerBtn.Click += new System.EventHandler(this.updatePlayerBtn_Click);
            // 
            // forenameTxt
            // 
            this.forenameTxt.Location = new System.Drawing.Point(151, 44);
            this.forenameTxt.Name = "forenameTxt";
            this.forenameTxt.Size = new System.Drawing.Size(240, 31);
            this.forenameTxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Forename";
            // 
            // registerPlayerBtn
            // 
            this.registerPlayerBtn.Location = new System.Drawing.Point(75, 189);
            this.registerPlayerBtn.Name = "registerPlayerBtn";
            this.registerPlayerBtn.Size = new System.Drawing.Size(115, 48);
            this.registerPlayerBtn.TabIndex = 9;
            this.registerPlayerBtn.Text = "Create";
            this.registerPlayerBtn.UseVisualStyleBackColor = true;
            this.registerPlayerBtn.Click += new System.EventHandler(this.createPlayerBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Surname";
            // 
            // dobDtp
            // 
            this.dobDtp.Location = new System.Drawing.Point(151, 134);
            this.dobDtp.Name = "dobDtp";
            this.dobDtp.Size = new System.Drawing.Size(240, 31);
            this.dobDtp.TabIndex = 6;
            // 
            // surnameTxt
            // 
            this.surnameTxt.Location = new System.Drawing.Point(151, 89);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(240, 31);
            this.surnameTxt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "DOB";
            // 
            // matchTab
            // 
            this.matchTab.BackColor = System.Drawing.Color.White;
            this.matchTab.Controls.Add(this.groupBox6);
            this.matchTab.Location = new System.Drawing.Point(8, 39);
            this.matchTab.Name = "matchTab";
            this.matchTab.Size = new System.Drawing.Size(1014, 828);
            this.matchTab.TabIndex = 3;
            this.matchTab.Text = "Create Match";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.updateGameBtn);
            this.groupBox6.Controls.Add(this.createGameBtn);
            this.groupBox6.Controls.Add(this.gameLstBox);
            this.groupBox6.Controls.Add(this.gameDtp);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.gamePitchCombo);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.gameOppCombo);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Location = new System.Drawing.Point(22, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(968, 787);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Match Details";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(521, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 31);
            this.textBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filter:";
            // 
            // updateGameBtn
            // 
            this.updateGameBtn.Location = new System.Drawing.Point(219, 254);
            this.updateGameBtn.Name = "updateGameBtn";
            this.updateGameBtn.Size = new System.Drawing.Size(115, 48);
            this.updateGameBtn.TabIndex = 8;
            this.updateGameBtn.Text = "Update";
            this.updateGameBtn.UseVisualStyleBackColor = true;
            this.updateGameBtn.Click += new System.EventHandler(this.updateGameBtn_Click);
            // 
            // createGameBtn
            // 
            this.createGameBtn.Location = new System.Drawing.Point(75, 254);
            this.createGameBtn.Name = "createGameBtn";
            this.createGameBtn.Size = new System.Drawing.Size(115, 48);
            this.createGameBtn.TabIndex = 6;
            this.createGameBtn.Text = "Create";
            this.createGameBtn.UseVisualStyleBackColor = true;
            this.createGameBtn.Click += new System.EventHandler(this.createGameBtn_Click);
            // 
            // gameLstBox
            // 
            this.gameLstBox.FormattingEnabled = true;
            this.gameLstBox.ItemHeight = 25;
            this.gameLstBox.Location = new System.Drawing.Point(448, 80);
            this.gameLstBox.Name = "gameLstBox";
            this.gameLstBox.Size = new System.Drawing.Size(502, 679);
            this.gameLstBox.TabIndex = 7;
            this.gameLstBox.SelectedIndexChanged += new System.EventHandler(this.gameLstBox_SelectedIndexChanged);
            // 
            // gameDtp
            // 
            this.gameDtp.Location = new System.Drawing.Point(208, 44);
            this.gameDtp.Name = "gameDtp";
            this.gameDtp.Size = new System.Drawing.Size(200, 31);
            this.gameDtp.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 25);
            this.label15.TabIndex = 1;
            this.label15.Text = "Select Date";
            // 
            // gamePitchCombo
            // 
            this.gamePitchCombo.FormattingEnabled = true;
            this.gamePitchCombo.Location = new System.Drawing.Point(208, 158);
            this.gamePitchCombo.Name = "gamePitchCombo";
            this.gamePitchCombo.Size = new System.Drawing.Size(200, 33);
            this.gamePitchCombo.TabIndex = 5;
            this.gamePitchCombo.Click += new System.EventHandler(this.selectPitchComboClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(172, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "Select Opponent";
            // 
            // gameOppCombo
            // 
            this.gameOppCombo.FormattingEnabled = true;
            this.gameOppCombo.Location = new System.Drawing.Point(208, 100);
            this.gameOppCombo.Name = "gameOppCombo";
            this.gameOppCombo.Size = new System.Drawing.Size(200, 33);
            this.gameOppCombo.TabIndex = 4;
            this.gameOppCombo.Click += new System.EventHandler(this.selectOppComboClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 166);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 25);
            this.label17.TabIndex = 3;
            this.label17.Text = "Select Pitch";
            // 
            // lineupTab
            // 
            this.lineupTab.BackColor = System.Drawing.Color.White;
            this.lineupTab.Controls.Add(this.groupBox2);
            this.lineupTab.Controls.Add(this.groupBox1);
            this.lineupTab.Location = new System.Drawing.Point(8, 39);
            this.lineupTab.Name = "lineupTab";
            this.lineupTab.Size = new System.Drawing.Size(1014, 828);
            this.lineupTab.TabIndex = 5;
            this.lineupTab.Text = "Create Lineup";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removeLineupItemBtn);
            this.groupBox2.Controls.Add(this.lineupPlayersLstBox);
            this.groupBox2.Controls.Add(this.lineupPositionCombo);
            this.groupBox2.Controls.Add(this.lineupPlayerCombo);
            this.groupBox2.Controls.Add(this.addPlayerToLineupBtn);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Location = new System.Drawing.Point(15, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(983, 559);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Players";
            // 
            // removeLineupItemBtn
            // 
            this.removeLineupItemBtn.Location = new System.Drawing.Point(175, 213);
            this.removeLineupItemBtn.Name = "removeLineupItemBtn";
            this.removeLineupItemBtn.Size = new System.Drawing.Size(115, 48);
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
            this.lineupPlayersLstBox.Size = new System.Drawing.Size(652, 379);
            this.lineupPlayersLstBox.TabIndex = 5;
            // 
            // lineupPositionCombo
            // 
            this.lineupPositionCombo.FormattingEnabled = true;
            this.lineupPositionCombo.Location = new System.Drawing.Point(23, 162);
            this.lineupPositionCombo.Name = "lineupPositionCombo";
            this.lineupPositionCombo.Size = new System.Drawing.Size(267, 33);
            this.lineupPositionCombo.TabIndex = 4;
            this.lineupPositionCombo.Click += new System.EventHandler(this.selectPositionComboClick);
            // 
            // lineupPlayerCombo
            // 
            this.lineupPlayerCombo.FormattingEnabled = true;
            this.lineupPlayerCombo.Location = new System.Drawing.Point(23, 79);
            this.lineupPlayerCombo.Name = "lineupPlayerCombo";
            this.lineupPlayerCombo.Size = new System.Drawing.Size(267, 33);
            this.lineupPlayerCombo.TabIndex = 3;
            this.lineupPlayerCombo.Click += new System.EventHandler(this.selectPlayerComboClick);
            // 
            // addPlayerToLineupBtn
            // 
            this.addPlayerToLineupBtn.Location = new System.Drawing.Point(23, 213);
            this.addPlayerToLineupBtn.Name = "addPlayerToLineupBtn";
            this.addPlayerToLineupBtn.Size = new System.Drawing.Size(115, 48);
            this.addPlayerToLineupBtn.TabIndex = 2;
            this.addPlayerToLineupBtn.Text = "Add";
            this.addPlayerToLineupBtn.UseVisualStyleBackColor = true;
            this.addPlayerToLineupBtn.Click += new System.EventHandler(this.addPlayerToLineupBtn_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 134);
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
            this.groupBox1.Controls.Add(this.lineupGameSearchCombo);
            this.groupBox1.Controls.Add(this.lineupGameSearchTxt);
            this.groupBox1.Controls.Add(this.lineupSearchResultsLstBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Match Search";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(24, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(155, 25);
            this.label20.TabIndex = 3;
            this.label20.Text = "Search Criteria";
            // 
            // lineupGameSearchCombo
            // 
            this.lineupGameSearchCombo.FormattingEnabled = true;
            this.lineupGameSearchCombo.Items.AddRange(new object[] {
            "Date",
            "Opposition"});
            this.lineupGameSearchCombo.Location = new System.Drawing.Point(23, 84);
            this.lineupGameSearchCombo.Name = "lineupGameSearchCombo";
            this.lineupGameSearchCombo.Size = new System.Drawing.Size(267, 33);
            this.lineupGameSearchCombo.TabIndex = 2;
            this.lineupGameSearchCombo.Text = "Date";
            // 
            // lineupGameSearchTxt
            // 
            this.lineupGameSearchTxt.Location = new System.Drawing.Point(23, 123);
            this.lineupGameSearchTxt.Name = "lineupGameSearchTxt";
            this.lineupGameSearchTxt.Size = new System.Drawing.Size(267, 31);
            this.lineupGameSearchTxt.TabIndex = 1;
            this.lineupGameSearchTxt.TextChanged += new System.EventHandler(this.lineupSearchTxtChanged);
            // 
            // lineupSearchResultsLstBox
            // 
            this.lineupSearchResultsLstBox.FormattingEnabled = true;
            this.lineupSearchResultsLstBox.ItemHeight = 25;
            this.lineupSearchResultsLstBox.Location = new System.Drawing.Point(315, 44);
            this.lineupSearchResultsLstBox.Name = "lineupSearchResultsLstBox";
            this.lineupSearchResultsLstBox.Size = new System.Drawing.Size(652, 179);
            this.lineupSearchResultsLstBox.TabIndex = 0;
            this.lineupSearchResultsLstBox.SelectedIndexChanged += new System.EventHandler(this.gameSearchLstBoxIndexChanged);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1055, 901);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.Text = "TrackFit - Admin";
            this.tabControl1.ResumeLayout(false);
            this.playerTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.matchTab.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dobDtp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox forenameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerPlayerBtn;
        private System.Windows.Forms.ListBox playersLstBox;
        private System.Windows.Forms.TabPage matchTab;
        private System.Windows.Forms.ComboBox gamePitchCombo;
        private System.Windows.Forms.ComboBox gameOppCombo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker gameDtp;
        private System.Windows.Forms.ListBox gameLstBox;
        private System.Windows.Forms.Button createGameBtn;
        private System.Windows.Forms.TabPage lineupTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox lineupGameSearchCombo;
        private System.Windows.Forms.TextBox lineupGameSearchTxt;
        private System.Windows.Forms.ListBox lineupSearchResultsLstBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button removeLineupItemBtn;
        private System.Windows.Forms.ListBox lineupPlayersLstBox;
        private System.Windows.Forms.ComboBox lineupPositionCombo;
        private System.Windows.Forms.ComboBox lineupPlayerCombo;
        private System.Windows.Forms.Button addPlayerToLineupBtn;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox pitchLstBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pitchNameTxt;
        private System.Windows.Forms.Button createPitchBtn;
        private System.Windows.Forms.Button updatePlayerBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button updateOppBtn;
        private System.Windows.Forms.ListBox oppLstBox;
        private System.Windows.Forms.TextBox oppNameTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button createOppBtn;
        private System.Windows.Forms.Button updatePitchBtn;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button updateGameBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}


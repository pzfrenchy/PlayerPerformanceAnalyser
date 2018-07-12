namespace Analyser
{
    partial class UploadForm
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.uploadLineupLstBox = new System.Windows.Forms.ListBox();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trainingCBox = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.uploadSearchCombo = new System.Windows.Forms.ComboBox();
            this.uploadSearchTxt = new System.Windows.Forms.TextBox();
            this.uploadSearchResultsLstBox = new System.Windows.Forms.ListBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.uploadLineupLstBox);
            this.groupBox4.Controls.Add(this.uploadBtn);
            this.groupBox4.Location = new System.Drawing.Point(12, 293);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(910, 391);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select Player";
            // 
            // uploadLineupLstBox
            // 
            this.uploadLineupLstBox.FormattingEnabled = true;
            this.uploadLineupLstBox.ItemHeight = 25;
            this.uploadLineupLstBox.Location = new System.Drawing.Point(23, 40);
            this.uploadLineupLstBox.Name = "uploadLineupLstBox";
            this.uploadLineupLstBox.Size = new System.Drawing.Size(622, 329);
            this.uploadLineupLstBox.TabIndex = 4;
            this.uploadLineupLstBox.SelectedIndexChanged += new System.EventHandler(this.uploadLineupLstBoxIndexChanged);
            // 
            // uploadBtn
            // 
            this.uploadBtn.Enabled = false;
            this.uploadBtn.Location = new System.Drawing.Point(710, 160);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(136, 64);
            this.uploadBtn.TabIndex = 5;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.trainingCBox);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.uploadSearchCombo);
            this.groupBox3.Controls.Add(this.uploadSearchTxt);
            this.groupBox3.Controls.Add(this.uploadSearchResultsLstBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(910, 275);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Match Search";
            // 
            // trainingCBox
            // 
            this.trainingCBox.AutoSize = true;
            this.trainingCBox.Location = new System.Drawing.Point(29, 183);
            this.trainingCBox.Name = "trainingCBox";
            this.trainingCBox.Size = new System.Drawing.Size(122, 29);
            this.trainingCBox.TabIndex = 2;
            this.trainingCBox.Text = "Training";
            this.trainingCBox.UseVisualStyleBackColor = true;
            this.trainingCBox.CheckedChanged += new System.EventHandler(this.TrainingCBoxChecked);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(155, 25);
            this.label18.TabIndex = 3;
            this.label18.Text = "Search Criteria";
            // 
            // uploadSearchCombo
            // 
            this.uploadSearchCombo.FormattingEnabled = true;
            this.uploadSearchCombo.Items.AddRange(new object[] {
            "ID",
            "Date",
            "Opposition"});
            this.uploadSearchCombo.Location = new System.Drawing.Point(23, 88);
            this.uploadSearchCombo.Name = "uploadSearchCombo";
            this.uploadSearchCombo.Size = new System.Drawing.Size(225, 33);
            this.uploadSearchCombo.TabIndex = 0;
            this.uploadSearchCombo.Text = "ID";
            // 
            // uploadSearchTxt
            // 
            this.uploadSearchTxt.Location = new System.Drawing.Point(23, 133);
            this.uploadSearchTxt.Name = "uploadSearchTxt";
            this.uploadSearchTxt.Size = new System.Drawing.Size(225, 31);
            this.uploadSearchTxt.TabIndex = 1;
            this.uploadSearchTxt.TextChanged += new System.EventHandler(this.uploadSearchTxtChanged);
            // 
            // uploadSearchResultsLstBox
            // 
            this.uploadSearchResultsLstBox.FormattingEnabled = true;
            this.uploadSearchResultsLstBox.ItemHeight = 25;
            this.uploadSearchResultsLstBox.Location = new System.Drawing.Point(266, 48);
            this.uploadSearchResultsLstBox.Name = "uploadSearchResultsLstBox";
            this.uploadSearchResultsLstBox.Size = new System.Drawing.Size(618, 204);
            this.uploadSearchResultsLstBox.TabIndex = 3;
            this.uploadSearchResultsLstBox.SelectedIndexChanged += new System.EventHandler(this.uploadSeachIndexChanged);
            // 
            // UploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 696);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UploadForm";
            this.Text = "Manual Upload";
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox uploadLineupLstBox;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox trainingCBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox uploadSearchCombo;
        private System.Windows.Forms.TextBox uploadSearchTxt;
        private System.Windows.Forms.ListBox uploadSearchResultsLstBox;
    }
}
namespace Analyser
{
    partial class OptionsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.fExtTxt = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fDirTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.z6MaxTxt = new System.Windows.Forms.TextBox();
            this.z6MinTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.z5MaxTxt = new System.Windows.Forms.TextBox();
            this.z5MinTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.z4MaxTxt = new System.Windows.Forms.TextBox();
            this.z4MinTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.z3MaxTxt = new System.Windows.Forms.TextBox();
            this.z3MinTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.z2MaxTxt = new System.Windows.Forms.TextBox();
            this.z2MinTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.z1MaxTxt = new System.Windows.Forms.TextBox();
            this.z1MinTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.intervalTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "File Extension";
            // 
            // fExtTxt
            // 
            this.fExtTxt.Location = new System.Drawing.Point(27, 130);
            this.fExtTxt.Name = "fExtTxt";
            this.fExtTxt.Size = new System.Drawing.Size(191, 29);
            this.fExtTxt.TabIndex = 7;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(405, 297);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(109, 50);
            this.confirmBtn.TabIndex = 10;
            this.confirmBtn.Text = "Set";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fDirTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fExtTxt);
            this.groupBox1.Location = new System.Drawing.Point(334, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 174);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GPX File Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "File Location";
            // 
            // fDirTxt
            // 
            this.fDirTxt.Location = new System.Drawing.Point(27, 65);
            this.fDirTxt.Name = "fDirTxt";
            this.fDirTxt.Size = new System.Drawing.Size(191, 29);
            this.fDirTxt.TabIndex = 6;
            this.fDirTxt.Text = "XmlDocuments";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.z6MaxTxt);
            this.groupBox2.Controls.Add(this.z6MinTxt);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.z5MaxTxt);
            this.groupBox2.Controls.Add(this.z5MinTxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.z4MaxTxt);
            this.groupBox2.Controls.Add(this.z4MinTxt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.z3MaxTxt);
            this.groupBox2.Controls.Add(this.z3MinTxt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.z2MaxTxt);
            this.groupBox2.Controls.Add(this.z2MinTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.z1MaxTxt);
            this.groupBox2.Controls.Add(this.z1MinTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 335);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Effort Zones";
            // 
            // z6MaxTxt
            // 
            this.z6MaxTxt.Location = new System.Drawing.Point(224, 273);
            this.z6MaxTxt.Name = "z6MaxTxt";
            this.z6MaxTxt.Size = new System.Drawing.Size(60, 29);
            this.z6MaxTxt.TabIndex = 19;
            this.z6MaxTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // z6MinTxt
            // 
            this.z6MinTxt.Location = new System.Drawing.Point(135, 274);
            this.z6MinTxt.Name = "z6MinTxt";
            this.z6MinTxt.Size = new System.Drawing.Size(60, 29);
            this.z6MinTxt.TabIndex = 18;
            this.z6MinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Zone 6";
            // 
            // z5MaxTxt
            // 
            this.z5MaxTxt.Location = new System.Drawing.Point(224, 231);
            this.z5MaxTxt.Name = "z5MaxTxt";
            this.z5MaxTxt.Size = new System.Drawing.Size(60, 29);
            this.z5MaxTxt.TabIndex = 16;
            this.z5MaxTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // z5MinTxt
            // 
            this.z5MinTxt.Location = new System.Drawing.Point(135, 232);
            this.z5MinTxt.Name = "z5MinTxt";
            this.z5MinTxt.Size = new System.Drawing.Size(60, 29);
            this.z5MinTxt.TabIndex = 15;
            this.z5MinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Zone 5";
            // 
            // z4MaxTxt
            // 
            this.z4MaxTxt.Location = new System.Drawing.Point(224, 190);
            this.z4MaxTxt.Name = "z4MaxTxt";
            this.z4MaxTxt.Size = new System.Drawing.Size(60, 29);
            this.z4MaxTxt.TabIndex = 13;
            this.z4MaxTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // z4MinTxt
            // 
            this.z4MinTxt.Location = new System.Drawing.Point(135, 191);
            this.z4MinTxt.Name = "z4MinTxt";
            this.z4MinTxt.Size = new System.Drawing.Size(60, 29);
            this.z4MinTxt.TabIndex = 12;
            this.z4MinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Zone 4";
            // 
            // z3MaxTxt
            // 
            this.z3MaxTxt.Location = new System.Drawing.Point(224, 150);
            this.z3MaxTxt.Name = "z3MaxTxt";
            this.z3MaxTxt.Size = new System.Drawing.Size(60, 29);
            this.z3MaxTxt.TabIndex = 10;
            this.z3MaxTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // z3MinTxt
            // 
            this.z3MinTxt.Location = new System.Drawing.Point(135, 151);
            this.z3MinTxt.Name = "z3MinTxt";
            this.z3MinTxt.Size = new System.Drawing.Size(60, 29);
            this.z3MinTxt.TabIndex = 9;
            this.z3MinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Zone 3";
            // 
            // z2MaxTxt
            // 
            this.z2MaxTxt.Location = new System.Drawing.Point(224, 107);
            this.z2MaxTxt.Name = "z2MaxTxt";
            this.z2MaxTxt.Size = new System.Drawing.Size(60, 29);
            this.z2MaxTxt.TabIndex = 7;
            this.z2MaxTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // z2MinTxt
            // 
            this.z2MinTxt.Location = new System.Drawing.Point(135, 108);
            this.z2MinTxt.Name = "z2MinTxt";
            this.z2MinTxt.Size = new System.Drawing.Size(60, 29);
            this.z2MinTxt.TabIndex = 6;
            this.z2MinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Zone 2";
            // 
            // z1MaxTxt
            // 
            this.z1MaxTxt.Location = new System.Drawing.Point(224, 64);
            this.z1MaxTxt.Name = "z1MaxTxt";
            this.z1MaxTxt.Size = new System.Drawing.Size(60, 29);
            this.z1MaxTxt.TabIndex = 4;
            this.z1MaxTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // z1MinTxt
            // 
            this.z1MinTxt.Location = new System.Drawing.Point(135, 65);
            this.z1MinTxt.Name = "z1MinTxt";
            this.z1MinTxt.Size = new System.Drawing.Size(60, 29);
            this.z1MinTxt.TabIndex = 3;
            this.z1MinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Zone 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Min";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.intervalTxt);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(334, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 92);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Breakdown Interval";
            // 
            // intervalTxt
            // 
            this.intervalTxt.Location = new System.Drawing.Point(101, 37);
            this.intervalTxt.Name = "intervalTxt";
            this.intervalTxt.Size = new System.Drawing.Size(60, 29);
            this.intervalTxt.TabIndex = 1;
            this.intervalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Interval";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 363);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.confirmBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fExtTxt;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fDirTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox z6MaxTxt;
        private System.Windows.Forms.TextBox z6MinTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox z5MaxTxt;
        private System.Windows.Forms.TextBox z5MinTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox z4MaxTxt;
        private System.Windows.Forms.TextBox z4MinTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox z3MaxTxt;
        private System.Windows.Forms.TextBox z3MinTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox z2MaxTxt;
        private System.Windows.Forms.TextBox z2MinTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox z1MaxTxt;
        private System.Windows.Forms.TextBox z1MinTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox intervalTxt;
        private System.Windows.Forms.Label label11;
    }
}
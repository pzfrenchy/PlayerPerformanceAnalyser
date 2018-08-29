using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalyserLibrary;

namespace Analyser
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
            PopulateTextBoxes();
        }

        private void PopulateTextBoxes()
        {
            using (DataClassesDataContext dbContext = new DataClassesDataContext())
            {
                Option options = dbContext.Options.Where(o => o.Id.Equals(4)).SingleOrDefault();
                fDirTxt.Text = options.UploadDir;
                z1MinTxt.Text = Convert.ToString(options.EffortZone1Min);
                z1MaxTxt.Text = Convert.ToString(options.EffortZone1Max);
                z2MinTxt.Text = Convert.ToString(options.EffortZone2Min);
                z2MaxTxt.Text = Convert.ToString(options.EffortZone2Max);
                z3MinTxt.Text = Convert.ToString(options.EffortZone3Min);
                z3MaxTxt.Text = Convert.ToString(options.EffortZone3Max);
                z4MinTxt.Text = Convert.ToString(options.EffortZone4Min);
                z4MaxTxt.Text = Convert.ToString(options.EffortZone4Max);
                z5MinTxt.Text = Convert.ToString(options.EffortZone5Min);
                z5MaxTxt.Text = Convert.ToString(options.EffortZone5Max);
                z6MinTxt.Text = Convert.ToString(options.EffortZone6Min);
                z6MaxTxt.Text = Convert.ToString(options.EffortZone6Max);
                intervalTxt.Text = Convert.ToString(options.BreakdownInterval);
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataClassesDataContext dbContext = new DataClassesDataContext())
                {
                    Option options = dbContext.Options.Where(o => o.Id.Equals(4)).SingleOrDefault();
                    options.UploadDir = fDirTxt.Text;
                    options.EffortZone1Min = Convert.ToDouble(z1MinTxt.Text);
                    options.EffortZone1Max = Convert.ToDouble(z1MaxTxt.Text);
                    options.EffortZone2Min = Convert.ToDouble(z2MinTxt.Text);
                    options.EffortZone2Max = Convert.ToDouble(z2MaxTxt.Text);
                    options.EffortZone3Min = Convert.ToDouble(z3MinTxt.Text);
                    options.EffortZone3Max = Convert.ToDouble(z3MaxTxt.Text);
                    options.EffortZone4Min = Convert.ToDouble(z4MinTxt.Text);
                    options.EffortZone4Max = Convert.ToDouble(z4MaxTxt.Text);
                    options.EffortZone5Min = Convert.ToDouble(z5MinTxt.Text);
                    options.EffortZone5Max = Convert.ToDouble(z5MaxTxt.Text);
                    options.EffortZone6Min = Convert.ToDouble(z6MinTxt.Text);
                    options.EffortZone6Max = Convert.ToDouble(z6MaxTxt.Text);
                    options.BreakdownInterval = Convert.ToDouble(intervalTxt.Text);

                    dbContext.SubmitChanges();
                }
                MessageBox.Show("Options set");
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter the correct values");
            }
        }
    }
}

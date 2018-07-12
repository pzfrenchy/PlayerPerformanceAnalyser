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
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            OptionSettings.Instance.Directory = fDirTxt.Text;
            OptionSettings.Instance.FileExtension = fExtTxt.Text;
            this.Close();
        }

        public void openfile()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = "C:\\";
            op.Title = "Select file";
            if (op.ShowDialog() == DialogResult.OK)
            {
                OptionSettings.Instance.Directory = op.FileName;
            }
            OptionSettings.Instance.FileExtension = fExtTxt.Text;
        }
    }
}

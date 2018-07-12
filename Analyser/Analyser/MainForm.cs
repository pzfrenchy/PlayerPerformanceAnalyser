using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analyser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminForm adminScreen = new AdminForm();
            adminScreen.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void manualUploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadForm manualUpload = new UploadForm();
            manualUpload.Show();
        }
    }
}

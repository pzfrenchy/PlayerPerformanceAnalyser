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

        /// <summary>
        /// Event handler to create a new admin form on menu item click
        /// </summary>
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminForm adminScreen = new AdminForm();
            adminScreen.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        /// <summary>
        /// Event handler to create a new upload form on menu item click
        /// </summary>
        private void manualUploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadForm manualUpload = new UploadForm();
            manualUpload.Show();
        }

        /// <summary>
        /// Event handler to create a new options form on menu item click
        /// </summary>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm();
            optionsForm.Show();
        }

        /// <summary>
        /// Event handler to create a new admin form on shortcut keypress (ctrl+a)
        /// </summary>
        private void AdminFormKeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                if (e.KeyCode == Keys.A)
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
            }
        }

        /// <summary>
        /// Event handler to create a new options form on shortcut keypress (ctrl+s)
        /// </summary>
        private void SettingsFormKeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                if (e.KeyCode == Keys.S)
                {
                    OptionsForm optionsForm = new OptionsForm();
                    optionsForm.Show();
                }
            }
        }

        /// <summary>
        /// Event handler to create a new upload form on shortcut keypress (ctrl+u)
        /// </summary>
        private void UploadFormKeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                if (e.KeyCode == Keys.U)
                {
                    UploadForm uploadForm = new UploadForm();
                    uploadForm.Show();
                }
            }
        }

        private void playerStatsBtn_Click(object sender, EventArgs e)
        {
            PlayerStatsForm form = new PlayerStatsForm();
            form.Show();
        }
    }
}

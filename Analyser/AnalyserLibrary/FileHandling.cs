using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalyserLibrary
{
    public class FileHandling
    {
        public string getFileName()
        {
            string selectedFile = "";

            //Open file dialog screen to allow user to browse for gpx file
            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = "C:\\";
            op.Title = "Select file";
            if (op.ShowDialog() == DialogResult.OK)
            {
                //save file path for use in GPX reader
                selectedFile = op.FileName;
            }
            return selectedFile;
        }
    }
}

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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();

            //Test GpxFile class, loadGPXTracks parsing example file and displaying in listbox
            GpxFile reader = new GpxFile();

            List<string> list = reader.LoadGPXTracks("XmlDocuments/run.gpx");
            for (int i = 0; i < list.Count; i++)
            {
                listBox1.Items.Add(list[i]);
            }           
        }
    }
}

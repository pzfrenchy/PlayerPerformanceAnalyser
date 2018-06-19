using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Analyser
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        public void test()
        {
            try
            {
                //Test GpxFile class, loadGPXTracks parsing example file and displaying in listbox
                GpxFile reader = new GpxFile();

                List<string> list = reader.GPXTracksList("XmlDocuments/run.gpx");
                for (int i = 0; i < list.Count; i++)
                {
                    string[] elements = list[i].Split(',');

                    DataClassesDataContext dbContext = new DataClassesDataContext();

                    TimeLine timeLines = new TimeLine
                    {
                        Longitude = Convert.ToDouble(elements[1]),
                        Latitude = Convert.ToDouble(elements[2]),
                        ReadingTime = Convert.ToDateTime(elements[3]),
                        LineupID = null,
                        GPSDeviceID = null
                    };

                    dbContext.TimeLines.InsertOnSubmit(timeLines);
                    dbContext.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //test();
            Thread thread = new Thread(new ThreadStart(threadtest));
            thread.Start();
        }

        private void threadtest()
        {
            DirSearch gds = new DirSearch();
            gds.PrintQueryResults(".gpx", "XmlDocuments");

            var filelist = gds.GetFiles(".gpx", "XmlDocuments");

            GpxFile gpxFile = new GpxFile();
            foreach (var file in filelist)
            {
                var list = gpxFile.GPXTracksList(Convert.ToString(file.FullName));
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

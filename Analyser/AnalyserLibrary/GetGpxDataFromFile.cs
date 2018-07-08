using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserLibrary
{
    public class GetGpxDataFromFile
    {
        public List<string> getGpxData(string fe, string d)
        {
            List<string> gpxDataList = new List<string>();
            DirSearch ds = new DirSearch();

            var filelist = ds.GetFiles(fe, d);

            GpxFile gpxFile = new GpxFile();
            foreach (var file in filelist)
            {
                var list = gpxFile.GPXTracksList(Convert.ToString(file.FullName));
                foreach (var item in list)
                {
                    gpxDataList.Add(item);
                }
            }
            return gpxDataList;
        }
    }
}

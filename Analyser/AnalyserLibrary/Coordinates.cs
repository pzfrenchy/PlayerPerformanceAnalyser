using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserLibrary
{
    public class Coordinates
    {
        public Coordinates(double lat, double lon)
        {
            this.Lat = lat;
            this.Lon = lon;
        }

        public double Lat { get; set; }
        public double Lon { get; set; }
    }
}

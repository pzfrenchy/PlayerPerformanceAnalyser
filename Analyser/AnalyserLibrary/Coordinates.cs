using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserLibrary
{
    public class Coordinates
    {
        public Coordinates(DateTime dt, double lat, double lon)
        {
            this.Dt = dt;
            this.Lat = lat;
            this.Lon = lon;
        }

        public DateTime Dt { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
    }
}

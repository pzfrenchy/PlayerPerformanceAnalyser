using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserLibrary
{
    public class EffortZones
    {
        public EffortZones(string n, double min, double max)
        {
            this.Name = n;
            this.Min = min;
            this.Max = max;
        }
        public string Name { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
    }
}

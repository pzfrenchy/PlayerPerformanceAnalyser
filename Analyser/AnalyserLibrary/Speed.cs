using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserLibrary
{
    /// <summary>
    /// Class for calculating the velocity of an object, exposes methods to return velocity in different forms.
    /// </summary>
    public class Speed
    {
        public Speed(double d, DateTime startTime, DateTime endTime)
        {
            this.Distance = d;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        public double Distance { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        private TimeSpan CalcTimeSpan()
        {
            TimeSpan t = (EndTime - StartTime);
            return t;
        }

        public double AvgMtrPerSecond()
        {
            TimeSpan t = CalcTimeSpan();
            double v = Distance / t.TotalSeconds;
            return v;
        }

        public double AvgMtrPerSecondRnd()
        {
            double v = AvgMtrPerSecond();

            return Math.Round(v, 2);
        }
    }
}

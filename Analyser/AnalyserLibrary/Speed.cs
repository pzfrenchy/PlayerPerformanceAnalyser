using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserLibrary
{
    public class Speed
    {
        private TimeSpan CalcTimeSpan(DateTime startTime, DateTime endTime)
        {
            TimeSpan t = (endTime - startTime);
            return t;
        }

        public double AvgMtrPerSecond(double d, DateTime startTime, DateTime endTime)
        {
            TimeSpan t = CalcTimeSpan(startTime, endTime);
            double v = d / t.TotalSeconds;
            return v;
        }

        public double AvgMtrPerSecondRnd(double d, DateTime startTime, DateTime endTime)
        {
            double v = AvgMtrPerSecond(d, startTime, endTime);

            return Math.Round(v, 2);
        }
    }
}

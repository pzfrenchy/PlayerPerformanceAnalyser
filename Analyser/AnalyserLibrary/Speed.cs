using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserLibrary
{
    public class Speed
    {
        public double Distance { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan TimeSpan { get; set; }

        /// <summary>
        /// Represents a velocity, exposes methods to return velocity in different forms.
        /// </summary>
        /// <param name="d">distance</param>
        /// <param name="startTime">start time</param>
        /// <param name="endTime">end time</param>
        public Speed(double d, DateTime startTime, DateTime endTime)
        {
            this.Distance = d;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.TimeSpan = TimeSpan.Parse("-1");
        }

        /// <summary>
        /// Represents a velocity, exposes methods to return velocity in different forms.
        /// </summary>
        /// <param name="d">distance</param>
        /// <param name="t">time span</param>
        public Speed(double d, TimeSpan t)
        {
            this.Distance = d;
            this.TimeSpan = t;
        }

        private TimeSpan CalcTimeSpan()
        {
            TimeSpan t = (EndTime - StartTime);
            return t;
        }

        /// <summary>
        /// Returns calculated velocity of speed object in meters per second
        /// </summary>
        /// <returns>double, velocity</returns>
        public double AvgMtrPerSecond()
        {
            //TimeSpan will be set to -1 if constructor is used with start and end times. 
            //TimeSpan will then require calculating.
            if (TimeSpan == TimeSpan.Parse("-1"))
            {
                TimeSpan t = CalcTimeSpan();
                double v = Distance / t.TotalSeconds;
                return v;
            }
            else
            {
                double v = Distance / TimeSpan.TotalSeconds;
                return v;
            }
        }

        /// <summary>
        /// Returns calculated velocity of speed object in meters per second, rounded to 2 decimal places.
        /// </summary>
        /// <returns>double, velocity</returns>
        public double AvgMtrPerSecondRnd()
        {
            double v = AvgMtrPerSecond();

            return Math.Round(v, 2);
        }
    }
}

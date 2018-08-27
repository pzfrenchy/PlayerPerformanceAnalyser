using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserLibrary
{
    public class SeriesData
    {
        /// <summary>
        /// Method to generate series data for an activity
        /// </summary>
        /// <param name="t">List of activity waypoints</param>
        /// <param name="i">Series interval</param>
        /// <returns>List of values</returns>
        public List<double> GenerateSeriesData(List<TimeLine> t, double i)
        {
            List<TimeLine> timeLines = t;
            List<double> seriesData = new List<double>();
            double interval = i;
            double initialDistance = Calculations.Instance.CalcTotalDistance(t);

            if (timeLines.Count > 0) //Check there is timeline data for the activity
            {
                //timespan used to find difference between start and end times
                DateTime startTime = timeLines[0].ReadingTime;
                double totalDistance = 0;
                DateTime endTime = new DateTime(01, 01, 01, 00, 00, 00);
                TimeSpan totalTime = (timeLines[timeLines.Count - 1].ReadingTime - startTime);

                if (totalTime.TotalMinutes <= interval) //Check if activity is less than interval
                {
                    totalDistance = initialDistance;
                    seriesData.Add(initialDistance);
                }
                else //activity greater than interval, lets get splitting
                {
                    for (int y = 0; y < timeLines.Count - 1; y++)
                    {
                        TimeSpan ts = (timeLines[y + 1].ReadingTime - startTime);
                        if (ts.TotalMinutes <= interval)
                        {
                            HaversineDistance dist = new HaversineDistance(timeLines[y].Latitude, timeLines[y].Longitude, timeLines[y + 1].Latitude, timeLines[y + 1].Longitude);
                            totalDistance = totalDistance + dist.DistanceInMtr();
                            endTime = timeLines[y + 1].ReadingTime;
                        }
                        else
                        {
                            seriesData.Add(totalDistance);

                            //reset counters
                            totalDistance = 0;
                            startTime = timeLines[y].ReadingTime;
                        }
                    }
                }
            }
            return seriesData;
        }
    }
}

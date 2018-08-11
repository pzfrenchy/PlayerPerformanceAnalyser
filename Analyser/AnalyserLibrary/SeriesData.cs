using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserLibrary
{
    public class SeriesData
    {
        public List<double> GetDistanceData(List<TimeLine> t)
        {
            List<TimeLine> timeLines = t;
            List<double> seriesData = new List<double>();
            double initialDistance = Calculations.Instance.CalcTotalDistance(t);

            if (timeLines.Count > 0)
            {
                DateTime startTime = timeLines[0].ReadingTime;
                double totalDistance = 0;
                DateTime endTime = new DateTime(01, 01, 01, 00, 00, 00);
                TimeSpan totalTime = (timeLines[timeLines.Count - 1].ReadingTime - startTime);

                if (totalTime.TotalMinutes <= 5.0)
                {
                    totalDistance = initialDistance;
                    seriesData.Add(initialDistance);
                }
                else
                {
                    for (int i = 0; i < timeLines.Count - 1; i++)
                    {
                        TimeSpan ts = (timeLines[i + 1].ReadingTime - startTime);
                        if (ts.TotalMinutes <= 5.0)
                        {
                            Distance dist = new Distance(timeLines[i].Latitude, timeLines[i].Longitude, timeLines[i + 1].Latitude, timeLines[i + 1].Longitude);
                            totalDistance = totalDistance + dist.DistanceInMtr();
                            endTime = timeLines[i + 1].ReadingTime;
                        }
                        else
                        {
                            seriesData.Add(totalDistance);

                            //reset counters
                            totalDistance = 0;
                            startTime = timeLines[i].ReadingTime;
                        }
                    }
                }
            }
            return seriesData;
        }
    }
}

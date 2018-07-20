using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserLibrary
{
    public class Distance
    {
        /// <summary>
        /// Method to convert decimal degrees to radians.
        /// </summary>
        /// <param name="value">the value for conversion</param>
        /// <returns>the value in radians</returns>
        private double ToRadians(double value)
        {
            double output = (Math.PI / 180) * value;

            return output;
        }

        private double calcA(double lat1Rad, double lat2Rad, double dLatRad, double dLonRad)
        {
            double output = Math.Sin(dLatRad / 2) * Math.Sin(dLatRad / 2) +
                Math.Cos(lat1Rad) * Math.Cos(lat2Rad) *
                Math.Sin(dLonRad / 2) * Math.Sin(dLonRad / 2);

            return output;
        }

        private double calcB(double a)
        {
            double output = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return output;
        }

        private double ToMeter(double b)
        {
            double earthRadius = 6371e3; //in metres

            double distance = earthRadius * b;

            return distance;
        }

        private double CalcBetweenTwoPoints(double lat1, double lon1, double lat2, double lon2)
        {
            double lat1Rad = ToRadians(lat1);
            double lat2Rad = ToRadians(lat2);
            double dLatRad = ToRadians((lat2 - lat1));
            double dLonRad = ToRadians((lon2 - lon1));

            double a = calcA(lat1Rad, lat2Rad, dLatRad, dLonRad);

            double distance = calcB(a);

            return distance;
        }

        /// <summary>
        /// Calculates the distance between two point using latitude and longitude coordinates, returns double rounded to 2 decimal places.
        /// </summary>
        /// <param name="lat1">latitude 1</param>
        /// <param name="lon1">longitude 1</param>
        /// <param name="lat2">latitude 2</param>
        /// <param name="lon2">longitude 2</param>
        /// <returns>double</returns>
        public double DistanceInMtrRnd(double lat1, double lon1, double lat2, double lon2)
        {
            double distance = CalcBetweenTwoPoints(lat1, lon1, lat2, lon2);

            double distanceInMtr = ToMeter(distance);

            return Math.Round(distanceInMtr, 2);
        }

        /// <summary>
        /// Calculates the distance between two point using latitude and longitude coordinates.
        /// </summary>
        /// <param name="lat1">latitude 1</param>
        /// <param name="lon1">longitude 1</param>
        /// <param name="lat2">latitude 2</param>
        /// <param name="lon2">longitude 2</param>
        /// <returns>double</returns>
        public double DistanceInMtr(double lat1, double lon1, double lat2, double lon2)
        {
            double distance = CalcBetweenTwoPoints(lat1, lon1, lat2, lon2);

            double distanceInMtr = ToMeter(distance);

            return Math.Round(distanceInMtr, 8);
        }
    }
}

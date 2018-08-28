using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class HaversineDistance
    {
        public double Lat1 { get; set; }
        public double Lon1 { get; set; }
        public double Lat2 { get; set; }
        public double Lon2 { get; set; }

        /// <summary>
        /// Represents a distance between two geolocations, calculated using latitude and longitude
        /// </summary>
        /// <param name="lat1">first geolocation latitude</param>
        /// <param name="lon1">first geolocation longitude</param>
        /// <param name="lat2">second geolocation latitude</param>
        /// <param name="lon2">second geolocation longitude</param>
        public HaversineDistance(double lat1, double lon1, double lat2, double lon2)
        {
            this.Lat1 = lat1;
            this.Lat2 = lat2;
            this.Lon1 = lon1;
            this.Lon2 = lon2;
        }

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

        private double HaversineCalc()
        {
            double lat1Rad = ToRadians(Lat1);
            double lat2Rad = ToRadians(Lat2);
            double dLatRad = ToRadians((Lat2 - Lat1));
            double dLonRad = ToRadians((Lon2 - Lon1));

            var h1 = Math.Sin(dLatRad / 2) * Math.Sin(dLatRad / 2) +
              Math.Cos(lat1Rad) * Math.Cos(lat2Rad) *
              Math.Sin(dLonRad / 2) * Math.Sin(dLonRad / 2);

            var h2 = 2 * Math.Asin(Math.Min(1, Math.Sqrt(h1)));

            return h2;
        }

        /// <summary>
        /// Calculates the distance between two point using latitude and longitude coordinates, returns double rounded to 2 decimal places.
        /// </summary>
        /// <returns>double</returns>
        public double DistanceInMtrRnd()
        {
            double distance = DistanceInMtr();

            return Math.Round(distance, 2);
        }

        /// <summary>
        /// Calculates the distance between two point using latitude and longitude coordinates.
        /// </summary>
        /// <returns>double</returns>
        public double DistanceInMtr()
        {
            double earthRadius = 6371e3; //in metres

            double distance = earthRadius * HaversineCalc();

            return Math.Round(distance, 8);
        }

        public double DistanceInKmRnd()
        {
            double distance = DistanceInKm();

            return Math.Round(distance, 2);
        }

        public double DistanceInKm()
        {
            double earthRadius = 6371; //in Kilometres

            double distance = earthRadius * HaversineCalc();

            return Math.Round(distance, 8);
        }
    }
}

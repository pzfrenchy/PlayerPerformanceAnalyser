using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserLibrary
{
    public class Calculations
    {
        private static Calculations instance;

        private Calculations() { }

        public static Calculations Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Calculations();
                }
                return instance;
            }
        }

        /// <summary>
        /// Method to calculate the sum of distances for an activity
        /// </summary>
        public double CalcTotalDistance(List<TimeLine> timeLines)
        {
            double totalDistance = 0.0;

            //calculate sum of distance covered
            for (int i = 0; i < timeLines.Count() - 1; i++)
            {
                double p1Lat = timeLines[i].Latitude;
                double p1Lon = timeLines[i].Longitude;
                double p2Lat = timeLines[i + 1].Latitude;
                double p2Lon = timeLines[i + 1].Longitude;

                HaversineDistance d = new HaversineDistance(p1Lat, p1Lon, p2Lat, p2Lon);

                double distance = d.DistanceInMtr();

                totalDistance = totalDistance + distance;
            }

            return totalDistance;
        }

        /// <summary>
        /// Method to find the min and max X and Y coordinates from a given List
        /// </summary>
        /// <param name="coords">List of XY coordinates</param>
        /// <returns></returns>
        public List<XY> FindMinMaxCoords(List<XY> coords)
        {
            List<XY> output = new List<XY>();

            double minX = coords[0].X;
            double minY = coords[0].Y;
            double maxX = coords[0].X;
            double maxY = coords[0].Y;

            foreach (var c in coords)
            {
                //find minimum and maximum values to scale pitch.
                minX = Math.Min(c.X, minX);
                minY = Math.Min(c.Y, minY);
                maxX = Math.Max(c.X, maxX);
                maxY = Math.Max(c.Y, maxY);
            }

            XY minXY = new XY(minX, minY);
            XY maxXY = new XY(maxX, maxY);
            output.Add(minXY);
            output.Add(maxXY);

            return output;
        }

        /// <summary>
        /// Method to convert a list of geolocation coordinates to XY coordinates
        /// </summary>
        /// <param name="timeLines">List of geolocation points in timeline format</param>
        /// <param name="width">Width of the control</param>
        /// <param name="height">Height of the control</param>
        /// <returns></returns>
        public List<XY> ConvertGeolocationCoordsToXY(List<TimeLine> timeLines, int width, int height)
        {
            List<XY> XYCoords = new List<XY>();

            //Iterate through activity timeline and convert Latitude and longitude into XY
            foreach (var t in timeLines)
            {
                //Mercator projection used to convert from spherical to straight lines
                double x = (t.Longitude + 180) * (width / 360); //Get X value
                double latRad = t.Latitude * Math.PI / 180; //Convert to radians
                double mercN = Math.Log(Math.Tan((Math.PI / 4) + (latRad / 2))); //Calculate Mercator projection for Y
                double y = (height / 2) - (width * mercN / (2 * Math.PI)); //Calculate Y

                XY xy = new XY(x, y);
                XYCoords.Add(xy);
            }
            NormaliseXYCoords(XYCoords);
            return XYCoords;
        }

        /// <summary>
        /// Method to normalise a list of XY coordinates
        /// </summary>
        /// <param name="XYCoords">List of XY coordinates</param>
        /// <returns>List of XY coordinates</returns>
        public List<XY> NormaliseXYCoords(List<XY> XYCoords)
        {
            List<XY> minMax = Calculations.Instance.FindMinMaxCoords(XYCoords); //Find the min and max XY
            int padding = 10; //Stop points occuring on edge, improves readability

            //XY normalised to 0-1 range and multiplied out to fit picturebox
            int multiplier = 200;
            foreach (var item in XYCoords)
            {
                item.X = ((item.X - minMax[0].X) / (minMax[1].X - minMax[0].X)) * multiplier + padding;
                item.Y = ((item.Y - minMax[0].Y) / (minMax[1].Y - minMax[0].Y)) * multiplier + padding;
            }
            return XYCoords;
        }
    }
}

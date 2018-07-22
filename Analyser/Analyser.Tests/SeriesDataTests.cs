using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AnalyserLibrary;

namespace Analyser.Tests
{
    public class SeriesDataTests
    {
        //public static readonly List<object[]> GetDistanceDataTestData = new List<object[]>
        //{
        //    new object[]{10, new DateTime(2018, 07, 19, 0, 0, 0), new DateTime(2018, 07, 19, 0, 0, 5), 2 },
        //    new object[]{13.32, new DateTime(2018, 07, 19, 0, 0, 0), new DateTime(2018, 07, 19, 0, 0, 10), 1.332 },
        //};

        //[Theory, MemberData(nameof(GetDistanceDataTestData))]
        //public void AvgMtrPerSecond_ShouldCalculate(double distance, DateTime c1Dt, double c1Lat, double c1Lon, 
        //    DateTime c2Dt, double c2Lat, double c2Lon, DateTime c3Dt, double c3Lat, double c3Lon)
        //{
        //    List<ChartData> expected = new List<ChartData>();
        //    List<Coordinates> coordinates = new List<Coordinates>();
        //    Coordinates c1 = new Coordinates(c1Dt, c1Lat, c1Lon);
        //    Coordinates c2 = new Coordinates(c2Dt, c2Lat, c2Lon);
        //    Coordinates c3 = new Coordinates(c3Dt, c3Lat, c3Lon);
        //    coordinates.Add(c1);
        //    coordinates.Add(c2);
        //    coordinates.Add(c3);

        //    //Assert
        //    Assert.Equal(expected, actual);
        //}
    }
}

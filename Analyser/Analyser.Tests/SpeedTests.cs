using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AnalyserLibrary;

namespace Analyser.Tests
{

    public class SpeedTests
    {
        public static readonly List<object[]> AvgMtrPerSecondtestData = new List<object[]>
        {
            new object[]{10, new DateTime(2018, 07, 19, 0, 0, 0), new DateTime(2018, 07, 19, 0, 0, 5), 2 },
            new object[]{13.32, new DateTime(2018, 07, 19, 0, 0, 0), new DateTime(2018, 07, 19, 0, 0, 10), 1.332 },
        };

        [Theory, MemberData(nameof(AvgMtrPerSecondtestData))]
        public void AvgMtrPerSecond_ShouldCalculate(double distance, DateTime startTime, DateTime endTime, double expected)
        {
            //Arrange

            //Act
            Speed speed = new Speed(distance, startTime, endTime);
            double actual = speed.AvgMtrPerSecond();

            //Assert
            Assert.Equal(expected, actual);
        }

        public static readonly List<object[]> AvgMtrPerSecondRndtestData = new List<object[]>
        {
            new object[]{10, new DateTime(2018, 07, 19, 0, 0, 0), new DateTime(2018, 07, 19, 0, 0, 5), 2 },
            new object[]{13.32, new DateTime(2018, 07, 19, 0, 0, 0), new DateTime(2018, 07, 19, 0, 0, 10), 1.33 },
        };

        [Theory, MemberData(nameof(AvgMtrPerSecondRndtestData))]
        public void AvgMtrPerSecondRnd_ShouldCalculate(double distance, DateTime startTime, DateTime endTime, double expected)
        {
            //Arrange

            //Act
            Speed speed = new Speed(distance, startTime, endTime);
            double actual = speed.AvgMtrPerSecondRnd();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

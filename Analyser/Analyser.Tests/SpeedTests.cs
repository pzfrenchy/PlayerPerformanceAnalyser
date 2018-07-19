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
        public static readonly List<object[]> testData = new List<object[]>
        {
            new object[]{10, new DateTime(2018, 07, 19, 0, 0, 0), new DateTime(2018, 07, 19, 0, 0, 5), 2 },
            new object[]{10, new DateTime(2018, 07, 19, 0, 0, 0), new DateTime(2018, 07, 19, 0, 0, 10), 1 },
        };

        [Theory, MemberData(nameof(testData))]
        public void AvgSpeed_ShouldCalculate(double distance, DateTime startTime, DateTime endTime, double expected)
        {
            //Arrange

            //Act
            Speed speed = new Speed();
            double actual = speed.AvgMtrPerSecond(distance, startTime, endTime);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalyserLibrary;
using Xunit;

namespace Analyser.Tests
{
    public class HaversineDistanceTests
    {
        [Theory]
        [InlineData(50.128953, -5.501886, 50.128953, -5.501900, 1.00)]
        [InlineData(50.128953, 5.501886, 50.128953, 5.501900, 1.00)]
        [InlineData(50.128921, -5.501482, 50.128953, -5.501900, 30.01)]
        [InlineData(50.128921, 5.501482, 50.128953, 5.501900, 30.01)]
        [InlineData(50.128921, -5.501482, 50.236, -5.522464, 12000.00)]
        [InlineData(50.128921, 5.501482, 50.236, 5.522464, 12000.00)]
        public void DistanceInMtrRnd_LatLonShouldCalculate(double lat1, double lon1, double lat2, double lon2, double expected)
        {
            //Arrange


            //Act
            HaversineDistance calc = new HaversineDistance(lat1, lon1, lat2, lon2);
            double actual = calc.DistanceInMtrRnd();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(50.128953, -5.501886, 50.128953, -5.501900, 0.99795960)]
        [InlineData(50.128953, 5.501886, 50.128953, 5.501900, 0.99795960)]
        [InlineData(50.128921, -5.501482, 50.128953, -5.501900, 30.00794101)]
        [InlineData(50.128921, 5.501482, 50.128953, 5.501900, 30.00794101)]
        [InlineData(50.128921, -5.501482, 50.236, -5.522464, 12000.00400153)]
        [InlineData(50.128921, 5.501482, 50.236, 5.522464, 12000.00400153)]
        public void DistanceInMtr_LatLonShouldCalculate(double lat1, double lon1, double lat2, double lon2, double expected)
        {
            //Arrange

            //Act
            HaversineDistance calc = new HaversineDistance(lat1, lon1, lat2, lon2);
            double actual = calc.DistanceInMtr();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

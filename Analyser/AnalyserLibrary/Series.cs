using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserLibrary
{
    public class Series
    {
        /// <summary>
        /// Class to hold data on Series objects used to populate a chart of average distance and speed statistics.
        /// </summary>
        /// <param name="d">Distance, distance</param>
        /// <param name="p">Speed, speed</param>
        public Series(Distance d, Speed s)
        {
            this.Distance = d;
            this.Speed = s;
        }

        public Distance Distance { get; set; }
        public Speed Speed { get; set; }
    }
}

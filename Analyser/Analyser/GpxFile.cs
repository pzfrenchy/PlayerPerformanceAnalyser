using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Analyser
{
    /// <summary>
    /// Represents a GPX file (Used in GPS). Provides methods to parse GPX data.
    /// </summary>
    class GpxFile
    {
        /// <summary> 
        /// Load the Xml document for parsing 
        /// </summary> 
        /// <param name="filePath">Fully qualified file name (local)</param> 
        /// <returns>XDocument</returns> 
        private XDocument GetGpxDoc(string filePath)
        {
            XDocument gpxDoc = XDocument.Load(filePath);
            return gpxDoc;
        }

        /// <summary> 
        /// Load the namespace for a standard GPX document 
        /// </summary> 
        /// <returns></returns> 
        private XNamespace GetGpxNameSpace()
        {
            XNamespace gpx = XNamespace.Get("http://www.topografix.com/GPX/1/1");
            return gpx;
        }

        /// <summary> 
        /// When passed a file, open it and parse all tracks and track segments from it.
        /// </summary> 
        /// <param name = "filePath" > Fully qualified file name(local)</param> 
        /// <returns>list of strings (csv) containing line delimited waypoints from the file</returns> 
        public List<string> GPXTracksList(string filePath)
        {
            List<string> trackList = new List<string>();
            XDocument gpxDoc = GetGpxDoc(filePath);
            XNamespace gpx = GetGpxNameSpace();
            var tracks = from track in gpxDoc.Descendants(gpx + "trk")
            select new
            {
                //If "name" element exists, cast will return "Value" property; otherwise, it will return null.
                Name = (string)track.Element(gpx + "name"),
                Segs = (from trackpoint in track.Descendants(gpx + "trkpt")
                    select new
                    {
                        Latitude = trackpoint.Attribute("lat").Value,
                        Longitude = trackpoint.Attribute("lon").Value,
                        Time = (string)trackpoint.Element(gpx + "time")
                    })
            };

            foreach (var trk in tracks)
            {
                // Populate track data objects. 
                foreach (var trkSeg in trk.Segs)
                {
                    // Populate trackList with track segments data. 
                    trackList.Add(
                    string.Format("{0}, {1}, {2}, {3}\n",
                    trk.Name, trkSeg.Latitude, trkSeg.Longitude, trkSeg.Time));
                }
            }
            return trackList;
        }
    }
}

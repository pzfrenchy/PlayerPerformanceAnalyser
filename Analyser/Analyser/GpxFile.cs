using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Analyser
{
    /// <summary>
    /// Represents a GPX file (Used in GPS). Provides methods to parse GPX data and return in a variety of types.
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
        /// <returns>list of strings containing line delimited waypoints from the file</returns> 
        public List<string> LoadGPXTracks(string filePath)
        {
            XDocument gpxDoc = GetGpxDoc(filePath);
            XNamespace gpx = GetGpxNameSpace();
            var tracks = from track in gpxDoc.Descendants(gpx + "trk")
            select new
            {
                Name = track.Element(gpx + "name") != null ?
                track.Element(gpx + "name").Value : null,
                Segs = (from trackpoint in track.Descendants(gpx + "trkpt")
                    select new
                    {
                        Latitude = trackpoint.Attribute("lat").Value,
                        Longitude = trackpoint.Attribute("lon").Value,
                        Elevation = trackpoint.Element(gpx + "ele") != null ?
                        trackpoint.Element(gpx + "ele").Value : null,
                        Time = trackpoint.Element(gpx + "time") != null ?
                        trackpoint.Element(gpx + "time").Value : null
                    })
            };

            List<string> list = new List<string>();
            foreach (var trk in tracks)
            {
                // Populate track data objects. 
                foreach (var trkSeg in trk.Segs)
                {
                    // Populate detailed track segments in the object model here. 
                    list.Add(
                    string.Format("Track:{0} - Latitude:{1} Longitude:{2} Elevation:{3} Date:{4}\n",
                    trk.Name, trkSeg.Latitude, trkSeg.Longitude, trkSeg.Elevation, trkSeg.Time));
                }
            }
            return list;
        }
    }
}

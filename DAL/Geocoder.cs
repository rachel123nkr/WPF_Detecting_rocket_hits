using BE;
using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using Newtonsoft.Json;
using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Linq;
namespace DAL
{
    public class Geocoder
    {
        private const string apiKey = "AqgzfMyr-vs9J0BpQHIHDlrhetth2oPUtLlgP3pqJPdjihpRRFcjnrNZBDbcnm5f"; //משתנה מטחת לאחת צריך להוריד API KEY
        private const string ServiceUri = "http://dev.virtualearth.net/REST/v1/Locations?locality={0}&addressLine={1}&key="+apiKey;


        public string getWebData(string urlAddress)
        {
            string webData = null;

            //try the URI, fail out if not successful 
            HttpWebRequest request;
            HttpWebResponse response;

            try
            {
                request = (HttpWebRequest)WebRequest.Create(urlAddress);
                response = (HttpWebResponse)request.GetResponse();
            }

            catch
            {
                //this could be modified for specific responses if needed
                return null;
            }

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;
                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                webData = readStream.ReadToEnd();

                response.Close();
                readStream.Close();
            }
            return webData;
        }


        public Coordinate Geocode(string address, string city)
        {
            if (string.IsNullOrEmpty(address))
                throw new ArgumentNullException("address");

            string requestUriString = string.Format(ServiceUri, Uri.EscapeDataString(address), Uri.EscapeDataString(city));

            string data = getWebData(requestUriString);
            var root = JsonConvert.DeserializeObject<RootObject>(data);

            foreach (var rs in root.resourceSets)
            {
                foreach (var r in rs.resources)
                {
                    Console.WriteLine(r.point.Coordinates[0] + " , " + r.point.Coordinates[1]);
                    return new Coordinate(r.point.Coordinates[0] , r.point.Coordinates[1]);
                }
            }
            return new Coordinate(0, 0);
        }




        public double GetDistanceBetweenPoints(Coordinate coo1, Coordinate coo2)
        {
            double lat1 = coo1.Latitude, long1 = coo2.Longitude, lat2 = coo2.Latitude, long2 = coo2.Longitude;
            double distance = 0;

            double dLat = (lat2 - lat1) / 180 * Math.PI;
            double dLong = (long2 - long1) / 180 * Math.PI;

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2)
                        + Math.Cos(lat1 / 180 * Math.PI) * Math.Cos(lat2 / 180 * Math.PI)
                        * Math.Sin(dLong / 2) * Math.Sin(dLong / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            //Calculate radius of earth
            // For this you can assume any of the two points.
            double radiusE = 6378135; // Equatorial radius, in metres
            double radiusP = 6356750; // Polar Radius

            //Numerator part of function
            double nr = Math.Pow(radiusE * radiusP * Math.Cos(lat1 / 180 * Math.PI), 2);
            //Denominator part of the function
            double dr = Math.Pow(radiusE * Math.Cos(lat1 / 180 * Math.PI), 2)
                            + Math.Pow(radiusP * Math.Sin(lat1 / 180 * Math.PI), 2);
            double radius = Math.Sqrt(nr / dr);

            //Calculate distance in meters.
            distance = radius * c;
            return distance; // distance in meters
        }

      
          public Coordinate getImageCoordinate(String myPath)
        {

            string path = myPath;// picture path
            var gps = ImageMetadataReader.ReadMetadata(path)
                             .OfType<GpsDirectory>()
                             .FirstOrDefault();

            var location = gps.GetGeoLocation();
            var latitude = location.Latitude;
            var longitude = location.Longitude;
            return new Coordinate(latitude, longitude);
            //Console.WriteLine("Image at {0},{1}", location.Latitude, location.Longitude);
        }

    }
}

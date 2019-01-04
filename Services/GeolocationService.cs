using SpeedPay.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace SpeedPay.Services
{
    internal class GeolocationService
    {
        public string BaseUrl
        {
            get
            {
                return "https://www.googleapis.com/geolocation/v1/geolocate?";
            }
        }

        private static readonly HttpClient client = new HttpClient();

        public GeolocationCustomer FindLocationCustomer(string apiKey)
        {
            string action = string.Format("key={0}", apiKey);

            var request = (HttpWebRequest)WebRequest.Create(BaseUrl + action);
            request.Method = "POST";
            request.ContentType = "application/json";

            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            reader.Close();
            response.Close();

            JObject locationJson = JObject.Parse(responseFromServer);

            var location = new GeolocationCustomer()
            {
                Lat = locationJson["location"]["lat"].ToString(),
                Lng = locationJson["location"]["lng"].ToString(),
                Accuracy = locationJson["accuracy"].ToString()
            };

            return location;

        }
    }
}

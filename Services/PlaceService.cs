using Newtonsoft.Json.Linq;
using SpeedPay.Models;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SpeedPay.Services
{
    internal class PlaceService
    {
        public string BaseUrl
        {
            get
            {
                return "https://maps.googleapis.com/maps/api/place/textsearch/json?";
            }
        }

        private static readonly HttpClient client = new HttpClient();

        public Place GetPlace(string origin, string lat, string lng, string apiKey)
        {

            var OriginOrder = new Order();
            OriginOrder.Origin = origin;

            var Apikey = apiKey;

            var LocationCustomer = new Customer();
            LocationCustomer.Lat = lat;
            LocationCustomer.Lng = lng;

            StringBuilder location = new StringBuilder();
            location.Append(LocationCustomer.Lat);
            location.Append(",");
            location.Append(LocationCustomer.Lng);

            string action = string.Format("query={0}&location={1}&radius=10000&key={2}", OriginOrder.Origin, location, apiKey);

            var request = (HttpWebRequest)WebRequest.Create(BaseUrl + action);

            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();
            JObject resultJson = JObject.Parse(responseFromServer);

            JArray bodyResult = (JArray)resultJson["results"];

            Place place = new Place() { Body = bodyResult.ToString() };

            response.GetResponseStream();

            reader.Close();
            response.Close();

            return place;
        }
    }
}
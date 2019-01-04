using Microsoft.AspNetCore.Mvc;
using SpeedPay.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeedPay.Controllers
{
    [Route("api/[controller]")]
    public class FindPlaceController
    {
        public string FindPlace()
        {
            var api = new PlaceService();

            var place = api.GetPlace("MacDonalds", "-23.5512625", "-46.8563475", "AIzaSyBI3MpxlI6VQt7s4jTdDo4JZw6fUVxSYLo");

            return place.Body;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using SpeedPay.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeedPay.Controllers
{
    [Route("api/[controller]")]
    public class GeolocationCustomerController
    {
        public string FindGeolocationCustomer()
        {
            var apiService = new GeolocationService();

            var location = apiService.FindLocationCustomer("AIzaSyBI3MpxlI6VQt7s4jTdDo4JZw6fUVxSYLo");
            
            return location.Lat + location.Lng;
        }
    }
}

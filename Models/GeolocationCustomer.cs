using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SpeedPay.Models
{
    public class GeolocationCustomer
    {
        public int Id { get; set; }

        public string Lat { get; set; }

        public string Lng { get; set; }

        public string Accuracy { get; set; }

        public Customer customer { get; set; }

    }
}

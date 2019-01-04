using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SpeedPay.Models
{
    public class Order
    { 
        public int Id {get ; set;}

        public string Origin { get; set; }

        public string Items { get; set; }

        public string CustomerId { get; set; }
     
    }
}
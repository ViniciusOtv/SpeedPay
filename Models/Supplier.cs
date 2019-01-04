using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SpeedPay.Models
{
    public class Supplier
    {
        public int Id { get ; set; }

        public string Name { get; set; }

        public string Item { get; set; }
    }
}
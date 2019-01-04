using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace SpeedPay.Models
{
    public class Payment : Order
    {
        public int Id { get; set; }

        public string PaymentForm { get ; set;}

        public double Value { get ; set;}

        public double Currency { get ; set;}

        public string Status { get ; set;}

        public DateTime Date { get ; set;}

        public string Description { get ; set; }

    }
}
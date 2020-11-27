using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HairForceOne.WebService.Models
{
    public class AltBooking
    {
        public List<Product> Products { get; set; }
        public List<Service> Services { get; set; }
        public Employee Employee { get; set; }
        public int Duration { get; set; }
        public float Price { get; set; }

    }
}
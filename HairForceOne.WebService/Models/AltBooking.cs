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
        public int UserId { get; set; }
        public Employee Employee { get; set; }
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }
        public float TotalPrice { get; set; }
        public string Comment { get; set; }

    }
}
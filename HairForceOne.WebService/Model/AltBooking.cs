﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HairForceOne.WebService.Models
{
    public class AltBooking
    {
        public int BookingId { get; set; }
        public int ProductId { get; set; }
        public int ServiceId { get; set; }
        public int UserId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }
        public decimal TotalPrice { get; set; }
        public string Comment { get; set; }

    }
}
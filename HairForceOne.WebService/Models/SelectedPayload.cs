using HairForceOne.WebService.Models;
using System;
using System.Collections.Generic;

namespace HairForceOne.WebService.Controllers
{
    public class SelectedPayload
    {
        public int Duration { get; set; }
        public DateTime SelectedDate { get; set; }
        public List<Employee> Employee { get; set; }
    }
}
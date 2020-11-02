using System;
using System.Collections.Generic;
using System.Text;

namespace HairForceOne.WebClient.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public List<Shift> Shifts { get; set; }
    }
}

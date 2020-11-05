using System;
using System.Collections.Generic;

namespace HairForceOne.WebClient.Models
{
    public class Salon
    {
        public List<Employee> Employees { get; private set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public Salon()
        {
            Employees = new List<Employee>();
        }


    }
}

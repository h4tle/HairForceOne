using System;
using System.Collections.Generic;
using System.Text;

namespace HairForceOne.WebService.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }

        public Customer()
        {

        }
    }
}

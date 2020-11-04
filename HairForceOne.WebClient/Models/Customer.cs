using System;
using System.Collections.Generic;
using System.Text;

namespace HairForceOne.WebClient.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public String LastName { get; set; }
        public string Email { get; set; }
        public String PhoneNumber { get; set; }

        public Customer()
        {
                
        }

        public Customer(String FirstName, String LastName, String Email, String PhoneNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
        }

        public Customer(string email, string phoneNumber)
        {
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}

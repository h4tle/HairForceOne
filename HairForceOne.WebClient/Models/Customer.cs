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
        public string UserName { get; set; }
        public String Password { get; set; }
        public bool IsAuthenticated { get; set; }
        public string grant_type { get; set; }

        public Customer()
        {
                
        }

        public Customer(String FirstName, String LastName, String Email, String PhoneNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.UserName = Email;
            this.Password = PhoneNumber;
        }

        public Customer(string email, string phoneNumber)
        {
            UserName = email;
            Password = phoneNumber;
        }
    }
}

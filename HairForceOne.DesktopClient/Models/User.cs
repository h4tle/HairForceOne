using System;

namespace HairForceOne.DesktopClient.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public String LastName { get; set; }
        public string Email { get; set; }
        public String PhoneNo { get; set; }
        public String Password { get; set; }

        public User(int id)
        {
        }

        public User(String FirstName, String LastName, String Email, String PhoneNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNo = PhoneNumber;
        }

        public User(string email, string phoneNumber)
        {
            Email = email;
            PhoneNo = phoneNumber;
        }

        public User()
        {
        }
    }
}
using Newtonsoft.Json;
using System;

namespace HairForceOne.WebService.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public String Password { get; set; }
        [JsonIgnore]
        public String Salt { get; set; }
        public string Roles { get; set; }

        public User()
        {
        }
    }
}
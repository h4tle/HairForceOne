using Newtonsoft.Json;
using System;

namespace HairForceOne.WebService.Models
    // Husk password
{
    /// <summary>
    /// This class contains the properties of the User instance
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets and sets the UserId
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets and sets the FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets and sets the LastName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets and sets the Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets and sets the PhoneNo
        /// </summary>
        public string PhoneNo { get; set; }

        [JsonIgnore]
        public String Password { get; set; }

        [JsonIgnore]
        public String Salt { get; set; }

        /// <summary>
        /// Gets and sets the Roles
        /// </summary>
        public string Roles { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="User""/>User.
        /// </summary>
        public User()
        {
        }
    }
}
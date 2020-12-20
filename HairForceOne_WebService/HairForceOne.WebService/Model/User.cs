using Newtonsoft.Json;

namespace HairForceOne.WebService.Model
{
    /// <summary>
    /// This class contains the properties for the User instance
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets and sets the UserId for the User instance
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets and sets the FirstName for the User instance
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets and sets the LastName for the User instance
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets and sets the Email for the User instance
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets and sets the PhoneNo for the User instance
        /// </summary>
        public string PhoneNo { get; set; }

        /// <summary>
        /// Gets and sets the PasswordHash for the User instance
        /// </summary>
        [JsonIgnore]
        public string PasswordHash { get; set; }

        /// <summary>
        /// Gets and sets the Password for the User instance
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets and sets the RoleId for the User instance
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Gets and sets the Salt for the User instance
        /// </summary>
        [JsonIgnore]
        public string Salt { get; set; }

        public User(int UserId_, string FirstName_, string LastName_, string Email_, string PhoneNo_, string PasswordHash_, int RoleId_, string Salt_)
        {
            this.UserId = UserId_;
            this.FirstName = FirstName_;
            this.LastName = LastName_;
            this.Email = Email_;
            this.PhoneNo = PhoneNo_;
            this.PasswordHash = PasswordHash_;
            this.RoleId = RoleId_;
            this.Salt = Salt_;
        }

        /// <summary>
        /// Initializes a new instance for the <see cref="User"/>
        /// </summary>
        public User()
        {
        }
    }
}
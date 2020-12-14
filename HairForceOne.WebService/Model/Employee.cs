using Newtonsoft.Json;

namespace HairForceOne.WebService.Models
    // husk password
{
    /// <summary>
    /// This class contains all the properties for the Employee instance
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets and sets the EmployeeId
        /// </summary>
        public int EmployeeId { get; set; }

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

        /// <summary>
        /// Gets and sets the Experience
        /// </summary>
        public int Experience { get; set; }

        /// <summary>
        /// Gets and sets the Gender
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Gets and sets the ProfilePicture
        /// </summary>
        public string ProfilePicture { get; set; }

        /// <summary>
        /// Gets and sets the Biography
        /// </summary>
        public string Biography { get; set; }

        /// <summary>
        /// Gets and sets the PasswordHash
        /// </summary>
        [JsonIgnore]
        public string PasswordHash { get; set; }

        /// <summary>
        /// Gets and sets the Salt
        /// </summary>
        [JsonIgnore]
        public string Salt { get; set; }

        /// <summary>
        /// Gets and sets the Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets and sets the Roles
        /// </summary>
        public string Roles { get; set; }

        public Employee(int EmployeeId, string FirstName, string LastName, string Email, string PhoneNo, int Experience, string Gender, string ProfilePicture, string Biography, string PasswordHash, string Salt, string Roles)
        {
            this.EmployeeId = EmployeeId;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNo = PhoneNo;
            this.Experience = Experience;
            this.Gender = Gender;
            this.ProfilePicture = ProfilePicture;
            this.Biography = Biography;
            this.PasswordHash = PasswordHash;
            this.Salt = Salt;
            this.Roles = Roles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/>
        /// </summary>
        public Employee()
        {
        }
    }
}
using Newtonsoft.Json;

namespace HairForceOne.WebService.Model
{
    /// <summary>
    /// This class contains all the properties for the Employee instance
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets and sets the EmployeeId for the Employee instance
        /// </summary>

        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets and sets the FirstName for the Employee instance
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets and sets the LastName for the Employee instance
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets and sets the Email for the Employee instance
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets and sets the PhoneNo for the Employee instance
        /// </summary>
        public string PhoneNo { get; set; }

        /// <summary>
        /// Gets and sets the Experience for the Employee instance
        /// </summary>
        public int Experience { get; set; }

        /// <summary>
        /// Gets and sets the Gender for the Employee instance
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Gets and sets the Biography for the Employee instance
        /// </summary>
        public string Biography { get; set; }

        /// <summary>
        /// Gets and sets the PasswordHash for the Employee instance
        /// </summary>

        [JsonIgnore]
        public string PasswordHash { get; set; }

        /// <summary>
        /// Gets and sets the Salt for the Employee instance
        /// </summary>
        [JsonIgnore]
        public string Salt { get; set; }

        /// <summary>
        /// Gets and sets the RoleId for the Employee instance
        /// </summary>
        public int RoleId { get; set; }

        public string Password { get; set; }

        public Employee(int EmployeeId_, string FirstName_, string LastName_, string Email_, string PhoneNo_, int Experience_, string Gender_, string Biography_, string PasswordHash_, string Salt_, int RoleId_)
        {
            this.EmployeeId = EmployeeId_;
            this.FirstName = FirstName_;
            this.LastName = LastName_;
            this.Email = Email_;
            this.PhoneNo = PhoneNo_;
            this.Experience = Experience_;
            this.Gender = Gender_;
            this.Biography = Biography_;
            this.PasswordHash = PasswordHash_;
            this.Salt = Salt_;
            this.RoleId = RoleId_;
        }

        /// <summary>
        /// Initializes a new instance for the <see cref="Employee"/>
        /// </summary>
        public Employee()
        {
        }
    }
}
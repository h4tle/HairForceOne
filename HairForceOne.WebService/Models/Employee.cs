using System;

namespace HairForceOne.WebService.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public int Experience { get; set; }
        public string Gender { get; set; }
        public string ProfilePicture { get; set; }
        public string Biography { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
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
    }
}
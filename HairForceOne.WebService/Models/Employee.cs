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
        public String PasswordHash { get; set; }
        public String Salt { get; set; }
        public string Roles { get; set; }
    }
}
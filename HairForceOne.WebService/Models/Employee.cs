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
		public string Roles { get; set; }
		public string Salt { get; set; }

		public Employee(int EmployeeId_, string FirstName_, string LastName_, string Email_, string PhoneNo_, int Experience_, string Gender_, string ProfilePicture_, string Biography_, string PasswordHash_, string Roles_, string Salt_)
		{
			this.EmployeeId = EmployeeId_;
			this.FirstName = FirstName_;
			this.LastName = LastName_;
			this.Email = Email_;
			this.PhoneNo = PhoneNo_;
			this.Experience = Experience_;
			this.Gender = Gender_;
			this.ProfilePicture = ProfilePicture_;
			this.Biography = Biography_;
			this.PasswordHash = PasswordHash_;
			this.Roles = Roles_;
			this.Salt = Salt_;
		}
	}
}
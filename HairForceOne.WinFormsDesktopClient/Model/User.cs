using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairForceOne.WinFormsDesktopClient.Model
{
	public class User
	{
		public int UserId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string PhoneNo { get; set; }
		public string Password { get; set; }
		public string Roles { get; set; }
		public string Salt { get; set; }

		public User(int UserId_, string FirstName_, string LastName_, string Email_, string PhoneNo_, string Password_, string Roles_, string Salt_)
		{
			this.UserId = UserId_;
			this.FirstName = FirstName_;
			this.LastName = LastName_;
			this.Email = Email_;
			this.PhoneNo = PhoneNo_;
			this.Password = Password_;
			this.Roles = Roles_;
			this.Salt = Salt_;
		}
	}
}

namespace HairForceOne.WinFormsDesktopClient.Model
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
        public string Biography { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }

        public Employee(int EmployeeId_, string FirstName_, string LastName_, string Email_, string PhoneNo_, int Experience_, string Gender_, string Biography_, int RoleId_)
        {
            this.EmployeeId = EmployeeId_;
            this.FirstName = FirstName_;
            this.LastName = LastName_;
            this.Email = Email_;
            this.PhoneNo = PhoneNo_;
            this.Experience = Experience_;
            this.Gender = Gender_;
            this.Biography = Biography_;
            this.RoleId = RoleId_;
        }
        public Employee()
        {

        }
    }
}
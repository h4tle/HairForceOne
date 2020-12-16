using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairForceOne.WinFormsDesktopClient.Model
{
	public class Booking
	{
        public int BookingId { get; set; }
		public int UserId { get; set; }
		public int EmployeeId { get; set; }
		public DateTime StartTime { get; set; }
		public int Duration { get; set; }
		public decimal TotalPrice { get; set; }
		public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDone { get; set; }
        public List<Service> Services { get; set; }
        public List<Product> Products { get; set; }

        public Booking(int userId, int employeeId, DateTime startTime, int duration, decimal totalPrice, string comment, DateTime createdAt, bool isDone)
        {
			this.UserId = userId;
			this.EmployeeId = employeeId;
			this.StartTime = startTime;
			this.Duration = duration;
			this.TotalPrice = totalPrice;
			this.Comment = comment;
			this.CreatedAt = createdAt;
			this.IsDone = isDone;
        }

		public Booking(int userId, int employeeId, DateTime startTime, int duration, decimal totalPrice, string comment, List<Service> serivces, List<Product> products)
		{
			this.UserId = userId;
			this.EmployeeId = employeeId;
			this.StartTime = startTime;
			this.Duration = duration;
			this.TotalPrice = totalPrice;
			this.Comment = comment;
			this.Services = serivces;
			this.Products = products;
		}
        public Booking(int v)
        {

        }
	}
}

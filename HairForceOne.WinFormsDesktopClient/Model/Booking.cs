using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairForceOne.WinFormsDesktopClient.Model
{
	public class Booking
	{
		public List<Product> Products { get; set; }
		public List<Service> Services { get; set; }
		public int UserId { get; set; }
		public Employee Employee { get; set; }
		public DateTime StartTime { get; set; }
		public int Duration { get; set; }
		public decimal TotalPrice { get; set; }
		public string Comment { get; set; }

        public Booking(List<Product> products, List<Service> services, int userId, Employee employee, DateTime startTime, int duration, decimal totalPrice, string comment)
        {
			this.Products = products;
			this.Services = services;
			this.UserId = userId;
			this.Employee = employee;
			this.StartTime = startTime;
			this.Duration = duration;
			this.TotalPrice = totalPrice;
			this.Comment = comment;
        }
	}
}

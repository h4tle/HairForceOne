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
        public int ProductId { get; set; }
		public int ServiceId { get; set; }
		public int UserId { get; set; }
		public int EmployeeId { get; set; }
		public DateTime StartTime { get; set; }
		public int Duration { get; set; }
		public decimal TotalPrice { get; set; }
		public string Comment { get; set; }

        public Booking(int productId, int serviceId, int userId, int employeeId, DateTime startTime, int duration, decimal totalPrice, string comment)
        {
			this.ProductId = productId;
			this.ServiceId = serviceId;
			this.UserId = userId;
			this.EmployeeId = employeeId;
			this.StartTime = startTime;
			this.Duration = duration;
			this.TotalPrice = totalPrice;
			this.Comment = comment;
        }
	}
}

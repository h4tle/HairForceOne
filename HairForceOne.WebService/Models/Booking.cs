using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HairForceOne.WebService.Models
{
	public class Booking
	{
		public int BookingId { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public decimal TotalPrice { get; set; }
		public int UserId { get; set; }
		public int EmployeeId { get; set; }
		public int ProductId { get; set; }
		public int ServiceId { get; set; }
		public string Comment { get; set; }

		public Booking(int BookingId_, DateTime StartTime_, DateTime EndTime_, decimal TotalPrice_, int UserId_, int EmployeeId_, int ProductId_, int ServiceId_, string Comment_)
		{
			this.BookingId = BookingId_;
			this.StartTime = StartTime_;
			this.EndTime = EndTime_;
			this.TotalPrice = TotalPrice_;
			this.UserId = UserId_;
			this.EmployeeId = EmployeeId_;
			this.ProductId = ProductId_;
			this.ServiceId = ServiceId_;
			this.Comment = Comment_;
		}
	}
}
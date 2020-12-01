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
		public decimal TotalPrice { get; set; }
		public int UserId { get; set; }
		public int EventId { get; set; }
		public string Comment { get; set; }

		public Booking(int BookingId_, decimal TotalPrice_, int UserId_, int EventId_, string Comment_)
		{
			this.BookingId = BookingId_;
			this.TotalPrice = TotalPrice_;
			this.UserId = UserId_;
			this.EventId = EventId_;
			this.Comment = Comment_;
		}
	}
}

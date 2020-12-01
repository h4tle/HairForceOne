using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairForceOne.WinFormsDesktopClient.Model
{
	public class Event
	{
		public int EventId { get; set; }
		public string Title { get; set; }
		public DateTime StartTime { get; set; }
		public int Duration { get; set; }
		public int EmployeeId { get; set; }
		public DateTime BookedDate { get; set; }

	public Event(int EventId_, string Title_, DateTime StartTime_, int Duration_, int EmployeeId_, DateTime BookedDate_,)
	{
		this.EventId = EventId_;
		this.Title = Title_;
		this.StartTime = StartTime_;
		this.Duration = Duration_;
		this.EmployeeId = EmployeeId_;
		this.BookedDate = BookedDate_;
	}
}
}

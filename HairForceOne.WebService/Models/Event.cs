using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HairForceOne.WebService.Models
{
	public class Event
	{
		public int EventId { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime Time { get; set; }
        public DateTime BookedDate { get; set; }
        public int Duration { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Interval { get; set; }
        public DateTime DesiredDate { get; set; }
        public int DesiredLength { get; set; }

        public Event()
        {

        }

		public Event(int EventId_, string Title_, DateTime Start_, int Duration_, DateTime StartTime_, DateTime EndTime_, int Interval_, DateTime DesiredDate_, int DesiredLength_)
		{
			this.EventId = EventId_;
			this.Title = Title_;
			this.Start = Start_;
			this.Duration = Duration_;
			this.StartTime = StartTime_;
			this.EndTime = EndTime_;
			this.Interval = Interval_;
			this.DesiredDate = DesiredDate_;
			this.DesiredLength = DesiredLength_;
		}
	}
}
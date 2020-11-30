﻿using System;
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
		public int Duration { get; set; }

        public Event()
        {

        }

		public Event(int EventId_, string Title_, DateTime Start_, int Duration_)
		{
			this.EventId = EventId_;
			this.Title = Title_;
			this.Start = Start_;
			this.Duration = Duration_;
		}
	}
}
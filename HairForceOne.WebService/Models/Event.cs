using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HairForceOne.WebService.Models
{
	public class Event
	{
		public Employee employee { get; set; }
        public DateTime SelectedDate { get; set; }
        public int Duration { get; set; }
	}
}
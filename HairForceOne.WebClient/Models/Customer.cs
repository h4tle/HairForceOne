using System;
using System.Collections.Generic;
using System.Text;

namespace HairForceOne.WebClient.Models
{
    public class Customer
    {
        private List<TimeBooking> _timeBookings; // Kender timebooking kunde eller kender kunde sine timebookings? Begge?
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public List<TimeBooking> TimeBookings
        {
            get
            {
                return _timeBookings;
            }
        }

        public Customer()
        {
            _timeBookings = new List<TimeBooking>();
        }
    }
}

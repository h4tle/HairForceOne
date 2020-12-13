using HairForceOne.WinFormsDesktopClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairForceOne.WinFormsDesktopClient.Controller
{
    interface IBookingsController
    {
        List<Booking> GetAllBookings();
        List<Booking> GetBookingsByDate(DateTime date);
        List<Booking> GetBookingsByEmployee(Employee employee, DateTime date);
        List<TimeSpan> GetAvailableTimes(Event e);
        NotImplementedException Create(Booking b);
        NotImplementedException Delete(int bookingId);
        NotImplementedException Edit(Booking b);

    }
}

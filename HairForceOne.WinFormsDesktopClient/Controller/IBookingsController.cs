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
        List<TimeSpan> GetAvailableTimes(Event e);
        NotImplementedException Create(Booking b);
        NotImplementedException Delete(Booking b);
        NotImplementedException Edit(Booking b);

    }
}

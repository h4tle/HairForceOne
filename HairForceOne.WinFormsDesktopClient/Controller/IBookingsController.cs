using HairForceOne.WinFormsDesktopClient.Model;
using System;
using System.Collections.Generic;

namespace HairForceOne.WinFormsDesktopClient.Controller
{
    internal interface IBookingsController
    {
        List<Booking> GetAllBookings();

        List<Booking> GetBookingsByDate(DateTime date);

        List<Booking> GetBookingsByEmployee(Employee employee, DateTime date);

        List<TimeSpan> GetAvailableTimes(Event e);

        NotImplementedException Create(Booking b);

        NotImplementedException Delete(int bookingId);

        bool Edit(Booking b);
    }
}
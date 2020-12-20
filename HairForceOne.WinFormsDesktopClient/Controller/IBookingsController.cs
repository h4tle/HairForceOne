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

        bool Create(Booking b);

        bool Delete(int bookingId);

        bool Edit(Booking b);
    }
}
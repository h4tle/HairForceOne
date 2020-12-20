using HairForceOne.WebService.Controllers;
using HairForceOne.WebService.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace WebServiceUnitTest
{
    [TestClass]
    public class BookingTests
    {
        private BookingsController bookingsController;

        [TestInitialize]
        public void Setup()
        {
            bookingsController = new BookingsController()
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };
        }

        [TestMethod]
        public void Test_GetAllBookings()
        {
            //Arrange
            try
            {
                var result = bookingsController.GetAllBookings();
                List<Booking> bookings;
                result.TryGetContentValue<List<Booking>>(out bookings);
                Assert.IsTrue(bookings.Count > 0);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Test_CreateBookingRollBack()
        {
            //Arrange
            var startResult = bookingsController.GetAllBookings();
            List<Booking> startBookings;
            startResult.TryGetContentValue<List<Booking>>(out startBookings);

            //Act
            Booking booking = new Booking();

            booking.Duration = 30;
            booking.StartTime = DateTime.Now;
            booking.UserId = 1;
            booking.EmployeeId = 2;
            booking.Products = null;
            Service service = new Service();
            service.Duration = 30;
            service.ServiceId = 1;
            service.Description = "Blob";
            service.Gender = "male";
            service.Price = 27;
            service.Title = "Jeg har skidt";
            List<Service> services = new List<Service>();
            services.Add(service);

            booking.Services = services;

            //Act
            var createdResult = bookingsController.CreateBooking(booking);
            //Assert
            Assert.IsFalse(createdResult.IsSuccessStatusCode);

            var endResult = bookingsController.GetAllBookings();
            List<Booking> endBookings;
            endResult.TryGetContentValue<List<Booking>>(out endBookings);

            Assert.AreEqual(startBookings.Count, endBookings.Count);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;
using HairForceOne.WebService.Controllers;
using HairForceOne.WebService.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebServiceUnitTest
{
    [TestClass]
    public class BookingTests
    {
        [TestMethod]
        public void Test_GetAllBookings()
        {
            var bookingController = new BookingsController()
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            try
            {
                var result = bookingController.GetAllBookings();
                List<Booking> bookings;
                result.TryGetContentValue<List<Booking>>(out bookings);
                Assert.IsTrue(bookings.Count > 0);
            }
            catch (Exception e) {
                Assert.Fail();
            }
        }
        
    }
}

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
        public void Test_GetAll()
        {
            var bookingController = new BookingsController()
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            try
            {
                var b = bookingController.GetAllBookings();
                Assert.AreEqual();
            }
            catch (Exception e) {
                Assert.Fail();
            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using HairForceOne.WebService.Controllers;

using HairForceOne.WebService.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebServiceUnitTest
{
    [TestClass]
    public class ServiceTests
    {
        [TestMethod]
        public void Test_GetAllServices()
        {
            //Arrange
            var servicesController = new ServicesController()
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };
            try
            {
                //Acts
                var result = servicesController.GetAllServices();
                List<Service> services;
                result.TryGetContentValue<List<Service>>(out services);

                //Assert
                Assert.IsTrue(services.Count > 0);

            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }
    }
}

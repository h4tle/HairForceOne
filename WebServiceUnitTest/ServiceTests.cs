using HairForceOne.WebService.Controllers;
using HairForceOne.WebService.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Transactions;
using System.Web.Http;

namespace WebServiceUnitTest
{
    /// <summary>
    /// This class contains the TestMethod that handles the Service testing
    /// </summary>
    [TestClass]
    ///
    public class ServiceTests
    {
        private TransactionScope scope;

        [TestInitialize]
        public void TestInitialize()
        {
            scope = new TransactionScope();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            scope.Dispose();
        }

        /// <summary>
        /// This test instantiate the ServicesController instance to execute the GetAllServices() method and retrieves a list, to checkes if the list is greater than 0
        /// </summary>
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

        /// <summary>
        /// This Method instantiate the ServicesController instance to execute the GetService method and retrieves a Services by ServiceID
        /// </summary>
        /// <param name="id"></param>
        [TestMethod]
        public void Test_GetService()
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
                var result = servicesController.GetService(26);

                //Assert
                Service service;
                Assert.IsTrue(result.TryGetContentValue<Service>(out service));

                Assert.AreEqual(26, service.ServiceId);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void CheckIfCreateNewServicesWorks()
        {
            // Arrange
            var servicesController = new ServicesController()
            {
                Request = new HttpRequestMessage
                {
                    RequestUri = new Uri("http://localhost:44382/api/services")
                },
                Configuration = new HttpConfiguration()
            };

            // Act
            Service service = new Service() { ServiceId = 99, Title = "Test1", Description = "Test1", Duration = 30, Price = 300, Gender = "Male" };
            var response = servicesController.CreateNewService(service);

            // Assert
            Assert.AreEqual("Test1", service.Title);
        }

        [TestMethod]
        public void CheckIfEditServiceWorks()
        {
            // Arrange
            var servicesController = new ServicesController()
            {
                Request = new HttpRequestMessage
                {
                    RequestUri = new Uri("http://localhost:44382/api/services")
                },
                Configuration = new HttpConfiguration()
            };

            // Act
            var result = servicesController.GetService(56);
            Service service;
            result.TryGetContentValue<Service>(out service);
            string noneupdatedtitle = service.Title;
            service.Title = "Test2";
            var response = servicesController.EditService(service);
            var newresult = servicesController.GetService(56);
            Service actual;

            newresult.TryGetContentValue<Service>(out actual);

            // Assert
            Assert.AreNotEqual(actual.Title, noneupdatedtitle);
        }
    }
}
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
    public class ServiceTests
    {
        private TransactionScope scope;
        private ServicesController servicesController;

        /// <summary>
        /// This method instantiate the ServicesController instance and the TransactionScope instance
        ///
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            scope = new TransactionScope();
            servicesController = new ServicesController()
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };
        }

        /// <summary>
        /// This test executes the GetAllServices() method to retrieves a list, we check if the list is greater than 0
        /// </summary>
        [TestMethod]
        public void Test_GetAllServices()
        {
            //Arrange
            var result = servicesController.GetAllServices();
            try
            {
                //Acts
                List<Service> services;
                result.TryGetContentValue<List<Service>>(out services);

                //Assert
                Assert.IsTrue(services.Count > 0);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// This test executes the GetService method to retrieves a Services by ServiceID
        /// </summary>
        [TestMethod]
        public void Test_GetService()
        {
            //Arrange
            var result = servicesController.GetService(1);
            try
            {
                //Acts
                Service service;

                //Assert
                Assert.IsTrue(result.TryGetContentValue<Service>(out service));
                Assert.AreEqual(1, service.ServiceId);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// This test executes the CreateNewService() with a new Service to check for SuccessStatusCode
        /// </summary>
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
            try
            {
                // Act
                Service service = new Service() { ServiceId = 1, Title = "Test1", Description = "Test1", Duration = 30, Price = 300, Gender = "Male" };
                var response = servicesController.CreateNewService(service);

                // Assert
                Assert.IsTrue(response.IsSuccessStatusCode);
                Assert.AreEqual("Test1", service.Title);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// This test executes the GetService() to retrieve a service
        /// Than executes the EditService() method with an update in the Title, checks for SucessStatuscode and the two Titles not being Equal
        /// </summary>
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
            try
            {
                // Act
                var result = servicesController.GetService(1);
                Service service;
                result.TryGetContentValue<Service>(out service);
                string noneupdatedtitle = service.Title;
                service.Title = "Test";
                var response = servicesController.EditService(service);
                var newresult = servicesController.GetService(1);
                Service actual;

                newresult.TryGetContentValue<Service>(out actual);

                // Assert
                Assert.IsTrue(response.IsSuccessStatusCode);
                Assert.AreNotEqual(actual.Title, noneupdatedtitle);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// This method executes the Dispose() that cleans the Scope
        /// </summary>
        [TestCleanup]
        public void TestCleanup()
        {
            scope.Dispose();
        }
    }
}
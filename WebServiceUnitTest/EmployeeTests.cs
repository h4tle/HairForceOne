using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Http;
using System.Transactions;
using System.Web.Configuration;
using System.Web.Http;
using HairForceOne.WebService.Controllers;
using HairForceOne.WebService.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebServiceUnitTest
{
    [TestClass]
    public class EmployeeTests
    {
        private TransactionScope scope;
        private EmployeesController employeesController;

        [TestInitialize]
        public void Setup()
        {
            scope = new TransactionScope();
            employeesController = new EmployeesController()
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };
        }


        [TestMethod]
        public void Test_GetAllEmployees()
        {
            // Arrange
            try
            {
                // Act
                var result = employeesController.GetAllEmployees();
                List<Employee> employees;
                result.TryGetContentValue<List<Employee>>(out employees);
                // Assert
                Assert.IsTrue(employees.Count > 0);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        [TestCleanup]
        public void TestCleanup()
        {
            scope.Dispose();
        }
    }
}

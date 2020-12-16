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
        [TestMethod]
        public void Test_GetAllEmployees()
        {
            var employeesController = new EmployeesController()
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            try
            {

                var result = employeesController.GetAllEmployees();
                List<Employee> employees;
                result.TryGetContentValue<List<Employee>>(out employees);
                Assert.IsTrue(employees.Count > 0);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

    }
}

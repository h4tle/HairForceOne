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
    [TestClass]
    public class EmployeeTests
    {
        private TransactionScope scope;
        private EmployeesController employeesController;

        /// <summary>
        /// This method instantiate the EmployeeController instance and the TransactionScope instance
        ///
        /// </summary>
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
        /// <summary>
        /// This test executes the GetAllEmployees() method to retrieves a list, we check if the list is greater than 0
        /// </summary>
        [TestMethod]
        public void Test_GetAllEmployees()
        {
            // Arrange
            var result = employeesController.GetAllEmployees();
            try
            {
                // Act
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

        /// <summary>
        /// This test executes the GetEmployee method to retrieves a Employee by EmployeeID
        /// </summary>
        [TestMethod]
        public void Test_GetEmployee()
        {
            //Arrange

            var result = employeesController.GetEmployee(1);
            try
            {
                //Acts
                Employee employee;

                //Assert
                Assert.IsTrue(result.TryGetContentValue<Employee>(out employee));
                Assert.AreEqual(1, employee.EmployeeId);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// This test executes the CreateNewEmployee() with a new Service to check for SuccessStatusCode
        /// </summary>
        [TestMethod]
        public void CheckIfCreateNewEmployeeWorks()
        {
            // Arrange
            var employeesController = new EmployeesController()
            {
                Request = new HttpRequestMessage
                {
                    RequestUri = new Uri("http://localhost:44382/api/employees")
                },
                Configuration = new HttpConfiguration()
            };
            try
            {
                // Act
                Employee employee = new Employee() { EmployeeId = 1, FirstName = "TestEmployee", LastName = "TestEmployee", Email = "test@test.dk", PhoneNo = "11223344", Experience = 2, Gender = "Male", Biography = "Test", Password = "12345678", RoleId = 2, PasswordHash = "", Salt = "" };
                var response = employeesController.CreateNewEmployee(employee);

                // Assert
                Assert.IsTrue(response.IsSuccessStatusCode);
                Assert.AreEqual("TestEmployee", employee.FirstName);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// This test executes the GetEmployee() to retrieve an employee
        /// Than executes the EditEmployee() method with an update in the FirstName, checks for SucessStatuscode and the two FirstName not being Equal
        /// </summary>
        [TestMethod]
        public void CheckIfEditEmployeeWorks()
        {
            // Arrange
            var employeesController = new EmployeesController()

            {
                Request = new HttpRequestMessage
                {
                    RequestUri = new Uri("http://localhost:44382/api/employees")
                },
                Configuration = new HttpConfiguration()
            };
            try
            {
                // Act
                var result = employeesController.GetEmployee(1);
                Employee employee;
                result.TryGetContentValue<Employee>(out employee);
                string noneupdatedtitle = employee.FirstName;
                employee.FirstName = "Test";
                var response = employeesController.EditEmployee(employee);
                var newresult = employeesController.GetEmployee(1);
                Employee actual;

                newresult.TryGetContentValue<Employee>(out actual);

                // Assert
                Assert.IsTrue(response.IsSuccessStatusCode);
                Assert.AreNotEqual(actual.FirstName, noneupdatedtitle);
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
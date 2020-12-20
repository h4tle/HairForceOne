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
    public class UserTests
    {
        private TransactionScope scope;
        private UsersController usersController;

        /// <summary>
        /// This method instantiate the UsersController instance and the TransactionScope instance
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            scope = new TransactionScope();
            usersController = new UsersController()
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };
        }

        /// <summary>
        /// This test executes the GetAllUsers() method to retrieves a list, we check if the list is greater than 0
        /// </summary>
        [TestMethod]
        public void Test_GetAllUsers()
        {
            // Arrange
            var result = usersController.GetAllUsers();
            try
            {
                // Act
                result.TryGetContentValue<List<User>>(out List<User> users);

                // Assert
                Assert.IsTrue(users.Count > 0);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// This test executes the GetUsers() method to retrieves a User by UserId
        /// </summary>
        [TestMethod]
        public void Test_GetUser()
        {
            //Arrange

            var result = usersController.GetUser(1);
            try
            {
                //Acts

                //Assert
                Assert.IsTrue(result.TryGetContentValue<User>(out User user));
                Assert.AreEqual(1, user.UserId);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// This test executes the CreateNewUser() with a new User to check for SuccessStatusCode
        /// </summary>
        [TestMethod]
        public void CheckIfCreateNewUserWorks()
        {
            // Arrange
            var userController = new UsersController()
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
                User user = new User() { UserId = 1, FirstName = "TestUser", LastName = "TestUser", Email = "test@test.dk", PhoneNo = "11223344", Password = "12345678", RoleId = 2, PasswordHash = "", Salt = "" };
                var response = userController.CreateNewUser(user);

                // Assert
                Assert.IsTrue(response.IsSuccessStatusCode);
                Assert.AreEqual("TestUser", user.FirstName);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// This test executes the GetUser() to retrieve an user
        /// Than executes the EditUser() method with an update in the FirstName, checks for SucessStatuscode and the two FirstName not being Equal
        /// </summary>
        [TestMethod]
        public void CheckIfEditUserWorks()
        {
            // Arrange
            var usersController = new UsersController()

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
                var result = usersController.GetUser(1);
                result.TryGetContentValue<User>(out User user);
                string noneupdatedtitle = user.FirstName;
                user.FirstName = "Anders";
                var response = usersController.EditUser(user);
                var newresult = usersController.GetUser(1);

                newresult.TryGetContentValue<User>(out User actual);

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
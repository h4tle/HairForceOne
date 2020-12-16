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
    public class UserTests
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
        public void Test_GetAllUsers()
        {
            var usersController = new UsersController()
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };

            try
            {
                var result = usersController.GetAllUsers();
                List<User> users;
                result.TryGetContentValue<List<User>>(out users);
                Assert.IsTrue(users.Count > 0);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

    }
}

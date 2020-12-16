using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Transactions;
using System.Web.Http;
using HairForceOne.WebService.Controllers;
using HairForceOne.WebService.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebServiceUnitTest
{
    [TestClass]
    public class ProductTests
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
        public void Test_GetAllProducts()
        {
            //Arrange
            var productsController = new ProductsController()
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };
            try
            {
            //Acts
            var result = productsController.GetAllProducts();
            List<Product> products;
            result.TryGetContentValue<List<Product>>(out products);

            //Assert
            Assert.IsTrue(products.Count > 0);

            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }
    }
}

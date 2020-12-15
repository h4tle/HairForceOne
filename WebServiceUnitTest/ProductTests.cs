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
    public class ProductTests
    {
        [TestMethod]
        public void TestMethod1()
        {

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

            //Act
            var result = productsController.GetAllProducts();
            List<Product> products;
            result.TryGetContentValue<List<Product>>(out products);

            //Assert
            Assert.IsTrue(products.Count > 0);
        }
    }
}

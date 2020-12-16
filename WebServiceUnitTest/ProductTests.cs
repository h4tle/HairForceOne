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
    /// This class contains the TestMethod that handles the Product testing
    /// </summary>
    [TestClass]
    public class ProductTests
    {
        private TransactionScope scope;
        private ProductsController productsController;

        /// <summary>
        /// This method instantiate the ProductsController instance and the TransactionScope instance
        ///
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            scope = new TransactionScope();
            productsController = new ProductsController()
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };
        }

        /// <summary>
        /// This test executes the GetAllProducts() method to retrieves a list, we check if the list is greater than 0
        /// </summary>
        [TestMethod]
        public void Test_GetAllProducts()
        {
            //Arrange

            var result = productsController.GetAllProducts();
            try
            {
                //Acts
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

        /// <summary>
        /// This test executes the GetProduct method to retrieves a Product by ProductID
        /// </summary>
        [TestMethod]
        public void Test_GetProduct()
        {
            //Arrange
            var result = productsController.GetProduct(1);
            try
            {
                //Acts
                Product product;

                //Assert
                Assert.IsTrue(result.TryGetContentValue<Product>(out product));
                Assert.AreEqual(1, product.ProductId);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// This test executes the CreateNewProduct() with a new Product to check for SuccessStatusCode
        /// </summary>
        [TestMethod]
        public void CheckIfCreateNewProductWorks()
        {
            // Arrange
            var productsController = new ProductsController()
            {
                Request = new HttpRequestMessage
                {
                    RequestUri = new Uri("http://localhost:44382/api/product")
                },
                Configuration = new HttpConfiguration()
            };
            try
            {
                // Act
                Product product = new Product() { ProductId = 1, Brand = "Test", Title = "Test", Description = "Test", PurchasePrice = 100, RetailPrice = 1000, Gender = "Male" };
                var response = productsController.CreateNewProduct(product);

                // Assert
                Assert.IsTrue(response.IsSuccessStatusCode);
                Assert.AreEqual("Test", product.Title);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// This test executes the GetProduct() to retrieve a product
        /// Than executes the EditProduct() method with an update in the Title, checks for SucessStatuscode and the two Titles not being Equal
        /// </summary>
        [TestMethod]
        public void CheckIfEditProductWorks()
        {
            // Arrange
            var productsController = new ProductsController()
            {
                Request = new HttpRequestMessage
                {
                    RequestUri = new Uri("http://localhost:44382/api/product")
                },
                Configuration = new HttpConfiguration()
            };
            try
            {
                // Act
                var result = productsController.GetProduct(1);
                Product product;
                result.TryGetContentValue<Product>(out product);
                string noneupdatedtitle = product.Title;
                product.Title = "Test";
                var response = productsController.EditProduct(product);
                var newresult = productsController.GetProduct(1);
                Product actual;

                newresult.TryGetContentValue<Product>(out actual);

                // Assert
                Assert.IsTrue(response.IsSuccessStatusCode);
                Assert.AreNotEqual(actual.Title, noneupdatedtitle);
            }
            catch (Exception e)
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
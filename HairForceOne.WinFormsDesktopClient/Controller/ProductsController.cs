using HairForceOne.WinFormsDesktopClient.Model;
using Meziantou.Framework.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

// håndter exceptions (custom exception??)
// tag exception fra statuscode og håndter den
// try catch (Måske)
// navngiv metoder
// async

namespace HairForceOne.WinFormsDesktopClient.Controller
{
    internal class ProductsController : IProductsController
    {
        private readonly HttpClient client = new HttpClient();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsController"/> class.
        /// </summary>
        public ProductsController()
        {
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["HairForceOneApiURL"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", CredentialManager.ReadCredential(applicationName: "Token").Password);
        }

        /// <summary>
        /// This method gets a list of all Product objects using HttpClient
        /// </summary>
        /// <returns>A list of Products</returns>
        public List<Product> GetAllProducts()
        {
            Task<HttpResponseMessage> responseTask = client.GetAsync($"products");
            responseTask.Wait();
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(responseTask.Result.Content.ReadAsStringAsync().Result);
            return products;
        }

        /// <summary>
        /// This method gets a specific ProductId from the list of Product objects using HttpClient
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A Product object by ProductId</returns>
        //Todo
        public Service GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This methods posts a new Product object using HttpClient
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public NotImplementedException CreateNewProduct(Product product)
        {
            var JProduct = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");
            Task<HttpResponseMessage> responseTask = client.PostAsync($"products/", JProduct);
            responseTask.Wait();

            if (responseTask.Result.IsSuccessStatusCode)
            {
                return new NotImplementedException();
            }
            else
            {
                return new NotImplementedException();
            }
        }

        /// <summary>
        /// This method updates the exsisting Product object using HttpClient
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public NotImplementedException EditProduct(Product product)
        {
            var JProduct = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");
            Task<HttpResponseMessage> responseTask = client.PutAsync($"products/{product.ProductId}", JProduct);
            responseTask.Wait();

            if (responseTask.Result.IsSuccessStatusCode)
            {
                return new NotImplementedException();
            }
            else
            {
                return new NotImplementedException();
            }
        }

        /// <summary>
        /// This method deletes the Product object from the database, using HttpClient
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public NotImplementedException DeleteProduct(int id)
        {
            Task<HttpResponseMessage> responseTask = client.DeleteAsync($"products/{id}");
            responseTask.Wait();

            if (responseTask.Result.IsSuccessStatusCode)
            {
                return new NotImplementedException();
            }
            else
            {
                return new NotImplementedException();
            }
        }
    }
}
using HairForceOne.WinFormsDesktopClient.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HairForceOne.WinFormsDesktopClient.Controller
{
    class ProductsController : IProductsController
    {
        HttpClient client = new HttpClient();
        public ProductsController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["HairForceOneApiURL"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "Your Oauth token");
        }

        public NotImplementedException Create(Product product)
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

        public NotImplementedException Delete(int id)
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

        public Service GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {

            Task<HttpResponseMessage> responseTask = client.GetAsync($"products");
            responseTask.Wait();
            List<Product> l = JsonConvert.DeserializeObject<List<Product>>(responseTask.Result.Content.ReadAsStringAsync().Result);
            return l;
        }

        public NotImplementedException Update(Product product)
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
    }
}

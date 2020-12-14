using HairForceOne.WinFormsDesktopClient.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

// håndter exceptions (custom exception??)
// tag exception fra statuscode og håndter den
// try catch (Måske)
// navngiv metoder
// async
// fjern RestSharp
namespace HairForceOne.WinFormsDesktopClient.Controller
{
    class ServicesController : IServicesController
    {
        private RestClient client;
        private HttpClient client2;

        public ServicesController()
        {
            client = new RestClient(ConfigurationManager.AppSettings["HairForceOneApiURL"]);

            client2 = new HttpClient();
            client2.BaseAddress = new Uri(ConfigurationManager.AppSettings["HairForceOneApiURL"]);
            client2.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "Your Oauth token");
        }
        public NotImplementedException Create(Service service)
        {
            var JService = new StringContent(JsonConvert.SerializeObject(service), Encoding.UTF8, "application/json");
            Task<HttpResponseMessage> responseTask = client2.PostAsync($"services/", JService);
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
            Task<HttpResponseMessage> responseTask = client2.DeleteAsync($"services/{id}");
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

        public Service GetService(int id)
        {
            throw new NotImplementedException();
        }

        public List<Service> GetServices()
        {
            var request = new RestRequest("services", Method.GET);
            IRestResponse response = client.Execute(request);
            List<Service> l = JsonConvert.DeserializeObject<List<Service>>(response.Content);
            return l;
        }

        public NotImplementedException Update(Service service)
        {

                var JService = new StringContent(JsonConvert.SerializeObject(service), Encoding.UTF8, "application/json");
                Task<HttpResponseMessage> responseTask = client2.PutAsync($"services/{service.ServiceId}", JService);
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

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
// fjern RestSharp

/// <summary>
/// This class contains the HttpClient methods that handles the Service instance
/// </summary>
namespace HairForceOne.WinFormsDesktopClient.Controller
{
     internal class ServicesController : IServicesController
    {
        private readonly HttpClient client = new HttpClient();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServicesController"/> class.
        /// </summary>
        public ServicesController()
        {
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["HairForceOneApiURL"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", CredentialManager.ReadCredential(applicationName: "Token").Password);
        }

        /// <summary>
        /// This method gets a list of all Service objects using HttpClient
        /// </summary>
        /// <returns>A List of Services</returns>

        public List<Service> GetAllServices()
        {
            Task<HttpResponseMessage> responseTask = client.GetAsync($"services");
            responseTask.Wait();
            List<Service> services = JsonConvert.DeserializeObject<List<Service>>(responseTask.Result.Content.ReadAsStringAsync().Result);
            return services;
        }

        /// <summary>
        /// This method gets a specific ServiceId from the list of Service objects using HttpClient
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A Service object by ServiceId</returns>
        public Service GetService(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method posts a new Service object using HttpClint
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        public NotImplementedException CreateNewService(Service service)
        {
            var JService = new StringContent(JsonConvert.SerializeObject(service), Encoding.UTF8, "application/json");
            Task<HttpResponseMessage> responseTask = client.PostAsync($"services/", JService);
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
        /// This method updates the exsisting Service object using HttpClient
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        public NotImplementedException EditService(Service service)
        {
            var JService = new StringContent(JsonConvert.SerializeObject(service), Encoding.UTF8, "application/json");
            Task<HttpResponseMessage> responseTask = client.PutAsync($"services/{service.ServiceId}", JService);
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
        /// This method deletes the Service object from the database, using HttpClient
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public NotImplementedException DeleteService(int id)
        {
            Task<HttpResponseMessage> responseTask = client.DeleteAsync($"services/{id}");
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
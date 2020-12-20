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

/// <summary>
/// This class contains the HttpClient methods that handles User instance
/// </summary>
namespace HairForceOne.WinFormsDesktopClient.Controller
{
    internal class UsersController : IUsersController
    {
        private readonly HttpClient client = new HttpClient();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class.
        /// </summary>
        public UsersController()
        {
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["HairForceOneApiURL"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", CredentialManager.ReadCredential(applicationName: "Token").Password);
        }

        /// <summary>
        /// This method gets a list of all User object using HttpClient
        /// </summary>
        /// <returns>A List of Users</returns>
        public List<User> GetUsers()
        {
            Task<HttpResponseMessage> responseTask = client.GetAsync($"users");
            responseTask.Wait();
            if (responseTask.Result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<User>>(responseTask.Result.Content.ReadAsStringAsync().Result);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public bool CreateNewUser(User user)
        {
            var JUser = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            Task<HttpResponseMessage> responseTask = client.PostAsync($"users/", JUser);
            responseTask.Wait();
            return responseTask.Result.IsSuccessStatusCode;
        }

        public bool EditUser(User user)
        {
            var JUser = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            Task<HttpResponseMessage> responseTask = client.PutAsync($"users/{user.UserId}", JUser);
            responseTask.Wait();
            return responseTask.Result.IsSuccessStatusCode;
        }

        public bool DeleteUser(int id)
        {
            Task<HttpResponseMessage> responseTask = client.DeleteAsync($"users/{id}");
            responseTask.Wait();
            return responseTask.Result.IsSuccessStatusCode;
        }

        public User GetUser(int id)
        {
            Task<HttpResponseMessage> responseTask = client.GetAsync($"users/{id}");
            responseTask.Wait();
            if (responseTask.Result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<User>(responseTask.Result.Content.ReadAsStringAsync().Result);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
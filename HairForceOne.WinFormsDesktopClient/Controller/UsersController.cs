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
    class UsersController : IUsersController
    {
        HttpClient client = new HttpClient();
        public UsersController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["HairForceOneApiURL"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "Your Oauth token");
        }
        public NotImplementedException Create(User user)
        {
            var JUser = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            Task<HttpResponseMessage> responseTask = client.PostAsync($"users/", JUser);
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
            Task<HttpResponseMessage> responseTask = client.DeleteAsync($"users/{id}");
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

        public List<User> GetUsers()
        {
            Task<HttpResponseMessage> responseTask = client.GetAsync($"users");
            responseTask.Wait();
            List<User> ul = JsonConvert.DeserializeObject<List<User>>(responseTask.Result.Content.ReadAsStringAsync().Result);
            return ul;
        }


        public NotImplementedException Update(User user)
        {
            var JUser = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            Task<HttpResponseMessage> responseTask = client.PutAsync($"users/{user.UserId}", JUser);
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

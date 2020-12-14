using HairForceOne.WinFormsDesktopClient.Model;
using Meziantou.Framework.Win32;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net.Http;
using System.Text;

namespace HairForceOne.WinFormsDesktopClient.Controller
{
    internal class LoginController
    {
        private HttpClient client;

        public LoginController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["HairForceOneApiURL"]);
        }

        public bool Login(string Email, string Password)
        {
            bool LoggedIn = false;
            using (client)
            {
                var responseTask = client.PostAsync("token", new StringContent(string.Format("grant_type=password&username={0}&password={1}", Email, Password), Encoding.UTF8));
                
                responseTask.Wait();
                if (responseTask.Result.IsSuccessStatusCode)
                {
                    Token token = JsonConvert.DeserializeObject<Token>(responseTask.Result.Content.ReadAsStringAsync().Result);
                    CredentialManager.WriteCredential(
                    applicationName: "Token",
                    userName: Email,
                    secret: token.AccessToken,
                    persistence: CredentialPersistence.Session);
                    LoggedIn = true;
                    return LoggedIn;
                }
                else
                {
                    return LoggedIn;
                }
            }
        }
    }
}
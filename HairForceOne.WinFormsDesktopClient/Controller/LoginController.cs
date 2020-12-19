using HairForceOne.WinFormsDesktopClient.Model;
using Meziantou.Framework.Win32;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net.Http;
using System.Text;

namespace HairForceOne.WinFormsDesktopClient.Controller
{
    /// <summary>
    /// This class contains the HttpClient methods that handles login with Bearer token
    /// </summary>
    internal class LoginController : ILoginsControlller
    {
        private readonly HttpClient client = new HttpClient();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginController"/> class.
        /// </summary>
        public LoginController()
        {
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["HairForceOneApiURL"]);
        }

        /// <summary>
        /// This methods posts the Email, Password and Grant_type for validation using HttpClient
        /// </summary>
        /// <param name="Email"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        // Todo
        public bool Login(string Email, string Password)
        {
            bool LoggedIn = false;

            var responseTask = client.PostAsync("token", new StringContent(string.Format("grant_type=password&username={0}&password={1}", Email, Password), Encoding.UTF8));

            responseTask.Wait();
            if (responseTask.Result.IsSuccessStatusCode)
            {
                Token token = JsonConvert.DeserializeObject<Token>(responseTask.Result.Content.ReadAsStringAsync().Result);

                // Meziantou.Framework.Win32
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
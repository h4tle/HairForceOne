using HairForceOne.WebClient.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Mvc;

namespace HairForceOne.WebClient.Controllers
{
    [Authorize]
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="Email"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        [HttpPost]
        public object Index(String Email, String Password)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44382");
                var responseTask = client.PostAsync("token", new StringContent(string.Format("grant_type=password&username={0}&password={1}", Email, Password), Encoding.UTF8));
                responseTask.Wait();

                //If success received
                if (responseTask.Result.IsSuccessStatusCode)
                {
                    Token token = responseTask.Result.Content.ReadAsAsync<Token>().Result;
                    Session["Token"] = token;

                    using (var client2 = new HttpClient())
                    {
                        client2.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);
                        client2.BaseAddress = new Uri("https://localhost:44382/api/");

                        responseTask = client2.GetAsync($"users/1");
                        responseTask.Wait();

                        if (responseTask.Result.IsSuccessStatusCode)
                        {
                            Session["User"] = responseTask.Result.Content.ReadAsAsync<User>().Result;

                            return RedirectToAction("Index", "Users");
                        }
                        else
                        {
                            return RedirectToAction("Error");
                        }
                    }

                }
                else
                {
                    return RedirectToAction("Error");
                }
            }
        }
    }
}
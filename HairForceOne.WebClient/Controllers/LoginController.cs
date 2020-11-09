using HairForceOne.WebClient.Models;
using System;
using System.Net.Http;
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
                    return RedirectToAction("Index", "Users");
                }
                else
                {
                    return RedirectToAction("Error");
                }
            }
        }
    }
}
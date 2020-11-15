using HairForceOne.WebClient.Models;
using HairForceOne.WebClient.Util;
using System;
using System.Net.Http;
using System.Text;
using System.Web.Mvc;

namespace HairForceOne.WebClient.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public object Index(String Email, String Password)
        {
            using (HttpClient client = new HttpClientHairForce().SetBase())
            {
                var responseTask = client.PostAsync("token", new StringContent(string.Format("grant_type=password&username={0}&password={1}", Email, Password), Encoding.UTF8));
                responseTask.Wait();
                if (responseTask.Result.IsSuccessStatusCode)
                {
                    Token token = responseTask.Result.Content.ReadAsAsync<Token>().Result;
                    Session["Token"] = token;

                    using (HttpClient client2 = new HttpClientHairForce().SetBase())
                    {
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
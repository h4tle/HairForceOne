using HairForceOne.WebClient.Models;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

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

        [HttpPost]
        public object Index(String Email, String Password)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44382");

                var responseTask = client.PostAsync("token", new StringContent(string.Format("grant_type=password&username={0}&password={1}", Email, Password), Encoding.UTF8));
                responseTask.Wait();
                //var claims = client.GetAsync("api/login");
                //claims.Wait();
                //var test333 = claims.Result.Content.ReadAsStringAsync();
                //ClaimsPrincipal.Current = claims.Result;

                //HttpContext.User = responseTask.Result.Content.Headers;
                //To store result of web api response.   
                var result = responseTask.Result.Content.ReadAsStringAsync();
                result.Wait();

                var test34 = responseTask.Result.Content.Headers;
                var test55 = responseTask.Result.Content.ReadAsStringAsync();
                var test77 = responseTask.Result.Headers.WwwAuthenticate;
                var prinicpal = (ClaimsPrincipal)Thread.CurrentPrincipal;

                prinicpal.Claims.ToList();
                var test2 = HttpContext.User.Identity;
                var test5 = ClaimsPrincipal.Current.Identities.ToList();
                var test6 = ClaimsPrincipal.Current.Claims.ToList();

                TokenResponse TokenResponse = JsonConvert.DeserializeObject<TokenResponse>(result.Result);
                String id = TokenResponse.UserId;


                //If success received   
                if (responseTask.Result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Users", "User");
                }
                else
                {
                    return RedirectToAction("Error");
                }
            }
           
        }

    }
}
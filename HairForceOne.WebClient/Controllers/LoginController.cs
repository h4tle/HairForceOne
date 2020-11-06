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
using System.Web.Security;
using System.Windows.Forms;

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
                Token token = responseTask.Result.Content.ReadAsAsync<Token>().Result;
                Session["Token"] = token;

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
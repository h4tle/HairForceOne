using HairForceOne.WebClient.Models;
using HairForceOne.WebClient.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Mvc;

namespace HairForceOne.WebClient.Controllers
{
    public class UsersController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<User> users = null;
            using (HttpClient client = new HttpClientHairForce().SetBase())
            {
                var responseTask = client.GetAsync("users");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<User>>();
                    readTask.Wait();
                    users = readTask.Result;
                    return View(users);
                }
                else
                {
                    var token = Session["Token"] as Token;
                    if (token == null)
                    {
                        return RedirectToAction("", "Login");
                    }
                    users = Enumerable.Empty<User>();
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                    return RedirectToAction("Details", new { id = 1 });
                }
            }
        }

        public ActionResult Details(int id)
        {
            var token = Session["Token"] as Token;
            if (token == null)
            {
                return RedirectToAction("", "Login");
            }
            User u = GetUser(id);
            return View(u);
        }

        public ActionResult Create()
        {
            var token = Session["Token"] as Token;
            if (token == null)
            {
                return RedirectToAction("", "Login");
            }
            return View();
        }

        [HttpPost]
        // binding
        // ([Bind(Include = "FirstName")]Expense expense)
        // public ActionResult Create(string FirstName, String LastName, String Email, String PhoneNo, String Password)
        public ActionResult Create(string FirstName, String LastName, String Email, String PhoneNo, String Password)
        {
            User u = new User(FirstName, LastName, Email, PhoneNo);
            u.Password = Password;
            var JUser = new StringContent(JsonConvert.SerializeObject(u), Encoding.UTF8, "application/json");
            using (HttpClient client = new HttpClientHairForce().SetBase())
            {
                var responseTask = client.PostAsync("users", JUser);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<User>>();
                    readTask.Wait();
                    return RedirectToAction("Index");
                }
                else
                {
                    var token = Session["Token"] as Token;
                    if (token == null)
                    {
                        return RedirectToAction("", "Login");
                    }
                    return RedirectToAction("Index");
                }
            }
        }

        public ActionResult Edit(int id)
        {
            var token = Session["Token"] as Token;
            if (token == null)
            {
                return RedirectToAction("", "Login");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, String FirstName, String LastName, String Email, String PhoneNo, String Password)
        {
            try
            {
                User u = new User(FirstName, LastName, Email, PhoneNo);
                u.UserId = id;
                u.Password = Password;

                using (HttpClient client = new HttpClientHairForce().SetBase())
                {
                    var JUser = new StringContent(JsonConvert.SerializeObject(u), Encoding.UTF8, "application/json");
                    var responseTask = client.PutAsync($"users/{id}", JUser);
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<User>();
                        readTask.Wait();
                        u = readTask.Result;
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        var token = Session["Token"] as Token;
                        if (token == null)
                        {
                            return RedirectToAction("", "Login");
                        }
                        ModelState.AddModelError(string.Empty, "Server error try after some time.");
                        return View("ERROR");
                    }
                }
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var token = Session["Token"] as Token;
            if (token == null)
            {
                return RedirectToAction("", "Login");
            }
            User u = GetUser(id);
            return View(u);
        }

        [HttpPost]
        public ActionResult Delete(int id, User u)
        {
            try
            {
                using (HttpClient client = new HttpClientHairForce().SetBase())
                {
                    var responseTask = client.DeleteAsync($"users/{id}");
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<User>();
                        readTask.Wait();
                        u = readTask.Result;
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Server error try after some time.");
                        return View("ERROR");
                    }
                }
            }
            catch
            {
                return View();
            }
        }

        private User GetUser(int id)
        {
            // TO DO
            User u = new User();
            try
            {
                using (HttpClient client = new HttpClientHairForce().SetBase())
                {
                    var responseTask = client.GetAsync($"users/{id}");
                    responseTask.Wait();

                    var result = responseTask.Result;

                    var readTask = result.Content.ReadAsAsync<User>();
                    readTask.Wait();

                    u = readTask.Result;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return u;
        }
    }
}
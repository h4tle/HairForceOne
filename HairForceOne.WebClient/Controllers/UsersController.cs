using HairForceOne.WebClient.Models;
using HairForceOne.WebClient.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Mvc;

namespace HairForceOne.WebClient.Controllers
{
    public class UsersController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            IEnumerable<User> users = null;
            using (HttpClient client = new HttpClientHairForce().SetBase())
            {
                var responseTask = client.GetAsync("users");
                responseTask.Wait();

                //To store result of web api response.
                var result = responseTask.Result;

                //If success received
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
                    //Error response received
                    users = Enumerable.Empty<User>();
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                    return RedirectToAction("Details", new { id = 1 });
                }
            }
        }

        // GET: User/Details/5
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

        // GET: User/Create
        public ActionResult Create()
        {
            var token = Session["Token"] as Token;
            if (token == null)
            {
                return RedirectToAction("", "Login");
            }
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(string FirstName, String LastName, String Email, String PhoneNo, String Password)
        {
            User u = new User(FirstName, LastName, Email, PhoneNo);
            u.Password = Password;

            var JUser = new StringContent(JsonConvert.SerializeObject(u), Encoding.UTF8, "application/json");
            using (HttpClient client = new HttpClientHairForce().SetBase())
            {
                var responseTask = client.PostAsync("users", JUser);

                responseTask.Wait();

                //To store result of web api response.
                var result = responseTask.Result;

                //If success received
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

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            var token = Session["Token"] as Token;
            if (token == null)
            {
                return RedirectToAction("", "Login");
            }
            return View();
        }

        // POST: User/Edit/5
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

                    //To store result of web api response.
                    var result = responseTask.Result;

                    //If success received
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

        // GET: User/Delete/5
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

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, User u)
        {
            try
            {
                using (HttpClient client = new HttpClientHairForce().SetBase())
                {
                    var responseTask = client.DeleteAsync($"users/{id}");
                    responseTask.Wait();

                    //To store result of web api response.
                    var result = responseTask.Result;

                    //If success received
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
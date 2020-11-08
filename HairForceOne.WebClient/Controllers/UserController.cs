using HairForceOne.WebClient.Models;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace HairForceOne.WebClient.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Users()
        {
            IEnumerable<User> users = null;

            using (var client = new HttpClient())
            {
                var token = Session["Token"] as Token;
                if(token == null)
                {
                    return RedirectToAction("","Login");
                }
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);
                client.BaseAddress = new Uri("https://localhost:44382/api/");

                //Called Member default GET All records  
                //GetAsync to send a GET request   
                // PutAsync to send a PUT request  
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
                }
                else
                {
                    //Error response received   
                    users = Enumerable.Empty<User>();
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }
            return View(users);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            var token = Session["Token"] as Token;
            if (token == null)
            {
                return RedirectToAction("", "Login");
            }
            User c = GetUser(id);
            return View(c);
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
            User c = new User(FirstName, LastName, Email, PhoneNo);
            c.Password = Password;

            var JUser = new StringContent(JsonConvert.SerializeObject(c), Encoding.UTF8, "application/json");
            using (var client = new HttpClient())
            {
                var token = Session["Token"] as Token;
                if (token == null)
                {
                    return RedirectToAction("", "Login");
                }
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);
                client.BaseAddress = new Uri("https://localhost:44382/api/");

                //Called Member default GET All records  
                //GetAsync to send a GET request   
                // PutAsync to send a PUT request 
                var responseTask = client.PostAsync("users", JUser);

                responseTask.Wait();

                //To store result of web api response.   
                var result = responseTask.Result;

                //If success received   
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<User>>();
                    readTask.Wait();

                    return RedirectToAction("users");
                }
                else
                {
                    return RedirectToAction("users");
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
                User c = new User(FirstName, LastName, Email, PhoneNo);
                c.UserId = id;
                c.Password = Password;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44382/api/");

                    //Called Member default GET All records  
                    //GetAsync to send a GET request   
                    // PutAsync to send a PUT request  
                    Dictionary<string, string> jsonValues = new Dictionary<string, string>();
                    var JUser = new StringContent(JsonConvert.SerializeObject(c), Encoding.UTF8, "application/json");
                    //var Jpass = new StringContent(string.Format("password={0}", Password), Encoding.UTF8);
                    var responseTask = client.PutAsync($"users/{id}", JUser);
                    responseTask.Wait();

                    //To store result of web api response.   
                    var result = responseTask.Result;

                    //If success received   
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<User>();
                        readTask.Wait();

                        c = readTask.Result;
                        return RedirectToAction("users");
                    }
                    else
                    {
                        //Error response received   
                        //cars = Enumerable.Empty<Car>();
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
            User c = GetUser(id);
            return View(c);
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, User c)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44382/api/");

                    //Called Member default GET All records  
                    //GetAsync to send a GET request   
                    // PutAsync to send a PUT request  
                    var responseTask = client.DeleteAsync($"users/{id}");
                    responseTask.Wait();

                    //To store result of web api response.   
                    var result = responseTask.Result;

                    //If success received   
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<User>();
                        readTask.Wait();

                        c = readTask.Result;
                        return RedirectToAction("users");
                    }
                    else
                    {
                        //Error response received   
                        // c = Enumerable.Empty<User>();
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
            User c = new User();
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44382/api/");

                    var responseTask = client.GetAsync($"users/{id}");
                    responseTask.Wait();

                    var result = responseTask.Result;

                    var readTask = result.Content.ReadAsAsync<User>();
                    readTask.Wait();

                    c = readTask.Result;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return c;
        }
    }
}

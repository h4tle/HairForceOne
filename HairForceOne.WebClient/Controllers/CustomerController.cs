using HairForceOne.WebClient.Models;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace HairForceOne.WebClient.Controllers
{
    public class CustomerController : Controller
    {
        Var token = null;
        // GET: Customer
        public ActionResult Customers()
        {
            IEnumerable<Customer> customers = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44382/api/");

                //Called Member default GET All records  
                //GetAsync to send a GET request   
                // PutAsync to send a PUT request  
                var responseTask = client.GetAsync("customers");
                responseTask.Wait();

                //To store result of web api response.   
                var result = responseTask.Result;

                //If success received   
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Customer>>();
                    readTask.Wait();

                    customers = readTask.Result;
                }
                else
                {
                    //Error response received   
                    customers = Enumerable.Empty<Customer>();
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }
            return View(customers);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            Customer c = GetCustomer(id);
            return View(c);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(string FirstName, String LastName, String Email, String PhoneNumber)
        {
            Customer c = new Customer(FirstName, LastName, Email, PhoneNumber);

            var JCustomer = new StringContent(JsonConvert.SerializeObject(c), Encoding.UTF8, "application/json");
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44382/api/");

                //Called Member default GET All records  
                //GetAsync to send a GET request   
                // PutAsync to send a PUT request  
                var responseTask = client.PostAsync("customers", JCustomer);

                responseTask.Wait();

                //To store result of web api response.   
                var result = responseTask.Result;

                //If success received   
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Customer>>();
                    readTask.Wait();

                    return RedirectToAction("customers");
                }
                else
                {
                    return RedirectToAction("customers");
                }
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, String FirstName, String LastName, String Email, String PhoneNumber)
        {
            try
            {
                Customer c = new Customer(FirstName, LastName, Email, PhoneNumber);
                c.UserId = id;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44382/api/");

                    //Called Member default GET All records  
                    //GetAsync to send a GET request   
                    // PutAsync to send a PUT request  
                    var JCustomer = new StringContent(JsonConvert.SerializeObject(c), Encoding.UTF8, "application/json");
                    var responseTask = client.PutAsync($"customers/{id}", JCustomer);
                    responseTask.Wait();

                    //To store result of web api response.   
                    var result = responseTask.Result;

                    //If success received   
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<Customer>();
                        readTask.Wait();

                        c = readTask.Result;
                        return RedirectToAction("Customers");
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

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            Customer c = GetCustomer(id);
            return View(c);
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Customer c)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44382/api/");

                    //Called Member default GET All records  
                    //GetAsync to send a GET request   
                    // PutAsync to send a PUT request  
                    var responseTask = client.DeleteAsync($"customers/{id}");
                    responseTask.Wait();

                    //To store result of web api response.   
                    var result = responseTask.Result;

                    //If success received   
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<Customer>();
                        readTask.Wait();

                        c = readTask.Result;
                        return RedirectToAction("Customers");
                    }
                    else
                    {
                        //Error response received   
                        // c = Enumerable.Empty<Customer>();
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

        private Customer GetCustomer(int id)
        {
            Customer c = new Customer();
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44382/api/");

                    var responseTask = client.GetAsync($"customers/{id}");
                    responseTask.Wait();

                    var result = responseTask.Result;

                    var readTask = result.Content.ReadAsAsync<Customer>();
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

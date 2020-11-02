using HairForceOne.WebClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace HairForceOne.WebClient.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Customers()
        {
                IEnumerable<Customer> customers = null;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44352/api/");

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
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

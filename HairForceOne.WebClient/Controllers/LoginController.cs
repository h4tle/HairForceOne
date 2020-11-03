using HairForceOne.WebClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace HairForceOne.WebClient.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(String Email, String PhoneNumber)
        {
            Customer c = new Customer(Email, PhoneNumber);
            c.UserName = "gmaybury0@abc.net.au";
            c.Password = "4520744842";
            c.grant_type = "password";

            var JCustomer = new StringContent(JsonConvert.SerializeObject(c), Encoding.UTF8, "application/json");
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44382");

                //Called Member default GET All records  
                //GetAsync to send a GET request   
                // PutAsync to send a PUT request  
                var responseTask = client.PostAsync("token", new StringContent(string.Format("grant_type=password&username={0}&password={1}", c.UserName, c.Password), Encoding.UTF8));

                responseTask.Wait();

                //To store result of web api response.   
                var result = responseTask.Result.Content.ReadAsStringAsync().Result;


                //If success received   
                if (responseTask.Result.IsSuccessStatusCode)
                {

                    return RedirectToAction("customers");
                }
                else
                {
                    return RedirectToAction("customers");
                }
            }
            //using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dapperConnStr"].ConnectionString))
            //{
            //    string sql = $"SELECT * FROM UsernamePassword WHERE Username = '{c.Email}' AND Password = '{c.PhoneNumber}'";

            //    var result = conn.(sql);

            //    dto.ExecutedSQL = sql;
            //    dto.IsAuthenticated = result.Any();
            //}


            //return View(dto);
        }
    }
}
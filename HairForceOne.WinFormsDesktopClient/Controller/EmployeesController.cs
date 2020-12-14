using HairForceOne.WinFormsDesktopClient.Model;
using Meziantou.Framework.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

// håndter exceptions (custom exception??)
// tag exception fra statuscode og håndter den
// try catch (Måske)
// navngiv metoder
// async
namespace HairForceOne.WinFormsDesktopClient.Controller
{
    class EmployeesController : IEmployeesController
    {
        private readonly HttpClient client = new HttpClient();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeesController"/> class.
        /// </summary>
        public EmployeesController()
        {
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["HairForceOneApiURL"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", CredentialManager.ReadCredential(applicationName: "Token").Password);
        }

        public NotImplementedException Create(Employee employee)
        {
            var JEmployee = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");
            Task<HttpResponseMessage> responseTask = client.PostAsync($"employees/", JEmployee);
            responseTask.Wait();

            if (responseTask.Result.IsSuccessStatusCode)
            {
                return new NotImplementedException();
            }
            else
            {
                return new NotImplementedException();
            }
        }

        public NotImplementedException Delete(int id)
        {
            Task<HttpResponseMessage> responseTask = client.DeleteAsync($"employees/{id}");
            responseTask.Wait();

            if (responseTask.Result.IsSuccessStatusCode)
            {
                return new NotImplementedException();
            }
            else
            {
                return new NotImplementedException();
            }
        }

        public List<Employee> GetEmployees()
        {
            Task<HttpResponseMessage> responseTask = client.GetAsync($"employees");
            responseTask.Wait();
            List<Employee> l = JsonConvert.DeserializeObject<List<Employee>>(responseTask.Result.Content.ReadAsStringAsync().Result);
            return l;
        }

        public Employee GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public NotImplementedException Update(Employee employee)
        {
            var JEmployee = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");
            Task<HttpResponseMessage> responseTask = client.PutAsync($"employees/{employee.EmployeeId}", JEmployee);
            responseTask.Wait();

            if (responseTask.Result.IsSuccessStatusCode)
            {
                return new NotImplementedException();
            }
            else
            {
                return new NotImplementedException();
            }
        }
    }
}

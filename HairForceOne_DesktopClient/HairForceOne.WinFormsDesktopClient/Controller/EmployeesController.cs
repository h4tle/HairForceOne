using HairForceOne.WinFormsDesktopClient.Model;
using Meziantou.Framework.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// <summary>
    /// This class contains the HttpClient methods that handles the Employee instance
    /// </summary>
    internal class EmployeesController : IEmployeesController
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

        /// <summary>
        /// This method gets a list of all Employee objects using HttpClient
        /// </summary>
        /// <returns>A list of Employees</returns>
        public List<Employee> GetEmployees()
        {
            Task<HttpResponseMessage> responseTask = client.GetAsync($"employees");
            responseTask.Wait();
            if (responseTask.Result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<Employee>>(responseTask.Result.Content.ReadAsStringAsync().Result);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// This method gets a specific EmployeeId from the list of Employee objects using HttpClient
        /// </summary>
        /// <param name="id"></param>
        /// <returns>An Employee object by EmployeeId</returns>
        public Employee GetEmployee(int id)
        {
            Task<HttpResponseMessage> responseTask = client.GetAsync($"employees/{id}");
            responseTask.Wait();
            if (responseTask.Result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<Employee>(responseTask.Result.Content.ReadAsStringAsync().Result);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// This methods posts a new Employee object using HttpClient
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool CreateNewEmployee(Employee employee)
        {
            var JEmployee = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");
            Task<HttpResponseMessage> responseTask = client.PostAsync($"employees/", JEmployee);
            responseTask.Wait();
            return responseTask.Result.IsSuccessStatusCode;
        }

        /// <summary>
        /// This method updates the exsisting Employee object using HttpClient
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool EditEmployee(Employee employee)
        {
            var JEmployee = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");
            Task<HttpResponseMessage> responseTask = client.PutAsync($"employees/{employee.EmployeeId}", JEmployee);
            responseTask.Wait();
            return responseTask.Result.IsSuccessStatusCode;
        }

        /// <summary>
        /// This method deletes the Employee object from the database, using HttpClient
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteEmployee(int id)
        {
            Task<HttpResponseMessage> responseTask = client.DeleteAsync($"employees/{id}");
            responseTask.Wait();
            return responseTask.Result.IsSuccessStatusCode;
        }
    }
}
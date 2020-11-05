using Dapper;
using HairForceOne.WebService.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HairForceOne.WebService.Controllers
{
    public class CustomerController : ApiController
    {
        public IEnumerable<Customer> GetAllCustomers()
        {
            String sql = "SELECT * FROM Customer";

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dapperConnStr"].ConnectionString))
            {
                var customers = connection.Query<Customer>(sql).ToList();
                return customers;
            }
        }

        public HttpResponseMessage Post([FromBody] Customer c)
        {
            string sql = "INSERT INTO [dbo].[Customer] ([FirstName],[LastName],[Email],[PhoneNumber])" +
                         "VALUES (@FirstName, @LastName, @Email, @PhoneNumber)";



            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dapperConnStr"].ConnectionString))
            {
                var affectedRows = connection.Execute(sql, new
                {
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Email = c.Email,
                    PhoneNumber = c.PhoneNumber
                });
            }
            return Request.CreateResponse(HttpStatusCode.Accepted);
        }
    }
}

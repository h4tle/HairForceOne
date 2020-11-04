using Dapper;
using HairForceOne.WebService.Models;
using HairForceOne.WebService.Providers;
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
    public class CustomersController : ApiController
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

        public Customer GetCustomer(int id)
        {
            String sql = $"select * FROM Customer WHERE CustomerID = {id}";

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dapperConnStr"].ConnectionString))
            {
                Customer c = connection.Query<Customer>(sql).FirstOrDefault();
                return c;
            }
        }

        public HttpResponseMessage Post([FromBody] Customer c)
        {
            var Hash = new OAuthProvider();
            c.PhoneNumber = Hash.ComputeHash(c.PhoneNumber);
            
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

        public int Put(Customer c)
        {
            String sql = $"UPDATE Customer SET FirstName = '{c.FirstName}', LastName = '{c.LastName}', Email = '{c.Email}', PhoneNumber = '{c.PhoneNumber}' WHERE CustomerId = '{c.CustomerId}'";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dapperConnStr"].ConnectionString))
            {
                int CustomerId = connection.Execute(sql);
                return CustomerId;
            }
        }

        public void Delete(int id)
        {
            String sql = $"DELETE FROM Customer WHERE CustomerId = '{id}'";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dapperConnStr"].ConnectionString))
            {
                connection.Execute(sql);
            }

        }

    }
}

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
    public class UsersController : ApiController
    {
        public IEnumerable<User> GetAllUsers()
        {
            String sql = "SELECT * FROM hfo_User";

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dapperConnStr"].ConnectionString))
            {
                var users = connection.Query<User>(sql).ToList();
                return users;
            }
        }

        public User GetUser(int id)
        {
            String sql = $"select * FROM hfo_User WHERE UserId = {id}";

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dapperConnStr"].ConnectionString))
            {
                User c = connection.Query<User>(sql).FirstOrDefault();
                return c;
            }
        }

        public HttpResponseMessage Post([FromBody] User c)
        {
            var Hash = new OAuthProvider();
            c.Password = Hash.ComputeHash(c.Password);
            
            string sql = "INSERT INTO hfo_User (FirstName,LastName,Email,PhoneNo,Password)" +
                         "VALUES (@FirstName, @LastName, @Email, @PhoneNo, @Password)";



            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dapperConnStr"].ConnectionString))
            {
                var affectedRows = connection.Execute(sql, new
                {
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Email = c.Email,
                    PhoneNo = c.PhoneNo,
                    Password = c.Password
                });
            }
            return Request.CreateResponse(HttpStatusCode.Accepted);
        }

        public int Put(User c)
        {
            OAuthProvider Hash = new OAuthProvider();
            c.Password = Hash.ComputeHash(c.Password);
            String sql = $"UPDATE hfo_User SET FirstName = '{c.FirstName}', LastName = '{c.LastName}', Email = '{c.Email}', PhoneNo = '{c.PhoneNo}', PasswordHash = '{c.Password}' WHERE UserId = '{c.UserId}'";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dapperConnStr"].ConnectionString))
            {
                int UserId = connection.Execute(sql);
                return UserId;
            }
        }

        public void Delete(int id)
        {
            String sql = $"DELETE FROM hfo_User WHERE UserId = '{id}'";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dapperConnStr"].ConnectionString))
            {
                connection.Execute(sql);
            }

        }

    }
}

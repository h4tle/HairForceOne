﻿using Dapper;
using HairForceOne.WebService.Models;
using HairForceOne.WebService.Util;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HairForceOne.WebService.Controllers
{
    [Authorize]
    public class UsersController : ApiController
    {
        [Authorize(Roles = "admin")]
        public IEnumerable<User> GetAllUsers()
        {
            string sql = "SELECT * FROM hfo_User";

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dapperConnStr"].ConnectionString))
            {
                return connection.Query<User>(sql).ToList();
            }
        }

        public User GetUser(int id)
        {
            string sql = $"select * FROM hfo_User WHERE UserId = @id";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dapperConnStr"].ConnectionString))
            {
                return connection.Query<User>(sql, new { id }).FirstOrDefault();
            }
        }

        [Authorize(Roles = "admin")]
        public HttpResponseMessage Post([FromBody] User u)
        {
            string salt = PasswordHelper.GenerateSalt();
            u.Password = PasswordHelper.ComputeHash(u.Password, salt);

            string sql = "INSERT INTO hfo_User (FirstName,LastName,Email,PhoneNo,Password,Salt)" +
                         "VALUES (@FirstName, @LastName, @Email, @PhoneNo, @Password, @Salt)";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dapperConnStr"].ConnectionString))
            {
                var affectedRows = connection.Execute(sql, new
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Email = u.Email,
                    PhoneNo = u.PhoneNo,
                    Password = u.Password,
                    Salt = salt
                });
                return Request.CreateResponse(HttpStatusCode.Accepted);
            }
        }

        [Authorize(Roles = "admin")]
        public int Put(User u)
        {
            string salt = PasswordHelper.GenerateSalt();
            u.Password = PasswordHelper.ComputeHash(u.Password, salt);
            string sql = $"UPDATE hfo_User SET FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNo = @PhoneNo, Password = @Password, Salt = @Salt WHERE UserId = @UserId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dapperConnStr"].ConnectionString))
            {
                int UserId = connection.Execute(sql, new
                {
                    UserId = u.UserId,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Email = u.Email,
                    PhoneNo = u.PhoneNo,
                    Password = u.Password,
                    Salt = salt
                });
                return UserId;
            }
            //OAuthProvider Hash = new OAuthProvider();
            ////c.Password = Hash.ComputeHash(c.Password);
            //String sql = $"UPDATE hfo_User SET FirstName = '{c.FirstName}', LastName = '{c.LastName}', Email = '{c.Email}', PhoneNo = '{c.PhoneNo}', PasswordHash = '{c.Password}' WHERE UserId = '{c.UserId}'";
            //using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dapperConnStr"].ConnectionString))
            //{
            //    int UserId = connection.Execute(sql);
            //    return UserId;
            //}
        }

        [Authorize(Roles = "admin")]
        public void Delete(int id)
        {
            string sql = $"DELETE FROM hfo_User WHERE UserId = @Id";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dapperConnStr"].ConnectionString))
            {
                connection.Execute(sql, new { id });
            }
        }
    }
}
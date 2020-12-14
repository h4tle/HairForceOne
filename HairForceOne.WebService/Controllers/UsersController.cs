using Dapper;
using HairForceOne.WebService.Models;
using HairForceOne.WebService.Util;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace HairForceOne.WebService.Controllers
    //Authorize tags mangler
    // trycatch mangler
    //navne ændres

    //Martin johansen christensen
{
    //[Authorize]
    public class UsersController : ApiController
    {
        //[Authorize(Roles = "admin")]
        [AllowAnonymous]
        public IEnumerable<User> GetAllUsers()
        {
            string sql = "SELECT * FROM hfo_User";

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.Query<User>(sql).ToList();
            }
        }

        [AllowAnonymous]
        public User GetUser(int id)
        {
            string UserId = HttpContext.Current.User.Identity.GetUserId();
            string sql = "select * FROM hfo_User WHERE UserId = @UserId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.Query<User>(sql, new { UserId }).FirstOrDefault();
            }
        }
        // USer u
        [AllowAnonymous]
        public HttpResponseMessage Post([FromBody] User u)
        {
            string salt = PasswordHelper.GenerateSalt();
            u.Password = PasswordHelper.ComputeHash(u.Password, salt);

            string sql = "INSERT INTO hfo_User (FirstName,LastName,Email,PhoneNo,Password,Salt)" +
                         "VALUES (@FirstName, @LastName, @Email, @PhoneNo, @Password, @Salt)";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
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

        // hash og salt metode skal ikke køres når pass ikke ændres
        [Authorize(Roles = "admin")]
        public int Put(User u)
        {
            string salt = PasswordHelper.GenerateSalt();
            u.Password = PasswordHelper.ComputeHash(u.Password, salt);
            string sql = $"UPDATE hfo_User SET FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNo = @PhoneNo, Password = @Password, Salt = @Salt WHERE UserId = @UserId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
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
            //using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            //{
            //    int UserId = connection.Execute(sql);
            //    return UserId;
            //}
        }

        [Authorize(Roles = "admin")]
        public void Delete(int id)
        {
            string sql = "DELETE FROM hfo_User WHERE UserId = @Id";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                connection.Execute(sql, new { id });
            }
        }
    }
}
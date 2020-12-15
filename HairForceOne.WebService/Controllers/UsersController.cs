using Dapper;
using HairForceOne.WebService.Model;
using HairForceOne.WebService.Util;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace HairForceOne.WebService.Controllers
{
    /// <summary>
    /// This class contains the dapper methods that handles the User instance and SQL connection
    /// </summary>

    [Authorize]
    public class UsersController : ApiController
    {
        /// <summary>
        /// This method gets the list of User objects using Dapper
        /// </summary>
        /// <returns>A List of Users</returns>

        [HttpGet]
        public HttpResponseMessage GetAllUsers()
        {
            try
            {
                string sql = "SELECT * FROM hfo_User";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    List<User> users = connection.Query<User>(sql).AsList();
                    return Request.CreateResponse(HttpStatusCode.OK, users);
                }
            }
            catch (SqlException e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        /// <summary>
        /// This method gets a specific UserId from the list of User objects using Dapper
        /// </summary>
        /// <returns>A User object by UserId</returns>

        [HttpGet]
        public HttpResponseMessage GetUser(int id)
        {
            try
            {
                // Identity contains the UserId
                string UserId = HttpContext.Current.User.Identity.GetUserId();

                string sql = "SELECT * FROM hfo_User WHERE UserId = @UserId";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    User user = connection.QuerySingleOrDefault<User>(sql, new { UserId });
                    return Request.CreateResponse(HttpStatusCode.OK, user);
                }
            }
            catch (SqlException e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        /// <summary>
        /// This method posts a new User object to the Database using Dapper
        /// When creating a new User, Passworld.Helper.GenerateSalt() generates a new unique Salt
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        public HttpResponseMessage CreateNewUser([FromBody] User user)
        {
            try
            {
                // Generates Salt
                string salt = PasswordHelper.GenerateSalt();

                // Hashing the password + salt
                user.PasswordHash = PasswordHelper.ComputeHash(user.Password, salt);

                string sql = "INSERT INTO hfo_User (FirstName,LastName,Email,PhoneNo,PasswordHash,Salt)" +
                             "VALUES (@FirstName, @LastName, @Email, @PhoneNo, @PasswordHash, @Salt)";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    int UserId = connection.Execute(sql, new
                    {
                        user.FirstName,
                        user.LastName,
                        user.Email,
                        user.PhoneNo,
                        user.PasswordHash,
                        salt
                    });
                    return Request.CreateResponse(HttpStatusCode.Created, UserId);
                }
            }
            catch (SqlException e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        /// <summary>
        /// This method updates the exsisting User Object using dapper
        /// If no Password changes, it dosent generate new salt
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>

        [Authorize(Roles = "1")]
        [HttpPut]
        public HttpResponseMessage EditUser(User user)
        {
            try
            {
                // checks for password updates
                if (!string.IsNullOrWhiteSpace(user.Password))
                {
                    // Generates Salt
                    user.Salt = PasswordHelper.GenerateSalt();

                    // Hashing the password + salt
                    user.Password = PasswordHelper.ComputeHash(user.Password, user.Salt);
                }

                string sql = "UPDATE hfo_User SET FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNo = @PhoneNo, PasswordHash = @PasswordHash, Salt = @Salt WHERE UserId = @UserId";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    int UserId = connection.Execute(sql, new
                    {
                        user.UserId,
                        user.FirstName,
                        user.LastName,
                        user.Email,
                        user.PhoneNo,
                        user.Password,
                        user.Salt
                    });

                    return Request.CreateResponse(HttpStatusCode.OK, UserId);
                }
            }
            catch (SqlException e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        /// <summary>
        /// This method deletes the User Object from the database, using a specific UserId
        /// </summary>
        /// <param name="id"></param>
        [Authorize(Roles = "1")]
        [HttpDelete]
        public HttpResponseMessage DeleteUser(int id)
        {
            try
            {
                string UserId = HttpContext.Current.User.Identity.GetUserId();

                string sql = "DELETE FROM hfo_User WHERE UserId = @UserId";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    connection.Execute(sql, new { UserId });
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            catch (SqlException e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }
    }
}
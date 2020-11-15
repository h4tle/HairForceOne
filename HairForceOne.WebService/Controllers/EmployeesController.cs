using Dapper;
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
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> GetAllEmployees()
        {
            string sql = "SELECT * FROM hfo_Employee";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.Query<Employee>(sql).ToList();
            }
        }

        //public User GetEmployee(int id)
        //{
        //    string EmployeeId = HttpContext.Current.Employee.Identity.GetEmployeeId();

        //    string sql = $"select * FROM hfo_Employee WHERE EmployeeId = @EmployeeId";
        //    using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
        //    {
        //        return connection.Query<User>(sql, new { EmployeeId }).FirstOrDefault();
        //    }
        //}

        public HttpResponseMessage Post([FromBody] Employee e)
        {
            string salt = PasswordHelper.GenerateSalt();
            e.PasswordHash = PasswordHelper.ComputeHash(e.PasswordHash, salt);

            // sql default role -> admin?

            string sql = "INSERT INTO hfo_Employee (FirstName,LastName,Email,PhoneNo,Experience,Gender,ProfilePicture,Biography,PasswordHash,Salt,Roles)" +
                         "VALUES (@FirstName, @LastName, @Email, @PhoneNo, @Experience, @Gender, @ProfilePicture, @Biography @PasswordHash, @Salt, @Roles)";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                var affectedRows = connection.Execute(sql, new
                {
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Email = e.Email,
                    PhoneNo = e.PhoneNo,
                    Experience = e.Experience,
                    Gender = e.Gender,
                    ProfilePicture = e.ProfilePicture,
                    Biography = e.Biography,
                    PasswordHash = e.PasswordHash,
                    Salt = salt,
                    Roles = e.Roles
                });
                return Request.CreateResponse(HttpStatusCode.Accepted);
            }
        }

        public int Put(Employee e)
        {
            string salt = PasswordHelper.GenerateSalt();
            e.PasswordHash = PasswordHelper.ComputeHash(e.PasswordHash, salt);
            string sql = $"UPDATE hfo_Employee SET FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNo = @PhoneNo, Experience = @Experience, Gender = @Gender, ProfilePicture = @ProfilePicture, Biography = @Biography, PasswordHash = @PasswordHash, Salt = @Salt, Roles = @Roles WHERE EmployeeId = @EmployeeId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                int EmployeeId = connection.Execute(sql, new
                {
                    EmployeeId = e.EmployeeId,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Email = e.Email,
                    PhoneNo = e.PhoneNo,
                    Experience = e.Experience,
                    Gender = e.Gender,
                    ProfilePicture = e.ProfilePicture,
                    Biography = e.Biography,
                    PasswordHash = e.PasswordHash,
                    Salt = salt,
                    Roles = e.Roles
                });
                return EmployeeId;
            }
        }

        public void Delete(int id)
        {
            string sql = $"DELETE FROM hfo_Employee WHERE EmployeeId = @Id";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                connection.Execute(sql, new { id });
            }
        }
    }
}
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
    //Authorization tags mangler
    //try/catch mangler
    //navne skal ændres
{
    /// <summary>
    /// This class contains all methods for handling employees
    /// </summary>
    public class EmployeesController : ApiController
    {
        /// <summary>
        /// This method gets a list of all employees
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// This method posts a new employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public HttpResponseMessage Post([FromBody] Employee employee)
        {
            string salt = PasswordHelper.GenerateSalt();
            employee.PasswordHash = PasswordHelper.ComputeHash(employee.Password, salt);

            // sql default role -> admin?
            try
            {
                string sql = "INSERT INTO hfo_Employee (FirstName,LastName,Email,PhoneNo,Experience,Gender,ProfilePicture,Biography,PasswordHash,Salt,Roles)" +
                             "VALUES (@FirstName, @LastName, @Email, @PhoneNo, @Experience, @Gender, @ProfilePicture, @Biography, @PasswordHash, @Salt, @Roles)";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    var affectedRows = connection.Execute(sql, new
                    {
                        FirstName = employee.FirstName,
                        LastName = employee.LastName,
                        Email = employee.Email,
                        PhoneNo = employee.PhoneNo,
                        Experience = employee.Experience,
                        Gender = employee.Gender,
                        ProfilePicture = employee.ProfilePicture,
                        Biography = employee.Biography,
                        PasswordHash = employee.PasswordHash,
                        Salt = salt,
                        Roles = employee.Roles
                    });
                    return Request.CreateResponse(HttpStatusCode.Accepted);
                }
            }
            catch (SqlException e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e);
            }
        }

        /// <summary>
        /// This method edits and updates a employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public int Put(Employee employee)
        {
            if (!string.IsNullOrWhiteSpace(employee.Password))
            {
                employee.Salt = PasswordHelper.GenerateSalt();
                employee.PasswordHash = PasswordHelper.ComputeHash(employee.Password, employee.Salt);
            }
            string sql = "UPDATE hfo_Employee SET FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNo = @PhoneNo, Experience = @Experience, Gender = @Gender, ProfilePicture = @ProfilePicture, Biography = @Biography, PasswordHash = @PasswordHash, Salt = @Salt, Roles = @Roles WHERE EmployeeId = @EmployeeId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                int EmployeeId = connection.Execute(sql, new
                {
                    EmployeeId = employee.EmployeeId,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Email = employee.Email,
                    PhoneNo = employee.PhoneNo,
                    Experience = employee.Experience,
                    Gender = employee.Gender,
                    ProfilePicture = employee.ProfilePicture,
                    Biography = employee.Biography,
                    PasswordHash = employee.PasswordHash,
                    Salt = employee.Salt,
                    Roles = employee.Roles
                });
                return EmployeeId;
            }
        }

        /// <summary>
        /// This method deletes an employee
        /// </summary>
        /// <param name="id"></param>

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
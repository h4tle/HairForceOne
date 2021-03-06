﻿using Dapper;
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
    /// This class contains the dapper methods that handles the Employee instance and SQL connection
    /// </summary>
    [RoutePrefix("api/employees")]
    [Authorize]
    public class EmployeesController : ApiController
    {
        /// <summary>
        /// This method gets the list of Employee objects using Dapper
        /// </summary>
        /// <returns>A List of Employees</returns>

        [HttpGet]
        public HttpResponseMessage GetAllEmployees()
        {
            try
            {
                string sql = "SELECT * FROM hfo_Employee";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    List<Employee> employees = connection.Query<Employee>(sql).AsList();
                    return Request.CreateResponse(HttpStatusCode.OK, employees);
                }
            }
            catch (SqlException)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Medarbejdere kunne ikke hentes. Prøv igen senere"
                };
            }
        }

        /// <summary>
        /// This method gets a specific EmployeeId from the list of Employee objects using Dapper
        /// </summary>
        /// <returns>A Employee object by EmployeeId</returns>

        //[AllowAnonymous]

        [Authorize(Roles = "2, 3")]
        [HttpGet]
        [Route("myemployee")]
        public HttpResponseMessage GetEmployee()
        {
            try
            {
                // Identity contains the EmployeeId
                string EmployeeId = HttpContext.Current.User.Identity.GetUserId();

                string sql = "SELECT * FROM hfo_Employee WHERE EmployeeId = @EmployeeId";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    Employee employee = connection.QuerySingleOrDefault<Employee>(sql, new { EmployeeId });
                    return Request.CreateResponse(HttpStatusCode.OK, employee);
                }
            }
            catch (SqlException)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Din profil kan ikke hentes. Prøv igen senere"
                };
            }
        }

        [Route("{EmployeeId}")]
        [Authorize(Roles = "3")]
        [HttpGet]
        public HttpResponseMessage GetEmployee(int EmployeeId)
        {
            try
            {
                string sql = "SELECT * FROM hfo_Employee WHERE EmployeeId = @EmployeeId";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    Employee employee = connection.QuerySingleOrDefault<Employee>(sql, new { EmployeeId });
                    return Request.CreateResponse(HttpStatusCode.OK, employee);
                }
            }
            catch (SqlException)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Medarbejderen kan ikke hentes. Prøv igen senere"
                };
            }
        }

        /// <summary>
        /// This method posts a new Employee object to the Database using Dapper
        /// When creating a new Employee, Passworld.Helper.GenerateSalt() generates a new unique Salt
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [Authorize(Roles = "3")]
        [HttpPost]
        public HttpResponseMessage CreateNewEmployee([FromBody] Employee employee)
        {
            // Generates Salt
            string salt = PasswordHelper.GenerateSalt();

            // Hashing the password + salt
            employee.PasswordHash = PasswordHelper.ComputeHash(employee.Password, salt);

            try
            {
                string sql = "INSERT INTO hfo_Employee (FirstName, LastName, Email, PhoneNo, Experience, Gender, Biography, PasswordHash, Salt, RoleId)" +
                                            "VALUES (@FirstName, @LastName, @Email, @PhoneNo, @Experience, @Gender, @Biography, @PasswordHash, @Salt, @RoleId)";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    int EmployeeId = connection.Execute(sql, new
                    {
                        employee.FirstName,
                        employee.LastName,
                        employee.Email,
                        employee.PhoneNo,
                        employee.Experience,
                        employee.Gender,
                        employee.Biography,
                        employee.PasswordHash,
                        salt,
                        employee.RoleId
                    });
                    return Request.CreateResponse(HttpStatusCode.Accepted, EmployeeId);
                }
            }
            catch (SqlException)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Medarbejderen kan ikke oprettes. Prøv igen senere"
                };
            }
        }

        /// <summary>
        /// This method updates the exsisting Employee Object using dapper
        /// If no Password changes, it dosent generate new salt
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>

        [Authorize(Roles = "3")]
        [HttpPut]
        public HttpResponseMessage EditEmployee(Employee employee)
        {
            try
            {
                // checks for password updates
                if (!string.IsNullOrWhiteSpace(employee.Password))
                {
                    // Generates Salt
                    employee.Salt = PasswordHelper.GenerateSalt();

                    // Hashing the password + salt
                    employee.PasswordHash = PasswordHelper.ComputeHash(employee.Password, employee.Salt);
                }
                string sql = "UPDATE hfo_Employee SET FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNo = @PhoneNo, Experience = @Experience, Gender = @Gender, Biography = @Biography, PasswordHash = @PasswordHash, Salt = @Salt, RoleId = @RoleId WHERE EmployeeId = @EmployeeId";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    int EmployeeId = connection.Execute(sql, new
                    {
                        employee.EmployeeId,
                        employee.FirstName,
                        employee.LastName,
                        employee.Email,
                        employee.PhoneNo,
                        employee.Experience,
                        employee.Gender,
                        employee.Biography,
                        employee.PasswordHash,
                        employee.Salt,
                        employee.RoleId
                    });
                    return Request.CreateResponse(HttpStatusCode.OK, EmployeeId);
                }
            }
            catch (SqlException)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Medarbejderen kan ikke redigeres. Prøv igen senere"
                };
            }
        }

        /// <summary>
        /// This method deletes the Employee Object from the database, using a specific UserId
        /// </summary>
        /// <param name="id"></param>
        //[Authorize(Roles = "admin")]

        // HVAD FANDEN?! int id
        [Authorize(Roles = "3")]
        [HttpDelete]
        public HttpResponseMessage DeleteEmployee(int EmployeeId)
        {
            try
            {
                string sql = "DELETE FROM hfo_Employee WHERE EmployeeId = @EmployeeId";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    connection.Execute(sql, new { EmployeeId });
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            catch (SqlException)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Medarbejderen kunne ikke slettes. Prøv igen senere"
                };
            }
        }
    }
}
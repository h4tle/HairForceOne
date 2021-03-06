﻿using Dapper;
using HairForceOne.WebService.Model;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HairForceOne.WebService.Controllers
{
    /// <summary>
    /// This class contains the dapper methods that handles the Service instance and SQL connection
    /// </summary>

    [Authorize]
    [AllowAnonymous]
    public class ServicesController : ApiController
    {
        /// <summary>
        /// This method gets the list of Service objects using Dapper
        /// </summary>
        /// <returns>A List of Services</returns>

        [HttpGet]
        public HttpResponseMessage GetAllServices()
        {
            try
            {
                string sql = "SELECT * FROM hfo_Service";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    List<Service> services = connection.Query<Service>(sql).AsList();
                    return Request.CreateResponse(HttpStatusCode.OK, services);
                }
            }
            catch (SqlException)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Services kan ikke hentes. Prøv igen senere"
                };
            }
        }

        /// <summary>
        /// This method gets a list of all Service objects based on the Gender parameter
        /// </summary>
        /// <param name="gender"></param>
        /// <returns>A List of Services by Gender</returns>

        [HttpGet]
        public HttpResponseMessage GetAllServicesByGender(string gender)
        {
            try
            {
                string sql = "SELECT * from hfo_Service WHERE Gender LIKE CONCAT('%',@Gender,'%')";

                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    List<Service> services = connection.Query<Service>(sql, new { Gender = gender }).AsList();
                    return Request.CreateResponse(HttpStatusCode.OK, services);
                }
            }
            catch (SqlException)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Services kan ikke hentes. Prøv igen senere"
                };
            }
        }

        /// <summary>
        /// This method gets a specific ServiceId from the list of Service objects using Dapper
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A Service object by ServiceId</returns>

        [HttpGet]
        public HttpResponseMessage GetService(int id)
        {
            try
            {
                string sql = "select * FROM hfo_Service WHERE ServiceId = @ServiceId";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    Service service = connection.QuerySingleOrDefault<Service>(sql, new { ServiceId = id });
                    return Request.CreateResponse(HttpStatusCode.OK, service);
                }
            }
            catch (SqlException)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Services kan ikke hentes. Prøv igen senere"
                };
            }
        }

        /// <summary>
        /// This method posts a new Service object to the Database using Dapper
        /// </summary>
        /// <param name="service"></param>
        /// <returns>A Service object by ServiceId</returns>

        [Authorize(Roles = "2,3")]
        [HttpPost]
        public HttpResponseMessage CreateNewService([FromBody] Service service)
        {
            try
            {
                string sql = "INSERT INTO hfo_Service (Title,Description,Duration,Price,Gender)" +
                             "VALUES (@Title, @Description, @Duration, @Price, @Gender)";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    int ServiceId = connection.Execute(sql, new
                    {
                        service.Title,
                        service.Description,
                        service.Duration,
                        service.Price,
                        service.Gender,
                    });
                    return Request.CreateResponse(HttpStatusCode.Created, ServiceId);
                }
            }
            catch (SqlException)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Services kan ikke oprettes. Prøv igen senere"
                };
            }
        }

        /// <summary>
        /// This method updates the exsisting Service Object using dapper
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>

        //[Authorize(Roles = "2,3")]
        [HttpPut]
        public HttpResponseMessage EditService(Service service)
        {
            try
            {
                string sql = "UPDATE hfo_Service SET Title = @Title, Description = @Description, Duration = @Duration, Price = @Price, Gender = @Gender WHERE ServiceId = @ServiceId";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    int ServiceId = connection.Execute(sql, new
                    {
                        service.ServiceId,
                        service.Title,
                        service.Description,
                        service.Duration,
                        service.Price,
                        service.Gender,
                    });
                    return Request.CreateResponse(HttpStatusCode.OK, ServiceId);
                }
            }
            catch (SqlException)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Service kan ikke opdateres. Prøv igen senere"
                };
            }
        }

        /// <summary>
        /// This method deletes the Service Object from the database, using a specific ServiceId
        /// </summary>
        /// <param name="id"></param>

        //[Authorize(Roles = "2,3")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                string sql = "DELETE FROM hfo_Service WHERE ServiceId = @ServiceId";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    connection.Execute(sql, new { ServiceId = id });
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            catch (SqlException)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Service kan ikke slettes. Prøv igen senere"
                };
            }
        }
    }
}
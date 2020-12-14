using Dapper;
using HairForceOne.WebService.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HairForceOne.WebService.Controllers
    //navne ændres
    // trycatch mangler
    // Authorization tags
{
    /// <summary>
    /// This class contains all methods for handling services
    /// </summary>
    public class ServicesController : ApiController
    {
        /// <summary>
        /// This method gets a list of all services
        /// </summary>
        /// <returns>List of services</returns>
        [AllowAnonymous]
        public IEnumerable<Service> GetAllServices()
        {
            string sql = "SELECT * FROM hfo_Service";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.Query<Service>(sql).ToList();
            }
        }

        // skal slettes

        /// <summary>
        /// This method gets a list of all services based on Gender parameter
        /// </summary>
        /// <param name="gender"></param>
        /// <returns></returns>
        public IEnumerable<Service> GetAllServicesGender(string gender)
        {
            string sql = "SELECT * from hfo_Service WHERE Gender LIKE CONCAT('%',@Gender,'%')";

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.Query<Service>(sql, new { Gender = gender }).ToList();
            }
        }

        /// <summary>
        /// This method gets a service based on specific ServiceId
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Service based on ServiceId</returns>
        public Service GetService(int id)
        {
            string sql = $"select * FROM hfo_Service WHERE ServiceId = @ServiceId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.QuerySingleOrDefault<Service>(sql, new { ServiceId = id });
            }
        }

        /// <summary>
        /// This method posts a new service
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        public HttpResponseMessage Post([FromBody] Service service)
        {
            string sql = "INSERT INTO hfo_Service (Title,Description,Duration,Price,Gender)" +
                         "VALUES (@Title, @Description, @Duration, @Price, @Gender)";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                var affectedRows = connection.Execute(sql, new
                {
                    Title = service.Title,
                    Description = service.Description,
                    Duration = service.Duration,
                    Price = service.Price,
                    Gender = service.Gender,
                });
                return Request.CreateResponse(HttpStatusCode.Accepted);
            }
        }

        /// <summary>
        /// This method edits and updates a service
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        public int Put(Service service)
        {
            string sql = "UPDATE hfo_Service SET Title = @Title, Description = @Description, Duration = @Duration, Price = @Price, Gender = @Gender WHERE ServiceId = @ServiceId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                int ProductId = connection.Execute(sql, new
                {
                    ServiceId = service.ServiceId,
                    Title = service.Title,
                    Description = service.Description,
                    Duration = service.Duration,
                    Price = service.Price,
                    Gender = service.Gender,
                });
                return ProductId;
            }
        }

        /// <summary>
        /// This method deletes a service
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            string sql = $"DELETE FROM hfo_Service WHERE ServiceId = @ServiceId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                connection.Execute(sql, new { ServiceId = id });
            }
        }
    }
}
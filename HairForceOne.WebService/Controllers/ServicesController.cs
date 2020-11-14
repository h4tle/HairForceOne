using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dapper;
using HairForceOne.WebService.Models;

namespace HairForceOne.WebService.Controllers
{
    public class ServicesController : ApiController
    {
        public IEnumerable<Service> GetAllSerices()
        {
            string sql = "SELECT * FROM hfo_Service";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.Query<Service>(sql).ToList();
            }
        }

        public IEnumerable<Service> GetAllServices(string type)
        {
            string sql = "SELECT * from hfo_Service WHERE Type LIKE CONCAT('%',@Type,'%')";

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.Query<Service>(sql, new { Type = type }).ToList();
            }
        }

        public IEnumerable<Service> GetAllServicesGender(string gender)
        {
            string sql = "SELECT * from hfo_Service WHERE Gender LIKE CONCAT('%',@Gender,'%')";

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.Query<Service>(sql, new { Gender = gender }).ToList();
            }
        }
        public Service GetService(int id)
        {
            string sql = $"select * FROM hfo_Service WHERE ServiceId = @ServiceId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.QuerySingleOrDefault<Service>(sql, new { ServiceId = id });
            }
        }
        public HttpResponseMessage Post([FromBody] Service s)
        {
            string sql = "INSERT INTO hfo_Service (Title,Decription,Duration,Price,Gender,Type)" +
                         "VALUES (@Title, @Description, @Duration, @Price, @Gender, @Type)";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                var affectedRows = connection.Execute(sql, new
                {
                    Title = s.Title,
                    Description = s.Description,
                    Duration = s.Duration,
                    Price = s.Price,
                    Gender = s.Gender,
                    Type = s.Type

                });
                return Request.CreateResponse(HttpStatusCode.Accepted);
            }
        }

        public int Put(Service s)
        {
            string sql = $"UPDATE hfo_Service SET Title = @Title, Description = @Description, Duration = @Duration, Price = @Price, Gender = @Gender, Type = @Type, WHERE ServiceId = @ServiceId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                int ProductId = connection.Execute(sql, new
                {
                    ServiceId = s.ServiceId,
                    Title = s.Title,
                    Description = s.Description,
                    Duration = s.Duration,
                    Price = s.Price,
                    Gender = s.Gender,
                    Type = s.Type
                });
                return ProductId;
            }
        }

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

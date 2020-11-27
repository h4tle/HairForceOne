using Dapper;
using HairForceOne.WebService.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace HairForceOne.WebService.Controllers
{
    public class EventsController
    {
        [AllowAnonymous]
        public IEnumerable<Event> GetAllEvents()
        {
            string sql = "SELECT * FROM hfo_Event";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.Query<Event>(sql).ToList();
            }
        }
    }
}
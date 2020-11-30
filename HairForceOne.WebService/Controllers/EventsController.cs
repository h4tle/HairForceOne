using Dapper;
using HairForceOne.WebService.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HairForceOne.WebService.Controllers
{
    public class EventsController : ApiController
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

        [HttpPost]
        public IEnumerable<DateTime> Post(SelectedPayload TimeThing)
        {
            TimeSpan Duration = new TimeSpan(0, TimeThing.Duration, 0);
            int empId = 1;
            DateTime open = DateTime.Now;
            open.AddHours(9.00);
            DateTime close = DateTime.Now;
            close.AddHours(16.00);
            string test1 = close.ToString();
            string sql = $"SELECT * FROM hfo_Event WHERE StartTime > '2020-12-1' AND EmployeeId = 1";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                var result = connection.Query<Event>(sql, new
                {
                    eployeeId = empId,
                    selectedDate = TimeThing.SelectedDate,
                });
                //Calculating available times
                List<DateTime> availableTimes = new List<DateTime>();
                for (DateTime i = open; i < close; i = i + Duration)
                {
                    foreach (Event e in result)
                    {
                        if (open + Duration < e.Start)
                        {
                            availableTimes.Add(open);
                        }
                    }
                }

                return availableTimes;
            }
        }
    }
}
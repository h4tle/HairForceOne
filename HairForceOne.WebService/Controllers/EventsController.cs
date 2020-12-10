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
        public IEnumerable<dynamic> GetAllEvents()
        {
            string sql = "exec [GetSomeTable]";

            //string sql = "SELECT * FROM hfo_Event";

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                var results = connection.Query<dynamic>(sql).ToList();
                return results;
            }
        }

        [HttpPost]
        public IEnumerable<TimeSpan> Post(SelectedPayload TimeThing)
        {
            var newTimezz = TimeThing.SelectedDate.Date.AddTicks(DateTime.Now.TimeOfDay.Ticks);
            TimeSpan Duration = new TimeSpan(0, TimeThing.Duration, 0);
            int empId = TimeThing.EmployeeId;
            TimeSpan open = new TimeSpan(9, 0, 0);
            if (newTimezz.TimeOfDay < open)
            {
                DateTime test2 = newTimezz.Date.AddTicks(open.Ticks);
                newTimezz = test2;
            }
            TimeSpan close = new TimeSpan(16, 0, 0);
            TimeSpan interval = new TimeSpan(0, 15, 0);
            DateTime selectedDate = new DateTime((newTimezz.Ticks + interval.Ticks - 1) / interval.Ticks * interval.Ticks, newTimezz.Kind);
            if (selectedDate.Date != DateTime.Now.Date)
            {

                DateTime test3 = selectedDate.Date.AddTicks(open.Ticks);
                selectedDate = test3;
            }
            try
            {
                string sql = $"SELECT * FROM hfo_AltBooking WHERE DATEDIFF( d , StartTime , @selectedDate ) = 0 AND EmployeeId = @employeeId";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    var result = connection.Query<AltBooking>(sql, new
                    {
                        employeeId = empId,
                        selectedDate,
                    });
                    List<AltBooking> events = result.OrderBy(d => d.StartTime).ToList();
                    //Calculating available times
                    List<TimeSpan> availableTimes = new List<TimeSpan>();
                    for (TimeSpan i = selectedDate.TimeOfDay; i < close; i = i + interval)
                    {
                        if (i + Duration > close)
                        {
                            return availableTimes;
                        }
                        bool avail = true;
                        for (int i2 = 0; i2 < events.Count; i2++)
                        {
                            TimeSpan eventDuration = new TimeSpan(0, events.ElementAt(i2).Duration, 0);
                            if (i + Duration <= events.ElementAt(i2).StartTime.TimeOfDay || i >= events.ElementAt(i2).StartTime.TimeOfDay.Add(eventDuration))
                            {

                            }
                            else
                            {
                                if (i2 > 0)
                                {

                                    events.RemoveAt(i2 - 1);
                                }
                                avail = false;
                                break;
                            }
                        }
                        if (avail)
                        {
                            availableTimes.Add(i);
                        }
                    }

                    return availableTimes;
                }
            }
            catch (SqlException e)
            {

                throw e;
            }
            
        }
    }
}
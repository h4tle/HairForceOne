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
    // Authorizeation tags mangler
{
    /// <summary>
    /// This class contains the methods that handles the booking instance
    /// </summary>
    [RoutePrefix("api/bookings")]
    public class BookingsController : ApiController
    {
        // GET: api/Bookings
        [HttpGet]
        public IEnumerable<Booking> GetAllBookings()
        {
            try
            {
                //hfo_Booking
                string sql = "SELECT * FROM hfo_Booking";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    return connection.Query<Booking>(sql).ToList();
                }
            }
            // return HttpStatusCode with execption

            catch (SqlException e)
            {
                throw e;
            }
        }

        // ret navn
        [HttpPost]
        [Route("date")]
        public IEnumerable<Booking> BookingsByDate([FromBody] DateTime date)
        {
            try
            {
                string sql = "SELECT * FROM hfo_Booking WHERE datediff(dd, StartTime, @date) = 0";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    return connection.Query<Booking>(sql, new { date });
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        //Bruger ikke endnu, mangler try/catch
        public Booking GetBooking(int id)
        {
            string sql = "select * FROM hfo_Booking WHERE BookingId = @BookingId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.QuerySingleOrDefault<Booking>(sql, new { BookingId = id });
            }
        }

        // Try/Catch virker som den skal her (Kan bruges i andre metoder)
        //Skal refaktureres 
        [HttpPost]
        public HttpResponseMessage CreateNewBooking([FromBody] Booking booking)
        {
            //ClaimsPrincipal user = HttpContext.Current.User as ClaimsPrincipal;
            //var UserId = user.FindFirst(ClaimTypes.NameIdentifier).Value;
            try
            {
                string sql = "INSERT INTO hfo_Booking (TotalPrice, EmployeeId, UserId, Comment, StartTime, Duration)" +
                             "VALUES (@TotalPrice, @EmployeeId, @UserId, @Comment, @StartTime, @Duration)";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    var affectedRows = connection.Execute(sql, new
                    {
                        booking.TotalPrice,
                        booking.EmployeeId,
                        booking.UserId,
                        booking.Comment,
                        booking.StartTime,
                        booking.Duration,
                    });
                    return Request.CreateResponse(HttpStatusCode.Accepted);
                }
            }
            catch (SqlException e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e);
            }
        }

        [HttpPut]
        public int UpdateBooking(Booking booking)
        {
            string sql = "UPDATE hfo_Booking SET TotalPrice = @TotalPrice, EmployeeId = @EmployeeId, UserId = @UserId, Comment = @Comment, StartTime = @StartTime, Duration = @Duration, IsDone = @IsDone WHERE BookingId = @BookingId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                int BookingId = connection.Execute(sql, new
                {
                    TotalPrice = booking.TotalPrice,
                    EmployeeId = booking.EmployeeId,
                    UserId = booking.UserId,
                    booking.Comment,
                    StartTime = booking.StartTime,
                    booking.Duration,
                    booking.CreatedAt,
                    booking.IsDone,
                    BookingId = booking.BookingId,
                });
                return BookingId;
            }
        }

        [HttpDelete]
        public void DeleteBooking(int bookingId)
        {
            string sql = "DELETE FROM hfo_Booking WHERE BookingId = @bookingId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                connection.Execute(sql, new { bookingId });
            }
        }
    }
}
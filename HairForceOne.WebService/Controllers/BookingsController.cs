using Dapper;
using HairForceOne.WebService.Model;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace HairForceOne.WebService.Controllers
// Authorizeation tags mangler
{
    /// <summary>
    /// This class contains the methods that handles the booking instance
    /// </summary>
    [RoutePrefix("api/bookings")]
    [Authorize]
    public class BookingsController : ApiController
    {
        // GET: api/Bookings
        [HttpGet]
        [Authorize(Roles = "1")]
        public HttpResponseMessage GetAllBookings()
        {
            try
            {
                //hfo_Booking
                string sql = "SELECT * FROM hfo_Booking";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    List<Booking> bookings = connection.Query<Booking>(sql).AsList();
                    return Request.CreateResponse(HttpStatusCode.OK, bookings);
                }
            }
            // return HttpStatusCode with execption
            catch (SqlException e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        // ret navn
        [HttpPost]
        [Route("date")]
        [Authorize(Roles = "1")]
        public HttpResponseMessage GetBookingsByDate([FromBody] DateTime date)
        {
            try
            {
                string sql = "SELECT * FROM hfo_Booking WHERE datediff(dd, StartTime, @date) = 0";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    List<Booking> bookings = connection.Query<Booking>(sql, new { date }).AsList();
                    return Request.CreateResponse(HttpStatusCode.OK, bookings);
                }
            }
            catch (SqlException e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        // Ret navn på route
        [HttpGet]
        [Route("mybookings")]
        public HttpResponseMessage GetBookingsByUser()
        {
            try
            {
                string UserId = HttpContext.Current.User.Identity.GetUserId();
                string sql = "SELECT * FROM hfo_Booking WHERE UserId = @UserId";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    List<Booking> bookings = connection.Query<Booking>(sql, new { UserId }).AsList();
                    return Request.CreateResponse(HttpStatusCode.OK, bookings);
                }
            }
            catch (SqlException e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        //Bruger ikke endnu, mangler try/catch
        [HttpGet]
        [Authorize(Roles = "1")]
        public HttpResponseMessage GetBooking(int id)
        {
            try
            {
                string sql = "SELECT * FROM hfo_Booking WHERE BookingId = @BookingId";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    Booking booking = connection.QuerySingleOrDefault<Booking>(sql, new { BookingId = id });
                    return Request.CreateResponse(HttpStatusCode.OK, booking);
                }
            }
            catch (SqlException e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        //Skal refaktureres
        [HttpPost]
        public HttpResponseMessage CreateBooking([FromBody] Booking booking)
        {
            try
            {
                string sql = "INSERT INTO hfo_Booking (TotalPrice, EmployeeId, UserId, Comment, StartTime, Duration)" +
                             "VALUES (@TotalPrice, @EmployeeId, @UserId, @Comment, @StartTime, @Duration)";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    var BookingId = connection.Execute(sql, new
                    {
                        booking.TotalPrice,
                        booking.EmployeeId,
                        booking.UserId,
                        booking.Comment,
                        booking.StartTime,
                        booking.Duration,
                    });
                    return Request.CreateResponse(HttpStatusCode.Accepted, BookingId);
                }
            }
            catch (SqlException e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e);
            }
        }

        [HttpPut]
        public HttpResponseMessage UpdateBooking(Booking booking)
        {
            try
            {
                string sql = "UPDATE hfo_Booking SET TotalPrice = @TotalPrice, EmployeeId = @EmployeeId, UserId = @UserId, Comment = @Comment, StartTime = @StartTime, Duration = @Duration, IsDone = @IsDone WHERE BookingId = @BookingId";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    int BookingId = connection.Execute(sql, new
                    {
                        booking.TotalPrice,
                        booking.EmployeeId,
                        booking.UserId,
                        booking.Comment,
                        booking.StartTime,
                        booking.Duration,
                        booking.CreatedAt,
                        booking.IsDone,
                        booking.BookingId,
                    });
                    return Request.CreateResponse(HttpStatusCode.OK, BookingId);
                }
            }
            catch (SqlException e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpDelete]
        public HttpResponseMessage DeleteBooking(int bookingId)
        {
            try
            {
                string sql = "DELETE FROM hfo_Booking WHERE BookingId = @bookingId";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    connection.Execute(sql, new { bookingId });
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            catch (SqlException e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }
    }
}
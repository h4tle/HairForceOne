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
{
    /// <summary>
    /// This class contains the methods that handles the booking instance
    /// </summary>
    [RoutePrefix("api/bookings")]
    [Authorize]
    public class BookingsController : ApiController
    {
        // GET: api/Bookings
        /// <summary>
        /// Gets a list of all bookings from the DB.
        /// </summary>
        /// <returns>A list of all bookings</returns>
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

        /// <summary>
        /// Gets a list of all bookings from a specific date.
        /// </summary>
        /// <param name="date">Look for bookings from this date.</param>
        /// <returns>A list of all bookings from the specified date</returns>
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

        /// <summary>
        /// Gets all bookings of the logged in user
        /// </summary>
        /// <returns>A list of all bookings from the lo</returns>
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

        /// <summary>
        /// Gets a booking with the specified id.
        /// </summary>
        /// <param name="id">Id of the booking that is retrieved</param>
        /// <returns>A single booking object</returns>
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

        /// <summary>
        /// Creates a new booking and stores it in the DB.
        /// </summary>
        /// <param name="booking">booking object to store in the DB.</param>
        /// <returns>the id of the created booking</returns>
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

        /// <summary>
        /// Replaces values in a specific booking.
        /// </summary>
        /// <param name="booking">the specific booking containing new values</param>
        /// <returns>the id of the updated booking</returns>
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

        /// <summary>
        /// Deletes a booking from the DB.
        /// </summary>
        /// <param name="bookingId">the id of the specific booking to delete</param>
        /// <returns>A status code</returns>
        [Authorize(Roles = "1")]
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
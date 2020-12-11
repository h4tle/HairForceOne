using Dapper;
using HairForceOne.WebService.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web;
using System.Web.Http;

namespace HairForceOne.WebService.Controllers
{
    [RoutePrefix("bookings/")]
    public class BookingsController : ApiController
    {
        // GET: api/Bookings
        [HttpGet]
        public IEnumerable<AltBooking> GetAllBookings()
        {
            try
            {
            string sql = "SELECT * FROM hfo_AltBooking";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                     return connection.Query<AltBooking>(sql).ToList();
            }
            }
            catch (SqlException e)
            {

                throw e;
            }
        }
        [HttpGet]
        [Route("date")]
        public IEnumerable<AltBooking> GetBookingsByDate(DateTime date)
        {
            try
            {
                string sql = "SELECT * FROM hfo_AltBooking WHERE datediff(dd, StartTime, @date) = 0";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    var l = connection.Query<AltBooking>(sql, new { date });
                    return l;
                }
            }
            catch (SqlException e)
            {

                throw e;
            }
        }

        public Booking GetBooking(int id)
        {
            string sql = $"select * FROM hfo_Booking WHERE BookingId = @BookingId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.QuerySingleOrDefault<Booking>(sql, new { ProductId = id });
            }
        }
        public HttpResponseMessage Post([FromBody] AltBooking b )
        {
            //ClaimsPrincipal user = HttpContext.Current.User as ClaimsPrincipal;
            //var UserId = user.FindFirst(ClaimTypes.NameIdentifier).Value;
            try
            {
                var UserId = 1;
                string sql = "INSERT INTO hfo_AltBooking (StartTime, Duration, TotalPrice, Comment, UserId, EmployeeId, ProductId, ServiceId)" +
                             "VALUES (@StartTime, @Duration, @TotalPrice, @Comment, @UserId, @EmployeeId, @ProductId, @ServiceId)";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    var affectedRows = connection.Execute(sql, new
                    {
                        UserId,
                        b.StartTime,
                        b.Duration,
                        b.TotalPrice,
                        b.Comment,
                        b.EmployeeId,
                        b.ProductId,
                        b.ServiceId
                    });
                    return Request.CreateResponse(HttpStatusCode.Accepted);
                }
            }
            catch (SqlException e)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, e);
            }
            
        }
        public int Put(Booking b)
        {
            string sql = $"UPDATE hfo_Booking SET StartTime = @StartTime, EndTime = @EndTime, TotalPrice = @TotalPrice, Comment = @Comment WHERE BookingId = @BookingId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                int BookingId = connection.Execute(sql, new
                {
                    ProductId = b.BookingId,
                    StartTime = b.StartTime,
                    EndTime = b.EndTime,
                    TotalPrice = b.TotalPrice,
                    Comment = b.Comment
                });
                return BookingId;
            }
        }
        [HttpDelete]
        public void Delete(int id)
        {
            string sql = $"DELETE FROM hfo_AltBooking WHERE BookingId = @id";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                connection.Execute(sql, new { id });
            }
        }
    }
}

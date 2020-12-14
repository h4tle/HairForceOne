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
            string sql = $"select * FROM hfo_Booking WHERE BookingId = @BookingId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.QuerySingleOrDefault<Booking>(sql, new { ProductId = id });
            }
        }

        // Try/Catch virker som den skal her (Kan bruges i andre metoder)
        //Skal refaktureres 
        [HttpPost]
        public HttpResponseMessage CreateNewBooking([FromBody] AltBooking b)
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

        // ret navn
        public int Put(Booking b)
        {
            string sql = "UPDATE hfo_Booking SET StartTime = @StartTime, EndTime = @EndTime, TotalPrice = @TotalPrice, Comment = @Comment WHERE BookingId = @BookingId";
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

        // ret navn
        [HttpDelete]
        public void Delete(int id)
        {
            string sql = "DELETE FROM hfo_AltBooking WHERE BookingId = @id";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                connection.Execute(sql, new { id });
            }
        }
    }
}
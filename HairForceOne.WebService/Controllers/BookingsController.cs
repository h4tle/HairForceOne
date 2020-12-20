using Dapper;
using Dapper.Transaction;
using HairForceOne.WebService.Model;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Transactions;
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
        [Authorize(Roles = "2, 3")]
        public HttpResponseMessage GetAllBookings()
        {
            try
            {
                //hfo_Booking
                string sqlBooking = "SELECT * FROM hfo_Booking WHERE isDone = 0";
                string sqlService = "EXEC GetServicesForBooking @BookingId";
                string sqlProduct = "EXEC GetProductsForBooking @BookingId";
                using (var scope = new TransactionScope())
                {
                    using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                    {
                        List<Booking> bookings = connection.Query<Booking>(sqlBooking).AsList();

                        connection.Open();
                        using (var transaction = connection.BeginTransaction())
                        {
                            foreach (Booking booking in bookings)
                            {
                                List<Service> services = transaction.Query<Service>(sqlService, new { booking.BookingId }).AsList();
                                booking.Services = services;
                                List<Product> products = transaction.Query<Product>(sqlProduct, new { booking.BookingId }).AsList();
                                booking.Products = products;
                            }
                            transaction.Commit();
                            scope.Complete();
                        }
                        return Request.CreateResponse(HttpStatusCode.OK, bookings);
                    }
                }
            }
            catch (SqlException)
            {
                var msg = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Bookings kan ikke hentes. Prøv igen senere"
                };
                throw new HttpResponseException(msg);
            }
        }

        /// <summary>
        /// Gets a list of all bookings from a specific date.
        /// </summary>
        /// <param name="date">Look for bookings from this date.</param>
        /// <returns>A list of all bookings from the specified date</returns>
        [HttpPost]
        [Route("date")]
        [Authorize(Roles = "2, 3")]
        public HttpResponseMessage GetBookingsByDate([FromBody] DateTime date)
        {
            try
            {
                string sqlBooking = "SELECT * FROM hfo_Booking WHERE datediff(dd, StartTime, @date) = 0 AND isDone = 0";
                string sqlService = "EXEC GetServicesForBooking @BookingId";
                string sqlProduct = "EXEC GetProductsForBooking @BookingId";
                using (var scope = new TransactionScope())
                {
                    using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                    {
                        List<Booking> bookings = connection.Query<Booking>(sqlBooking, new { date }).AsList();
                        connection.Open();
                        using (var transaction = connection.BeginTransaction())
                        {
                            foreach (Booking booking in bookings)
                            {
                                List<Service> services = transaction.Query<Service>(sqlService, new { booking.BookingId }).AsList();
                                booking.Services = services;
                                List<Product> products = transaction.Query<Product>(sqlProduct, new { booking.BookingId }).AsList();
                                booking.Products = products;
                            }
                            transaction.Commit();
                            scope.Complete();
                        }
                        return Request.CreateResponse(HttpStatusCode.OK, bookings);
                    }
                }
            }
            catch (SqlException)
            {
                var msg = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Bookings kan ikke hentes. Prøv igen senere"
                };
                throw new HttpResponseException(msg);
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
                string sql = "SELECT * FROM hfo_Booking WHERE UserId = @UserId AND isDone = 0";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    List<Booking> bookings = connection.Query<Booking>(sql, new { UserId }).AsList();
                    return Request.CreateResponse(HttpStatusCode.OK, bookings);
                }
            }
            catch (SqlException)
            {
                var msg = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Bookings kan ikke hentes. Prøv igen senere"
                };
                throw new HttpResponseException(msg);
            }
        }

        /// <summary>
        /// Gets a booking with the specified id.
        /// </summary>
        /// <param name="id">Id of the booking that is retrieved</param>
        /// <returns>A single booking object</returns>
        [HttpGet]
        [Authorize(Roles = "2, 3")]
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
            catch (SqlException)
            {
                var msg = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Booking kan ikke hentes. Prøv igen senere"
                };
                throw new HttpResponseException(msg);
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
                string bookingSql = "INSERT INTO hfo_Booking (TotalPrice, EmployeeId, UserId, Comment, StartTime, Duration)" +
                             "VALUES (@TotalPrice, @EmployeeId, @UserId, @Comment, @StartTime, @Duration); SELECT CAST(SCOPE_IDENTITY() as int)";
                string serviceSql = "INSERT INTO hfo_ServiceLine (ServiceId, BookingId)" +
                            "VALUES (@ServiceId, @BookingId)";
                string productSql = "INSERT INTO hfo_ProductLine (ProductId, BookingId, Quantity)" +
                            "VALUES (@ProductId, @BookingId, @Quantity)";
                using (var scope = new TransactionScope())
                {
                    using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                    {
                        int BookingId = connection.QuerySingle<int>(bookingSql, new
                        {
                            booking.TotalPrice,
                            booking.EmployeeId,
                            booking.UserId,
                            booking.Comment,
                            booking.StartTime,
                            booking.Duration,
                        });

                        connection.Open();

                        using (var transaction = connection.BeginTransaction())
                        {
                            foreach (Service s in booking.Services)
                            {
                                var productId = transaction.Execute(serviceSql, new
                                {
                                    s.ServiceId,
                                    BookingId
                                });
                            }

                            foreach (Product p in booking.Products)
                            {
                                var productId = transaction.Execute(productSql, new
                                {
                                    p.ProductId,
                                    BookingId,
                                    Quantity = 1
                                });
                            }
                            transaction.Commit();
                            string sqlGetBookings = "EXEC GetConcurrencyBookings @EmployeeId, @StartTime, @Duration";
                            var concurrentBookings = connection.Query<Booking>(sqlGetBookings, new
                            {
                                booking.EmployeeId,
                                booking.StartTime,
                                booking.Duration
                            }).AsList();
                            if (concurrentBookings.Count != 1)
                            {
                                scope.Dispose();
                                return Request.CreateResponse(HttpStatusCode.BadRequest);
                            }

                            scope.Complete();
                            return Request.CreateResponse(HttpStatusCode.Accepted, BookingId);
                        }
                    }
                }
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Booking kan ikke oprettes. Prøv igen"
                };
            }
        }

        /// <summary>
        /// Replaces values in a specific booking.
        /// </summary>
        /// <param name="booking">the specific booking containing new values</param>
        /// <returns>the id of the updated booking</returns>
        [HttpPut]
        [Authorize(Roles = "2,3")]
        public HttpResponseMessage UpdateBooking(Booking booking)
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    string updateSql = "EXEC UpdateServiceAndProductLines @BookingId";
                    string serviceSql = "INSERT INTO hfo_ServiceLine (ServiceId, BookingId)" +
                            "VALUES (@ServiceId, @BookingId)";
                    string productSql = "INSERT INTO hfo_ProductLine (ProductId, BookingId, Quantity)" +
                             "VALUES (@ProductId, @BookingId, @Quantity)";
                    string bookingSql = "UPDATE hfo_Booking SET TotalPrice = @TotalPrice, EmployeeId = @EmployeeId, UserId = @UserId, Comment = @Comment, StartTime = @StartTime, Duration = @Duration, IsDone = @IsDone WHERE BookingId = @BookingId";
                    using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                    {
                        int BookingId = connection.Execute(bookingSql, new
                        {
                            booking.TotalPrice,
                            booking.EmployeeId,
                            booking.UserId,
                            booking.Comment,
                            booking.StartTime,
                            booking.Duration,
                            booking.IsDone,
                            booking.BookingId,
                        });
                        connection.Open();
                        connection.Execute(updateSql, new { booking.BookingId });
                        connection.Open();

                        using (var transaction = connection.BeginTransaction())
                        {
                            foreach (Service s in booking.Services)
                            {
                                var serviceId = transaction.Execute(serviceSql, new
                                {
                                    s.ServiceId,
                                    BookingId
                                });
                            }

                            foreach (Product p in booking.Products)
                            {
                                var productId = transaction.Execute(productSql, new
                                {
                                    p.ProductId,
                                    BookingId,
                                    p.Quantity
                                });
                            }
                            transaction.Commit();
                        }
                        scope.Complete();
                        return Request.CreateResponse(HttpStatusCode.OK, BookingId);
                    }
                }
            }
            catch (SqlException)
            {
                var msg = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Booking kan ikke opdateres. Prøv igen senere"
                };
                throw new HttpResponseException(msg);
            }
        }

        /// <summary>
        /// Deletes a booking from the DB.
        /// </summary>
        /// <param name="bookingId">the id of the specific booking to delete</param>
        /// <returns>A status code</returns>
        [Authorize(Roles = "2,3")]
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
            catch (SqlException)
            {
                var msg = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Bookingen kunne ikke slettes. Prøv igen."
                };
                throw new HttpResponseException(msg);
            }
        }

        [HttpPost]
        [Route("availabletimes")]
        public HttpResponseMessage GetAvialableTimes(Event ev)
        {
            // Sets the time of the selected date to be the current time
            var currentTime = ev.SelectedDate.Date.AddTicks(DateTime.Now.TimeOfDay.Ticks);
            TimeSpan Duration = new TimeSpan(0, ev.Duration, 0);
            int employeeId = ev.EmployeeId;
            TimeSpan openHour = new TimeSpan(9, 0, 0);
            // Checks if the current time is earlier than the open time
            if (currentTime.TimeOfDay < openHour)
            {
                DateTime sameAsOpenHour = currentTime.Date.AddTicks(openHour.Ticks);
                currentTime = sameAsOpenHour;
            }
            TimeSpan closeHour = new TimeSpan(16, 0, 0);
            TimeSpan interval = new TimeSpan(0, 15, 0);
            DateTime selectedDate = new DateTime((currentTime.Ticks + interval.Ticks - 1) / interval.Ticks * interval.Ticks, currentTime.Kind);
            // Checks if the selected date is the same as the current date and sets the start time to the open time if not
            if (selectedDate.Date != DateTime.Now.Date)
            {
                DateTime sameAsOpenHour = selectedDate.Date.AddTicks(openHour.Ticks);
                selectedDate = sameAsOpenHour;
            }
            try
            {
                string sql = $"SELECT * FROM hfo_Booking WHERE DATEDIFF( d , StartTime , @selectedDate ) = 0 AND EmployeeId = @employeeId AND isDone = 0";
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
                {
                    var result = connection.Query<Booking>(sql, new
                    {
                        employeeId,
                        selectedDate,
                    });
                    //Sorts the list of bookings in ascending order
                    List<Booking> bookings = result.OrderBy(d => d.StartTime).ToList();
                    //Calculating available times
                    List<TimeSpan> availableTimes = new List<TimeSpan>();
                    for (TimeSpan i = selectedDate.TimeOfDay; i < closeHour; i = i + interval)
                    {
                        //Checks if the selected time and duration is after the closing hour.
                        if (i + Duration > closeHour)
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, availableTimes);
                        }
                        bool available = true;
                        for (int i2 = 0; i2 < bookings.Count; i2++)
                        {
                            TimeSpan bookingDuration = new TimeSpan(0, bookings.ElementAt(i2).Duration, 0);
                            //Checks if the the booking overlaps with our selected time
                            if (i + Duration <= bookings.ElementAt(i2).StartTime.TimeOfDay || i >= bookings.ElementAt(i2).StartTime.TimeOfDay.Add(bookingDuration))
                            {
                            }
                            else
                            {
                                //Removes booking if we've already checked all overlapping times
                                if (i2 > 0)
                                {
                                    bookings.RemoveAt(i2 - 1);
                                }
                                available = false;
                                break;
                            }
                        }
                        // If no bookings overlapped, add to list of avaliable times
                        if (available)
                        {
                            availableTimes.Add(i);
                        }
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, availableTimes);
                }
            }
            catch (SqlException)
            {
                var msg = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = "Ledige tider kan ikke hentes. Prøv igen."
                };
                throw new HttpResponseException(msg);
            }
        }
    }
}
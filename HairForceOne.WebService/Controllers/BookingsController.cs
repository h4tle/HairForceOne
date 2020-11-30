﻿using Dapper;
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
    public class BookingsController : ApiController
    {
        // GET: api/Bookings
        public IEnumerable<Booking> GetAllBookings()
        {
            string sql = "SELECT * FROM hfo_Booking";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                return connection.Query<Booking>(sql).ToList();
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
            
            string sql = "INSERT INTO hfo_AltBooking (StartTime,Duration,TotalPrice,Comment,EmployeeId, ProductId, ServiceId)" +
                         "VALUES (@StartTime, @Duration, @TotalPrice, @Comment, @EmployeeId, @ProductId, @ServiceId)";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                var affectedRows = connection.Execute(sql, new
                {
                    b.StartTime,
                    b.Duration,
                    b.TotalPrice,
                    b.Comment,
                    b.Employee.EmployeeId,
                    b.Products.First<Product>().ProductId,
                    b.Services.First<Service>().ServiceId
                });
                return Request.CreateResponse(HttpStatusCode.Accepted);
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
        public void Delete(int id)
        {
            string sql = $"DELETE FROM hfo_Booking WHERE BookingId = @BookingId";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                connection.Execute(sql, new { ProductId = id });
            }
        }
    }
}
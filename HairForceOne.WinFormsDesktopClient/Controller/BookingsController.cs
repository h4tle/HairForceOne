﻿using HairForceOne.WinFormsDesktopClient.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HairForceOne.WinFormsDesktopClient.Controller
{
    class BookingsController : IBookingsController
    {
        HttpClient client = new HttpClient();
        public BookingsController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["HairForceOneApiURL"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "Your Oauth token");
        }

        public NotImplementedException Create(Booking booking)
        {
            try
            {
                var JBooking = new StringContent(JsonConvert.SerializeObject(booking), Encoding.UTF8, "application/json");
                Task<HttpResponseMessage> responseTask = client.PostAsync($"bookings/", JBooking);
                responseTask.Wait();

                if (responseTask.Result.IsSuccessStatusCode)
                {
                    return new NotImplementedException();
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            catch (SqlException e)
            {

                throw e;
            }
            
        }

        public NotImplementedException Delete(Booking b)
        {
            throw new NotImplementedException();
        }

        public NotImplementedException Edit(Booking b)
        {
            throw new NotImplementedException();
        }

        public List<Booking> GetAllBookings()
        {
            throw new NotImplementedException();
        }

        public List<TimeSpan> GetAvailableTimes(Event e)
        {
            var JEvent = new StringContent(JsonConvert.SerializeObject(e), Encoding.UTF8, "application/json");
            Task<HttpResponseMessage> responseTask = client.PostAsync($"events/", JEvent);
            responseTask.Wait();

            if (responseTask.Result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<TimeSpan>>(responseTask.Result.Content.ReadAsStringAsync().Result);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
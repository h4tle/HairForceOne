using HairForceOne.WinFormsDesktopClient.Model;
using Meziantou.Framework.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

// håndter exceptions (custom exception??)
// tag exception fra statuscode og håndter den
// try catch (Måske)
// navngiv metoder
// async
namespace HairForceOne.WinFormsDesktopClient.Controller
{
    internal class BookingsController : IBookingsController
    {
        private HttpClient Client { get; set; }

        public BookingsController()
        {
            Client = new HttpClient
            {
                BaseAddress = new Uri(ConfigurationManager.AppSettings["HairForceOneApiURL"])
            };
            // skal sætte token ind
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", CredentialManager.ReadCredential(applicationName: "Token").Password);
        }

        internal bool CheckOut(Booking booking)
        {
            booking.IsDone = true;
            var JBooking = new StringContent(JsonConvert.SerializeObject(booking), Encoding.UTF8, "application/json");
            Task<HttpResponseMessage> responseTask = Client.PutAsync($"bookings/{booking.BookingId}", JBooking);
            responseTask.Wait();
            return responseTask.Result.IsSuccessStatusCode;
        }

        // navngiv metode
        public bool Create(Booking booking)
        {
            try
            {
                var JBooking = new StringContent(JsonConvert.SerializeObject(booking), Encoding.UTF8, "application/json");
                Task<HttpResponseMessage> responseTask = Client.PostAsync($"bookings/", JBooking);
                responseTask.Wait();

                return responseTask.Result.IsSuccessStatusCode;
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public bool Delete(int bookingId)
        {
            Task<HttpResponseMessage> responseTask = Client.DeleteAsync($"bookings/{bookingId}");
            responseTask.Wait();

            return responseTask.Result.IsSuccessStatusCode;
        }

        public bool Edit(Booking booking)
        {
            var JBooking = new StringContent(JsonConvert.SerializeObject(booking), Encoding.UTF8, "application/json");
            Task<HttpResponseMessage> responseTask = Client.PutAsync($"bookings/{booking.BookingId}", JBooking);
            responseTask.Wait();
            return responseTask.Result.IsSuccessStatusCode;
        }

        public List<Booking> GetAllBookings()
        {
            Task<HttpResponseMessage> responseTask = Client.GetAsync($"bookings/");
            responseTask.Wait();
            if (responseTask.Result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<Booking>>(responseTask.Result.Content.ReadAsStringAsync().Result);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public List<Booking> GetBookingsByDate(DateTime date)
        {
            var JDate = new StringContent(JsonConvert.SerializeObject(date), Encoding.UTF8, "application/json");
            Task<HttpResponseMessage> responseTask = Client.PostAsync($"bookings/date/", JDate);
            responseTask.Wait();

            if (responseTask.Result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<Booking>>(responseTask.Result.Content.ReadAsStringAsync().Result);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public List<Booking> GetBookingsByEmployee(Employee employee, DateTime date)
        {
            List<Booking> bookings = GetBookingsByDate(date);
            if (employee == null)
            {
                return bookings;
            }
            else
            {
                List<Booking> employeeBookings = new List<Booking>();
                foreach (Booking booking in bookings)
                {
                    if (booking.EmployeeId == employee.EmployeeId)
                    {
                        employeeBookings.Add(booking);
                    }
                }
                return employeeBookings;
            }
        }

        public List<TimeSpan> GetAvailableTimes(Event e)
        {
            var JEvent = new StringContent(JsonConvert.SerializeObject(e), Encoding.UTF8, "application/json");
            Task<HttpResponseMessage> responseTask = Client.PostAsync($"bookings/availabletimes", JEvent);
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
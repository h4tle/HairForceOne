using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HairForceOne.WebService.Controllers
{
    public class BookingsController : ApiController
    {
        // GET: api/Bookings
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Bookings/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Bookings
        public void Post([FromBody]string value)
        {
            
        }

        // PUT: api/Bookings/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Bookings/5
        public void Delete(int id)
        {
        }
    }
}

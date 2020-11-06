using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Net.Http;
using System.Web.Http;
using System.Security.Principal;
using System.Threading;
using System.Security.Claims;
using Microsoft.Owin.Security;

namespace HairForceOne.WebService.Controllers
{
    public class LoginController : ApiController
    {
        // GET: api/Login
        
        public ClaimsPrincipal Get()
        {
          //  AuthenticationTicket manager = new AuthenticationTicket()
           // var test4 = Request.GetOwinContext().Request.User;
            var test = Thread.CurrentPrincipal;
            var test2 = HttpContext.Current.User.Identity;
            ClaimsPrincipal c = HttpContext.Current.User as ClaimsPrincipal;
            return c;
        }

        // GET: api/Login/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Login
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}

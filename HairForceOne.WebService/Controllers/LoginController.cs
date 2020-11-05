using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Net.Http;
using System.Web.Http;
using System.Security.Principal;
using System.Threading;

namespace HairForceOne.WebService.Controllers
{
    public class LoginController : ApiController
    {
        // GET: api/Login
        public IPrincipal Get()
        {
            var test4 = Request.GetOwinContext().Request.User;
            var test = Thread.CurrentPrincipal;
            var test2 = HttpContext.Current.User.Identity;
            return HttpContext.Current.User;
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

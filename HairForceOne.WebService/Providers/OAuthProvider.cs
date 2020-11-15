using Dapper;
using HairForceOne.WebService.Models;
using HairForceOne.WebService.Util;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace HairForceOne.WebService.Providers
{
    public class OAuthProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            await Task.Run(() => context.Validated());
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Hildur"].ConnectionString))
            {
                string Email = context.UserName;
                string password = context.Password;


                // searching the user in the database
                var reader = conn.QueryMultiple("SELECT * FROM hfo_User WHERE Email =@Email; SELECT * FROM hfo_Employee WHERE Email =@Email",
                    new { Email });
                User u = reader.ReadSingleOrDefault<User>();
                Employee e = reader.ReadSingleOrDefault<Employee>();

                // if the user is found, claims are added
                if (u != null || e != null)
                {
                    if(u != null)
                    {
                        if (PasswordHelper.ComparePass(password, u.Password, u.Salt))
                        {
                            var Claims = new List<Claim>();
                            Claims.Add(new Claim(ClaimTypes.Name, u.FirstName));
                            Claims.Add(new Claim(ClaimTypes.NameIdentifier, u.UserId.ToString()));
                            Claims.Add(new Claim("LoggedOn", DateTime.Now.ToString())); // ??
                            Claims.Add(new Claim(ClaimTypes.Role, u.Roles));
                            ClaimsIdentity oAuthClaimIdentity = new ClaimsIdentity(Claims, context.Options.AuthenticationType);

                            // Ticket har din identity
                            AuthenticationTicket ticket = new AuthenticationTicket(oAuthClaimIdentity, new AuthenticationProperties());
                            await Task.Run(() => context.Validated(ticket));
                        }
                    }
                    else
                    {
                        if (PasswordHelper.ComparePass(password, e.PasswordHash, e.Salt))
                        {
                            var Claims = new List<Claim>();
                            Claims.Add(new Claim(ClaimTypes.Name, e.FirstName));
                            Claims.Add(new Claim(ClaimTypes.NameIdentifier, e.EmployeeId.ToString()));
                            Claims.Add(new Claim("LoggedOn", DateTime.Now.ToString())); // ??
                            Claims.Add(new Claim(ClaimTypes.Role, e.Roles));
                            ClaimsIdentity oAuthClaimIdentity = new ClaimsIdentity(Claims, context.Options.AuthenticationType);

                            // Ticket har din identity
                            AuthenticationTicket ticket = new AuthenticationTicket(oAuthClaimIdentity, new AuthenticationProperties());
                            await Task.Run(() => context.Validated(ticket));
                        }
                    }
                    
                }
                else
                {
                    context.SetError("Wrong Crendentials", "Provided username and password is incorrect");
                }
            }
        }

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.Current.GetOwinContext().Authentication;
            }
        }
    }
}
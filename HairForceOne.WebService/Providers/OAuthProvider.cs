using Dapper;
using HairForceOne.WebService.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
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
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dapperConnStr"].ConnectionString))
            {
                string Email = context.UserName;
                string PasswordHash = ComputeHash(context.Password); // computing hash of password

                // searching the user in the database
                User user = conn.QuerySingleOrDefault<User>("SELECT * FROM hfo_User WHERE Email =@Email AND Password =@PasswordHash",
                    new {Email, PasswordHash});

                // if the user is found, claims are added
                if (user != null)
                {
                    var Claims = new List<Claim>();
                    Claims.Add(new Claim(ClaimTypes.Name, user.FirstName));
                    Claims.Add(new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()));
                    Claims.Add(new Claim("LoggedOn", DateTime.Now.ToString())); // ??
                    Claims.Add(new Claim(ClaimTypes.Role, user.Roles));
                    ClaimsIdentity oAuthClaimIdentity = new ClaimsIdentity(Claims, context.Options.AuthenticationType);

                    // Ticket har din identity
                    AuthenticationTicket ticket = new AuthenticationTicket(oAuthClaimIdentity, new AuthenticationProperties());
                    await Task.Run(() => context.Validated(ticket));
                }
                else { 
                    context.SetError("Wrong Crendentials", "Provided username and password is incorrect");
                }
            }
        }
        public string ComputeHash(string input)
        {
            using (var sha = SHA512.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {builder.Append(bytes[i].ToString("X2")); }
                return builder.ToString();
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
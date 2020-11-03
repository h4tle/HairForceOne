using Dapper;
using HairForceOne.WebService.Models;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dapperConnStr"].ConnectionString))
            {
                string username = context.UserName;
                //string passwordHash = ComputeHash(context.Password); // computing hash of password
                string passwordHash = context.Password;

                // searching the user in the database
                var user = conn.QuerySingleOrDefault<Customer>("SELECT * FROM Customer WHERE Email = @username AND PhoneNumber = @passwordHash"
                    , new { username, passwordHash });

                // if the user is found, claims are added
                if (user != null)
                {
                    identity.AddClaim(new Claim(ClaimTypes.Name, user.FirstName));
                    identity.AddClaim(new Claim("LoggedOn", DateTime.Now.ToString()));
                    await Task.Run(() => context.Validated(identity));
                }
                else
                {
                    context.SetError("Wrong Crendentials", "Provided username and password is incorrect");
                }

            }
        }

        private string ComputeHash(string input)
        {
            using (var sha = SHA512.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
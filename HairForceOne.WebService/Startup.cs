using Microsoft.Owin.Cors;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using HairForceOne.WebService.Providers;
using System.Web.Http;
using HairForceOne.WebService.Providers;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;

[assembly: OwinStartup(typeof(HairForceOne.WebService.Startup))]

namespace HairForceOne.WebService
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            app.UseCors(CorsOptions.AllowAll); // enables cross origin http requests
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/token")
            });

            // creating options object 
            var oauthoptions = new OAuthAuthorizationServerOptions
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(30), //token expiration time  
                Provider = new OAuthProvider() // oauthprovider is a custom implementation
            };

            // configuring the application
            app.UseOAuthBearerTokens(oauthoptions);
            app.UseOAuthAuthorizationServer(oauthoptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}
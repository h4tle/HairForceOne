using HairForceOne.WebService.Providers;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;

//using HairForceOne.WebService.Providers;
using System.Web.Http;

[assembly: OwinStartup(typeof(HairForceOne.WebService.Startup))]

namespace HairForceOne.WebService
{
    public class Startup
    {
        // skal gennemgås + kommentarer
        // cors?
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll); // enables cross origin http requests
            // creating options object
            var oauthoptions = new OAuthAuthorizationServerOptions
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/api/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(60), //token expiration time
                Provider = new OAuthProvider() // oauthprovider is a custom implementation
            };

            // configuring the application
            app.UseOAuthBearerTokens(oauthoptions);
            app.UseOAuthAuthorizationServer(oauthoptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
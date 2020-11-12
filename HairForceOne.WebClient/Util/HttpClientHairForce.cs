using HairForceOne.WebClient.Models;
using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace HairForceOne.WebClient.Util
{
    public class HttpClientHairForce
    {
        public HttpClientHairForce()
        {
            SetBase();
        }

        public HttpClient SetBase()
        {
            HttpClient h = new HttpClient();
            Token t = HttpContext.Current.Session["Token"] as Token;
            if (t != null)
            { h.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", t.AccessToken); }
            h.BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseAddress"]);
            return h;
        }
    }
}
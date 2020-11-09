using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HairForceOne.WebClient.Models
{
    public class TokenResponse
    {
        public String FirstName { get; set; }
        public String UserId { get; set; }
        public String Access_Token { get; set; }
        public Array Claims { get; set; }
    }
}
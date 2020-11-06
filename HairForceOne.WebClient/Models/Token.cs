﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HairForceOne.WebClient.Models
{
    public class Token
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("token_type")]
        public static string TokenType { get; set; }
        [JsonProperty("expires_in")]
        public static int ExpiresIn { get; set; }
        [JsonProperty("refresh_token")]
        public static string RefreshToken { get; set; }
        [JsonProperty("error")]
        public static string Error { get; set; }
    }
}
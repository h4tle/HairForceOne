﻿using System;

namespace HairForceOne.DesktopClient.Models
{
    public class TokenResponse
    {
        public String FirstName { get; set; }
        public String UserId { get; set; }
        public String Access_Token { get; set; }
        public Array Claims { get; set; }
    }
}
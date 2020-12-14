using System;
using System.Security.Cryptography;
using System.Text;

namespace HairForceOne.WebService.Util
{
    public static class PasswordHelper
    {
        // generer tilfældig streng
        public static string GenerateSalt()
        {
            int length = 32;
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buffer = new byte[length];
            rng.GetBytes(buffer);
            return Convert.ToBase64String(buffer);
        }

        // hasher password og salt
        // skal gennemgås
        // uppercase?
        public static string ComputeHash(string password, string salt)
        {
            SHA512Managed sHA512ManagedString = new SHA512Managed();
            byte[] bytes = sHA512ManagedString.ComputeHash(Encoding.UTF8.GetBytes(password + salt));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            { builder.Append(bytes[i].ToString("X2")); }
            return builder.ToString();
        }

        //public static string ComputeHash(string password, string salt)
        //{
        //    using (var sha = SHA512.Create())
        //    {
        //        // ComputeHash - returns byte array
        //        byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password + salt));
        //        // Convert byte array to a string
        //        StringBuilder builder = new StringBuilder();
        //        for (int i = 0; i < bytes.Length; i++)
        //        { builder.Append(bytes[i].ToString("X2")); }
        //        return builder.ToString();
        //    }
        //}

        // hasher og salter pass og tjekker om det er ens med det hashede og saltede pass fra db
        public static bool ComparePass(string password, string passwordHash, string salt)
        {
            string newHashedPin = ComputeHash(password, salt);
            return newHashedPin.Equals(passwordHash);
        }
    }
}
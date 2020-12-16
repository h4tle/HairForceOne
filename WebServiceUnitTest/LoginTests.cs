using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using System.Text;

namespace WebServiceUnitTest
{
    [TestClass]
    public class LoginTests
    {
        private readonly HttpClient client = new HttpClient();

        [TestMethod]
        public void CheckLogin()
        {
            try
            {
                using (client)
                {
                    string Email = "martin.jokumsen@gmail.com";
                    string Password = "12345678";

                    //var testlogin  { Email = "test@test.dk", Password = "12345678" };
                    var responseTask = client.PostAsync("http://localhost:44382/api/token", new StringContent(string.Format("grant_type=password&username={0}&password={1}", Email, Password), Encoding.UTF8));

                    //responseTask.();
                    Assert.IsTrue(responseTask.Result.IsSuccessStatusCode);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
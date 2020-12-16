using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using System.Text;

namespace WebServiceUnitTest
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void CheckLogin()
        {
            try
            {
                HttpClient client = new HttpClient();

                using (client)
                {
                    string Email = "martin.jokumsen@gmail.com";
                    string Password = "12345678";

                    //var testlogin  { Email = "test@test.dk", Password = "12345678" };
                    var response = client.PostAsync("http://localhost:44382/api/token", new StringContent(string.Format("grant_type=password&username={0}&password={1}", Email, Password), Encoding.UTF8));
                    response.Wait();
                    Assert.IsTrue(response.Result.IsSuccessStatusCode);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

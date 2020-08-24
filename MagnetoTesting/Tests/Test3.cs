using MagnetoTesting.Infrastructure;
using NUnit.Framework;
using Microsoft.Extensions.Configuration;


namespace MagnetoTesting.Tests
{
    public class Test3 : TestBase
    {
        private AdminLoginPage _adminLoginPage;
        private AdminPage _adminPage;

        public Test3()
        {
            //Configuration = configuration;
            _adminLoginPage = new AdminLoginPage(Driver);
            _adminPage = new AdminPage(Driver);
        }


        //prisiloginimo dalį galima būtų iškelt į konstruktorių (arba setup metodą)
        [Test]
        public void test3_adminLogin()
        {

            string userName = ConfigurationReader.GetValue("Admin", "Username");
            string password = ConfigurationReader.GetValue("Admin", "Password");
            string expectedResult = "Logged in as SandboxAdmin";

            _adminLoginPage.GoToAdminPage();
            _adminLoginPage.LogIn(userName, password);

            _adminPage.ClosePopup();

            string actualResult = _adminPage.GetInfoBar();
  
            Assert.That(actualResult, Contains.Substring(expectedResult));

        }
    }
}

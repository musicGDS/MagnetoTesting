using NUnit.Framework;
using MagnetoTesting.Infrastructure;

namespace MagnetoTesting.Tests
{
    //Vietoj "Test1" galima įrašyt actual testo pavadinimą (galioja ir kitiems)
    // Test if User can log in

    public class Test1 : TestBase
    {
        private HomePage _homePage;
        private LogInPage _logInPage;
        private MyAccountPage _myAccountPage;
        private AccountDashboardPage _dashboardPage;

        public Test1()
        {
            _homePage = new HomePage(Driver);
            _logInPage = new LogInPage(Driver);
            _myAccountPage = new MyAccountPage(Driver);
        }

        [Test]
        public void Test1_LogIn()
        {
            string userEmail = ConfigurationReader.GetValue("User1", "Username");
            string userPassword = ConfigurationReader.GetValue("User1", "Password");
            string expectedPageTitle = "My Account";
            
            _homePage.GoToHomepage();
            _homePage.GoToLogin();
            _logInPage.LogIn(userEmail, userPassword);
            
            string actualTitle = _myAccountPage.GetPageTitle();            
            Assert.That(expectedPageTitle == actualTitle);
        }
    }
}
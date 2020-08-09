using System;
using NUnit.Framework;
using MagnetoTesting.Infrastructure;


namespace MagnetoTesting
{
    public class Test2 : TestBase
    {
        private HomePage _homePage;
        private LogInPage _logInPage;
        private MyAccountPage _myAccountPage;
        //private AccountDashboardPage _dashboardPage;

        public Test2()
        {
            _homePage = new HomePage(Driver);
            _logInPage = new LogInPage(Driver);
            _myAccountPage = new MyAccountPage(Driver);
        }

        [Test]
        public void Test2_GoToMyWishlist()
        {
            string userEmail = "tester1@testing.com";
            string userPassword = "tester1testing";
            string expectedPageTitle = "My Wishlist";

            _homePage.GoToHomepage();
            _homePage.GoToLogin();

            _logInPage.InputEmail(userEmail);
            _logInPage.InputPassword(userPassword);
            _logInPage.ClickLogIn();

            _homePage.pressHomeLogo();
            _homePage.GoToMyWishlist();

            string actualTitle = Driver.Title;

            //Pokol aiskinuosi kur padeti driver close
            Driver.Close();

            //Sukursiu wishlist page
            Assert.That(expectedPageTitle == actualTitle);
        }
    }
}

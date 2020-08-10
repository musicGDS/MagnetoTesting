using System;
using NUnit.Framework;
using MagnetoTesting.Infrastructure;


namespace MagnetoTesting.Tests
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

        //useremail, userpassword galima perkelt į appsettings.json, expectedPageTitle galima perkelt į page'ą ir jame assertint, čia būtų _myWishlist.AssertCorrectTitle(actualTitle);
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

            //Sukursiu wishlist page, tada perkelsiu sita funkcija
            string actualTitle = Driver.Title;

            Assert.That(expectedPageTitle == actualTitle);
        }
    }
}

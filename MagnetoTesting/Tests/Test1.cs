using NUnit.Framework;
using MagnetoTesting.Infrastructure;
using System;

namespace MagnetoTesting
{
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
            string userEmail = "tester1@testing.com";
            string userPassword = "tester1testing";
            string expectedPageTitle = "My Account";
            
            _homePage.GoToHomepage();
            _homePage.GoToLogin();

            _logInPage.InputEmail(userEmail);
            _logInPage.InputPassword(userPassword);
            _logInPage.ClickLogIn();

            //string actualTitle = Driver.Title;

            string actualTitle = _myAccountPage.GetPageTitle();

            //Pokol aiskinuosi kur padeti driver close
            //Driver.Close();


            //Taippat bandziau is dashboard'o pasiimti welcome message "My Account" irgi tas pats

            Assert.That(expectedPageTitle == actualTitle);
        }
    }
}
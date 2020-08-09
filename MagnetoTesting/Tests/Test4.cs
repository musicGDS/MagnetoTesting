using System;
using System.Threading;
using MagnetoTesting.Infrastructure;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MagnetoTesting
{
    public class Test4 : TestBase
    {
        private HomePage _homePage;
        private LogInPage _logInPage;
        private MyAccountPage _myAccountPage;
        private AccountDashboardPage _dashboardPage;

        public Test4()
        {
            _homePage = new HomePage(Driver);
            _logInPage = new LogInPage(Driver);
            _myAccountPage = new MyAccountPage(Driver);
            _dashboardPage = new AccountDashboardPage(Driver);
        }

        [Test]

        public void test4_userLogOut()
        {
            string userEmail = "tester1@testing.com";
            string userPassword = "tester1testing";
            
            _homePage.GoToHomepage();

            Thread.Sleep(5000);

            _homePage.GoToLogin();
            _logInPage.LogIn(userEmail, userPassword);
            _homePage.LogOut();

            Assert.That(Driver.FindElements(By.LinkText("Log In")).Count != 0);
        }


    }
}

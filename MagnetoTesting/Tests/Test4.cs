﻿using System;
using MagnetoTesting.Infrastructure;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MagnetoTesting.Tests
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
            string userEmail = ConfigurationReader.GetValue("User1", "Username");
            string userPassword = ConfigurationReader.GetValue("User1", "Password");
            
            _homePage.GoToHomepage();

            _homePage.GoToLogin();
            _logInPage.LogIn(userEmail, userPassword);
            _homePage.LogOut();

            Assert.That(Driver.FindElements(By.LinkText("Log In")).Count != 0);
        }
    }
}

using System;
using MagnetoTesting.Infrastructure;
using NUnit.Framework;

//NOT FINISHED CAPTCHA 

namespace MagnetoTesting.Tests
{
    public class Test5 : TestBase
    {
        private HomePage _homePage;
        private LogInPage _logInPage;
        private CreateNewCustomerAccountPage _newCustomerPage;
        private MyAccountPage _myAccountPage;

        public Test5()
        {
            _homePage = new HomePage(Driver);
            _logInPage = new LogInPage(Driver);
            _newCustomerPage = new CreateNewCustomerAccountPage(Driver);
            _myAccountPage = new MyAccountPage(Driver);
        }

        //Remember to delete tester3 account
        [Test]
        public void Test5_CreateUser()
        {
            string name = "tester3";
            string lastName = "testing";
            string email = "tester3@testing.com";
            string password = "tester3testing";
            string expectedPageTitle = "My Account";

            _homePage.GoToHomepage();
            _homePage.GoToLogin();

            _logInPage.ClickCreateAccount();

            _newCustomerPage.InputFirstName(name);
            _newCustomerPage.InputLastName(lastName);
            _newCustomerPage.InputEmailAddress(email);
            _newCustomerPage.InputPassword(password);
            _newCustomerPage.RepeatPassword(password);

            Console.WriteLine("Enter Captcha:");
            string captchaAnswer = Console.ReadLine();

            _newCustomerPage.InputCaptcha(captchaAnswer);

            _newCustomerPage.PressSubmit();

            string actualTitle = _myAccountPage.GetPageTitle();

            //Taippat bandziau is dashboard'o pasiimti welcome message "My Account" irgi tas pats

            Assert.That(expectedPageTitle == actualTitle);

        }
    }
}

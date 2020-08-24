using MagnetoTesting.Infrastructure;
using NUnit.Framework;

namespace MagnetoTesting.Tests
{
    public class test8 : TestBase
    {
        private HomePage _homePage;
        private LogInPage _logInPage;

        private AdminLoginPage _adminLoginPage;
        private AdminPage _adminPage;
        private AdminOnlineCustomersPage _customersPage;
        private AdminCustomerInformationPage _customerInfo;

        public test8()
        {
            _homePage = new HomePage(Driver);
            _logInPage = new LogInPage(Driver);
            _adminLoginPage = new AdminLoginPage(Driver);
            _adminPage = new AdminPage(Driver);
            _customersPage = new AdminOnlineCustomersPage(Driver);
            _customerInfo = new AdminCustomerInformationPage(Driver);
        }

        [Test]
        public void Test8_checkIfLoggedInAdminPannel()
        { 
            string userEmail = ConfigurationReader.GetValue("User1", "Username");
            string userPassword = ConfigurationReader.GetValue("User1", "Password");

            string adminName = ConfigurationReader.GetValue("Admin", "Username");
            string adminPassword = ConfigurationReader.GetValue("Admin", "Password");

            string expectedUserName = "Tester1 Testing";

            _homePage.GoToHomepage();
            _homePage.GoToLogin();
            _logInPage.LogIn(userEmail, userPassword);
            _logInPage.OpenNewTab();
            

            _adminLoginPage.GoToAdminPage();
            _adminLoginPage.LogIn(adminName, adminPassword);
            _adminPage.ClosePopup();
            _adminPage.HoverCustomers();
            _adminPage.GoToOnlineCustomersPage();
            _customersPage.ClickOnFirstListItem();

            Assert.That(_customerInfo.GetCustomersFullName, Contains.Substring(expectedUserName));
        }
    }       
}

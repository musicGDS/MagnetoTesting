using System;
using MagnetoTesting.Admin;
using MagnetoTesting.Infrastructure;
using NUnit.Framework;

namespace MagnetoTesting.Tests
{
    public class Test3 : TestBase
    {
        private AdminLoginPage _adminLoginPage;
        private AdminPage _adminPage;

        public Test3()
        {
            _adminLoginPage = new AdminLoginPage(Driver);
            _adminPage = new AdminPage(Driver);
        }

        [Test]
        public void test3_adminLogin()
        {
            string userName = "SandboxAdmin";
            string password = "CdXttuZqTFsbZFQ";
            string expectedResult = "Logged in as SandboxAdmin";

            _adminLoginPage.GoToAdminPage();
            _adminLoginPage.LogIn(userName, password);

            _adminPage.ClosePopup();

            string actualResult = _adminPage.GetInfoBar();

            Assert.That(actualResult, Contains.Substring(expectedResult));

        }
    }
}

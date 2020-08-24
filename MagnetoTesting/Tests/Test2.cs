using NUnit.Framework;
using MagnetoTesting.Infrastructure;


namespace MagnetoTesting.Tests
{
    public class Test2 : TestBase
    {
        private HomePage _homePage;
        private LogInPage _logInPage;

        public Test2()
        {
            _homePage = new HomePage(Driver);
            _logInPage = new LogInPage(Driver);
        }

        //useremail, userpassword galima perkelt į appsettings.json, expectedPageTitle galima perkelt į page'ą ir jame assertint, čia būtų _myWishlist.AssertCorrectTitle(actualTitle);
        [Test]
        public void Test2_GoToMyWishlist()
        {
            string userEmail = ConfigurationReader.GetValue("User1", "Username");
            string userPassword = ConfigurationReader.GetValue("User1", "Password");

            _homePage.GoToHomepage();
            _homePage.GoToLogin();

            _logInPage.InputEmail(userEmail);
            _logInPage.InputPassword(userPassword);
            _logInPage.ClickLogIn();

            _homePage.pressHomeLogo();
            _homePage.GoToMyWishlist();    
        }
    }
}

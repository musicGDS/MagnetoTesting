using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using MagnetoTesting.Infrastructure;

namespace MagnetoTesting
{
    public class HomePage : PageBase
    {
        private string homepageURL = ConfigurationReader.GetValue("URL", "MainUrl");
        private WebDriverWait wait;

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        //Page elements

        //Header

        private By elem_logo = By.XPath("//a[@class='logo']//img");

        //Search

        private By elem_searchInput = By.XPath("//input[@id='search']");

        private By elem_searchButton = By.XPath("//div[@class='form-search']//button[@class='button']");

        //User menu

        private By elem_welcomeMessage = By.ClassName("welcome-msg");

        private By elem_buttonMyAccount = By.LinkText("My Account");

        private By elem_buttonMyWishlist = By.LinkText("My Wishlist");

        private By elem_buttonLogIn = By.LinkText("Log In");

        private By elem_buttonLogOut = By.LinkText("Log Out");

        //Methods

        public void GoToHomepage()
        {
            Driver.Navigate().GoToUrl(homepageURL);
        }

        public void pressHomeLogo()
        {
            Click(elem_logo);
        }

        //Search bar Methods

        public void InputSearchText(string userInput)
        {
            SendKeys(elem_searchInput, userInput);
        }

        public void PressSearch()
        {
            Click(elem_searchButton);
        }

        //User Account links methods

        public string WelcomeMessage()
        {
            return Text(elem_welcomeMessage);
        }

        public void GoToMyAccount()
        {
            Click(elem_buttonMyAccount);
        }

        public void GoToMyWishlist()
        {
            Click(elem_buttonMyWishlist);
        }


        //My Cart

        //Checkout

        public void GoToLogin()
        {
            Click(elem_buttonLogIn);
            
        }

        public void LogOut()
        {
            Click(elem_buttonLogOut);
        }
    }
}

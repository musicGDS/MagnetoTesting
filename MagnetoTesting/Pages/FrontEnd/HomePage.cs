using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using MagnetoTesting.Infrastructure;
using System.Threading;

namespace MagnetoTesting
{
    public class HomePage : PageBase
    {
        private string homepageURL = "http://dovydenas.lt/sandboxthree/";
        private WebDriverWait wait;

        public HomePage(IWebDriver driver) : base(driver)
        {
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        //Page elements

        //Header

        private By elem_logo = By.XPath("//a[@class='logo']//img");

        //Search

        private By elem_searchInput = By.XPath("//input[@id='search']");

        private By elem_searchButton = By.XPath("//input[@id='search']");

        //User menu

        private By elem_welcomeMessage = By.ClassName("welcome-msg");

        private By elem_buttonMyAccount = By.LinkText("My Account");

        private By elem_buttonMyWishlist = By.LinkText("My Wishlist");

        private By elem_buttonMyCart = By.XPath("//a[@class='top-link-cart']");

        private By elem_buttonCheckout = By.XPath("Checkout");

        private By elem_buttonLogIn = By.LinkText("Log In");

        private By elem_buttonLogOut = By.LinkText("Log Out");


        //Compare Products

        private By elem_compareProductsCount = By.XPath("//div[@class='block-title']//strong//span//small");

        // Both filled and empty

        private By elem_compareProductsList = By.XPath("//ol[@id='compare-items']");

        private By elem_compareProductsCountClearList = By.XPath("//div[@class='actions']//a");

        private By elem_compareProductsCompare = By.XPath("//button[@class='button']//span//span[contains(text(),'Compare')]");

        // My Cart

        private By elem_myCartItemCount = By.XPath("//p[@class='amount']//a");

        private By elem_myCartSubtotal = By.XPath("//p[@class='subtotal']");

        private By elem_myCartSubtotalAmount = By.XPath("//p[@class='subtotal']//span[@class='price']");

        private By elem_myCartCheckoutButton = By.XPath("//span[contains(text(),'Checkout')]");

        private By elem_myCartProductsList = By.XPath("//span[contains(text(),'Checkout')]");

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

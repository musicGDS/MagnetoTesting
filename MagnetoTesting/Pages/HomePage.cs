using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
// For supporting Page Object Model
// Obsolete - using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using MagnetoTesting.Infrastructure;

namespace MagnetoTesting
{
    public class HomePage : PageBase
    {
        private string homepageURL = "http://dovydenas.lt/sandboxthree/";
        private WebDriverWait wait;

        public HomePage(IWebDriver driver) : base(driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
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

        
        //Compare Products

        [FindsBy(How = How.XPath, Using = "//div[@class='block-title']//strong//span//small")]
        private IWebElement elem_compareProductsCount;

        // Both filled and empty
        [FindsBy(How = How.XPath, Using = "//ol[@id='compare-items']")]
        private IWebElement elem_compareProductsList;

        [FindsBy(How = How.XPath, Using = "//div[@class='actions']//a")]
        private IWebElement elem_compareProductsCountClearList;

        [FindsBy(How = How.XPath, Using = "//button[@class='button']//span//span[contains(text(),'Compare')]")]
        private IWebElement elem_compareProductsCompare;

        // My Cart

        [FindsBy(How = How.XPath, Using = "//p[@class='amount']//a")]
        private IWebElement elem_myCartItemCount;

        [FindsBy(How = How.XPath, Using = "//p[@class='subtotal']")]
        private IWebElement elem_myCartSubtotal;

        [FindsBy(How = How.XPath, Using = "//p[@class='subtotal']//span[@class='price']")]
        private IWebElement elem_myCartSubtotalAmount;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Checkout')]")]
        private IWebElement elem_myCartCheckoutButton;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Checkout')]")]
        private IWebElement elem_myCartProductsList;

        public void pressHomeLogo()
        {
            Click(elem_searchInput);
        }

        //Methods

        public void GoToGomepage()
        {
            Driver.Navigate().GoToUrl(homepageURL);
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

        //My Wishlist

        //My Cart

        //Checkout

        public void GoToLogin()
        {
            Click(elem_buttonLogIn);
            
        }
    }
}

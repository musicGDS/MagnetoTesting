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

namespace MagnetoTesting
{
    public class HomePage
    {
        private string homepageURL = "http://dovydenas.lt/sandboxthree/";
        private IWebDriver driver;
        private WebDriverWait wait;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            PageFactory.InitElements(driver, this);
        }

        //Page elements

        //Header

        [FindsBy(How = How.XPath, Using = "//a[@class='logo']//img")]
        private IWebElement elem_logo;

        //Search

        [FindsBy(How = How.XPath, Using = "//input[@id='search']")]
        private IWebElement elem_searchInput;

        [FindsBy(How = How.XPath, Using = "//input[@id='search']")]
        private IWebElement elem_searchButton;

        //User menu

        [FindsBy(How = How.ClassName, Using = "welcome-msg")]
        private IWebElement elem_welcomeMessage;

        [FindsBy(How = How.LinkText, Using = "My Account")]
        private IWebElement elem_buttonMyAccount;

        [FindsBy(How = How.LinkText, Using = "My Wishlist")]
        private IWebElement elem_buttonMyWishlist;

        [FindsBy(How = How.XPath, Using = "//a[@class='top-link-cart']")]
        private IWebElement elem_buttonMyCart;

        [FindsBy(How = How.LinkText, Using = "Checkout")]
        private IWebElement elem_buttonCheckout;

        [FindsBy(How = How.LinkText, Using = "Log In")]
        private IWebElement elem_buttonLogIn;

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
            elem_searchInput.Click();
        }

        //Methods

        public void GoToGomepage()
        {
            driver.Navigate().GoToUrl(homepageURL);
        }
        //Search bar Methods

        public void InputSearchText(string userInput)
        {
            elem_searchInput.SendKeys(userInput);
        }

        public void PressSearch()
        {
            elem_searchButton.Click();
        }

        //User Account links methods

        public string WelcomeMessage()
        {
            return elem_welcomeMessage.Text;
        }

        public MyAccount GoToMyAccount()
        {
            elem_buttonMyAccount.Click();
            return new MyAccount(driver);
        }

        //My Wishlist

        //My Cart

        //Checkout

        public LogIn GoToLogin()
        {
            elem_buttonLogIn.Click();
            return new LogIn(driver);
        }
    }
}

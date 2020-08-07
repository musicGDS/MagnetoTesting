using System;
using MagnetoTesting.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MagnetoTesting
{
    public class AccountDashboardPage : PageBase
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public AccountDashboardPage(IWebDriver driver) : base(driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        //Elements

        private By elem_welcomeMessage = By.XPath("//p[@class='hello']//strong");

        //Methods

        //Pasiaiskint, kodel nesuveike
        public string GetWelcomeMessage()
        {
            return Text(elem_welcomeMessage);
        }
    }
}

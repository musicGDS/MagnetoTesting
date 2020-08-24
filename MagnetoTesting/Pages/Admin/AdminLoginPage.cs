using System;
using MagnetoTesting.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Microsoft.Extensions.Configuration;

namespace MagnetoTesting
{
    public class AdminLoginPage : PageBase

    {
        private string adminPanelURL = ConfigurationReader.GetValue("URL", "AdminUrl");
        private IWebDriver driver;
        private WebDriverWait wait;

        public AdminLoginPage(IWebDriver driver) : base(driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        private By elem_userNameInput = By.XPath("//input[@id='username']");

        private By elem_passwordInput = By.XPath("//input[@id='login']");

        private By elem_forgotPassword = By.XPath("//a[@class='left']");

        private By elem_logInButton = By.XPath("//input[@class='form-button']");

        public void GoToAdminPage()
        {
            Driver.Navigate().GoToUrl(adminPanelURL);
        }

        public void InputUsername(string userName)
        {
            SendKeys(elem_userNameInput, userName);
        }

        public void InputPassword(string password)
        {
            SendKeys(elem_passwordInput, password);
        }

        public void ClickLogin()
        {
            Click(elem_logInButton);
        }

        public void ClickForgotPassword()
        {
            Click(elem_forgotPassword);
        }

        public void LogIn(string userName, string password)
        {
            InputUsername(userName);
            InputPassword(password);
            ClickLogin();
        }

    }
}

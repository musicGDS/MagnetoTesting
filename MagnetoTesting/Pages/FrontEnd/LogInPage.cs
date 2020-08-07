using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using MagnetoTesting.Infrastructure;

namespace MagnetoTesting
{
    public class LogInPage : PageBase
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public LogInPage(IWebDriver driver) : base(driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        // Elements

        private By elem_buttonCreateAccount = By.XPath("//span[contains(text(),'Create an Account')]");

        private By elem_fieldEmail = By.Id("email");

        private By elem_fieldPassword = By.Id("pass");

        private By elem_forgotPassword = By.XPath("//a[contains(text(),'Forgot Your Password?')]");

        private By elem_ButtonLogin = By.XPath("//span[contains(text(),'Login')]");

        // Methods

        public void ClickCreateAccount()
        {
            Click(elem_buttonCreateAccount);
        }

        public void InputEmail(string email)
        {
            SendKeys(elem_fieldEmail, email);
        }

        public void InputPassword(string pass)
        {
            SendKeys(elem_fieldPassword, pass);
        }

        public void ClickForgotPassword()
        {
            Click(elem_forgotPassword);
        }

        public void ClickLogIn()
        {
            Click(elem_ButtonLogin);
        }

        public void LogIn(string email, string password)
        {
            InputEmail(email);
            InputPassword(password);
            ClickLogIn();
        }

    }
}
﻿using System;
using MagnetoTesting.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MagnetoTesting
{
    public class AdminLoginPage : PageBase

    {
        private string adminPanelURL =
            "http://dovydenas.lt/sandboxthree/index.php/admin/index/index/key/88bbdb6c542e5ea72f83e22c8f726c00/";
        private IWebDriver driver;
        private WebDriverWait wait;

        public AdminLoginPage(driver) : base(driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        private By elem_userNameInput = By.XPath("//input[@id='username']");

        private By elem_passwordInput = By.XPath("//input[@id='login']");

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

        //parasyti viena metoda loginui

    }
}

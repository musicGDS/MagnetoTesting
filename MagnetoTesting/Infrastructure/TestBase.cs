using System;
using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace MagnetoTesting.Infrastructure
{
    public class TestBase
    {
        public IWebDriver Driver;

        public TestBase()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
        }

        [TearDown]
        public void _TearDown()
        {
            Driver.Quit();
        }
    }
}
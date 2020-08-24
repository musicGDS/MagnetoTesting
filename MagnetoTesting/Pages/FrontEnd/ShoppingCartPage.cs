using System;
using MagnetoTesting.Infrastructure;
using OpenQA.Selenium;

namespace MagnetoTesting
{
    public class ShoppingCartPage : PageBase
    {
        public ShoppingCartPage(IWebDriver driver) : base(driver)
        {
        }

        //Methods

        public string GetPageTitle()
        {
            return Driver.Title;
        }
    }
}

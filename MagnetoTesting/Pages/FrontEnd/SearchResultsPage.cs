using System;
using MagnetoTesting.Infrastructure;
using OpenQA.Selenium;

namespace MagnetoTesting
{
    public class SearchResultsPage : PageBase
    {
        public SearchResultsPage(IWebDriver driver) : base(driver)
        {
        }

        //Elements

        
        //Methods

        public bool IsPresent(string linkText)
        {
            return Driver.FindElements(By.LinkText(linkText)).Count != 0;
        }
    }
}

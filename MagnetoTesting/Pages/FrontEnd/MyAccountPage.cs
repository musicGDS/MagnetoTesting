using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using MagnetoTesting.Infrastructure;

namespace MagnetoTesting
{
    public class MyAccountPage : PageBase 
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public MyAccountPage(IWebDriver driver) : base(driver)
        {
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        //vietoj komentarų ir "Elements" ar "Methods", gali naudot #region

        // Elements


        //Methods

        public string GetPageTitle()
        {
            return Driver.Title;
        }
    }
}
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using MagnetoTesting.Infrastructure;

namespace MagnetoTesting
{
    public class MyAccountPage : PageBase 
    {
        public MyAccountPage(IWebDriver driver) : base(driver)
        {       
        }
        
        public string GetPageTitle()
        {
            return Driver.Title;
        }
    }
}
using System;
using MagnetoTesting.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
namespace MagnetoTesting
{
    public class AdminCustomerInformationPage : PageBase
    {
        public AdminCustomerInformationPage(IWebDriver driver) : base(driver)
        {
        }

        //Elements

        private By elem_customerFullName = By.XPath("//div[@class='main-col-inner']//h3[@class='icon-head head-customer'][contains(text(),'Tester1 Testing')]");

        //Methods

        public string GetCustomersFullName()
        {
            return Text(elem_customerFullName);
        }
    }
}

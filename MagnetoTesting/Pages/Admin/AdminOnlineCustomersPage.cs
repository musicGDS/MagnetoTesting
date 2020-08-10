using MagnetoTesting.Infrastructure;
using OpenQA.Selenium;

namespace MagnetoTesting
{
    public class AdminOnlineCustomersPage : PageBase
    {
        public AdminOnlineCustomersPage(IWebDriver driver) : base(driver)
        {
        }

        //Elements

        private By elem_table = By.XPath("//table[@id='onlineGrid_table']//tbody");

        private By elem_firstListItem = By.XPath("//tr[@class='even pointer']");

        //Methods

       
        public void ClickOnFirstListItem()
        {
            Click(elem_firstListItem);
        }

    }
}
using MagnetoTesting.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace MagnetoTesting
{
    public class AdminOnlineCustomersPage : PageBase
    {
        public AdminOnlineCustomersPage(IWebDriver driver) : base(driver)
        {
        }

        //Elements

        private By elem_table = By.XPath("//table[@id='onlineGrid_table']//tbody");

        private By elem_firstListItem = By.XPath("//div[@class='grid']//tr[1]//td[1]");

        //Methods

       
        public void ClickOnFirstListItem()
        {
            //Actions actions = new Actions(Driver);
            //actions.MoveToElement(Element(elem_firstListItem)).Click().Perform();
            Click(elem_firstListItem);
        }

    }
}
using MagnetoTesting.Infrastructure;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MagentoTesting
{
    public class WishlistPage : PageBase 
    {
        private IWebDriver driver;
        

        public WishlistPage(IWebDriver driver) : base(driver)
        { 
        }

        private string ActualTitle()
        {
            return Driver.Title;
        }

        private string expectedPageTitle = "My Wishlist";

        public void AssertTitle()
        {
            Assert.That(expectedPageTitle == ActualTitle());
        }
    }
}

using OpenQA.Selenium;


namespace MagnetoTesting.Infrastructure
{
    public class PageBase
    {
        public IWebDriver Driver;

        public PageBase(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement Element(By by)
        {
            return Driver.FindElement(by);
        }

        public void Click(By by)
        {
            Element(by).Click();
        }

        public void SendKeys(By by, string keys)
        {
            Element(by).SendKeys(keys);
        }

        public string Text(By by)
        {
            return Element(by).Text;
        }
    }
}

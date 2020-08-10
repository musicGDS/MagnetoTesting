using System;
using MagnetoTesting.Infrastructure;
using OpenQA.Selenium;

namespace MagnetoTesting.Admin
{
    public class AdminPage : PageBase

    {
        //private IWebDriver driver;

        public AdminPage(IWebDriver driver) : base(driver)
        {
        }

        //Header
        private By elem_logo = By.XPath("private IWebDriver driver;");

        private By elem_globalSearch = By.XPath("//input[@id='global_search']");

        private By elem_infoBar = By.XPath("//p[@class='super']");

        private By elem_logOut = By.XPath("//a[@class='link-logout']");

        private By elem_closePopupButton = By.XPath("//div[@class='message-popup-head']//a");

        //Menu

        private By elem_menuDashboard = By.XPath("//body[@id='html-body']/div/div/div/ul[@id='nav']/li[1]/a[1]");

        private By elem_menuSales = By.XPath("//body[@id='html-body']/div/div/div/ul[@id='nav']/li[2]/a[1]");

        private By elem_menuCatalog = By.XPath("//body[@id='html-body']/div/div/div/ul[@id='nav']/li[3]/a[1]");

        private By elem_menuMobile = By.XPath("//body[@id='html-body']/div/div/div/ul[@id='nav']/li[4]/a[1]");

        private By elem_menuCustomers = By.XPath("//body[@id='html-body']/div/div/div/ul[@id='nav']/li[5]/a[1]");

        private By elem_menuPromotions = By.XPath("//body[@id='html-body']/div/div/div/ul[@id='nav']/li[6]/a[1]");

        private By elem_menuNewsletter = By.XPath("//body[@id='html-body']/div/div/div/ul[@id='nav']/li[7]/a[1]");

        private By elem_menuCMS = By.XPath("//body[@id='html-body']/div/div/div/ul[@id='nav']/li[8]/a[1]");

        private By elem_menuReports = By.XPath("//body[@id='html-body']/div/div/div/ul[@id='nav']/li[9]/a[1]");

        private By elem_menuSystem = By.XPath("//body[@id='html-body']/div/div/div/ul[@id='nav']/li[10]/a[1]");

        private By elem_helpLink = By.XPath("//a[@id='page-help-link']");

        //Methods

        public void PressHomeLogo()
        {
            Click(elem_logo);
        }

        public void LogOut()
        {
            Click(elem_logOut);
        }

        public string GetInfoBar()
        {
            return Text(elem_infoBar);
        }

        public void ClosePopup()
        {
            Click(elem_closePopupButton);
        }

    }
}

using MagnetoTesting.Infrastructure;
using OpenQA.Selenium;

namespace MagnetoTesting
{
    public class AccountDashboardPage : PageBase
    {
        public AccountDashboardPage(IWebDriver driver) : base(driver)
        {
        }

        //Elements

        private By elem_welcomeMessage = By.ClassName("welcome-msg");

        //Methods

        //Pasiaiskint, kodel nesuveike
        public string GetWelcomeMessage()
        {
            return Text(elem_welcomeMessage);
        }
    }
}

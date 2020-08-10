using System;
using MagnetoTesting.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MagnetoTesting
{
    public class CreateNewCustomerAccountPage : PageBase 
    {
        public CreateNewCustomerAccountPage(IWebDriver driver) : base(driver)
        {
        }

        private By elem_firstNameInput = By.Id("firstname");

        private By elem_lastNameInput = By.Id("lastname");

        private By elem_emailAddressInput = By.Id("email_address");

        private By elem_newsletterSignupCheckbox = By.Id("is_subscribed");

        private By elem_passwordInput = By.Id("password");

        private By elem_confirmPasswordInput = By.Id("confirmation");

        private By elem_captchaInput = By.Id("captcha_user_create");

        private By elem_captchaImage = By.Id("user_create");

        private By elem_backButton = By.XPath("//a[@class='back-link']");

        private By elem_submitButton = By.XPath("//div[@class='buttons-set']//button[@class='button']");

        //Methods

        public void InputFirstName(string name)
        {
            SendKeys(elem_firstNameInput, name);
        }

        public void InputLastName(string name)
        {
            SendKeys(elem_lastNameInput, name);
        }

        public void InputEmailAddress(string email)
        {
            SendKeys(elem_emailAddressInput, email);
        }

        public void PressSubscribeButton()
        {
            Click(elem_newsletterSignupCheckbox);
        }

        public void InputPassword(string pass)
        {
            SendKeys(elem_passwordInput, pass);
        }

        public void RepeatPassword(string pass)
        {
            SendKeys(elem_confirmPasswordInput, pass);
        }

        public void InputCaptcha(string answer)
        {
            SendKeys(elem_captchaInput, answer);
        }

        public void GoBack()
        {
            Click(elem_backButton);
        }

        public void PressSubmit()
        {
            Click(elem_submitButton);
        }
    }
}

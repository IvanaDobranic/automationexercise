using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExerciseFramework.Pages
{
    class PaymentPage
    {
        readonly IWebDriver _driver;
        public By payInfo = By.ClassName("payment-information");
        public By nameonCard = By.CssSelector("[name='name_on_card'][required=''][type='text']");
        public By cardNumber = By.CssSelector("[name='card_number'][required=''][type='text']");
        public By cvc = By.CssSelector("[placeholder='ex. 311'][required=''][type='text']");
        public By expir = By.CssSelector("[placeholder='MM'][required=''][type='text']");
        public By year = By.CssSelector("[placeholder='YYYY'][required=''][type='text']");
        public By payconfBtn = By.CssSelector("[data-qa='pay-button'][type='submit']");


        public PaymentPage(IWebDriver driver)

        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(payInfo));
        }
    }
}

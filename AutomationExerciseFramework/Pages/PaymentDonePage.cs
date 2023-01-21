using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExerciseFramework.Pages
{
    class PaymentDonePage
    {
        readonly IWebDriver _driver;
        public By paydone = By.CssSelector("[data-qa='order-placed'][style='color: green;'] b");
        public By downInv = By.CssSelector(".check_out[href='/download_invoice/500']");

        public PaymentDonePage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(paydone));
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExerciseFramework.Pages
{
    class CheckOutPage
    {
        public IWebDriver _driver;
        public By addressBox = By.Id("address_delivery");
        public By commBox = By.ClassName("form-control");
        public By placeBtn = By.CssSelector(".btn-default.check_out[href='/payment']");
        

        public CheckOutPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(addressBox));
        }
    }
}

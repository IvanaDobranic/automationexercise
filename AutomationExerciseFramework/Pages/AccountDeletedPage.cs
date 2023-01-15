using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExerciseFramework.Pages
{
    class AccountDeletedPage
    {
        readonly IWebDriver _driver;
        public By deletePage = By.XPath("//h2[@data-qa='account-deleted']");
        public By contDelBtn = By.ClassName("btn-primary");

        public AccountDeletedPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(deletePage));
        }
    }
}

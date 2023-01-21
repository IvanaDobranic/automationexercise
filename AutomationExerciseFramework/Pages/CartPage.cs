using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExerciseFramework.Pages
{
    class CartPage
    {
        public IWebDriver _driver;
        public By cartLink = By.ClassName("fa-shopping-cart");
        public By insidecart = By.CssSelector("cart_description h4 a[href='/product_details/5']");
        public By wiewItempic = By.CssSelector("[href='/product_details/5']");
        public By proceedBtn = By.CssSelector("btn.check_out");

        public CartPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(cartLink));
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExerciseFramework.Pages
{
    class ProductDetails
    {
        public IWebDriver _driver;
        public By prodDetInfo = By.ClassName("product-information");
        public By addtocartBtn = By.CssSelector(".btn-default.cart[type='button']");
        public By viewcartBtn = By.CssSelector(".text-center [href='/view_cart']");


        public ProductDetails(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(prodDetInfo));

        }
    }
}

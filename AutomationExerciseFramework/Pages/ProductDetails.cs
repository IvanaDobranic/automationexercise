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
        public By prodName = By.XPath("//*[@class='product-information']//h2");
        public By yourName = By.Id("name");
        public By emaiAdd = By.Id("email");
        public By addRevF = By.Id("review");
        public By subbtn = By.Id("button-review");
        public By confmess = By.XPath("//*[@class='form-row']//span");


        public ProductDetails(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(prodDetInfo));

        }
    }
}

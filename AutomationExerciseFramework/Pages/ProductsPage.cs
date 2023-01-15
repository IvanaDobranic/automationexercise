using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationExerciseFramework.Pages
{
    class ProductsPage
    {
        public IWebDriver _driver;
        public By productsPage = By.ClassName("features_items");
        public By searchInput = By.Id("search_product");
        public By searchBtn = By.Id("submit_search");
        public By viewProdBtn = By.ClassName("fa-plus-square");

        public ProductsPage(IWebDriver driver)
        {
            this._driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(productsPage));
        }
    }
}

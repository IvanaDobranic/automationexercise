using AutomationExerciseFramework.Helpers;
<<<<<<< HEAD
using AutomationExerciseFramework.Pages;
using NUnit.Framework;
=======
>>>>>>> main
using System;
using TechTalk.SpecFlow;

namespace AutomationExerciseFramework.Steps
{
    [Binding]
<<<<<<< HEAD
    public class PDPSteps : Base
    {
        Utilites ut = new Utilites(Driver);
        HeaderPage hp = new HeaderPage(Driver);

        private readonly ProductData productData;

        public PDPSteps(ProductData productData)
        {
            this.productData = productData;
        }

       
=======
    public class PDPSteps: Base
    {
        Utilites ut = new Utilites(Driver);
>>>>>>> main

        [Given(@"user opens products page")]
        public void GivenUserOpensProductsPage()
        {
<<<<<<< HEAD
            ut.ClickOnElement(hp.productsLink);
        }
        
        [Given(@"searches for '(.*)' term")]
        public void GivenSearchesForTerm(string searchedTerm)
        {
            ProductsPage pp = new ProductsPage(Driver);
            ut.EnterTextInElement(pp.searchInput, searchedTerm);
            ut.ClickOnElement(pp.searchBtn);
=======
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"searches for '(.*)' term")]
        public void GivenSearchesForTerm(string p0)
        {
            ScenarioContext.Current.Pending();
>>>>>>> main
        }
        
        [Given(@"opens first search result")]
        public void GivenOpensFirstSearchResult()
        {
<<<<<<< HEAD
            ProductsPage pp = new ProductsPage(Driver);
            ut.ClickOnElement(pp.viewProdBtn);

=======
            ScenarioContext.Current.Pending();
>>>>>>> main
        }
        
        [When(@"user click on Add to Cart button")]
        public void WhenUserClickOnAddToCartButton()
        {
<<<<<<< HEAD
            ProductDetails pd = new ProductDetails(Driver);
            productData.ProductName = ut.ReturnTextFromElement(pd.prodName);
            ut.ClickOnElement(pd.addtocartBtn);
=======
            ScenarioContext.Current.Pending();
>>>>>>> main
        }
        
        [When(@"proceeds to cart")]
        public void WhenProceedsToCart()
        {
<<<<<<< HEAD
            ProductDetails pd = new ProductDetails(Driver);
            ut.ClickOnElement(pd.viewcartBtn);
        }
        
        [Then(@"shopping cart will be displayed with expected product inside")]
        public void ThenShoppingCartWillBeDisplayedWithProuctInside()
        {
            CartPage cp = new CartPage(Driver);
            Assert.True(ut.TextPresentInElement(productData.ProductName), "Page NOT found");


=======
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"shopping cart will be displayed with '(.*)' prouct inside")]
        public void ThenShoppingCartWillBeDisplayedWithProuctInside(string p0)
        {
            ScenarioContext.Current.Pending();
>>>>>>> main
        }
    }
}

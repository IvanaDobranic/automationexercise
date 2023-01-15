using AutomationExerciseFramework.Helpers;
using AutomationExerciseFramework.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationExerciseFramework.Steps
{
    [Binding]
    public class PDPSteps : Base
    {
        Utilites ut = new Utilites(Driver);
        HeaderPage hp = new HeaderPage(Driver);

        internal ProductDetails ProductDetails { get; private set; }

        [Given(@"user opens products page")]
        public void GivenUserOpensProductsPage()
        {
            ut.ClickOnElement(hp.productsLink);
        }
        
        [Given(@"searches for '(.*)' term")]
        public void GivenSearchesForTerm(string searchedTerm)
        {
            ProductsPage pp = new ProductsPage(Driver);
            ut.EnterTextInElement(pp.searchInput, searchedTerm);
            ut.ClickOnElement(pp.searchBtn);
        }
        
        [Given(@"opens first search result")]
        public void GivenOpensFirstSearchResult()
        {
            ProductsPage pp = new ProductsPage(Driver);
            ut.ClickOnElement(pp.viewProdBtn);

        }
        
        [When(@"user click on Add to Cart button")]
        public void WhenUserClickOnAddToCartButton()
        {
            ProductDetails pd = new ProductDetails(Driver);
            ut.ClickOnElement(pd.addtocartBtn);
        }
        
        [When(@"proceeds to cart")]
        public void WhenProceedsToCart()
        {
            ProductDetails pd = new ProductDetails(Driver);
            ut.ClickOnElement(pd.viewcartBtn);
        }
        
        [Then(@"shopping cart will be displayed with '(.*)' prouct inside")]
        public void ThenShoppingCartWillBeDisplayedWithProuctInside(string pageFound)
        {
            CartPage cp = new CartPage(Driver);
            Assert.True(ut.TextPresentInElement(pageFound), "Page NOT found");


        }
    }
}

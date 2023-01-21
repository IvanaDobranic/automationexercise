using AutomationExerciseFramework.Helpers;
using AutomationExerciseFramework.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationExerciseFramework.Steps
{
    [Binding]
    public class CheckOutSteps : Base
    {
        Utilites ut = new Utilites(Driver);
        HeaderPage hp = new HeaderPage(Driver);


        [When(@"shopping cart will be displayed with expected product inside")]
        public void WhenShoppingCartWillBeDisplayedWithExpectedProductInside()
        {
            CartPage cp = new CartPage(Driver);
            ut.ElementIsDisplayed(cp.wiewItempic);
        }
        
        [When(@"user click on '(.*)' button")]
        public void WhenUserClickOnButton()
        {
            CartPage cp = new CartPage(Driver);
            ut.ClickOnElement(cp.proceedBtn);
        }
        
        [When(@"user add comment about order")]
        public void WhenUserAddCommentAboutOrder()
        {
            CheckOutPage cop = new CheckOutPage(Driver);
            ut.EnterTextInElement(cop.commBox, TestConstants.commBox);
        }
        
        [When(@"click on '(.*)' button")]
        public void WhenClickOnButton()
        {
            CheckOutPage cop = new CheckOutPage(Driver);
            ut.ClickOnElement(cop.placeBtn);
        }
        
        [When(@"user fills all required fields")]
        public void WhenUserFillsAllRequiredFields()
        {
            PaymentPage pyp = new PaymentPage(Driver);
            ut.EnterTextInElement(pyp.nameonCard, TestConstants.NameonCard);
            ut.EnterTextInElement(pyp.cardNumber, TestConstants.CardNumber);
            ut.EnterTextInElement(pyp.cvc, TestConstants.CVC);
            ut.EnterTextInElement(pyp.expir, TestConstants.ExpirationM);
            ut.EnterTextInElement(pyp.year, TestConstants.ExpirationY);
        }
        
        [When(@"user click on '(.*)'")]
        public void WhenUserClickOn()
        {
            PaymentPage pyp = new PaymentPage(Driver);
            ut.ClickOnElement(pyp.payconfBtn);
        }
        
        [Then(@"user will successfully place an order")]
        public void ThenUserWillSuccessfullyPlaceAnOrder(string message)
        {
            PaymentDonePage pydp = new PaymentDonePage(Driver);
            Assert.True(ut.TextPresentInElement(message), "Order was not placed successfully");



        }
    }
}

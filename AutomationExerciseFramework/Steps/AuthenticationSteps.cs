using AutomationExerciseFramework.Helpers;
using AutomationExerciseFramework.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationExerciseFramework.Steps
{
    [Binding]
    public class AuthenticationSteps : Base
    {
        Utilites ut = new Utilites(Driver);
        HeaderPage hp = new HeaderPage(Driver);

        [Given (@"user opens sign in page")]
        public void GivenUserOpensSignInPage()
        {
            ut.ClickOnElement(hp.loginLink);
        }
        
        [Given(@"enters correct credentials")]
        public void GivenEntersCorrectCredentials()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.loginEmail, TestConstants.Username);
            ut.EnterTextInElement(ap.loginPassword, TestConstants.Password);
  
        }
        
        [When(@"user submits login form")]
        public void WhenUserSubmitsLoginForm()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.ClickOnElement(ap.loginBtn);
        }
        
        [Then(@"user will be logged in")]
        public void ThenUserWillBeLoggedIn()
        {
            Assert.True(ut.ElementIsDisplayed(hp.deleteAcc), "User is NOT logged in");
        }

        [Given(@"enters '(.*)' name and valid email adress")]
        public void GivenEntersNameAndValidEmailAdress(string name)
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.name, name);
            ut.EnterTextInElement(ap.signupEmail, ut.GenerateRandomEmail());

        }

        [Given(@"user cliks on SignUp button")]
        public void GivenUserCliksOnSignUpButton()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.ClickOnElement(ap.signupBtn);
        }

        [When(@"user fills in all required fields")]
        public void WhenUserFillsInAllRequiredFields()
        {
            SignupPage sp = new SignupPage(Driver);
            ut.EnterTextInElement(sp.password, TestConstants.Password);
            ut.EnterTextInElement(sp.firstName, TestConstants.FirstName);
            ut.EnterTextInElement(sp.lastName, TestConstants.LastName);
            ut.EnterTextInElement(sp.address, TestConstants.Address);
            ut.DropdownSelect(sp.country, TestConstants.Country);
            ut.EnterTextInElement(sp.state, TestConstants.State);
            ut.EnterTextInElement(sp.city, TestConstants.City);
            ut.EnterTextInElement(sp.zipcode, TestConstants.ZipCode);
            ut.EnterTextInElement(sp.mobile, TestConstants.Phone);
        }

        [When(@"submits the signup form")]
        public void WhenSubmitsTheSignupForm()
        {
            SignupPage sp = new SignupPage(Driver);
            Driver.FindElement(sp.form).Submit();
            //ut.ClickOnElement(sp.createAcc);
        }

        [Then(@"user will get '(.*)' success message")]
        public void ThenUserWillGetSuccessMessage(string message)
        {
            AccountCreatedPage acp = new AccountCreatedPage(Driver);
            Assert.True(ut.TextPresentInElement(message), "User did NOT get expected success message");
            ut.ClickOnElement(acp.continueBtn);
        }




        [Given(@"user registers new account with '(.*)' name")]
        public void GivenUserOpensSignInPage(string name)
        {
            GivenUserOpensSignInPage();
            GivenEntersNameAndValidEmailAdress(name);
            GivenUserCliksOnSignUpButton();
            WhenUserFillsInAllRequiredFields();
            WhenSubmitsTheSignupForm();
            AccountCreatedPage acp = new AccountCreatedPage(Driver);
            ut.ClickOnElement(acp.continueBtn);
        }

        [When(@"user selects option for deleting the account")]
        public void WhenUserSelectsOptionForDeletingTheAccount()
        {
            HeaderPage hp = new HeaderPage(Driver);
            ut.ClickOnElement(hp.deleteAcc);
        }

        [Then(@"account will be deleted with '(.*)' message")]
        public void ThenAccountWillBeDeletedWithMessage(string message)
        {
            AccountDeletedPage adp = new AccountDeletedPage(Driver);
            Assert.True(ut.TextPresentInElement(message), "Failed to Delete Account!");
            ut.ClickOnElement(adp.contDelBtn);
        }

    }

    


    }


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SD_TestAutomationFramework.lib;
using System;
using TechTalk.SpecFlow;

namespace SD_TestAutomationFramework.BDD.scripts
{
    [Binding]
    [Scope(Feature = "Checkout")]
    public class CheckoutStepDefinitions : SharedSignIn_StepDefinition
    {
        [Given(@"I click on the basket button")]
        public void GivenIClickOnTheBasketButton()
        {
            SD_Website.SD_ProductsPage.ClickBasketLink();
        }

        [Given(@"I click on the checkout button")]
        public void GivenIClickOnTheCheckoutButton()
        {
            SD_Website.SD_BasketPage.GoToCheckout();
        }

        [When(@"I input my (.*) in the firstname field")]
        public void WhenIInputMyBobInTheFirstnameField(string firstName)
        {
            SD_Website.SD_CheckoutPage.InputFirstName(firstName);
        }

        [When(@"I input my (.*) in the lastname field")]
        public void WhenIInputMyMarleyInTheLastnameField(string lastName)
        {
            SD_Website.SD_CheckoutPage.InputLastName(lastName);
        }

        [When(@"I input my (.*) in the zip code field")]
        public void WhenIInputMyJAMCAInTheZipCodeField(string postalCode)
        {
            SD_Website.SD_CheckoutPage.InputPostCode(postalCode);
        }

        [When(@"I click the checkout button")]
        public void WhenIClickTheCheckoutButton()
        {
            SD_Website.SD_CheckoutPage.ClickCheckout();
        }



        [Then(@"I am given an Error")]
        public void ThenIAmGivenAnError()
        {
            Assert.That(SD_Website.SD_CheckoutPage.GetCheckoutAlert(), Does.Contain("Error"));
        }


        [Then(@"I am taken to  ""([^""]*)""")]
        public void ThenIAmTakenTo(string checkoutPage)
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo(checkoutPage));
        }

    }
}

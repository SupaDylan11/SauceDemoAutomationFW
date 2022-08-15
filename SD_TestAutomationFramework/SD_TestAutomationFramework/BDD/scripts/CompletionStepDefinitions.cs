using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SD_TestAutomationFramework.lib;
using System;
using TechTalk.SpecFlow;


namespace SD_TestAutomationFramework.BDD.scripts
{
    [Binding]
    [Scope (Feature = "Completion")]
    public class CompletionStepDefinitions : SharedSignIn_StepDefinition
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

        [Given(@"I enter ""([^""]*)"" in the first-name box")]
        public void GivenIEnterInTheFirst_NameBox(string bob)
        {
            SD_Website.SD_CheckoutPage.InputFirstName(bob);
        }

        [Given(@"I enter ""([^""]*)"" in the last-name box")]
        public void GivenIEnterInTheLast_NameBox(string marley)
        {
            SD_Website.SD_CheckoutPage.InputLastName(marley);
        }

        [Given(@"I enter ""([^""]*)"" in the postal-code box")]
        public void GivenIEnterInThePostal_CodeBox(string postCode)
        {
            SD_Website.SD_CheckoutPage.InputPostCode(postCode);
        }

        [Given(@"I click on the continue button in the checkout page")]
        public void GivenIClickOnTheContinueButtonInTheCheckoutPage()
        {
            SD_Website.SD_CheckoutPage.ClickCheckout();
        }

        [Given(@"I click on the finish button in the overview page")]
        public void GivenIClickOnTheFinishButtonInTheOverviewPage()
        {
            SD_Website.SD_OverviewPage.ClickFinish();
        }


        [When(@"I click the back home button")]
        public void WhenIClickTheBackHomeButton()
        {
            SD_Website.SD_CheckoutComplete.ClickBackToHome();
        }

        [Then(@"I am taken to product page")]
        public void ThenIAmTakenToProductPage()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }

        [AfterScenario]
        public void CleanUp()
        {
            SD_Website.SeleniumDriver.Quit();
        }
    }
}

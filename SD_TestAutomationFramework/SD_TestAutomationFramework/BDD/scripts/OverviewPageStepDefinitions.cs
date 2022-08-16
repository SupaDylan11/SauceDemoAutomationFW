using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SD_TestAutomationFramework.lib;
using System;
using TechTalk.SpecFlow;


namespace SD_TestAutomationFramework.BDD.scripts
{
    [Binding]
    [Scope (Feature = "Overview")]
    public class OverviewPageStepDefinitions : SharedSignIn_StepDefinition
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

        [Given(@"I click on the continue button in  the checkout page")]
        public void GivenIClickOnTheContinueButtonInTheCheckoutPage()
        {
            SD_Website.SD_CheckoutPage.ClickCheckout();
        }

        [When(@"I click the finish button in the overview page")]
        public void WhenIClickTheFinishButtonInTheOverviewPage()
        {
            SD_Website.SD_OverviewPage.ClickFinish();
        }

        [When(@"I click the cancel button in the overview page")]
        public void WhenIClickTheCancelButtonInTheOverviewPage()
        {
            SD_Website.SD_OverviewPage.ClickCancel();
        }

        [Then(@"I am taken to productpage")]
        public void ThenIAmTakenToProductpage()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }

        [Then(@"I am taken to completePage")]
        public void ThenIAmTakenToCompletePage()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/checkout-complete.html"));
        }

        [AfterScenario]
        public void CleanUp()
        {
            SD_Website.SeleniumDriver.Quit();
        }
    }
}

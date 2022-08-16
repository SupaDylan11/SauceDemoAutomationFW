using OpenQA.Selenium.Firefox;
using SD_TestAutomationFramework.lib;
using System;
using TechTalk.SpecFlow;

namespace SD_TestAutomationFramework.BDD.scripts
{
    [Binding]
    [Scope(Feature = "UserJourneys")]
    public class UserJourneysStepDefinitions
    {
        public SD_Website<FirefoxDriver> SD_Website = new();

        [Given(@"I am logged in and on the products page")]
        public void GivenIAmLoggedInAndOnTheProductsPage()
        {
            SD_Website.SD_SignInPage.VisitSignInPage();
            SD_Website.SD_SignInPage.InputUserName(AppConfigReader.User);
            SD_Website.SD_SignInPage.InputPassword(AppConfigReader.Password);
            Thread.Sleep(12000);
            SD_Website.SD_SignInPage.clickSignIn();
            Thread.Sleep(5000);
        }

        [When(@"I add (.*) and (.*) to the cart and go to my basket")]
        public void WhenIAddItem1AndItem2ToTheCartAndGoToMyBasket(string item1, string item2)
        {
            // Add products to the basket
            SD_Website.SD_ProductsPage.AddItemToCart(item1);
            SD_Website.SD_ProductsPage.AddItemToCart(item2);
            Thread.Sleep(15000);

            // Go to the Baskets page
            SD_Website.SD_ProductsPage.ClickBasketLink();
            Thread.Sleep(10000);
        }

        [When(@"remove the second product (.*) and click the Checkout button")]
        public void WhenRemoveTheSecondProductAndClickTheCheckoutButton(string secondItem)
        {
            SD_Website.SD_BasketPage.RemoveItemFromCart(secondItem);
            Thread.Sleep(10000);
            SD_Website.SD_BasketPage.GoToCheckout();
            Thread.Sleep(15000);
        }

        [When(@"I input my details (.*) (.*) and (.*) for the checkout")]
        public void WhenIInputMyDetailsAndForTheCheckout(string firstName, string lastName, string postcode)
        {
            SD_Website.SD_CheckoutPage.InputFirstName(firstName);
            SD_Website.SD_CheckoutPage.InputLastName(lastName);
            SD_Website.SD_CheckoutPage.InputPostCode(postcode);
            Thread.Sleep(15000);

            // Click the CONTINUE button
            SD_Website.SD_CheckoutPage.ClickCheckout();
            Thread.Sleep(8000);
        }

        [When(@"I click Finish button")]
        public void WhenIClickFinishButton()
        {
            SD_Website.SD_OverviewPage.ClickFinish();
            Thread.Sleep(15000);
        }

        [Then(@"I am taken to the complete page")]
        public void ThenIAmTakenToTheCompletePage()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/checkout-complete.html"));
        }

    }
}



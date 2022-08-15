using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SD_TestAutomationFramework.lib;
using System;
using TechTalk.SpecFlow;


namespace SD_TestAutomationFramework.BDD.scripts
{
    [Binding]
    public class CompletionStepDefinitions
    {
        public SD_Website<ChromeDriver> SD_Website { get; set; } = new SD_Website<ChromeDriver>();
        private string user = AppConfigReader.User;
        private string passwd = AppConfigReader.Password;
        [Given(@"I am signed in and on the confirmation page")]
        public void GivenIAmSignedInAndOnTheConfirmationPage()
        {
            SD_Website.SD_SignInPage.VisitSignInPage();
            SD_Website.SD_SignInPage.InputUserName(user);
            SD_Website.SD_SignInPage.InputPassword(passwd);
            SD_Website.SD_SignInPage.clickSignIn();
            SD_Website.SD_ProductsPage.ClickBasketLink();
            SD_Website.SD_BasketPage.GoToCheckout();

            SD_Website.SD_CheckoutPage.ClickFirstName();
            SD_Website.SD_CheckoutPage.InputFirstName("Bob");
            SD_Website.SD_CheckoutPage.ClickLastName();
            SD_Website.SD_CheckoutPage.InputLastName("Marley");
            SD_Website.SD_CheckoutPage.ClickPostCode();
            SD_Website.SD_CheckoutPage.InputPostCode("JAM1 1CA");

            SD_Website.SD_CheckoutPage.ClickCheckout();

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

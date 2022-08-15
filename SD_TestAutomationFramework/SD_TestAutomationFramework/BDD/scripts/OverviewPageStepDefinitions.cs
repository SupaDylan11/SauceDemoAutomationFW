using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SD_TestAutomationFramework.lib;
using System;
using TechTalk.SpecFlow;


namespace SD_TestAutomationFramework.BDD.scripts
{
    [Binding]
    public class OverviewPageStepDefinitions
    {
        public SD_Website<ChromeDriver> SD_Website { get; set; } = new SD_Website<ChromeDriver>();
        private string user = AppConfigReader.User;
        private string passwd = AppConfigReader.Password;
        [Given(@"I am signed in and on the overview page")]
        public void GivenIAmSignedInAndOnTheOverviewPage()
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
        }

        [When(@"I click the finish button")]
        public void WhenIClickTheFinishButton()
        {
            SD_Website.SD_OverviewPage.ClickFinish();
        }
        [When(@"I click the cancel button")]
        public void WhenIClickTheCancelButton()
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

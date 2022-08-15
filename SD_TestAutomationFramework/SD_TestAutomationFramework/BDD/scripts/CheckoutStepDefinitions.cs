using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SD_TestAutomationFramework.lib;
using System;
using TechTalk.SpecFlow;

namespace SD_TestAutomationFramework.BDD.scripts
{
    [Binding]
    public class CheckoutStepDefinitions
    {
        public SD_Website<ChromeDriver> SD_Website { get; set; } = new SD_Website<ChromeDriver>();
        private string user = AppConfigReader.User;
        private string passwd = AppConfigReader.Password;

        [Given(@"I am signed in and on the checkout page")]
        public void GivenIAmSignedInAndOnTheCheckoutPage()
        {
            SD_Website.SD_SignInPage.VisitSignInPage();
            SD_Website.SD_SignInPage.InputUserName(user);
            SD_Website.SD_SignInPage.InputPassword(passwd);
            SD_Website.SD_SignInPage.clickSignIn();
            SD_Website.SD_ProductsPage.ClickBasketLink();
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



        [AfterScenario]
        public void DiposeWebDriver()
        {
            SD_Website.SeleniumDriver.Quit();
        }
    }
}

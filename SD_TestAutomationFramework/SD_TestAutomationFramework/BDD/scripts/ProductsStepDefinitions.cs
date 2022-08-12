using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SD_TestAutomationFramework.lib;
using System;
using TechTalk.SpecFlow;

namespace SD_TestAutomationFramework.BDD.scripts
{
    [Binding]
    public class ProductsStepDefinitions
    {
        public SD_Website<ChromeDriver> SD_Website { get; set; } = new SD_Website<ChromeDriver>();

        [Given(@"I am signed in and on the products page")]
        public void GivenIAmSignedInAndOnTheProductsPage()
        {
            SD_Website.SD_SignInPage.VisitSignInPage();
            SD_Website.SD_SignInPage.InputUserName("standard_user");
            SD_Website.SD_SignInPage.InputPassword("secret_sauce");
            SD_Website.SD_SignInPage.clickSignIn();
        }

        [When(@"I select the (.*) I want to inspect")]
        public void WhenISelectTheIWantToInspect(int item)
        {
            SD_Website.SD_ProductsPage.SelectItem(item);
            Thread.Sleep(3000);
        }

        [Then(@"I am taken to that ""(.*)""")]
        public void ThenIAmTakenToThat(string itempage)
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo(itempage));
        }

        [AfterScenario]
        public void DiposeWebDriver()
        {
            SD_Website.SeleniumDriver.Quit();
        }
    }
}

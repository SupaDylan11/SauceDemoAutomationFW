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

        [When(@"I select the <item> I want to inspect")]
        public void WhenISelectTheItemIWantToInspect(IWebElement item)
        {
            throw new PendingStepException();
        }

        [Then(@"I am taken to that <itempage>")]
        public void ThenIAmTakenToThatItempage()
        {
            throw new PendingStepException();
        }
    }
}

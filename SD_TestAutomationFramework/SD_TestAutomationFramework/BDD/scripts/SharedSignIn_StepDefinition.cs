using OpenQA.Selenium.Chrome;
using SD_TestAutomationFramework.lib;
using System;
using TechTalk.SpecFlow;

namespace SD_TestAutomationFramework.BDD.scripts
{
    //[Binding]
    public class SharedSignIn_StepDefinition
    {
        public SD_Website<ChromeDriver> SD_Website = new();

        [Given(@"I am signed in and on the products page")]
        public void GivenIAmSignedInAndOnTheProductsPage()
        {
            SD_Website.SD_SignInPage.VisitSignInPage();
            SD_Website.SD_SignInPage.InputUserName(AppConfigReader.User);
            SD_Website.SD_SignInPage.InputPassword(AppConfigReader.Password);
            SD_Website.SD_SignInPage.clickSignIn();
        }


        [AfterScenario]
        public void DiposeWebDriver()
        {
            SD_Website.SeleniumDriver.Quit();
        }
    }
}

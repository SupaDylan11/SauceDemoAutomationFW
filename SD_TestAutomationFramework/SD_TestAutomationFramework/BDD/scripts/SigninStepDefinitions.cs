using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SD_TestAutomationFramework.lib;
using System;
using TechTalk.SpecFlow;


namespace SD_TestAutomationFramework.BDD.scripts
{
    [Binding]
    public class SigninStepDefinitions
    {
        public SD_Website<ChromeDriver> SD_Website { get; set; } = new SD_Website<ChromeDriver>();

        private string user = AppConfigReader.User;
        private string lockedOut = AppConfigReader.LockedOut;
        private string problem = AppConfigReader.Problem;
        private string performanceGlitch = AppConfigReader.PerformanceGlitch;
        private string password = AppConfigReader.Password;
        private string invalidUser = AppConfigReader.InvalidUser;
        private string invalidPassword = AppConfigReader.InvalidPswd;

        [Given(@"I have entered user credentials")]
        public void GivenIHaveEnteredUserCredentials()
        {
            SD_Website.SD_SignInPage.VisitSignInPage();
            SD_Website.SD_SignInPage.InputUserName(user);
            SD_Website.SD_SignInPage.InputPassword(password);
        }

        [When(@"I click the sign in button")]
        public void WhenIClickTheSignInButton()
        {
            SD_Website.SD_SignInPage.clickSignIn();
        }

        [Then(@"I will be taken to the main store page")]
        public void ThenIWillBeTakenToTheMainStorePage()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Does.Contain("https://www.saucedemo.com/inventory.html"));
        }

        [Given(@"I have entered locked out user credentials")]
        public void GivenIHaveEnteredLockedOutUserCredentials()
        {
            SD_Website.SD_SignInPage.VisitSignInPage();
            SD_Website.SD_SignInPage.InputUserName(lockedOut);
            SD_Website.SD_SignInPage.InputPassword(password);
        }

        [Then(@"I will have a locked out error")]
        public void ThenIWillHaveALockedOutError()
        {
            Assert.That(SD_Website.SD_SignInPage.GetAlertSignIn, Does.Contain("locked out"));
        }

        [Given(@"I have entered invalid credentials")]
        public void GivenIHaveEnteredInvalidCredentials()
        {
            SD_Website.SD_SignInPage.VisitSignInPage();
            SD_Website.SD_SignInPage.InputUserName(invalidUser);
            SD_Website.SD_SignInPage.InputPassword(invalidPassword);
        }

        [Then(@"I will have an error")]
        public void ThenIWillHaveAnError()
        {
            Assert.That(SD_Website.SD_SignInPage.GetAlertSignIn, Does.Contain("Epic sadface"));
        }


        [AfterScenario]
        public void DiposeWebDriver()
        {
            SD_Website.SeleniumDriver.Quit();
        }
    }
}

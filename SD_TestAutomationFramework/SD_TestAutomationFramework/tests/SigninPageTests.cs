using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SD_TestAutomationFramework.lib;

namespace SD_TestAutomationFramework.tests
{
    public class SigninPageTests
    {
        private SD_Website<ChromeDriver> SD_Website = new();

        private string user = AppConfigReader.User;
        private string lockedOut = AppConfigReader.LockedOut;
        private string problem = AppConfigReader.Problem;
        private string performanceGlitch = AppConfigReader.PerformanceGlitch;
        private string password = AppConfigReader.Password;
        private string invalidUser = AppConfigReader.InvalidUser;
        private string invalidPassword = AppConfigReader.InvalidPswd;

        [Test]
        public void GivenIAmOnTheSignInPage_WhenIEnterCorrectCredentials_WhenIClickSignIn_EnterTheStore()
        {
            SD_Website.SD_SignInPage.VisitSignInPage();
            SD_Website.SD_SignInPage.InputUserName(user);
            SD_Website.SD_SignInPage.InputPassword(password);
            SD_Website.SD_SignInPage.clickSignIn();
            Assert.That(SD_Website.SeleniumDriver.Url, Does.Contain("https://www.saucedemo.com/inventory.html"));
        }

        [Test]
        public void GivenIAmOnTheSignInPage_AndIEnterInvalidDetails_WhenIClickSignIn_ShowAnError()
        {
            SD_Website.SD_SignInPage.VisitSignInPage();
            SD_Website.SD_SignInPage.InputUserName(invalidUser);
            SD_Website.SD_SignInPage.InputPassword(invalidPassword);
            SD_Website.SD_SignInPage.clickSignIn();
            Assert.That(SD_Website.SD_SignInPage.GetAlertSignIn, Does.Contain("Epic sadface"));
        }

        [Test]
        public void GivenIAmOnTheSignInPage_AndIEnterAnLockedOutAccount_WhenIClickSignIn_ShowAnError()
        {
            SD_Website.SD_SignInPage.VisitSignInPage();
            SD_Website.SD_SignInPage.InputUserName(lockedOut);
            SD_Website.SD_SignInPage.InputPassword(password);
            SD_Website.SD_SignInPage.clickSignIn();
            Assert.That(SD_Website.SD_SignInPage.GetAlertSignIn, Does.Contain("locked out"));
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            SD_Website.SeleniumDriver.Quit();
            SD_Website.SeleniumDriver.Dispose();
        }
    }
}

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

        [TestCase("standard_user")]
        [TestCase("problem_user")]
        [TestCase("performance_glitch_user")]
        public void GivenIAmOnTheSignInPage_WhenIEnterCorrectCredentials_WhenIClickSignIn_EnterTheStore(string username)
        {
            SD_Website.SD_SignInPage.VisitSignInPage();
            SD_Website.SD_SignInPage.InputUserName(username);
            SD_Website.SD_SignInPage.InputPassword("secret_sauce");
            SD_Website.SD_SignInPage.clickSignIn();
            Assert.That(SD_Website.SeleniumDriver.Url, Does.Contain("https://www.saucedemo.com/inventory.html"));
        }

        [Test]
        public void GivenIAmOnTheSignInPage_AndIEnterInvalidDetails_WhenIClickSignIn_ShowAnError()
        {
            SD_Website.SD_SignInPage.VisitSignInPage();
            SD_Website.SD_SignInPage.InputUserName("dylan");
            SD_Website.SD_SignInPage.InputPassword("enron");
            SD_Website.SD_SignInPage.clickSignIn();
            Assert.That(SD_Website.SD_SignInPage.GetAlertSignIn, Does.Contain("Epic sadface"));
        }

        [Test]
        public void GivenIAmOnTheSignInPage_AndIEnterAnLockedOutAccount_WhenIClickSignIn_ShowAnError()
        {
            SD_Website.SD_SignInPage.VisitSignInPage();
            SD_Website.SD_SignInPage.InputUserName("locked_out_user");
            SD_Website.SD_SignInPage.InputPassword("secret_sauce");
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

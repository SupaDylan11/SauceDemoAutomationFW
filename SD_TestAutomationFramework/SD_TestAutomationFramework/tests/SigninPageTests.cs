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

        [Test]
        public void GivenIAmOnTheSignInPage_WhenIEnterCorrectCredentials_WhenIClickSignIn_EnterTheStore()
        {
            SD_Website.SD_SignInPage.VisitSignInPage();
            SD_Website.SD_SignInPage.InputUserName("standard_user");
            SD_Website.SD_SignInPage.InputPassword("secret_sauce");
            SD_Website.SD_SignInPage.clickSignIn();
            Assert.That(SD_Website.SeleniumDriver.Url, Does.Contain("https://www.saucedemo.com/inventory.html"));
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            SD_Website.SeleniumDriver.Quit();
            SD_Website.SeleniumDriver.Dispose();
        }
    }
}

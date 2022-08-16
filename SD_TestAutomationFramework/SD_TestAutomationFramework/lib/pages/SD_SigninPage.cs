using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_TestAutomationFramework.lib.pages
{
    public class SD_SigninPage
    {
        #region properties
        //WEB DRIVER
        private IWebDriver _seleniumDriver;
        private string _signInUrl = AppConfigReader.BaseUrl;
        private IWebElement _usernameLoginField => _seleniumDriver.FindElement(By.Id("user-name"));
        private IWebElement _passwordLoginField => _seleniumDriver.FindElement(By.Id("password"));
        private IWebElement _submitBtn => _seleniumDriver.FindElement(By.Id("login-button"));
        private IWebElement _signinAlert => _seleniumDriver.FindElement(By.ClassName("error-message-container"));
        #endregion

        //constructor
        public SD_SigninPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        #region 
        public void VisitSignInPage() => _seleniumDriver.Navigate().GoToUrl(_signInUrl);
        public void InputUserName(string username) => _usernameLoginField.SendKeys(username);
        public void InputPassword(string password) => _passwordLoginField.SendKeys(password);
        public void clickSignIn() => _submitBtn.Click();
        public string GetAlertSignIn() => _signinAlert.Text;
        #endregion
    }
}

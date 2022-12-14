using OpenQA.Selenium;


namespace SD_TestAutomationFramework.lib.pages
{
    public class SD_CheckoutPage
    {
        #region properties
        //WEB DRIVER
        private IWebDriver _seleniumDriver;


        private IWebElement _firstNameLoginField => _seleniumDriver.FindElement(By.Id("first-name"));
        private IWebElement _lastNameLoginField => _seleniumDriver.FindElement(By.Id("last-name"));
        private IWebElement _postalCodeLoginField => _seleniumDriver.FindElement(By.Id("postal-code"));
        private IWebElement _checkoutButton => _seleniumDriver.FindElement(By.Id("continue"));
        private IWebElement _checkoutAlert => _seleniumDriver.FindElement(By.ClassName("error-message-container"));
        #endregion

        //constructor
        public SD_CheckoutPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        #region Methods

        public void ClickFirstName() => _firstNameLoginField.Click();
        public void InputFirstName(string firstName) => _firstNameLoginField.SendKeys(firstName);
        public void ClickLastName() => _lastNameLoginField.Click();
        public void InputLastName(string lastName) => _lastNameLoginField.SendKeys(lastName);
        public void ClickPostCode() => _postalCodeLoginField.Click();
        public void InputPostCode(string postCode) => _postalCodeLoginField.SendKeys(postCode);
        public void ClickCheckout() => _checkoutButton.Click();
        public string GetCheckoutAlert() => _checkoutAlert.Text;
        #endregion

    }
}

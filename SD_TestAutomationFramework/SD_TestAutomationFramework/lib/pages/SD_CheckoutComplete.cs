using OpenQA.Selenium;


namespace SD_TestAutomationFramework.lib.pages
{
    public class SD_CheckoutComplete
    {
        #region properties
        //WEB DRIVER
        private IWebDriver _seleniumDriver;


        private IWebElement _backButton => _seleniumDriver.FindElement(By.Id("back-to-products"));

        #endregion

        //constructor
        public SD_CheckoutComplete(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        #region Methods

        public void ClickBackToHome() => _backButton.Click();

        #endregion

    }
}
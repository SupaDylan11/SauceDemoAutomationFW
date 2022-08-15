using OpenQA.Selenium;


namespace SD_TestAutomationFramework.lib.pages
{
    public class SD_OverviewPage
    {
        #region properties
        //WEB DRIVER
        private IWebDriver _seleniumDriver;


        private IWebElement _finishButton => _seleniumDriver.FindElement(By.Id("finish"));
        private IWebElement _cancelButton => _seleniumDriver.FindElement(By.Id("cancel"));
       
        #endregion

        //constructor
        public SD_OverviewPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        #region Methods

        public void ClickFinish() => _finishButton.Click();
        public void ClickCancel() => _cancelButton.Click();
       
        #endregion

    }
}
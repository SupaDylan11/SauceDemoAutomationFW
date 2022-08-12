using OpenQA.Selenium;

namespace SD_TestAutomationFramework.lib.pages
{
    public class SD_BasketPage
    {
        #region Properties and Fields
        public SD_BasketPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        private IWebDriver _seleniumDriver;

        private string _productsPageUrl = AppConfigReader.BaseUrl;
        private IWebElement _addToCartButton => _seleniumDriver.FindElement(By.LinkText("Add to cart"));
        private IWebElement _removeFromCartButton => _seleniumDriver.FindElement(By.LinkText("Remove"));
        #endregion
        
        public IWebElement AddToBasket => _addToCartButton;
        public IWebElement RemoveFromBasket => _removeFromCartButton;
    }
}


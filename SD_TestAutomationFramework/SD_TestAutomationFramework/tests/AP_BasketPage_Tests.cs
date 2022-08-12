using AP_TestAutomationFramework.lib;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SD_TestAutomationFramework;
using SD_TestAutomationFramework.lib;

namespace AP_TestAutomationFramework.tests
{
    public class AP_BasketPage_Tests
    {
        private SD_Website<FirefoxDriver> SD_Website = new();

        [Test]
        public void GivenIAmOnTheBasketPage_WhenIClickTheAddToCartButton_ThenTheItemShouldBeAdded()
        {
            SD_Website.SD_SignInPage.VisitSignInPage();
            Thread.Sleep(4000);
            SD_Website.SD_BasketPage.AddToBasket.Click();

            
        }

        [Test]
        public void GivenIAmOnTheHomePage_WhenIDoASearch_ThenIShouldLandOnTheSearchResultsPage()
        {
/*            AP_Website.AP_HomePage.VisitHomePage();
            Thread.Sleep(4000);
            AP_Website.AP_HomePage.SearchBox.SendKeys("ksdfhj");
            AP_Website.AP_HomePage.SearchBox.SendKeys(Keys.Enter);
            Thread.Sleep(4000);

            Assert.That(AP_Website.SeleniumDriver.Title, Does.Contain("Search - My Store"));*/
        }

        [Test]
        public void GivenIAmOnTheHomePage_WhenIClickOnWomensSectionButton_ThenIShouldLandOnTheWomensSectionPage()
        {
/*            AP_Website.AP_HomePage.VisitHomePage();
            Thread.Sleep(4000);
            AP_Website.AP_HomePage.WomensMenuOption.Click();
            Thread.Sleep(6000);

            Assert.That(AP_Website.SeleniumDriver.Title, Does.Contain("Women - My Store"));*/
        }


    }
}

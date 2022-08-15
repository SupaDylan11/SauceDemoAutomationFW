using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SD_TestAutomationFramework.BDD.scripts;
using SD_TestAutomationFramework.lib;
using TechTalk.SpecFlow;

namespace SD_TestAutomationFramework
{
    [Binding]
    [Scope(Feature = "Basket")]
    public class BasketStepDefinitions : SharedSignIn_StepDefinition
    {

        [Given(@"I add an (.*) to the basket")]
        public void GivenIAddAnToTheBasket(string product)
        {
            SD_Website.SD_ProductsPage.AddItemToCart(product);
        }

        [When(@"I go to the Basket page")]
        public void WhenIGoToTheBasketPage()
        {
            SD_Website.SD_ProductsPage.ClickBasketLink();
        }

        [When(@"click the Remove (.*) button")]
        public void WhenClickTheRemoveButton(string product)
        {
            SD_Website.SD_BasketPage.RemoveItemFromCart(product);
        }

        [When(@"I press the checkout button")]
        public void WhenIPressTheCheckoutButton()
        {
            SD_Website.SD_BasketPage.GoToCheckout();
        }

        [Then(@"I am taken to the checkout page")]
        public void ThenIAmTakenToTheCheckoutPage()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/checkout-step-one.html"));
        }

        [Then(@"the (.*) should be removed")]
        public void ThenTheShouldBeRemoved(string product)
        {
            IWebElement itemInBasket2 = SD_Website.SD_BasketPage.ItemInBasket(product);
            Assert.That(itemInBasket2, Is.Null);
        }

    }
}

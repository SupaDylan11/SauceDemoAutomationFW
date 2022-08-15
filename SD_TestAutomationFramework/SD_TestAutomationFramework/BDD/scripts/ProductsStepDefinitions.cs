using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SD_TestAutomationFramework.lib;
using System;
using TechTalk.SpecFlow;

namespace SD_TestAutomationFramework.BDD.scripts
{
    [Binding]
    [Scope(Feature = "Products")]
    public class ProductsStepDefinitions : SharedSignIn_StepDefinition
    {

        [When(@"I select the (.*) I want to inspect")]
        public void WhenISelectTheIWantToInspect(int item)
        {
            SD_Website.SD_ProductsPage.SelectItem(item);
            Thread.Sleep(3000);
        }

        [When(@"I select the filter dropdown")]
        public void WhenISelectTheFilterDropdown()
        {
            SD_Website.SD_ProductsPage.ClickFilterLink();
            Thread.Sleep(3000);
        }

        [When(@"I select the ""([^""]*)""")]
        public void WhenISelectThe(string filtertype)
        {
            SD_Website.SD_ProductsPage.ClickFilterType(filtertype);
            Thread.Sleep(3000);
        }

        [When(@"I add an item to the cart")]
        public void WhenIAddAnItemToTheCart()
        {
            SD_Website.SD_ProductsPage.AddToBasket("fleece-jacket");
            Thread.Sleep(3000);
        }

        [When(@"I remove the item from the cart")]
        public void WhenIRemoveTheItemFromTheCart()
        {
            SD_Website.SD_ProductsPage.RemoveFromBasket("fleece-jacket");
        }

        [When(@"I press the basket button")]
        public void WhenIPressTheBasketButton()
        {
            SD_Website.SD_ProductsPage.ClickBasketLink();
        }

        [Then(@"I am taken to the basket page")]
        public void ThenIAmTakenToTheBasketPage()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/cart.html"));
        }


        [Then(@"the number of items in cart is (.*)")]
        public void ThenTheNumberOfItemsInCartIs(int numOfItems)
        {
            Assert.That(SD_Website.SD_ProductsPage.CartItems.Count, Is.EqualTo(numOfItems));
        }


        [Then(@"I am displayed the ""([^""]*)"" as per the filter order")]
        public void ThenIAmDisplayedTheAsPerTheFilterOrder(string firstitem)
        {
            Assert.That(SD_Website.SD_ProductsPage.FirstItemName, Does.Contain(firstitem).IgnoreCase);
        }


        [Then(@"I am taken to that ""(.*)""")]
        public void ThenIAmTakenToThat(string itempage)
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo(itempage));
        }

    }
}

using OpenQA.Selenium.Chrome;
using SD_TestAutomationFramework.lib;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_TestAutomationFramework.tests
{
    public class SD_CheckoutTests
    {
        //private SD_Website<ChromeDriver> SD_Website = new();

        //[Test]
        //public void GivenIAmOnTheCheckoutPageWithValidFields_WhenIClickTheContinueButton_ThenIShouldLandOnTheCheckoutPage()
        //{
        //    //Sign In
        //    SD_Website.SD_SignInPage.VisitSignInPage();
        //    SD_Website.SD_SignInPage.InputUserName("standard_user");
        //    SD_Website.SD_SignInPage.InputPassword("secret_sauce");
        //    SD_Website.SD_SignInPage.clickSignIn();

        //    //Click Backpack Link
        //    SD_Website.SD_ProductsPage.ClickBasketLink();

        //    //Click Checkout button
        //    SD_Website.SD_BasketPage.GoToCheckout();

        //    //Adding shipping details

        //    SD_Website.SD_CheckoutPage.ClickFirstName();
        //    SD_Website.SD_CheckoutPage.InputFirstName("Bob");
        //    SD_Website.SD_CheckoutPage.ClickLastName();
        //    SD_Website.SD_CheckoutPage.InputLastName("Marley");
        //    SD_Website.SD_CheckoutPage.ClickPostCode();
        //    SD_Website.SD_CheckoutPage.InputPostCode("JAM1 1CA");

        //    ////Click Checkout button
        //    SD_Website.SD_CheckoutPage.ClickCheckout();


        //    //Check title is backpack page title
        //    Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/checkout-step-two.html"));
        //}

        //[Test]
        //public void GivenIAmOnTheProductsPage_WhenISelectTheFilterDropdown_AndISelectTheZAFilter_ThenTheFirstItemShouldBeTshirtred()
        //{

        //    //Sign In
        //    SD_Website.SD_SignInPage.VisitSignInPage();
        //    SD_Website.SD_SignInPage.InputUserName("standard_user");
        //    SD_Website.SD_SignInPage.InputPassword("secret_sauce");
        //    SD_Website.SD_SignInPage.clickSignIn();

        //    //Click Backpack Link
        //    SD_Website.SD_ProductsPage.ClickBasketLink();

        //    //Click Checkout button
        //    SD_Website.SD_BasketPage.GoToCheckout();

        //    //Adding shipping details

        //    SD_Website.SD_CheckoutPage.ClickFirstName();
        //    SD_Website.SD_CheckoutPage.InputFirstName("Bob");


        //    ////Click Checkout button
        //    SD_Website.SD_CheckoutPage.ClickCheckout();

        //    //Check first item includes (red)
        //    Assert.That(SD_Website.SD_CheckoutPage.GetCheckoutAlert(), Does.Contain("Error"));
        //}

        //[OneTimeTearDown]
        //public void CleanUp()
        //{
        //    SD_Website.SeleniumDriver.Quit();
        //}

    }
}

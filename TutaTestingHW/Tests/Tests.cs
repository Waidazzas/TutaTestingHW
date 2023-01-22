using NUnit.Framework;

namespace TutaTestingHW
{
    public class Tests : Base
    {

        [Test]
        public void Test1SignUp()
        {
            HomePage.NavigateToPage();
            HomePage.ClickSignUp();
            HomePage.CreateUser("Jonelis395", "Jonelis");
            AssertionPage.SignUpValidation("Sign up successful.");

        }

        [Test]
        public void Test2Login()
        {
            HomePage.ClickLogin();
            HomePage.LoginUser("Jonelis395", "Jonelis");
            AssertionPage.LoginValidation("Jonelis395");
        }

        [Test]
        public void Test3AddProductToCart()
        {
            HomePage.ProductFilter("Laptops");
            HomePage.FoundProduct("MacBook air");
            ProductPage.AddProductToCart();
            AssertionPage.VerifyAddedProduct("Product added.");
        }

        [Test]
        public void Test4PlaceOrder()
        {
            ProductPage.ClickOnCart();
            CartPage.ClickPlaceOrder();
            CartPage.FillingOutOrderForm("Vaidas", "Lithuania", "Kaunas", "222222222222", "Kovas", "1994");
            AssertionPage.VerifyPurchasedProduct("Thank you for your purchase!");
        }
    }
}
using NUnit.Framework;

namespace TutaTestingHW
{
    public class Tests : Base
    {

        [Test, Order(1)]
        public void SignUp()
        {
            HomePage.NavigateToPage();
            HomePage.ClickSignUp();
            HomePage.CreateUser("Jonelis", "Jonelis");
            AssertionPage.SignUpValidation("Sign up successful.");

        }

        [Test, Order(2)]
        public void Login()
        {
            HomePage.ClickLogin();
            HomePage.LoginUser("Jonelis", "Jonelis");
            AssertionPage.LoginValidation("Jonelis");
        }

        [Test, Order(3)]
        public void AddProductToCart()
        {
            HomePage.ProductFilter("Laptops");
            HomePage.FoundProduct("MacBook air");
            ProductPage.AddProductToCart();
            AssertionPage.VerifyAddedProduct("Product added.");
        }

        [Test, Order(4)]
        public void PlaceOrder()
        {
            ProductPage.ClickOnCart();
            CartPage.ClickPlaceOrder();
            CartPage.FillingOutOrderForm("Vaidas", "Lithuania", "Kaunas", "222222222222", "Kovas", "1994");
            AssertionPage.VerifyPurchasedProduct("Thank you for your purchase!");
        }
    }
}
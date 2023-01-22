using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace TutaTestingHW
{
    public class Base
    {
        protected static IWebDriver driver;
        protected static MainPage HomePage;
        protected static AssertPage AssertionPage;
        protected static ProductsPage ProductPage;
        protected static ToOrder CartPage;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            HomePage = new MainPage();
            AssertionPage = new AssertPage();
            ProductPage = new ProductsPage();
            CartPage = new ToOrder();


        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            driver.Quit();
        }
    }
}

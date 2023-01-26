using OpenQA.Selenium;

namespace TutaTestingHW
{
    public class ProductsPage : Base
    {
        IWebElement ClickCart => driver.FindElement(By.Id("cartur"));
        public void AddProductToCart()
        {
            ExplicitWaits.WaitToDisplayed(By.LinkText("Add to cart")).Click();
        }
        
        public void ClickOnCart()
        {
            ClickCart.Click();
        }
    }
}

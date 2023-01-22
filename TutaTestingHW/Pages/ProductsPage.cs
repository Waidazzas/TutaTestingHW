using OpenQA.Selenium;

namespace TutaTestingHW
{
    public class ProductsPage : Base
    {
        IWebElement AddButton => driver.FindElement(By.LinkText("Add to cart"));
        IWebElement ClickCart => driver.FindElement(By.Id("cartur"));
        public void AddProductToCart()
        {
            ExplicitWaits.WaitByClickable(By.LinkText("Add to cart")).Click();
        }
        
        public void ClickOnCart()
        {
            ClickCart.Click();
        }
    }
}

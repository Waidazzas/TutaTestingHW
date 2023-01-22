using OpenQA.Selenium;

namespace TutaTestingHW
{
    public class ToOrder : Base
    {
        IWebElement PlaceOrderButton => driver.FindElement(By.CssSelector(".btn.btn-success"));
        IWebElement Name => driver.FindElement(By.Id("name"));
        IWebElement Country => driver.FindElement(By.Id("country"));
        IWebElement City => driver.FindElement(By.Id("city"));
        IWebElement Card => driver.FindElement(By.Id("card"));
        IWebElement Month => driver.FindElement(By.Id("month"));
        IWebElement Year => driver.FindElement(By.Id("year"));
        IWebElement Purchase => driver.FindElement(By.XPath("//button [@class='btn btn-primary' and text()='Purchase']"));
        public void ClickPlaceOrder()
        {
            PlaceOrderButton.Click();
        }

        public void FillingOutOrderForm(string name, string country, string city, string card, string month, string year)
        {
            ExplicitWaits.WaitToClickable(Purchase);
            Name.SendKeys(name);
            Country.SendKeys(country);
            City.SendKeys(city);
            Card.SendKeys(card);
            Month.SendKeys(month);
            Year.SendKeys(year);
            Purchase.Click();
        }
    }
}

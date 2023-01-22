using NUnit.Framework;
using OpenQA.Selenium;


namespace TutaTestingHW
{
    public class AssertPage : Base
    {
        IWebElement LoginName => driver.FindElement(By.Id("nameofuser"));
        IWebElement ProceededTitle => driver.FindElement(By.XPath("//h2 [text()='Thank you for your purchase!']"));
        IWebElement CloseButton => driver.FindElement(By.XPath("(//button [@class='btn btn-secondary'])[2]"));

        public void SignUpValidation(string AlertText)
        {
            ExplicitWaits.WaitToAlert();
            var SucceedSign = driver.SwitchTo().Alert();
            Assert.That(SucceedSign.Text, Is.EqualTo(AlertText));
            driver.SwitchTo().Alert().Accept();
            CloseButton.Click();

        }

        public void LoginValidation(string AlertText)
        {
            ExplicitWaits.WaitToDisplayed(By.Id("nameofuser"));
            Assert.That(LoginName.Text, Is.EqualTo($"Welcome {AlertText}"));
        }
        public void VerifyAddedProduct(string AlertText)
        {
            ExplicitWaits.WaitToAlert();
            var ProductAlert = driver.SwitchTo().Alert();
            Assert.That(ProductAlert.Text, Is.EqualTo(AlertText));
            driver.SwitchTo().Alert().Accept();
        }
        public void VerifyPurchasedProduct(string ProceedText)
        {
            ExplicitWaits.WaitToDisplayed(By.XPath("//h2 [text()='Thank you for your purchase!']"));
            Assert.That(ProceededTitle.Text, Is.EqualTo(ProceedText));
        }
    }
}


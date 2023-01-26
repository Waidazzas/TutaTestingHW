using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace TutaTestingHW
{
    public class ExplicitWaits : Base
    {
        public static IWebElement WaitToDisplayed(By name)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait.Until(ExpectedConditions.ElementIsVisible(name));
        }
        public static void WaitToClickable(IWebElement name)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(name));
        }
        public static void WaitToAlert()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.AlertIsPresent());
        }
    }
}

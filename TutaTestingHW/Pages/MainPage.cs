using OpenQA.Selenium;
using System.Collections.Generic;

namespace TutaTestingHW
{
    public class MainPage : Base
    {
        private const string PageAddress = "https://www.demoblaze.com/index.html";
        IWebElement SignUp => driver.FindElement(By.Id("signin2"));
        IWebElement Login => driver.FindElement(By.Id("login2"));
        IWebElement Username => driver.FindElement(By.Id("sign-username"));
        IWebElement LoginUsername => driver.FindElement(By.Id("loginusername"));

        IWebElement Password => driver.FindElement(By.Id("sign-password"));
        IWebElement LoginPassword => driver.FindElement(By.Id("loginpassword"));

        IWebElement RegisterButton => driver.FindElement(By.XPath("//button [@class='btn btn-primary' and text()='Sign up']"));
        IWebElement LoginButton => driver.FindElement(By.XPath("//button [@class='btn btn-primary' and text()='Log in']"));
        IReadOnlyCollection<IWebElement> ProductFilters => driver.FindElements(By.Id("itemc"));
        IReadOnlyCollection<IWebElement> ProductFinder => driver.FindElements(By.CssSelector(".card-title"));


        public void NavigateToPage()
        {
            if (driver.Url != PageAddress)
                driver.Url = PageAddress;
        }

        public void ClickSignUp()
        {
            SignUp.Click();
        }

        public void CreateUser(string username, string password)
        {
            ExplicitWaits.WaitToClickable(RegisterButton);
            Username.SendKeys(username);
            Password.SendKeys(password);
            RegisterButton.Click();
        }

        public void ClickLogin()
        {
            Login.Click();
        }

        public void LoginUser(string username, string password)
        {
            ExplicitWaits.WaitToClickable(LoginButton);
            LoginUsername.SendKeys(username);
            LoginPassword.SendKeys(password);
            LoginButton.Click();
        }
        
        public void ProductFilter(string Text)
        {
            foreach (var select in ProductFilters)
            {
                if (select.Text.Equals(Text))
                {
                    select.Click();
                    break;
                }
            }
        }

        public void FoundProduct(string Text)
        {
            ExplicitWaits.WaitByClickable(By.LinkText(Text));

            foreach (var select in ProductFinder)
            {
                if (select.Text.Equals(Text))
                {
                    select.Click();
                    break;
                }
            }
        }

    }
}

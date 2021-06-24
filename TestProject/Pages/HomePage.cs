using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Pages
{
    public class HomePage
    {
        public HomePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebDriver Driver { get; }

        public IWebElement lnkLogin => Driver.FindElement(By.LinkText("Увійти"));

        public void ClickLogin() => lnkLogin.Click();
    }
}

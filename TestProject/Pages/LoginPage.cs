using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Pages
{
    class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

       IWebElement txtEmail => Driver.FindElement(By.Id("login-email"));
       IWebElement txtPassword => Driver.FindElement(By.Id("login-password"));
       IWebElement btnLogin => Driver.FindElement(By.CssSelector("button.login-button"));
       IWebElement errorMessage => Driver.FindElement(By.CssSelector("div.js-form-errors"));
        public void Login(string email, string password)
        {
            txtEmail.SendKeys(email);
            txtPassword.SendKeys(password);
            btnLogin.Submit();
        }
        public string GetErrorMessage()
        {
            return errorMessage.Text; 
            
        }
    }
}

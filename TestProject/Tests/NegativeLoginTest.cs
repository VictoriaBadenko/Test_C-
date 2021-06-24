using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestProject.Pages;

namespace TestProject.Tests
{
    class NegativeLoginTest
    {
        IWebDriver webDriver = new ChromeDriver(@"C:\driver");

        [SetUp]
        public void Setup()
        {
            webDriver.Navigate().GoToUrl("https://prometheus.org.ua/");
            webDriver.Manage().Window.Maximize();

        }

        [Test]
        public void NegativeTest()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("vyhog@gmail.com", "zxcvbmmg");

            Thread.Sleep(3000);

            string actualMessage = loginPage.GetErrorMessage();
            string expectedMessage = "Не удалось войти в систему.";
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TearDown]
        public void TearDown() => webDriver.Quit();        
    }
}

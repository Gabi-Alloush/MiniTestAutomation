using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using MiniTestAutomation.Pages;

namespace MiniTestAutomation.Tests
{
    [TestClass]
    public class LoginTest
    {
        private IWebDriver driver = null!;
        private LoginPage loginPage = null!;

        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");

            loginPage = new LoginPage(driver);
        }

        [TestMethod]
        public void Test_ValidLogin()
        {
            loginPage.EnterUsername("Gabi");
            loginPage.EnterPassword("Alloush");
            loginPage.ClickLoginButton();

            Assert.IsTrue(loginPage.IsLoginSuccessful(), "Login failed!");
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}

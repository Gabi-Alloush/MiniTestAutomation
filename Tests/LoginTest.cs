using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MiniTestAutomation.Tests
{
    [TestClass]
    public class LoginTest
    {
        private IWebDriver driver = null!;

        [TestInitialize]
        public void Setup()
        {
            // Initialize Chrome WebDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
        }

        [TestMethod]
        public void Test_ValidLogin()
        {
            // Locate the username and password fields
            driver.FindElement(By.Name("username")).SendKeys("Gabi");
            driver.FindElement(By.Name("password")).SendKeys("Alloush");

            // Click the login button
	        driver!.FindElement(By.CssSelector("input[value='Log In']")).Click();

            // Verify login success by checking if the 'Accounts Overview' page is displayed
            bool isLoginSuccessful = driver.PageSource.Contains("Accounts Overview");
            Assert.IsTrue(isLoginSuccessful, "Login failed!");
        }

        [TestCleanup]
        public void TearDown()
        {
            // Close the browser after test execution
            driver.Quit();
        }
    }
}

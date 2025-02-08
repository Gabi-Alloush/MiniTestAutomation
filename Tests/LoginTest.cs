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
            var options = new ChromeOptions();
            options.AddArguments("--headless"); // Run Chrome in headless mode
            options.AddArguments("--no-sandbox"); // Bypass OS security model
            options.AddArguments("--disable-dev-shm-usage"); // Overcome limited resource issues
            options.AddArguments("--disable-gpu"); // Disable GPU usage
            options.AddArguments("--window-size=1920,1080"); // Set a standard screen size
            options.AddArguments("--remote-debugging-port=9222"); // Ensures unique debugging session
            options.AddArguments("--disable-blink-features=AutomationControlled"); // Helps avoid bot detection
            options.AddArguments("--disable-infobars"); // Prevents UI alerts that may block automation

            // Explicitly set ChromeDriverService to avoid "session not created" issue
            var service = ChromeDriverService.CreateDefaultService();
            service.EnableVerboseLogging = true;
            service.SuppressInitialDiagnosticInformation = true;
            service.HideCommandPromptWindow = true;

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

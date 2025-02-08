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

            // Detect OS and set the correct Chrome binary path
            if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Windows))
            {
                options.BinaryLocation = @"C:\Program Files\Google\Chrome\Application\chrome.exe"; // Windows path
            }
            else if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Linux))
            {
                options.BinaryLocation = "/usr/bin/google-chrome"; // Linux path for GitHub Actions
            }

            options.AddArguments("--headless"); // Run in headless mode for CI/CD
            options.AddArguments("--no-sandbox"); // Required for CI/CD environments
            options.AddArguments("--disable-dev-shm-usage"); // Prevents resource issues in Docker/Linux environments
            options.AddArguments("--disable-gpu"); // Disables GPU usage
            options.AddArguments("--window-size=1920,1080"); // Sets a standard viewport
            options.AddArguments("--disable-software-rasterizer"); // Avoids GPU emulation issues

            driver = new ChromeDriver(options);
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

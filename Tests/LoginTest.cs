using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniTestAutomation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MiniTestAutomation.Tests
{
    [TestClass]
    public class LoginTest
    {
        private ChromeDriver driver = null!;
        private LoginPage loginPage = null!;

        [TestInitialize]
        public void Setup()
        {
            var options = new ChromeOptions();

            // Set Chrome binary path based on OS
            if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Windows))
                options.BinaryLocation = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            else
                options.BinaryLocation = "/usr/bin/google-chrome";

            // Headless mode & performance optimizations
            options.AddArguments("--headless", "--no-sandbox", "--disable-dev-shm-usage", "--disable-gpu", "--window-size=1920,1080");

            // Initialize ChromeDriver with options
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");

            loginPage = new LoginPage(driver);
        }

        [TestMethod]
        public void Test_ValidLogin()
        {
            loginPage.EnterUsername("Gabi");
            loginPage.EnterPassword("Password");
            loginPage.ClickLoginButton();
            Assert.IsTrue(loginPage.IsLoginSuccessful(), "Login failed!");
        }

        [TestCleanup]
        public void TearDown()
        {
            driver?.Quit();
        }
    }
}

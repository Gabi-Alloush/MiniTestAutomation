using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniTestAutomation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MiniTestAutomation.Tests
{
    [TestClass]
    public class LoginTest
    {
        private RegistrationPage registrationPage = null!;
        private ChromeDriver driver = null!;
        private LoginPage loginPage = null!;

        [TestInitialize]
        public void Setup()
        {
            registrationPage = new RegistrationPage(driver);
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
            // Generate unique credentials
            string username = "TestUser_" + Guid.NewGuid().ToString("N").Substring(0, 8);
            string password = "Test@123";

            // Navigate to the registration page
            driver.FindElement(By.LinkText("Register")).Click();

            // Register the new user
            registrationPage.EnterPersonalDetails("Test", "User", "123 Test Street", "TestCity", "TestState", "12345", "1234567890", "123-45-6789");
            registrationPage.EnterAccountDetails(username, password);
            registrationPage.SubmitRegistration();

            // Log in with the newly created user
            loginPage.EnterUsername(username);
            loginPage.EnterPassword(password);
            loginPage.ClickLoginButton();

            // Verify login success
            Assert.IsTrue(loginPage.IsLoginSuccessful(), "Login failed!");
        }

        [TestCleanup]
        public void TearDown()
        {
            driver?.Quit();
        }
    }
}

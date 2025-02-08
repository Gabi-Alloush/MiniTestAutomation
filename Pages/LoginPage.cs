using OpenQA.Selenium;

namespace MiniTestAutomation.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        // Locators
        private readonly By UsernameField = By.Name("username");
        private readonly By PasswordField = By.Name("password");
        private readonly By LoginButton = By.CssSelector("input[value='Log In']");

        // Constructor
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Page Actions
        public void EnterUsername(string username) => _driver.FindElement(UsernameField).SendKeys(username);
        public void EnterPassword(string password) => _driver.FindElement(PasswordField).SendKeys(password);
        public void ClickLoginButton() => _driver.FindElement(LoginButton).Click();
        public bool IsLoginSuccessful() => _driver.PageSource.Contains("Accounts Overview");
    }
}

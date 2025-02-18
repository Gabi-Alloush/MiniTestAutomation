using OpenQA.Selenium;

namespace MiniTestAutomation.Pages
{
    public class RegistrationPage
    {
        private readonly IWebDriver _driver;

        // Locators
        private readonly By FirstNameField = By.Id("customer.firstName");
        private readonly By LastNameField = By.Id("customer.lastName");
        private readonly By AddressField = By.Id("customer.address.street");
        private readonly By CityField = By.Id("customer.address.city");
        private readonly By StateField = By.Id("customer.address.state");
        private readonly By ZipCodeField = By.Id("customer.address.zipCode");
        private readonly By PhoneNumberField = By.Id("customer.phoneNumber");
        private readonly By SsnField = By.Id("customer.ssn");
        private readonly By UsernameField = By.Id("customer.username");
        private readonly By PasswordField = By.Id("customer.password");
        private readonly By ConfirmPasswordField = By.Id("repeatedPassword");
        private readonly By RegisterButton = By.XPath("//input[@value='Register']");

        // Constructor
        public RegistrationPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Method to enter personal details
        public void EnterPersonalDetails(string firstName, string lastName, string address, string city, string state, string zip, string phone, string ssn)
        {
            _driver.FindElement(FirstNameField).SendKeys(firstName);
            _driver.FindElement(LastNameField).SendKeys(lastName);
            _driver.FindElement(AddressField).SendKeys(address);
            _driver.FindElement(CityField).SendKeys(city);
            _driver.FindElement(StateField).SendKeys(state);
            _driver.FindElement(ZipCodeField).SendKeys(zip);
            _driver.FindElement(PhoneNumberField).SendKeys(phone);
            _driver.FindElement(SsnField).SendKeys(ssn);
        }

        // Method to enter account details
        public void EnterAccountDetails(string username, string password)
        {
            _driver.FindElement(UsernameField).SendKeys(username);
            _driver.FindElement(PasswordField).SendKeys(password);
            _driver.FindElement(ConfirmPasswordField).SendKeys(password);
        }

        // Method to submit registration
        public void SubmitRegistration()
        {
            _driver.FindElement(RegisterButton).Click();
        }
    }
}


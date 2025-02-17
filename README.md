# 🏆 Mini Test Automation Project

This is a **Test Automation Project** using **C#, MSTest, and Selenium WebDriver**.  
It is designed to automate UI testing for **ParaBank**, following industry best practices.

---

## 🚀 Features
- **Automated UI Testing** using **Selenium WebDriver**
- **MSTest Framework** for structured test execution
- **Page Object Model (POM)** for maintainable test design
- **GitHub Actions CI/CD** for automated test execution
- **SonarCloud Integration** for code quality analysis
- **Headless Chrome Execution** for CI/CD efficiency
- **Test Reporting using TRX + ReportUnit**

---

## 🛠️ Technologies Used
| Technology       | Purpose |
|-----------------|---------|
| **C#**          | Main programming language |
| **MSTest**      | Unit testing framework |
| **Selenium WebDriver** | Browser automation |
| **GitHub Actions** | CI/CD for automated test execution |
| **SonarCloud**  | Static code analysis and quality checks |
| **Headless Chrome** | Runs tests without opening a browser UI |

---

## 📌 Setup Instructions

### **1️⃣ Clone the Repository**
git clone https://github.com/Gabi-Alloush/MiniTestAutomation.git
cd MiniTestAutomation

### **2️⃣ Install Dependencies**
dotnet restore

### **3️⃣ Running Tests Locally**
To execute tests locally:
dotnet test

To run tests in headless mode (useful for CI/CD), modify ChromeOptions in LoginTest.cs.

---

## 🔄 Continuous Integration (CI/CD)
✅ GitHub Actions automatically executes tests on every push & PR.  
✅ Test results are stored in the TestResults folder.  
✅ SonarCloud checks code quality & test coverage.

✅ CI/CD Pipeline Steps:
1. Pulls the latest code
2. Restores dependencies
3. Builds the project
4. Executes tests in headless mode
5. Analyzes code quality using SonarCloud

---

## 📊 SonarCloud Code Quality
SonarCloud performs static analysis to detect:  
✔ Code smells  
✔ Bugs  
✔ Security vulnerabilities  
✔ Maintainability issues

---

## 📂 Project Structure
```
MiniTestAutomation/
│── .github/workflows/        # GitHub Actions CI/CD pipelines
│── Pages/                    # Page Object Model (POM) structure
│── Tests/                    # MSTest test cases
│── README.md                 # Project documentation
│── MiniTestAutomation.csproj # .NET project file
│── .gitignore                # Git ignored files
```

---

## ✅ Recent Updates & Fixes  
✅ CI/CD Integration: Automated tests run on GitHub Actions.  
✅ SonarCloud Added: Static code analysis enabled.  
✅ Refactored LoginTest: Optimized Selenium setup & cleanup.  
🔄 Next Step: Implementing TRX + ReportUnit for Test Reports..

---

## ℹ️ Why We Chose TRX + ReportUnit Instead of Allure
Initially, we planned to use Allure for test reporting. However, we faced issues integrating Allure CLI in GitHub Actions.After analysis, we decided to use TRX (built-in MSTest reporting) with ReportUnit, which:
- Works natively with MSTest.
- Requires no extra CLI tools.
- Is easier to integrate into CI/CD pipelines.

---

## 🏆 Author
Developed by Gabi Alloush
🚀 Test Automation Engineer 🚀

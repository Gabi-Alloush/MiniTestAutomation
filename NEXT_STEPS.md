# 🚀 Next Steps & Future Enhancements

This document tracks upcoming features and improvements for the **Mini Test Automation Project**.

---

## 🔄 Upcoming Features

### ** Expand Test Coverage**
- Add **more test scenarios** for ParaBank
- Implement **negative test cases** (invalid login, edge cases)
- Create **data-driven tests** for better maintainability

### ** Enhance CI/CD Workflow**
- Improve **GitHub Actions pipelines**
- Run tests **in parallel** to reduce execution time
- Automatically **upload test reports** for visibility

### ** Security & Performance Testing**
- Integrate **JMeter** for performance/load testing
- Conduct **basic security tests** on login & transactions

---

## ✅ Completed Features
✔ **CI/CD Pipeline with GitHub Actions**  
✔ **SonarCloud Code Quality Integration**  
✔ **Page Object Model (POM) Implementation**  
✔ **Headless Chrome Execution for CI/CD**  
✔ **Refactored Login Test for Better Maintainability** 
✔ **Implement TRX + ReportUnit for Test Reporting**

---

## ℹ️ Why We Switched from Allure to TRX + ReportUnit

After facing issues with Allure integration in GitHub Actions, we decided to use TRX + ReportUnit instead.This solution is lighter, more stable, and works natively with MSTest.
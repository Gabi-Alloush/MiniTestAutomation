# 🚀 Next Steps & Future Enhancements

This document tracks upcoming features and improvements for the **Mini Test Automation Project**.

---

## 🔄 Upcoming Features

### **1️⃣ Implement TRX + ReportUnit for Test Reporting**
- Generate TRX test reports using MSTest.
- Use ReportUnit to convert TRX reports into an HTML format.
- Automate report generation and upload in GitHub Actions.

### **2️⃣ Expand Test Coverage**
- Add **more test scenarios** for ParaBank
- Implement **negative test cases** (invalid login, edge cases)
- Create **data-driven tests** for better maintainability

### **3️⃣ Enhance CI/CD Workflow**
- Improve **GitHub Actions pipelines**
- Run tests **in parallel** to reduce execution time
- Automatically **upload test reports** for visibility

### **4️⃣ Security & Performance Testing**
- Integrate **JMeter** for performance/load testing
- Conduct **basic security tests** on login & transactions

---

## ✅ Completed Features
✔ **CI/CD Pipeline with GitHub Actions**  
✔ **SonarCloud Code Quality Integration**  
✔ **Page Object Model (POM) Implementation**  
✔ **Headless Chrome Execution for CI/CD**  
✔ **Refactored Login Test for Better Maintainability**  

---

## ℹ️ Why We Switched from Allure to TRX + ReportUnit

After facing issues with Allure integration in GitHub Actions, we decided to use TRX + ReportUnit instead.This solution is lighter, more stable, and works natively with MSTest.
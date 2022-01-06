using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace SeleniumTestAutomation
{
    [TestClass]
    public class BaseDriver
    {
        protected IWebDriver ChromeDriver;
        protected ExtentTest test;
        public BaseDriver(IWebDriver driver, ExtentTest extenttest)
        {
            this.ChromeDriver = driver;
            this.test = extenttest;
        }
        public void Visible(IWebDriver ChromeDriver, int timeSeconds, By checkingElement)
        {
            WebDriverWait wait = new WebDriverWait(ChromeDriver, TimeSpan.FromSeconds(timeSeconds));
            wait.Until(ExpectedConditions.ElementIsVisible(checkingElement));
        }
        public IWebElement IsClickable(IWebDriver ChromeDriver, By checkingElement)
        {
            WebDriverWait wait = new WebDriverWait(ChromeDriver, TimeSpan.FromSeconds(3));
            return wait.Until(ExpectedConditions.ElementToBeClickable(checkingElement));
        }
        public void ClickElement(IWebDriver ChromeDriver, By locator)
        {
            IsClickable(ChromeDriver, locator).Click();
        }
        public void ClickToOpenInNewTab(IWebDriver ChromeDriver, By locator)
        {
            Actions action = new Actions(ChromeDriver);
            action.KeyDown(Keys.Control).MoveToElement(ChromeDriver.FindElement(locator)).Click().Perform();
        }
        public void HoverOverElement(IWebDriver ChromeDriver, By locator)
        {
            Actions hover = new Actions(ChromeDriver);
            hover.MoveToElement(ChromeDriver.FindElement(locator)).Perform();
        }
        public void SelectElemntFromdropdown(IWebDriver ChromeDriver, By locator, string searchKey)
        {
            (new SelectElement(ChromeDriver.FindElement(locator))).SelectByText(searchKey);
        }
        public void TextEntered(IWebDriver ChromeDriver, By locator, string searchKey) => IsClickable(ChromeDriver, locator).SendKeys(searchKey);
        public bool ConfirmTitle(IWebDriver ChromeDriver, By checkingElement, string actualTitle) => ChromeDriver.FindElement(checkingElement).Text.Equals(actualTitle);
    }
}
using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestAutomation
{
    public class InTechMagazine:BaseDriver
    {
        public InTechMagazine(IWebDriver driver, ExtentTest extenttest) : base(driver,extenttest) { }
        private By _agreeCookiesButton = By.CssSelector("input[value=Agree]");
        private By _readDigitalIssueButton = By.LinkText("Read Digital Issue");
        public void AcceptCookies()
        {
            ChromeDriver.SwitchTo().Window(ChromeDriver.WindowHandles[1]);
            ClickElement(ChromeDriver, _agreeCookiesButton);
        }
        public void DigitalIssueOption() => ClickToOpenInNewTab(ChromeDriver, _readDigitalIssueButton);
    }
}

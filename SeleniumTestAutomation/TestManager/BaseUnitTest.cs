﻿using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Configuration;

namespace SeleniumTestAutomation
{
    public class BaseUnitTest
    {
        public IWebDriver ChromeDriver;
        public static string browser = ConfigurationManager.AppSettings["BrowserName"];
        public static ExtentReports rep;
        [AssemblyInitialize]
        public static ExtentReports ExtentReportInitialize(TestContext testContext)
        {
            rep = ExtentManager.GetInstance();
            return rep;
        }
        public ExtentTest test;
        [TestInitialize]
        public void InitializeTest()
        { 
            switch (browser)
            {
                case "Chrome":
                    ChromeDriver = new ChromeDriver();
                    break;
                case "IE":
                    ChromeDriver = new InternetExplorerDriver();
                    break;
                case "Firefox":
                    ChromeDriver = new FirefoxDriver();
                    break;
            }
            AutomationHomePage automationHomePage = new AutomationHomePage(ChromeDriver,test);
            automationHomePage.OpenURL();
            automationHomePage.AcceptCookies();
        }
        [TestCleanup]
        public void EndTest()
        {
            rep.Flush();
            ChromeDriver.Quit();
        }
    }
}

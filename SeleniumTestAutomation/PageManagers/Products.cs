using AventStack.ExtentReports;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumTestAutomation
{
    public class Products:BaseDriver
    {
        public Products(IWebDriver driver, ExtentTest extenttest) : base(driver, extenttest) { }
        
        private By _productsTab = By.LinkText("Products");
        private By _headingofProductsTab = By.ClassName("mastHead-heading");
        private string _expectedHeadingofProductsTab = "Automation & Control Products - Search & Browse";
        private By _searchTextBox = By.CssSelector("textarea[rows='1']");
        private By _searchButton = By.CssSelector("input[type='button']");
        private By _searchResultsList = By.ClassName("sj-rs-item");

        public void ClickProducts()
        {
            ClickElement(ChromeDriver, _productsTab);
            test.Log(Status.Pass, "Products option is clicked successfully.");
        }

        public bool ConfirmTitleofProductsTab()
        {
            test.Log(Status.Info, "Check if Heading matches with actual heading of Products Tab");
            return ConfirmTitle(ChromeDriver, _headingofProductsTab, _expectedHeadingofProductsTab);
        }

        public void EnterTextToSearch(string searchKey)
        {
            TextEntered(ChromeDriver, _searchTextBox, searchKey);
            test.Log(Status.Pass, "Text entered successfully.");
        }

        public void HitSearchButton()
        {
            ClickElement(ChromeDriver, _searchButton);
            test.Log(Status.Pass, "Search Button is clicked successfully.");
        }

        public bool CheckIfSearchResultsHaveSearchKey(string searchKey)
        {
            test.Log(Status.Info, "Check if  search results have search key");
            test.Log(Status.Info, "Waiting for some time to load search results");
            Visible(ChromeDriver, 9, _searchResultsList);
            test.Log(Status.Info, "Storing search results in a list.");
            IList<IWebElement> searchResults = ChromeDriver.FindElements(_searchResultsList);
                test.Log(Status.Info, "Iterating through search results list to match with search key.");
                for (int i = 0; i < searchResults.Count; i++)
                {
                    searchResults.ElementAt(i).Text.Contains(searchKey);
                }
                test.Log(Status.Pass, "Search Results matched with Search Key successfully.");
                return true;
        }
    }
}

using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTestAutomation
{
    [TestClass]
    public class UnitTest2:BaseUnitTest
    {
        public TestContext testContext;
        public ExtentReports getrep;
        /// <summary>
        /// Test US Profinet page.
        /// </summary>
        [TestMethod]
        public void TestUSprofinet()
        {
            getrep = ExtentReportInitialize(testContext);
            test = getrep.CreateTest("Test US Profinet page.");
            USprofinetPage usProfinet = new USprofinetPage(ChromeDriver,test);
            usProfinet.ClickUSprofinetIcon();
            usProfinet.WhitepapersResources();
            Assert.IsTrue(usProfinet.ConfirmTitleofPage());
            test.Log(Status.Pass, "Heading matches with selected option");
            usProfinet.GetTextFromCategories("PROFIBUS");
            Assert.IsTrue(usProfinet.CheckIfTitleChanges("PROFIBUS"));
            test.Log(Status.Pass, "Title matches with search category");
        }
        /// <summary>
        /// Test multiple pages from Yahoo page.
        /// </summary>
        [TestMethod]
        public void MultiplePagesTest()
        {
            getrep = ExtentReportInitialize(testContext);
            test = getrep.CreateTest("Test multiple pages from Yahoo page.");
            new YahooPage(ChromeDriver,test).OpenYahooPage();
            Assert.IsTrue(new YahooPage(ChromeDriver, test).IsYahooPageOpened());
            test.Log(Status.Pass, "Yahoo Page is opened successfully.");
            new CricketPage(ChromeDriver, test).OpenCricketPage();
            new CricketPage(ChromeDriver, test).ClickOnLink();
            new CricketArchivesPage(ChromeDriver, test).OpenCricketArchivesPage();
            new ZimbabweTourOfIrelandPage(ChromeDriver, test).OpenzimbabweTourOfIrelandPage();
            new IrelandVsZimbabweScoresPage(ChromeDriver, test).OpenIrelandVsZimbabweScoresPage();
            new CricketTeamsPage(ChromeDriver, test).OpenCricketTeamsPage();
            new TeamIndiaResultsPage(ChromeDriver, test).OpenTeamIndiaResultsPage();
            Assert.IsTrue(new TeamIndiaResultsPage(ChromeDriver, test).IsTeamIndiaResultsPageOpened());
            test.Log(Status.Pass, "India tab is clicked and Team India Results Page is opened successfully.");
        }
    }
}

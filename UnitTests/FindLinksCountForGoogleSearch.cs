using System;
using System.Threading;
using Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RelevantCodes.ExtentReports;

namespace UnitTests
{
    [TestClass]
    public class FindLinksCountForGoogleSearch: TestBase
    {
        [TestMethod]
        public void GoogleSearch()
        {
            extentTest = extentReport.StartTest("FindLinksCountForGoogleSearch");
            extentTest.Log(LogStatus.Pass, "Google Page has been launched");
            Pages.Google.EnterText(Config.SearchText);
            extentTest.Log(LogStatus.Pass, "Entered text for search");
            Thread.Sleep(3000);

            if (Pages.SearchResults.FindLinksCount(Config.SearchText) > 0)
               extentTest.Log(LogStatus.Pass, "Search result count is greater than 0");
            else
                extentTest.Log(LogStatus.Fail, "No results found");
            Console.WriteLine(Environment.CurrentDirectory.ToString());
            Console.WriteLine("Count of links = " + Pages.SearchResults.FindLinksCount(Config.SearchText));
            Assert.IsTrue(Pages.SearchResults.FindLinksCount(Config.SearchText) > 0, Config.NoResultsMessage);
        }
    }
}

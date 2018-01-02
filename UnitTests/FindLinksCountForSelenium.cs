using System;
using System.Threading;
using Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class FindLinksCountForSelenium: TestBase
    {
        [TestMethod]
        public void RunTestGoogleSearch()
        {
            Pages.Google.EnterText(Config.SearchText);
            Thread.Sleep(3000);
            Assert.IsTrue(Pages.SearchResults.FindLinksCount(Config.SearchText) > 0, Config.NoResultsMessage);
        }
    }
}

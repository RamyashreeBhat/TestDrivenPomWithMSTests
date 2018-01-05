using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;
using RelevantCodes.ExtentReports;
using System.IO;
using System.Reflection;

namespace UnitTests
{
    public class TestBase
    {
        protected ExtentReports extentReport = new ExtentReports(@"D:\VisualStudioRepository\TestDrivenPom_MSTest\Report\Results.html", false);
        protected ExtentTest extentTest;
        [TestInitialize]
        public void Initialize() {
            extentReport.AddSystemInfo("User Name", "Ramyashree Bhat");
            Browser.Initialize();
                    }

        [TestCleanup]
        public void CleanUp()
        {
          Browser.Close();
          extentReport.EndTest(extentTest);
          extentReport.Flush();
        }

    }

  
}

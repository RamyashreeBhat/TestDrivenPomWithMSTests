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
        static string executablePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        static string requiredPath = executablePath.Substring(0, executablePath.LastIndexOf("UnitTests"));
        protected ExtentReports extentReport = new ExtentReports(requiredPath + @"TestResults\Results.html", false);
        protected ExtentTest extentTest;

        [ClassInitialize]
        public void Init() {
            Directory.CreateDirectory(requiredPath + @"TestResults");
        }

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

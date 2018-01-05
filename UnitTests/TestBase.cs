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
        static string requiredPath = executablePath.Substring(0, executablePath.LastIndexOf("Debug"));
        protected ExtentReports extentReport = new ExtentReports(requiredPath + @"Release\Results.html", false);
        protected ExtentTest extentTest;

        [TestInitialize]
        public void Initialize() {
            extentReport.AddSystemInfo("User Name", "Ramyashree Bhat");
            Console.WriteLine(requiredPath);
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

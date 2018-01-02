using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Framework
{
    public static class Browser
    {
        private static IWebDriver _webDriver;
        private static string _baseUrl = "https://www.google.co.in/";

        public static IWebDriver Driver { get { return _webDriver; } }

        internal static bool WaitUntilElementIsDisplayed(By element, int timeout)
        {
            for (int i = 0; i < timeout; i++)
            {

                if (ElementIsDisplayed(element))
                {
                    return true;
                }
                Thread.Sleep(1000);
            }
            return false;
        }

        public static IWebElement FindPageElement(By by)
        {
            return _webDriver.FindElement(by);
        }

        public static ReadOnlyCollection<IWebElement> FindPageElements(By by)
        {
            return _webDriver.FindElements(by);
        }
        public static bool ElementIsDisplayed(By element)
        {

            bool present = false;
            //_webDriver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(10));//

            try
            {
                present = _webDriver.FindElement(element).Displayed;
            }
            catch (NoSuchElementException)
            {
            }
            // _webDriver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(10));
            return present;
        }

        public static string Title { get { return _webDriver.Title; } }

        public static void Initialize()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl(_baseUrl);
        }

        public static void Close()
        {
            _webDriver.Close();//close current tab
            _webDriver.Quit();//close all tabs
        }

        
        public static void SwitchTabs(int tabIndex)
        {
            var windows = _webDriver.WindowHandles;
            _webDriver.SwitchTo().Window(windows[tabIndex]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Framework
{
    public class GooglePage
    {
        public void EnterText(string inputText) {
            var googleSearchBox = Browser.FindPageElement(By.Id("lst-ib"));
            googleSearchBox.SendKeys(inputText);
            googleSearchBox.SendKeys(Keys.Enter);
        }
    }
}

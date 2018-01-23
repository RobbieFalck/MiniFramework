using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UnitTestProject1.Framework
{
    public class Actions
    {
        public void NavigateToUrl(IWebDriver browser, string url)
        {
            browser.Navigate().GoToUrl(url);
        }

        public void Click(IWebElement element)
        {
            element.Click();
        }

        public void SwitchWindowToLast(IWebDriver browser)
        {
            browser.SwitchTo().Window(browser.WindowHandles.Last());
        }

        public void TypeText(IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public void Wait(int wait)
        {
            Thread.Sleep(wait);
        }

        public void ScrollDown(IWebDriver browser)
        {
            ((IJavaScriptExecutor)browser).ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }
    }
}

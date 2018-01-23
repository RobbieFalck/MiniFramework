using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace UnitTestProject1.Framework
{
    public class BasePage
    {
        public static IWebDriver _driver;

        [TestInitialize]
        public void SetupApplication()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDownApplication()
        {
            _driver.Quit();
        }
    }
}

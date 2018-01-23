using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UnitTestProject1.Framework;

namespace UnitTestProject1.Utils
{
    public class NavigateHelper : BasePage
    {
        Actions Actions => new Actions();

        public NavigateHelper(IWebDriver driver)
        {
            Driver = driver;
        }

        public void NavigateToHippdoromeOnline(string url)
        {
            Actions.NavigateToUrl(Driver, url);
        }

        private IWebDriver Driver { get; }
    }
}

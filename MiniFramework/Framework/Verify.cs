using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UnitTestProject1.Framework
{
    public class Verify
    {
        public bool ElementContainsText(IWebElement element, string text)
        {
            return element.Text.Contains(text);
        }
    }
}

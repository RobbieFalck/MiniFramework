using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UnitTestProject1.Framework;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTestProject1.PageObject.ForgotPassword
{
    partial class ForgotPassword : BasePage
    {
        public ForgotPassword(IWebDriver driver)
        {
            Driver = driver;
        }

        [FindsBy(How = How.ClassName, Using = "header-signInCta")]
        public IWebElement SignInButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "modal-forgotPasswordLink")]
        public IWebElement ForgotPasswordLink { get; set; }

        [FindsBy(How = How.Id, Using = "ForgotLoginRequestForm")]
        public IWebElement ForgotPasswordForm { get; set; }

        public static string ForgotPasswordFormText = "Forgotten your login details?";

        private IWebDriver Driver { get; }

        Actions Actions => new Actions();

        Verify Verify => new Verify();
    }
}

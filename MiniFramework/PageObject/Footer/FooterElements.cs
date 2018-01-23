using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using UnitTestProject1.Framework;

namespace UnitTestProject1.PageObject.Footer
{
    partial class Footer : BasePage
    {
        public Footer(IWebDriver driver)
        {
            Driver = driver;
        }

        [FindsBy(How = How.ClassName, Using = "header-signInCta")]
        public IWebElement SignInButton { get; set; }

        [FindsBy(How = How.Id, Using = "LoginUsername")]
        public IWebElement LoginUsername { get; set; }

        [FindsBy(How = How.Id, Using = "LoginPassword")]
        public IWebElement LoginPassword { get; set; }

        [FindsBy(How = How.ClassName, Using = "modal-button_login")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.LinkText, Using = "Cancel")]
        public IWebElement ModalCancelButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "footerSection-column")]
        public IList<IWebElement> FooterPages { get; set; }

        [FindsBy(How = How.ClassName, Using = "footerSection-textLink")]
        public IList<IWebElement> FooterPagesLinks { get; set; }

        public static string LoginNameText = "RT_HippoPounds";

        public static string LoginPasswordText = "ASDF1234";

        public static string BlackjackPage = "Blackjack";

        private IWebDriver Driver { get; }

        Actions Actions => new Actions();

        Verify Verify => new Verify();
    }
}

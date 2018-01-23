using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using UnitTestProject1.Framework;
using UnitTestProject1.Utils;

namespace UnitTestProject1.Tests.ForgotPassword
{
    [Binding]
    [Parallelizable]
    [Scope(Feature = "Footer")]
    public class FooterSteps : HippodromeBasePage
    {
        [Given(@"I navigate to HippodromeOnline")]
        public void GivenINavigateToHippodromeOnline()
        {
            Navigate.NavigateToHippdoromeOnline(Urls.HippodromeOnline);
        }

        [When(@"I login")]
        public void WhenILogin()
        {
            Footer.Login();
        }

        [When(@"I close modal pop up")]
        public void WhenICloseModalPopUp()
        {
            Footer.CloseModal();
        }

        [When(@"I scroll down to the footer links")]
        public void WhenIScrollDownToTheFooterLinks()
        {
            Footer.ScrollDown();
        }

        [Then(@"I should be able to view the blackjack link")]
        public void ThenIShouldBeAbleToViewTheBlackjackLink()
        {
            Footer.AssertBlackjackPresent();
        }

    }
}

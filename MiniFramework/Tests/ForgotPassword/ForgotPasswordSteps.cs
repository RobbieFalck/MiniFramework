using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using UnitTestProject1.Framework;
using UnitTestProject1.Utils;

namespace UnitTestProject1.Tests.ForgotPassword
{
    [Binding]
    [Parallelizable]
    [Scope(Feature = "ForgotPassword")]
    public class ForgotPasswordSteps : HippodromeBasePage
    {
        [Given(@"I navigate to HippodromeOnline")]
        public void GivenINavigateToHippodromeOnline()
        {
            Navigate.NavigateToHippdoromeOnline(Urls.HippodromeOnline);
        }
        
        [When(@"I click on the forgot password link")]
        public void WhenIClickOnTheForgotPasswordLink()
        {
            ForgotPassword.ClickForgotPassword();
        }
        
        [Then(@"I should be taken to the forgot password page")]
        public void ThenIShouldBeTakenToTheForgotPasswordPage()
        {
            ForgotPassword.AssertForgotPassword();
        }
    }
}

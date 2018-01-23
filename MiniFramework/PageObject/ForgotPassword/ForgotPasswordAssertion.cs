using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.PageObject.ForgotPassword
{
    partial class ForgotPassword
    {
        public void AssertForgotPassword()
        {
            Actions.SwitchWindowToLast(Driver);
            Verify.ElementContainsText(ForgotPasswordForm, ForgotPasswordFormText);
        }
    }
}

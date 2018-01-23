using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.PageObject.Footer;
using UnitTestProject1.PageObject.ForgotPassword;
using UnitTestProject1.Utils;

namespace UnitTestProject1.Framework
{
    public class HippodromeBasePage : BasePage
    {
        internal ForgotPassword ForgotPassword => new ForgotPassword(_driver);

        internal Footer Footer => new Footer(_driver);

        internal Urls Urls => new Urls();

        internal NavigateHelper Navigate => new NavigateHelper(_driver);
    }
}

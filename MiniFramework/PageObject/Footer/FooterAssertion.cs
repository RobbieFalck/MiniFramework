using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace UnitTestProject1.PageObject.Footer
{
    partial class Footer
    {
        public void AssertBlackjackPresent()
        {
            var displayed = false;

            foreach (var page in FooterPagesLinks)
            {
                if (page.Text == BlackjackPage)
                {
                    displayed = true;
                    break;
                }
            }

            displayed.Should().BeTrue();
        }
    }
}

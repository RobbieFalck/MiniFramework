using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.PageObject.Footer
{
    partial class Footer
    {
        public void Login()
        {
            Actions.Click(SignInButton);
            Actions.TypeText(LoginUsername, LoginNameText);
            Actions.TypeText(LoginPassword, LoginPasswordText);
            Actions.Click(SignInButton);
            Actions.Wait(1000);
        }

        public void CloseModal()
        {
            Actions.Click(ModalCancelButton);
        }

        public void ScrollDown()
        {
            Actions.ScrollDown(Driver);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPTask
{
    class DependencyInjectionTask
    {
    }

    public class PageObjects
    {
        private ButtonLogin buttonLogin;
        private ResetPassword resetPassword;

        public PageObjects(ButtonLogin buttonLogin)
        {
            this.buttonLogin = buttonLogin; 
        }

        public PageObjects(ResetPassword resetPassword)
        {
            this.resetPassword = resetPassword;
        }

        public void Login()
        {
            Console.WriteLine("User logged in");
        }

        public void ResetPassword()
        {
            Console.WriteLine("Please follow this steps to reset your passwords...");
        }
    }

    public class ButtonLogin
    {

    }

    public class ResetPassword
    {

    }
}

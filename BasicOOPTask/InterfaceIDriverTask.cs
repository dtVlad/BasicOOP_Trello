using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPTask
{
    class InterfaceIDriverTask
    {
    }

    interface IDriver
    {
        public void ClickOnButton();
        public void GetTextOfElement();
    }
    public abstract class Driver : IDriver
    {

        protected abstract void FindElement();
        internal abstract void clickOnElement(string button);

        public abstract void ClickOnButton();
        public abstract void GetTextOfElement();



        public string Text = "This is a text";
        public string Link;
        public string Button;
    }

    public class GetText : Driver
    {
        string locator;
         protected override void FindElement()
        {
        }

        public void FindElement(string locator)
        {
            if (true)
            {
                Console.WriteLine($"The text of element: {locator}");
            }
        }

        public override void GetTextOfElement()
        {

        }

        public void GetTextOfElement(string value)
        {
            FindElement(locator = value);
        }

        internal override void clickOnElement(string button)
        {

        }

        public override void ClickOnButton()
        {

        }
    }

    public class ClickOn : Driver
    {
        public string button;
        public string Link = "This is a link";
        public string Button = "This is a button";
        internal override void clickOnElement(string button)
        {
            if(button == Button)
            {
                Console.WriteLine("You have clicked on a button");
            }
            else
            {
                Console.WriteLine("You have clicked on a link");
            }
        }

        public override void ClickOnButton()
        {
        }

        public void ClickOnButton(string value)
        {
            clickOnElement(button=value);
        }

        public override void GetTextOfElement()
        {

        }

        protected override void FindElement()
        {

        }
    }
}

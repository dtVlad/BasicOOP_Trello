using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPTask
{
    public class InheritanceTask1
    {
        //Person
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintName()
        {
            Console.WriteLine($"My name is {FirstName} {LastName}");
        }


    }
}

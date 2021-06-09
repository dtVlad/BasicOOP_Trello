using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPTask
{
    class Encapsulation
    {
        private int age;
        private string name;
        public int  Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public  void Intro()
        {
            Console.WriteLine("{0}, {1} years old", Name, Age);
        }
    }
}

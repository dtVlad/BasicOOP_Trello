using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPTask
{
    class AbstractClassTask
    {
    }

    public abstract class Person
    {
        public string FullName;
        public void Greetings()
        {
            Console.WriteLine("Hello! Nice to meet you!");
        }

        public abstract void MyNameIs();
            

    }

    public class Student : Person
    {
        
        public override void MyNameIs()
        {
            Console.WriteLine($"My name is {FullName}");
        }
    }
}

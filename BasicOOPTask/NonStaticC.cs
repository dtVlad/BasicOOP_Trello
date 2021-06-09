using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPTask
{
    public class NonStaticC
    {
        public string Name;
        public int Age;
        public string Occupation;
        public double Height;

        public void Introduce()
        {
            Console.WriteLine("\nNew user: {0} \n{1} years old\nJob Position: {2}\n{3} cm tall", Name, Age, Occupation, Height);
        }
    }
}

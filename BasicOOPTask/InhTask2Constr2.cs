using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPTask
{
    public class InhTask2Constr2 : InhTask2Constr1
    {

        public InhTask2Constr2(string name, int age) : base (name, age)
        
        {

        }

        public void WhoIsHe()
        {
            Console.WriteLine($"My name is {name}, {age}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPTask
{
    public class InhTask2Constr1
    {
        public string name { get; set; }
        public int age { get; set; }

        public InhTask2Constr1(string fullName, int years)
        {
            name = fullName;
            age = years;
        }
    }
}

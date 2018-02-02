using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Constant
    {
        public const string Name = "Manish";
    }

    public abstract class Method
    {
       public abstract int AddNumber(int a, int b);
    }

    public class Clause : Method
    {
        public override int AddNumber(int a, int b)
        {
            return a + b;
        }
    }
}


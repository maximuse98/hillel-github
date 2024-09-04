using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class SimpleClass
    {
        public static int Multiple(int num1, int num2)
        {
            if (num2 == 1)
            {
                return num1;
            }
            return num1 + Multiple(num1, num2 - 1);
        }
    }
}

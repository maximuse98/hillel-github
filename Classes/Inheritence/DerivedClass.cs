using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Inheritence
{
    public class DerivedClass
    {
        private BaseClass _base;

        public DerivedClass(BaseClass @base)
        {
            _base = @base;
        }

        public void BaseMethod()
        {
            _base.BaseMethod();
        }

        public void DerivedMethod()
        {
            Console.WriteLine("DerivedClass.DerivedMethod");
        }
    }
}

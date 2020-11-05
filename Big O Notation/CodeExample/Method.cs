using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CodeExample
{
    class Method
    {
        int[] SomeArray;

        SetArray Array = new SetArray();
        Constant constant;
        Linear linear;
        Quadratic quad;
        Util util = new Util();
        public Method()
        {
            SomeArray = Array.setArray();
            constant = new Constant(SomeArray);
            util.Continue();
            linear = new Linear(SomeArray);
            util.Continue();
            quad = new Quadratic(SomeArray);
            ReadKey(true);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExample
{
    class Constant
    {
        public Constant(int[] someArray) => Console.WriteLine(someArray[20]);//Because the method is only calling for one input in the list. The time needed to execute this code will always be the same.
    }
}

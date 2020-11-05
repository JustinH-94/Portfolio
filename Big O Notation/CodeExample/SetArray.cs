using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExample
{
    class SetArray
    {
        int size = 100;
        int[] ExampleArr;
        public int[] setArray()
        {
            ExampleArr = new int[size + 1];
            for (int i = 1; i < ExampleArr.Length; i++)
                ExampleArr[i] = i;
            return ExampleArr;
        }
    }
}

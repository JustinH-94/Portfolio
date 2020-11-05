using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExample
{
    class Linear
    {
        public Linear(int[] somearray)//This method calls for every element in the array. As the compiler runs through the array, time passes until every element in the array is displayed. 
        {                             //Meaning time needed to run through the array remains consistent.
            for (int i = 1; i < somearray.Length; i++)
                Console.WriteLine(somearray[i]);
        }
    }
}

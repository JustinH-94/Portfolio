using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExample
{
    class Quadratic
    {
        public Quadratic(int[] somearray)//This method calls for every element in the array twice. Every element in the second foreach loop will be displayed as the first foreach loop will remain on its first.
        {                                //This will repeat itself until every element in the first foreach loop is displayed. This quadratic because despite having the same array size. The time needed to finish this code will greatly pass.
            foreach (int i in somearray)
            {
                foreach (int s in somearray)
                    Console.WriteLine($"{i}, {s}");
            }
        }
    }
}

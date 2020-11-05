using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace FisherYatesShuffleDemo
{
    class Util
    {
        public void ClearPage()
        {
            WriteLine("Press Any Key To Continue");
            ReadKey(true);
            Clear();
        }
    }
}

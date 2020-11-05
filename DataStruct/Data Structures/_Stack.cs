using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;
using System.Collections;
namespace Data_Structures
{
    class _Stack
    {
        //Stack is a Last In First Out (LiFo). Meaning the last item pushed into the stack is the first element. Stacks have a keyword attached called Pop()
        //that removes the top element in the stack, but the element can't be specified. It always has to be the top element.
        public string setStackName(Stack stack)
        {
            return getStackVal(stack);
        }

        string getStackVal(Stack stack)
        {
            foreach (string s in stack)
            {
                if (s == "Dorothea")
                    return s;
            }
            return String.Empty;
        }
    }
}

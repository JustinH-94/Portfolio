using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    class Array
    {

        //The Array is able to search throughout the entire data structure until it's able to find the value that it's searching for. But since it's a fixed size, you cannot adjust the size of the array
        public string setArrayName(string [] names)
        {
            return SearchName(names);
        }

        string SearchName(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "Zelda")
                    return names[i];
            }
            return String.Empty;
        }
    }
}

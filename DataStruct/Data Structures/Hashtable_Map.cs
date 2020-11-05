using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    class Hashtable_Map
    {
        int key;

        //The hashtable requires a key to be matched with an object value. Because of this, the data structure can immediately go to the key in the hashtable and obtain the value in it.
        //This works especially well with Employee IDs or product IDs. 
        //Unlike arrays, Hashtables are able to remove objects and not have an errors when the size decreases.
        public string setHashName(Hashtable nameHash, string nameFound)
        {
            key = getKey(nameHash, nameFound);
            return (string)nameHash[key];//4923 is the position in which the name "Zelda is stored inside the HashTable, so Key is 4923
        }

        int getKey(Hashtable nameHash, string nameFound)
        {
            for (int i = 0; i < nameHash.Count; i++)
                if ((string)nameHash[i] == nameFound)
                    return i;
            return 0;
        }
    }
}

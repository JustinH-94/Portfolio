using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;
using System.Collections;
using System.Linq;
using System.Globalization;
using System.Diagnostics;

namespace Data_Structures
{
    class DisplayDataStructures
    {
        Array array = new Array();
        Hashtable_Map HP = new Hashtable_Map();
        static string NameFile = "Names.txt";
        Stack stack;
        _Stack _stack = new _Stack();
        Queue q;
        _Queue _q = new _Queue();
        DisplayText text = new DisplayText();
        static Hashtable nameHash;
        string nameFound;
        string[] names;
        public DisplayDataStructures()
        {
            stack = new Stack();
            nameHash = new Hashtable();
            q = new Queue();
            LoadNames();
            Array_VS_Map();
            Stack_Vs_Queue();
            ReadKey(true);
        }

         public void LoadNames()
        {
            names = File.ReadAllLines(NameFile);
            setDataStructures(names);
            
        }

        void setDataStructures(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                nameHash.Add(i, names[i]);
                stack.Push(names[i]);
                q.Enqueue(names[i]);
            }
        }

        void Array_VS_Map()
        {           
            nameFound = array.setArrayName(names);
            text.DisplayName($"Found {nameFound}");
            text.DisplayStartPos($"The starting position in the array is {names[0]}\n");

            nameFound = HP.setHashName(nameHash, nameFound); //4923 is the position in which the name "Zelda is stored inside the HashTable
            text.DisplayName($"Found {nameFound}");
            text.DisplayStartPos($"The starting position in the hashtable is {(string)nameHash[0]}\n\n");

            //The different between an array and a hashtable/map is that array have a fixed size, while hashtables/maps are able to remove and adjust its size while also having a key attached to the value.
            //So when a system is using something like Order#s or Employee IDs, values that have a Key attached, then Hashtables would be more appropriate. However, when a system is just using something like
            //a simple list of names, then an array is more appropriate.
        }

        void Stack_Vs_Queue()
        {  
            nameFound = _stack.setStackName(stack);
            text.DisplayName($"Found {nameFound}");
            text.DisplayStartPos($"The starting position in the stack is {stack.Pop()} and it's now removed.\n");
    
            nameFound = _q.setQueueName(q);
            text.DisplayName($"Found {nameFound}");
            text.DisplayStartPos($"The starting position in the queue is {q.Dequeue()} and it's now at the top of the Queue\n\n");

            //Both data structures are able to removes items. though stack can only remove the top element, so they can have adjustable sizes. The only difference between the two is the order in which the
            //elements are inserted.
            //Stacks and Queues are equally as efficient as the other. It really all depends on what order you want the data structure to be.
        }
    }
}

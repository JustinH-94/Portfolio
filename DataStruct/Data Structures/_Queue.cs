using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    class _Queue
    {
        //Queue is a First In First Out(FiFo). Meaning that the first item in the queue, will the be the first element. Queue has a keyword called Dequeue()
        //that takes the first element in the queue, and moves it to the end/or top of the Queue making it the last element. 
        public string setQueueName(Queue q)
        {
            return getQueueName(q);
        }
        string getQueueName(Queue q)
        {
            foreach (string _q in q)
            {
                if (_q == "Dorothea")
                    return _q;
            }
            return String.Empty;
        }
    }
}

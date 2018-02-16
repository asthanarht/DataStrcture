using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interview.Classes;

namespace Interview.DataStructure
{
    public class Queue<T>
    {
        GenericNode<T> Front;
        GenericNode<T> Rear;

        public int size = 10;
        public int count = 0;

        public Queue()
        {
            Front = null;
            Rear = null;
        }

        public void Enqueue(T data)
        {
            if (count == size)
                throw new Exception("Queue Full");

            GenericNode<T> node = new GenericNode<T>(data);

            if (Rear != null)
            {
                Rear.next = node;
            }
            else
            {
                Front = node;
            }

            count += 1;
            Rear = node;
        }

        public GenericNode<T> Dequeue()
        {
            if(Front == null)
                throw new Exception("Queue Empty");

            GenericNode<T> node = Front;

            Front = Front.next;

            node.next = null;

            count -= 1;
            return node;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interview.Classes;

namespace Interview.DataStructure
{
    public class Stack<T>
    {
        GenericNode<T> header;

        public int count { get; set; }

        public Stack()
        {
            header = null;
        }

        public void Push(T data)
        {
            GenericNode<T> node = new GenericNode<T>(data);
            if (header != null)
            {
                node.next = header;
            }

            header = node;

            count += 1;
        }

        public GenericNode<T> Pop()
        {
            GenericNode<T> node = header;
            header = header.next;

            node.next = null;
            count -= 1;

            return node;
        }
    }
}

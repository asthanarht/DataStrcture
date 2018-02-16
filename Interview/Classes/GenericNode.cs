using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.Classes
{
    public class GenericNode<T>
    {
        public T data;
        public GenericNode<T> next;

        public GenericNode()
        {
            next = null;
        }

        public GenericNode(T value)
        {
            data = value;
            next = null;
        }
    }
}

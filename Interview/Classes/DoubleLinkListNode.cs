using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.Classes
{
    class DoubleLinkListNode
    {
        public int data;
        public DoubleLinkListNode previous;
        public DoubleLinkListNode next;

        public DoubleLinkListNode()
        {
            previous = null;
            next = null;
        }

        public DoubleLinkListNode(int value)
        {
            data = value;
            previous = null;
            next = null;
        }
    }
}

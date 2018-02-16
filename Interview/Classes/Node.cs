using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.Classes
{
    class Node
    {
        public int data;
        public Node link;

        public Node()
        {
            link = null;
        }

        public Node(int value)
        {
            data = value;
            link = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interview.Classes;

namespace Interview.DataStructure
{
    class DoubleLinkList
    {
        DoubleLinkListNode header = null;

        public DoubleLinkList()
        {
            header = new DoubleLinkListNode();
        }

        public DoubleLinkListNode Find(int value)
        {
            DoubleLinkListNode current = header;

            while (current != null)
            {
                if (current.data == value)
                {
                    break;
                }
                else
                {
                    current = current.next;
                }
            }

            return current;
        }

        public int Length()
        {
            int counter = 0;
            while (header.next != null)
            {
                counter += 1;
            }

            return counter;
        }

        public void InsertNodeAtBegining(int value)
        {
            DoubleLinkListNode node = new DoubleLinkListNode(value);

            if (header.next != null)
            {
                node.next = header.next;
                header.next.previous = node;
            }

            header = node;
        }

        public void InsertNodeAtEnd(int value)
        {
            DoubleLinkListNode node = new DoubleLinkListNode(value);
            DoubleLinkListNode current = header;

            while(current.next != null)
            {
                current = current.next;
            }

            node.previous = current;
            current.next = node;
        }

        public void InsertNodeAfter(int value, int after)
        {
            DoubleLinkListNode current = Find(after);

            if (current != null)
            {
                DoubleLinkListNode node = new DoubleLinkListNode(value);
                
                if(current.next != null)
                {
                    node.next = current.next;
                    current.next.previous = node;
                }

                node.previous = current;
                current.next = node;
            }
        }

        public void InsertNodeBefore(int value, int before)
        {
            DoubleLinkListNode current = Find(before);

            if (current != null)
            {
                DoubleLinkListNode node = new DoubleLinkListNode(value);
                node.next = current;
                node.previous = current.previous;
                current.previous.next = node;
                current.previous = node;
            }
        }

        public void DeleteNode(int value)
        {
            DoubleLinkListNode current = Find(value);
            
            if (current != null)
            {
                current.previous.next = current.next;

                if (current.next != null)
                {
                    current.next.previous = current.previous;
                }

                current = null;
            }
        }

        public void Traverse()
        {
            Console.WriteLine("######### Traverse Linklist #########");
            DoubleLinkListNode current = header;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void TraverseBackward()
        {
            Console.WriteLine("######### Traverse Backward #########");
            DoubleLinkListNode current = header;
            while (current.next != null)
            {
                current = current.next;
            }

            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.previous;
            }
        }

        public void IsListCircular()
        {
            DoubleLinkListNode fast = header;
            DoubleLinkListNode slow = header;

            if(header == null || header.next == null)
                Console.WriteLine("List is not circular");

            while (true)
            {
                fast = fast.next.next;
                slow = slow.next;

                if (fast == null || fast.next == null)
                {
                    Console.WriteLine("List is not circular");
                    return;
                }
                else if (fast == slow || fast.next == slow)
                {
                    Console.WriteLine("List is circular");

                    slow = header;
                    while (true)
                    {
                        if (slow == fast)
                        {
                            Console.WriteLine("Circular link list start from: " + slow.data);
                            return;
                        }
                        else
                        {
                            fast = fast.next.next;
                            slow = slow.next;
                        }
                    }
                }
            }
        }
    }
}

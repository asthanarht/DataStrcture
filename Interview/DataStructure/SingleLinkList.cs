using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interview.Classes;

namespace Interview.DataStructure
{
    class SingleLinkList
    {
        public Node header = null;

        public SingleLinkList()
        {
            //header = new Node();
        }

        public Node Find(int value)
        {
            Node current = header;

            while (current != null)
            {
                if (current.data == value)
                {
                    break;
        	        }
                else
                {
                    current = current.link;
                }
            }

            return current;
        }

        public Node FindPrevious(int value)
        {
            Node current = header.link;

            if (current == null || current.data == value)
                return header;

            while (current.link != null)
            {
                if (current.link.data == value)
                {
                    break;
                }
                else
                {
                    current = current.link;
                }
            }

            return current;
        }

        public int Length()
        {
            int counter = 0;
            while (header != null)
            {
                counter += 1;
                header = header.link;
            }

            return counter;
        }

        public void InsertNodeAtBegining(int value)
        {
            Node node = new Node(value);

            if (header != null)
            {
                node.link = header;
            }

            header = node;
        }

		public Node InsertNode(int value)
		{
			Node node = new Node(value);

			if (header != null)
			{
				node.link = header;
			}

			header = node;
			return header;
		}

        public void InsertNodeAtEnd(int value)
        {
            Node node = new Node(value);
            Node current = header;

            while(current.link != null)
            {
                current = current.link;
            }
            
            current.link = node;
        }

        public void InsertNodeAfter(int value, int after)
        {
            Node current = Find(after);

            if (current != null)
            {
                Node node = new Node(value);
                node.link = current.link;
                current.link = node;
            }
        }

        public void InsertNodeBefore(int value, int before)
        {
            Node node = new Node(value);

            if (header != null && header.data == before)
            {
                node.link = header;
                header = node;
            }
            else
            {
                Node current = FindPrevious(before);
                
                if (current != null)
                {
                    node.link = current.link;
                    current.link = node;
                }
            }
        }

        public void DeleteNode(int value)
        {
            Node current = FindPrevious(value);
            
            if (current.link != null)
            {
                Node deleteNode = current.link;
                current.link = deleteNode.link;
                deleteNode = null;
            }
        }

        public void Traverse()
        {
            Console.WriteLine("######### Traverse Linklist #########");
            Node current = header;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.link;
            }
        }

        public void TraverseBackward()
        {
            Console.WriteLine("######### Traverse Backward Linklist #########");
            Node current = header;
            TraverseBackward(current);
        }

        private void TraverseBackward(Node node)
        {
            if (node != null)
            {
                TraverseBackward(node.link);
                Console.WriteLine(node.data);
            }
        }

        public void IsListCircular()
        {
            Node fast = header;
            Node slow = header;

            if(header == null || header.link == null)
                Console.WriteLine("List is not circular");

            while (fast.link != null)
            {
                fast = fast.link.link;
                slow = slow.link;

                if(fast == slow)
                {
                    Console.WriteLine("List is circular");
                    break;
                }
            }

            if (fast.link != null)
            {
                Console.WriteLine("List is not circular");
                return;
            }

            slow = header;

            while (fast != slow)
            {
                fast = fast.link;
                slow = slow.link;
            }

            Console.WriteLine("List is circular and meeting at " + fast.data);
        }

        public void ReverseLinkList(Node head)
        {
            if (head == null)
                return;

            Node cp = head;
            Node prev = null;

            while (cp != null)
            {
                Node next = cp.link;
                cp.link = prev;
                prev = cp;
                cp = next;
            }

            head = prev;
        }

        public void CombinationOfNodes(Node head, StringBuilder buffer)
        {
            while (head != null)
            {
                buffer.Append(head.data);
                Console.WriteLine(buffer);
                CombinationOfNodes(head.link, buffer);
                buffer.Remove(buffer.Length - 1, 1);
                head = head.link;
            }
        }

        public void CombinationOfNodesForAGivenSum(Node head, int sum, List<Node> nodes)
        {
            while (head != null)
            {
                int bsum = 0;
                foreach (Node n in nodes)
                {
                    bsum += n.data;

                    if (bsum > sum)
                        return;
                    else if(bsum == sum)
                    {
                        foreach (Node t in nodes)
                        {
                            Console.Write(t.data + "+");
                        }
                        Console.WriteLine("");
                        return;
                    }
                }

                nodes.Add(head);
                CombinationOfNodesForAGivenSum(head.link, sum, nodes);
                nodes.Remove(head);
                head = head.link;
            }
        }

        public void PermutationOfNodes(Node head, StringBuilder buffer)
        {
            
        }

		public void PairWiseSwap(Node head)
		{
			Node prev = head;
			Node curr = head.link;

			head = curr;
			while (true) {
				Node next = curr.link;
				curr.link = prev;

				if (next == null || next.link == null) {
					prev.link = next;
					break;
				}

				prev.link = next.link;
				prev = next;
				curr = prev.link;
			}

			//Traverse ();
		}

		public Node PairwiseRecurseSwap(Node head)
		{
			if (head == null || head.link == null)
				return head;

			Node ramaning = head.link.link;
			Node newhead = head.link;

			head.link.link = head;
			head.link = PairwiseRecurseSwap (ramaning);
			return newhead;
		}

		// this can be used for RGB
		public void Sort012List(Node head)
		{
			Node current = head;
			int[] count = {0,0,0};

			while(current!=null) {
				count [current.data]+=1;
				current = current.link;
			}
			int i = 0;
			current = head;
			while (current != null) {
				if (count [i] == 0)
					++i;
				else {
					current.data = i;
					--count [i];
					current = current.link;
				}
			}
		}

		public void AddOperationList(Node list1, Node list2)
		{
			Node resultlist = new Node();
			Node p3 = resultlist;
			int carry = 0;
			while (list1 != null || list2 != null) {
				if (list1 != null) {
					carry += list1.data;
					list1 = list1.link;
				}
				if (list2 != null) {
					carry += list2.data;
					list2 = list2.link;

				}

				p3.link = new Node (carry % 10);
				carry /= 10;
				p3 = p3.link;

			}
			if (carry == 1) {
				p3.link = new Node (1);
			}

		}

		//10-20-30-40-50-60-null
		//50-60-10-20-30-40 -null
		public void RotateList(Node head ,int k)
		{
			Node current = head;

			int count = 1;

			while (count < k && current != null) {
				current = current.link;
				count++;
			}

			Node kthNode = current;

			while (current != null) {
				current = current.link;
			}

			current.link = head;
			head = kthNode.link;
			kthNode.link = null;
		}

		public void UnionList(Node list1, Node list2)
		{
			bool[] heap = new bool[20];

			Node resultList = null;
			while (list1 != null) {

				if (heap [list1.data] == false) {
					resultList = InsertNode (list1.data);
					heap [list1.data] = true;
				}
				list1 = list1.link;

			}

			while (list2 != null) {
				if (heap [list2.data] != true) {
					resultList = InsertNode (list2.data);

				}
				list2 = list2.link;
			}



		}

		public Node ReverseAlternateKNode(Node header,int k)
		{
		   Node	current = header;
			Node next = null;
			Node prev = null;
			int count = 0;

			while (count < k && current!=null) {

				current = current.link;
				count++;
			}

			count = 0;
			if (header != null)
				header.link = current;

			while (count < k-1 && current!=null) {
				next = current.link;
				current.link = prev;
				prev = current;
				current = next;
				count++;
			}

			if (current != null)
				current.link = ReverseAlternateKNode (current.link, k);

			return prev;
		}


		public void CloneList(Node head)
		{
			Node original = head;
			Node temp;
			Node Copy = null;

			while (original != null) {
				temp = original.link;
				Copy = new Node (original.data);
				Copy.link = original.link;
				original = temp;
			}

			original = head;
			Copy = original.link;

			while (original != null) {
				original = original.link;
			}
		}

		public void DeleteNodeOne(Node node)
		{
			if (node == null)
				Console.WriteLine ("Node cant delete");

			if (node.link == null)
				node = null;
			else {
				Node temp = node.link;
				node.data = temp.data;
				node.link = temp.link;
				temp = null;
			}

			Node temp1 = header;
		}

        public bool isPalindrom(Node tmp)
		{
			if (tmp == null)
			{
				return true;
			}
			bool result = isPalindrom(tmp.link);
			if (result == true && tmp.data == header.data)
			{
				header = header.link;
				return true;
			}
			return false;
		}




    }
}

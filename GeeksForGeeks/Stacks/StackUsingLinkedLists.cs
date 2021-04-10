using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks.Stacks
{
	public class Node
	{
		public int data;
		public Node next;
		public Node(int data)
		{
			this.data = data;
		}
	}
	class StackUsingLinkedLists
	{
		Node head;
		
		StackUsingLinkedLists(Node head)
		{
			this.head = head;
		}


		public void Push(int x)
		{
			Node newNode = new Node(x);
			if (head == null)
			{
				head = newNode;
			}
			else
			{
				newNode.next = head;
				head = newNode;
			}
			Console.WriteLine("Pushed " + x + " to stack");
		}

		public int Pop()
		{
			if (head == null)
				return -1;

			int poppedValue = head.data;
			head = head.next;
			return poppedValue;
		}

		public int Peek()
		{
			if(head == null)
			{
				return -1;
			}
			return head.data;
		}


		public bool IsEmpty()
		{
			return head == null ? true : false;
		}

	}
}

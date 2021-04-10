using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks.Stacks
{
	class StackUsingArrays
	{
		public class Stack
		{
			int[] stack;
			int top = -1;
			int max;
			Stack(int size)
			{
				stack = new int[size];
				max = size - 1;
			}

			public void Push(int x)
			{
				if(top == max)
				{
					Console.WriteLine("Stack Overflow Exception");
					return;
				}
				stack[++top] = x; 
			}

			public int Pop()
			{
				if(top == -1)
				{
					Console.WriteLine("Stack Empty");
					return -1;
				}
				int poppedElement = stack[top];
				--top;
				return poppedElement;
			}

			public int Peek()
			{
				if(top == -1)
				{
					Console.WriteLine("Stack Empty");
					return -1;
				}
				return stack[top];
			}

			public bool IsEmpty()
			{
				if(top == -1)
				{
					return true;
				}
				return false;
			}
		}


	}
}

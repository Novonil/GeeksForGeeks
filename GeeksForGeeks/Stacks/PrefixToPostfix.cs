using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks.Stacks
{
	class PrefixToPostfix
	{
		public static string convert(string str)
		{
			Stack<string> stack = new Stack<string>();

			for(int i = str.Length - 1; i>= 0; i--)
			{
				if(isOperator(str[i]))
				{
					string op1 = stack.Peek();
					stack.Pop();

					string op2 = stack.Peek();
					stack.Pop();

					stack.Push(op1 + op2 + str[i]);
				}	
				else
				{
					stack.Push(str[i].ToString());
				}
			}
			return stack.Peek();
		}


		public static bool isOperator(char c)
		{
			if (c == '+' || c == '-' || c == '*' || c == '/' || c == '^')
				return true;
			return false;
		}
	}
}

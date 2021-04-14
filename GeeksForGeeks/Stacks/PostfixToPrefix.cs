using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks.Stacks
{
	class PostfixToPrefix
	{
		public static string convert(string str)
		{
			Stack<string> stack = new Stack<string>();

			for(int i = 0; i< str.Length; i++)
			{
				if(isOperator(str[i]))
				{
					string op2 = stack.Peek();
					stack.Pop();
					string op1 = stack.Peek();
					stack.Pop();
					stack.Push(str[i] + op1 + op2);
				}
				else
				{
					stack.Push(str[i].ToString()) ;
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

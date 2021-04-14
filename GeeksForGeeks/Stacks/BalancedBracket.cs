using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks.Stacks
{
	class BalancedBracket
	{
		public static bool balanced(string str)
		{
			Stack<char> stack = new Stack<char>();

			for(int i = 0; i<str.Length; i++)
			{
				if(str[i] == '(' || str[i] == '{' || str[i] == '[')
				{
					stack.Push(str[i]);
				}
				else
				{
					if (stack.Count == 0)
						return false;
					char c = stack.Peek();
					stack.Pop();
					if((str[i] == ')' && c == '(') || (str[i] == '}' && c == '{') || str[i] == ']' && c == '[')
					{
						continue;
					}
					else
					{
						return false;
					}
				}
			}
			return stack.Count > 0 ? false : true;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks.Stacks
{
	class InfixToPostfix
	{
		public static string convert(string str)
		{
			Stack<string> stack = new Stack<string>();
			StringBuilder result = new StringBuilder();

			for (int i = 0; i < str.Length; i++)
			{
				if (isOperator(str[i]))
				{
					while (stack.Count > 0 && precedence(stack.Peek()[0]) >= precedence(str[i]))
					{
						string op = stack.Peek();
						stack.Pop();
						result.Append(op);
					}
					stack.Push(str[i].ToString());
				}
				else if (str[i] == '(')
				{
					stack.Push(str[i].ToString());
				}
				else if (str[i] == ')')
				{
					while (stack.Count > 0 && !stack.Peek().Equals("("))
					{
						string op = stack.Peek();
						stack.Pop();
						result.Append(op);
					}
					if (stack.Count > 0)
					{
						stack.Pop();
					}
					else
					{
						return "Invalid Expression";
					}
				}
				else
				{
					result.Append(str[i]);
				}
			}
			while (stack.Count > 0)
				result.Append(stack.Pop());
			return result.ToString();
		}
		public static bool isOperator(char c)
		{
			if (c == '+' || c == '-' || c == '*' || c == '/' || c == '^')
			{
				return true;
			}
			return false;
		}
		public static int precedence(char c)
		{
			switch (c)
			{
				case '+':
					return 1;
				case '-':
					return 1;
				case '*':
					return 2;
				case '/':
					return 2;
				case '^':
					return 3;
			}
			return -1;
		}
	}
}

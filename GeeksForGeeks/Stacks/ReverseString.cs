using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks.Stacks
{
	class ReverseString
	{
		public static string strreverse(string str)
		{
			int len = str.Length;
			StringBuilder rev = new StringBuilder();
			Stack<char> stack = new Stack<char>();

			for (int i = 0; i < len; i++)
			{
				stack.Push(str[i]);
			}
			while (stack.Count > 0)
			{
				rev.Append(stack.Peek());
				stack.Pop();
			}
			str = rev.ToString();
			return str;
		}

		public static void reverse(char[] str)
		{
			int len = str.Length;
			for (int i = 0; i < len / 2; i++)
			{
				swap(str, i, len - 1 - i);
			}
		}

		public static void swap(char[] str, int i, int j)
		{
			char c = str[i];
			str[i] = str[j];
			str[j] = c;
		}
	}
}

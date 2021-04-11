using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks.Stacks
{
	class EvaluationOfPostfixExpression
	{
		public static int evaluatePostfix(string expression)
		{
			Stack<int> stack = new Stack<int>();
			for(int i = 0; i< expression.Length; i++)
			{
				if(isOperator(expression[i]))
				{
					int op2 = stack.Peek();
					stack.Pop();
					int op1 = stack.Peek();
					stack.Pop();
					switch(expression[i])
					{
						case '+' :
							stack.Push(op1 + op2);
							break;
						case '-' :
							stack.Push(op1 - op2);
							break;
						case '*':
							stack.Push(op1 * op2);
							break;
						case '/' :
							stack.Push(op1 / op2);
							break;
						case '^':
							stack.Push(op1 ^ op2);
							break;
					}
				}
				else
				{
					stack.Push(Convert.ToInt32(expression[i] - '0'));
				}
			}
			return stack.Peek();
		}

		public static bool isOperator(char c)
		{
			if(c == '+' || c == '-' || c == '*' || c == '/' || c== '^')
			{
				return true;
			}
			return false;
		}



		public static int evaluateMultipleDigitExpression(string expression)
		{
			Stack<int> stack = new Stack<int>();

			for(int i = 0; i< expression.Length; i++)
			{
				if (expression[i] == ' ')
					continue;

				if(isDigit(expression[i]))
				{
					int number = 0;
					while(i < expression.Length && isDigit(expression[i]))
					{
						number = number * 10 + Convert.ToInt32(expression[i] - '0');
						i++;
					}
					i--;
					stack.Push(number);
				}
				else if(isOperator(expression[i]))
				{
					int op2 = stack.Peek();
					stack.Pop();
					int op1 = stack.Peek();
					stack.Pop();
					switch(expression[i])
					{
						case '+':
							stack.Push(op1 + op2);
							break;
						case '-':
							stack.Push(op1 - op2);
							break;
						case '*':
							stack.Push(op1 * op2);
							break;
						case '/':
							stack.Push(op1 / op2);
							break;
						case '^':
							stack.Push(op1 ^ op2);
							break;
					}
				}
			}
			return stack.Peek();
			stack.Pop();
		}

		public static bool isDigit(char ch)
		{
			if (ch >= '0' && ch <= '9')
				return true;
			return false;
		}
	}
}

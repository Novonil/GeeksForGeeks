using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks.Stacks
{
	class EvaluateExpression
	{
		public static int evaluate(string expression)
		{
			if (!checkIfWellFormed(expression))
				return -1;

			Stack<char> operators = new Stack<char>();
			Stack<int> value = new Stack<int>();
			for(int i = 0; i < expression.Length; i++)
			{
				if (expression[i] == '(')
					operators.Push(expression[i]);

				else if(expression[i] == ')')
				{
					while(operators.Count > 0 && operators.Peek() != '(')
					{
						char op = operators.Peek();
						operators.Pop();
						int op2 = value.Peek();
						value.Pop();
						int op1 = value.Peek();
						value.Pop();
						int result = applyOperation(op, op1, op2);
						value.Push(result);
					}
					operators.Pop();
				}

				else if(char.IsDigit(expression[i]))
				{
					int number = 0;
					while(i < expression.Length && char.IsDigit(expression[i]))
					{
						number = number * 10 + Convert.ToInt32(expression[i] - '0');
						i++;
					}
					i--;
					value.Push(number);
				}

				else if(isOperator(expression[i]))
				{
					while(operators.Count > 0 && precedence(operators.Peek()) >= precedence(expression[i]))
					{
						char op = operators.Peek();
						operators.Pop();
						int op2 = value.Peek();
						value.Pop();
						int op1 = value.Peek();
						value.Pop();
						int result = applyOperation(op, op1, op2);
						value.Push(result);
					}
					operators.Push(expression[i]);
				}
			}
			while(operators.Count > 0)
			{
				char op = operators.Peek();
				operators.Pop();
				int op2 = value.Peek();
				value.Pop();
				int op1 = value.Peek();
				value.Pop();
				int result = applyOperation(op, op1, op2);
				value.Push(result);
			}
			return value.Peek();
		}
		public static bool checkIfWellFormed(string expression)
		{
			return true;
		}

		public static int precedence(char c)
		{
			switch(c)
			{
				case '^':
					return 3;
				case '*':
					return 2;
				case '/':
					return 2;
				case '+' :
					return 1;
				case '-':
					return 1;
			}
			return -1;
		}


		public static int applyOperation(char op, int op1, int op2)
		{
			switch(op)
			{
				case '+':
					return op1 + op2;
				case '-':
					return op1 - op2;
				case '*':
					return op1 * op2;
				case '/':
					return op1 / op2;
				case '^':
					return op1 ^ op2;
			}
			return -1;
		}

		public static bool isOperator(char c)
		{
			if (c == '+' || c == '-' || c == '*' || c == '/' || c == '^')
				return true;
			return false;
		}

	}
}

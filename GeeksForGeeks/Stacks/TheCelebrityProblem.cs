using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks.Stacks
{
	class TheCelebrityProblem
	{
		public static int findCelebrity(int n, int[,] peoples)
		{
			Stack<int> stack = new Stack<int>();
			for(int i = 1; i <= n; i++)
			{
				stack.Push(i);
			}
			while(stack.Count >= 2)
			{
				int a = stack.Peek();
				stack.Pop();
				int b = stack.Peek();
				stack.Pop();
				stack.Push(knows(a, b, peoples) ? b : a);
			}
			int celebrity = stack.Peek();

			for(int i = 1; i < n; i++)
			{
				if (i!= celebrity && (knows(celebrity, i, peoples) || !knows(i, celebrity, peoples)))
					return -1;
			}
			return celebrity;
		}

		public static bool knows(int a, int b, int[,] peoples)
		{
			return peoples[a - 1, b - 1] == 1 ? true:false ;
		}


		public static int celebrity(int n, int[,] peoples)
		{
			int start = 0;
			int end = n - 1;
			while(start < end)
			{
				if (knows(start + 1, end + 1, peoples))
				{
					start++;
				}
				else
				{
					end--;
				}
			}

			for(int i = 0; i<n; i++)
			{
				if(i != start && (knows(start + 1, i + 1, peoples) || !knows(i+1,start+1,peoples)))
				{
					return -1;
				}
			}
			return start + 1;
		}

		public static int celebrityUsingGraphs(int n, int[,] peoples)
		{
			int[] indegree = new int[n];
			int[] outdegree = new int[n];

			for(int i = 0; i < n; i++)
			{
				for(int j = 0; j<n;j++)
				{
					if(peoples[i,j] == 1)
					{
						indegree[j]++;
						outdegree[i]++;
					}
				}
			}

			for(int i = 0; i <n;i++)
			{
				if (indegree[i] == n - 1 && outdegree[i] == 0)
					return i + 1;
			}
			return -1;
		}
	}
}

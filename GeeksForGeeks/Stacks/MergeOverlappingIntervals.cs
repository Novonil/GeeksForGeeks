using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks.Stacks
{
	class MergeOverlappingIntervals
	{
		public static List<(int, int)> merge(List<(int,int)> intervals)
		{
			Stack<(int, int)> stack = new Stack<(int, int)>();
			intervals.Sort(Comparer<(int, int)>.Create((a, b) => 
				{ 
					int res = a.Item1.CompareTo(b.Item1); 
					if(res == 0)
					{
						res = a.Item2.CompareTo(b.Item2);
					}
					return res;
				}));
			stack.Push((intervals[0].Item1, intervals[0].Item2));

			for (int i = 1; i < intervals.Count; i++)
			{
				if (intervals[i].Item1 < stack.Peek().Item2)
				{
					var temp = stack.Peek();
					stack.Pop();
					temp.Item2 = Math.Max(temp.Item2, intervals[i].Item2);
					stack.Push(temp);
				}
				else
				{
					stack.Push((intervals[i].Item1, intervals[i].Item2));
				}
			}

			List<(int, int)> result = new List<(int, int)>();
			while (stack.Count > 0)
			{
				result.Add(stack.Peek());
				stack.Pop();
			}
			return result;
		}

	}
}

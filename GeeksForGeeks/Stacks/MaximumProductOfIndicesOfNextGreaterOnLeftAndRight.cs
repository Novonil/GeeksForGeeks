using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks.Stacks
{
	class MaximumProductOfIndicesOfNextGreaterOnLeftAndRight
	{
		public static long maxProduct(int[] arr)
		{
			int n = arr.Length;
			int[] left = nextGreaterToLeft(n, arr);
			int[] right = nextGreaterToRight(n, arr);
			long product = 0;
			for(int i = 0; i < n; i++)
			{
				product = Math.Max(product, left[i] * right[i]);
			}
			return product;
		}

		public static int[] nextGreaterToLeft(int n, int[] arr)
		{
			Stack<int> stack = new Stack<int>();
			int[] left = new int[n];
			
			for(int i = 0; i<n;i++)
			{
				while(stack.Count > 0 && arr[stack.Peek()] <= arr[i])
				{
					stack.Pop();
				}
				left[i] = stack.Count == 0 ? 0 : stack.Peek() + 1;
				stack.Push(i);
			}
			return left;
		}


		public static int[] nextGreaterToRight(int n, int[] arr)
		{
			Stack<int> stack = new Stack<int>();
			int[] right = new int[n];

			for(int i = n-1; i>=0; i--)
			{
				while(stack.Count > 0 && arr[stack.Peek()] <= arr[i])
				{
					stack.Pop();
				}
				right[i] = stack.Count == 0 ? 0 : stack.Peek() + 1;
				stack.Push(i);
			}
			return right;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeks.Stacks
{
	class NextGreaterFrequencyElement
	{
		public static int[] nextGreaterFreq(int[] arr)
		{
			Dictionary<int, int> freqMap = generateFreqMap(arr);
			int[] result = fillNextGreaterFreq(arr, freqMap);
			return result;
		}

		public static Dictionary<int, int> generateFreqMap(int[] arr)
		{
			Dictionary<int, int> freqMap = new Dictionary<int, int>();

			foreach (int i in arr)
			{
				if (freqMap.ContainsKey(i))
				{
					freqMap[i]++;
				}
				else
				{
					freqMap.Add(i, 1);
				}
			}
			return freqMap;
		}
		


		public static int[] fillNextGreaterFreq(int[] arr, Dictionary<int,int> freqMap)
		{
			int[] result = new int[arr.Length];
			Stack<int> stack = new Stack<int>();
			for(int i = arr.Length-1; i >=  0; i--)
			{
				while(stack.Count > 0 && freqMap[stack.Peek()] <= freqMap[arr[i]])
				{
					stack.Pop();
				}
				result[i] = stack.Count == 0 ? -1 : stack.Peek();
				stack.Push(arr[i]);
			}
			return result;
		}
	}
}

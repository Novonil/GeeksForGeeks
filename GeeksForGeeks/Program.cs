using GeeksForGeeks.Stacks;
using System;

namespace GeeksForGeeks
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 1, 1, 2, 3, 4, 2, 1 };
			int[] result = NextGreaterFrequencyElement.nextGreaterFreq(nums);




			foreach (int i in result)
			{
				Console.WriteLine(i);
			}
			Console.ReadLine();
		}
	}
}

using GeeksForGeeks.Stacks;
using System;
using System.Collections.Generic;

namespace GeeksForGeeks
{
	class Program
	{
		static void Main(string[] args)
		{
			//int[] nums = { 5,4,3,4,5 };
			//long result = MaximumProductOfIndicesOfNextGreaterOnLeftAndRight.maxProduct(nums);
			//Console.WriteLine(result);


			//int[,] peoples =
			//{
			//	{ 0, 0, 1, 0 },
			//	{ 0, 0, 1, 0 },
			//	{ 0, 0, 0, 0 },
			//	{ 0, 0, 1, 0 }
			//};


			//char[] str = "abcdef".ToCharArray();


			List<(int, int)> arr = new List<(int, int)>(); ;
			arr.Add(( 6,8 ));
			arr.Add(( 1,9 ));
			arr.Add(( 2,4 ));
			arr.Add(( 4,7 ));



			List<(int,int)> res = MergeOverlappingIntervals.merge(arr);
			foreach(var v in res)
			{
				Console.WriteLine(v.Item1 + " , " + v.Item2);
			}
			//foreach (int i in result)
			//{
			//	Console.WriteLine(i);
			//}
			Console.ReadLine();
		}
	}
}

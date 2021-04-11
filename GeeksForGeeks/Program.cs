using GeeksForGeeks.Stacks;
using System;

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


			string str = "100 * 2 + 12";
			int res = EvaluateExpression.evaluate(str);
			Console.WriteLine(res);
			//foreach (int i in result)
			//{
			//	Console.WriteLine(i);
			//}
			Console.ReadLine();
		}
	}
}

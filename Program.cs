using System;

namespace ConsoleApp3OOPs
{
	internal class Program
	{
		static int[] data = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };

		static void Main(string[] args)
		{
			var spObject = new StatsProcessor();
			spObject.Numbers = data;
			var result = spObject.GetStatsProcessorResult();
			double no = data.Length;
			
			Console.WriteLine($"Mean: {result.Mean}");
			Console.WriteLine($"Median : {result.Median}");
			Console.WriteLine($"Mode : {result.Mode}");
		}
	}
}
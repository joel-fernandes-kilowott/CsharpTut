using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApp
{
	internal class Program
	{
		static int[] data = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };

		static void Main(string[] args)
        {
			var spObject = new StatsProcessor();
			spObject.Numbers = data;
			double no = data.Length;
			
			float mean = spObject.CalculateMean();
			Console.WriteLine($"Mean: {mean}");

			double median = spObject.CalculateMedian();
			Console.WriteLine($"Median : {median}");

			double Mode = spObject.CalculateMode();
			Console.WriteLine($"Mode : {Mode}");
		}
	}
}

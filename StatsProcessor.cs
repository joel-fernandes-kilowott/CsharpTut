
using System;

namespace ConsoleApp3OOPs
{
    /// <summary>
    /// This class will perform some basic statistics calculations
    /// </summary>
    /// 
    internal class StatsProcessor
    {
        // data that is provided to the object is encapsulatd
        internal int[] Numbers { private get; set; }

        /// <summary>
        /// method will calculate the sum of the encapsulated
        /// </summary>
        /// <returns>the sum of integers as an integer type</returns>
        /// 
        internal StatsResult GetStatsProcessorResult()
        {
            var result = new StatsResult();
            result.Mean = CalculateMean();
            result.Median = CalculateMedian();
            result.Mode = CalculateMode();
            return result;
        }
        internal float CalculateMean()
        {
            int sum = 0;
            float mean;

            for (int i = 0; i < Numbers.Length; i++)
            {
                sum += Numbers[i];
            }
            mean = (float)sum / Numbers.Length;
            return mean;
        }

        internal int CalculateMedian()
        {
            Array.Sort(Numbers);
            int m = (Numbers.Length) / 2;
            return Numbers[m];
        }

        internal float CalculateMode()
        {
            int maxcount = 0, maxvalue = 0;
            for (int k = 0; k < Numbers.Length; k++)
            {
                int count = 0;
                for (int j = 0; j < Numbers.Length; j++)
                {
                    if (Numbers[k] == Numbers[j])
                    {
                        count++;
                    }
                }
                if (count > maxcount)
                {
                    maxcount = count;
                    maxvalue = Numbers[k];
                }
            }
            return maxvalue;
        }


    }
}

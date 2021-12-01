using System.Linq;
using System;

namespace FirstConsoleApp
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
        internal float CalculateMean()
        {
            // this uses a nifty util from .NET from the LINQ namespace
            // see the "using..." section at the top of the file
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
            int sum = 0, maxcount = 0, maxvalue = 0;
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

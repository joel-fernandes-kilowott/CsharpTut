using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    internal class Stats
    {
        public static void ShowOutput()
        {
            int[] testdata = {40,38,37,36,34,33,32,31,30,30,30,29,26,26,19};
            int sum = 0, maxcount = 0, maxvalue = 0;
            float mean = 0.0f;
            
            for (int i = 0; i < testdata.Length; i++)
            {
                sum += testdata[i];
            }
            mean = (float)sum / testdata.Length;
            Console.WriteLine($"Mean = {mean}");
         
         //Median
            Array.Sort(testdata);
            int m = (testdata.Length) / 2;
            Console.WriteLine($"Median = {testdata[m]}");

            //Mode calculation
            for (int k = 0; k < testdata.Length; k++)
            {
                int count = 0;
                for (int j = 0; j < testdata.Length; j++)
                {
                    if(testdata[k] == testdata[j])
                    {
                        count++;
                    }
                }
                if (count > maxcount)
                {
                    maxcount = count;
                    maxvalue = testdata[k];
                }
            }
            Console.WriteLine($"Mode = {maxvalue}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DailyCodingProblem112818
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                This problem was asked by Stripe.
                Given an array of integers, find the first missing positive integer in linear time and constant space. 
                In other words, find the lowest positive integer that does not exist in the array. 
                The array can contain duplicates and negative numbers as well.
                For example, the input [3, 4, -1, 1] should give 2. The input [1, 2, 0] should give 3.
                You can modify the input array in-place. 
             */

            var arr = new int[] { -4, -3, -2, 1, 2, 3, 4, 7, 9, -8, 12, 34, 136, 40, 5, 6, 8, 10, 11, 14, 19};
            int fin = 1;
            int lastSum = int.MaxValue;
            foreach (int num in arr)
            {
                int possibleSum = num + 1;
                if (possibleSum < arr.Max() && !arr.Contains(possibleSum) && possibleSum > 0)
                {
                    if (possibleSum <= lastSum)
                    {
                        lastSum = possibleSum;
                    }
                }
            }
            fin = lastSum < 0 ? 1 : lastSum;
            // --^^-- ternary - set fin to 1 if lastSum < 0 or set fin to lastSum if fin is >= 0

            Debug.WriteLine(fin);
        }
    }
}

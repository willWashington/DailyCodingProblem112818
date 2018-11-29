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

            var arr = new int[] { 3, 4, -1, 1 };
            var result = new List<int>();
            int answer = 1;

            for (int i = 0; i < arr.Length; i++)
            { //for every int in the array
                foreach (int num in arr) 
                { //compare it to every other int in the array

                    int comparison = num + 1;
                    int max = arr.Max();
                    if (comparison > 0 && comparison > i && !arr.Contains(comparison) && comparison < max)                         
                    {
                        Debug.WriteLine(comparison);
                    }
                    //returns 2 2 - almost there
                }
            }
            Console.ReadLine();
        }
    }
}

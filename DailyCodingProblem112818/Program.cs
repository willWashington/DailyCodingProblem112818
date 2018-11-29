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

            var arr = new int[] { 1,2,0};
            List<int> answerList = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            { //for every int in the array                
                int min = arr.Min(); //get the lowest number in the array
                int minIndex = Array.IndexOf(arr, min); //find what index position the lowest number in the array is
                int max = arr.Max(); //get the highest number in the array
                int comparison = arr[i] + 1; //add 1 to the current array selection
                if (comparison > 0 && comparison > arr[i] && !arr.Contains(comparison))
                    //if comparison is:
                        //positive (greater than 0) AND
                        //greater than the current number in the outer loop AND
                        //is not in the original array AND
                        //is less than the highest number in the array
                {
                    answerList.Add(comparison);                    
                } else
                {
                    Debug.WriteLine("incorrect algorithm");
                }
            }
            //linq solution:
            int finalAnswer = answerList.Min();
            Debug.WriteLine(finalAnswer); //write it
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class RyanairArrayofTwoIntegers
    {
        // Write a function which takes an array of integers and return true if the elements of the array can be divided into 2 groups whose sums are equal.

        // For example:

        // Given the array [2, 5, 3] the function would return true.

        // The array [2 , 5, 3] can be split up into two groups [5] and [2, 3] whose sums are both 5.
        public bool SplitArray(int[] input)
        {
            int total = 0;

            foreach (var item in input)
            {
                total += item;
            }

            // Remember, the modulus calculates the remainder that is a result of the first operand being divided by the second
            var evenNumber = total % 2 == 0;
            if (evenNumber)
            {
                return true;
            }
            return false;
        }

        // Split an array into two equal Sum subarrays

        // Input : Arr[] = { 1 , 2 , 3 , 4 , 5 , 5  }
        // Output :  { 1 2 3 4 } 
        //          { 5 , 5 }

        // Input : Arr[] = { 4, 1, 2, 3 }
        // Output : {4 1}
        //         {2 3}

        // Input : Arr[] = { 4, 3, 2, 1}
        // Output : Not Possible

        // Returns split point. If  
        // not possible, then return -1. 
        public int FindSplitPoint(int[] arr, int n)
        {

            int leftSum = 0;

            // traverse array element 
            for (int i = 0; i < n; i++)
            {

                // add current element to left Sum 
                leftSum += arr[i];

                // find sum of rest array 
                // elements (rightSum) 
                int rightSum = 0;

                for (int j = i + 1; j < n; j++)
                    rightSum += arr[j];

                // split point index 
                if (leftSum == rightSum)
                    return i + 1;
            }

            // if it is not possible to  
            // split array into two parts 
            return -1;
        }

        // Prints two parts after finding  
        // split point using findSplitPoint() 
        public void PrintTwoParts(int[] arr, int n)
        {

            int splitPoint = FindSplitPoint(arr, n);

            if (splitPoint == -1 || splitPoint == n)
            {
                Console.Write("Not Possible");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (splitPoint == i)
                    Console.WriteLine();

                Console.Write(arr[i] + " ");
            }
        }

        //An Efficient solution is to first compute the sum of the whole array from left to right.Now we traverse array from right and keep track of right sum, left sum can be computed by subtracting current element from whole sum.

        //Below is the implementation of above idea.


        // Returns split point. If not possible, then 
        // return -1. 
        public int FindSplitPointOptimized(int[] arr, int n)
        {

            // traverse array element and compute sum 
            // of whole array 
            int leftSum = 0;

            for (int i = 0; i < n; i++)
                leftSum += arr[i];

            // again traverse array and compute right  
            // sum and also check left_sum equal to  
            // right sum or not 
            int rightSum = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                // add current element to right_sum 
                rightSum += arr[i];

                // exclude current element to the left_sum 
                leftSum -= arr[i];

                if (rightSum == leftSum)
                    return i;
            }

            // if it is not possible to split array 
            // into two parts. 
            return -1;
        }

        // Prints two parts after finding split  
        // point using findSplitPoint() 
        public void PrintTwoPartsOptimized(int[] arr, int n)
        {
            int splitPoint = FindSplitPointOptimized(arr, n);

            if (splitPoint == -1 || splitPoint == n)
            {
                Console.Write("Not Possible");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                if (splitPoint == i)
                    Console.WriteLine();

                Console.Write(arr[i] + " ");
            }
        }
    }

}

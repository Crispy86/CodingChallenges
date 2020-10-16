using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenges
{
    // Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

    // Example:

    // Input: [0,1,0,3,12]
    //    Output: [1,3,12,0,0]
    //    Note:

    // You must do this in-place without making a copy of the array.
    // Minimize the total number of operations.
    public class MoveZeroes
    {
        public static void MoveZeroesToEnd(int[] nums)
        {
            var length = nums.Length - 1;
            int count = 0;
            int current = 0;

            for (int i = 0; i < length; i++)
            {
                current = nums[i];

                if (current ==  0)
                {
                    nums[i] = nums[length];
                    nums[length] = 0;
                    length--;                        
                }
            }                       
        }

        public static void PushZerosToEnd(int[] nums)
        {
            // Count of non-zero elements 
            int count = 0;
            var length = nums.Length;
            // Traverse the array. If element encountered is 
            // non-zero, then replace the element  
            // at index â..countâ.. with this element 
            for (int i = 0; i < length; i++)
                if (nums[i] != 0)

                    // here count is incremented 
                    nums[count++] = nums[i];

            // Now all non-zero elements have been shifted to 
            // front and â..countâ.. is set as index of first 0. 
            // Make all elements 0 from count to end. 
            while (count < length)
                nums[count++] = 0;

            int[] newNums = nums;

        }
    }
}




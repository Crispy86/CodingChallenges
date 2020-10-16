using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class Arrays
    {
        //Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.

        //Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

        //Example 1:

        //Given nums = [1, 1, 2],

        //Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively.

        //It doesn't matter what you leave beyond the returned length.
        //Example 2:

        //Given nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4],

        //Your function should return length = 5, with the first five elements of nums being modified to 0, 1, 2, 3, and 4 respectively.

        //It doesn't matter what values are set beyond the returned length.
        int[] nums = { 1, 1, 2, 2, 3, 4 };
        int[] nums2 = { 2, 5, 1, 4, 6, 7 };
        public int RemoveDuplicates(int[] nums)
        {
            int count = 0;
            int current = 0;
            int next = 0;
            int previous;
            int temp;
                        
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    current = nums[i];

                   
                    next = nums[i + 1];
                    //temp = nums[i + 2];


                    if (current > next)
                    {
                        nums[i] = next;
                        nums[i + 1] = current;
                    previous = nums[i - 1];
                    if (previous > next)
                    {
                        nums[i - 1] = next;
                        nums[i] = previous;
                    }
                    }
                        count = Array.IndexOf(nums, next);
                }
           
            return count;
        }

        public int removeDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }
    }
}

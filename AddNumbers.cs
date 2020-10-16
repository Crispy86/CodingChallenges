using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class AddNumbers
    {
        //Given an array of integers, return indices of the two numbers such that they add up to a specific target.

        //You may assume that each input would have exactly one solution, and you may not use the same element twice.

        //Example:

        //Given nums = [2, 7, 11, 15], target = 9,

        //Because nums[0] + nums[1] = 2 + 7 = 9,
        //return [0, 1].

        public static int[] TwoSum(int[] nums, int target)
        {
            int total = 0;
            int[] numbers = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {            
                for (int j = 0; j < nums.Length; j++)
                {
                    total = nums[i] + nums[j];

                    if(total == target)
                    {
                        numbers[0] = i;
                        numbers[1] = j;
                        return numbers;
                    }
                    total = 0;
                }
            }
            return numbers;
        }

        public static int[] TwoSums(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                map.Add(nums[i], i);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement) && map[complement] != i)
                {
                    return new int[] { i, map[complement] };
                }
            }
            throw new ArgumentOutOfRangeException(nameof(target), "volume cannot be more than 100");
        }

        public static int[] OnePass(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map.Add(nums[i], i);
            }
            throw new ArgumentOutOfRangeException(nameof(target), "volume cannot be more than 100");
        }
    }
}

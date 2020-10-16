using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class LongestPrefix
    {


        //Write a function to find the longest common prefix string amongst an array of strings.

        //If there is no common prefix, return an empty string "".

        //Example 1:

        //Input: ["flower","flow","flight"]
        //Output: "fl"
        //Example 2:

        //Input: ["dog","racecar","car"]
        //Output: ""
        //Explanation: There is no common prefix among the input strings.
        //Note:

        //All given inputs are in lowercase letters a-z

        // A Function to find the string having the  
        // minimum length and returns that length 
        
        public static String LongestCommonPrefix(String[] strs)
        {

            if (strs == null || strs.Length == 0)
                return "";
            int minLen = int.MaxValue;
          foreach( string str in strs)
                minLen = Math.Min(minLen, str.Length);
            int low = 1;
            int high = minLen;
            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (IsCommonPrefix(strs, middle))
                    low = middle + 1;
                else
                    high = middle - 1;
            }
            return strs[0].Substring(0, (low + high) / 2);
        }

        private static bool IsCommonPrefix(String[] strs, int len)
        {
            String str1 = strs[0].Substring(0, len);
            for (int i = 1; i < strs.Length; i++)
                if (!strs[i].StartsWith(str1))
                    return false;
            return true;
        }
    }
}

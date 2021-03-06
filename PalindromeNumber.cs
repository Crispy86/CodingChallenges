﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class PalindromeNumber
    {
        //Determine whether an integer is a palindrome.An integer is a palindrome when it reads the same backward as forward.

        //Example 1:

        //Input: 121
        //Output: true
        //Example 2:

        //Input: -121
        //Output: false
        //Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
        //Example 3:

        //Input: 10
        //Output: false
        //Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
        //Follow up:

        //Coud you solve it without converting the integer to a string?

        public static bool IsPalindrome(int x)
        {
            int originalValue = x;
            int reverse = 0;

            while (x != 0)
            {
                int pop = x % 10;

                x /= 10;

                reverse = reverse * 10 + pop;
            }

            if(originalValue == reverse)
            return true;

            return false;
        }


            public static bool IsItAPalindrome(int x)
            {
                // Special cases:
                // As discussed above, when x < 0, x is not a palindrome.
                // Also if the last digit of the number is 0, in order to be a palindrome,
                // the first digit of the number also needs to be 0.
                // Only 0 satisfy this property.
                if (x < 0 || (x % 10 == 0 && x != 0))
                {
                    return false;
                }

                int revertedNumber = 0;
                while (x > revertedNumber)
            {
                int pop = x % 10;

                x /= 10;

               revertedNumber = revertedNumber * 10 + pop;
                
            }

                // When the length is an odd number, we can get rid of the middle digit by revertedNumber/10
                // For example when the input is 12321, at the end of the while loop we get x = 12, revertedNumber = 123,
                // since the middle digit doesn't matter in palidrome(it will always equal to itself), we can simply get rid of it.
                return x == revertedNumber || x == revertedNumber / 10;
            }

    }
}

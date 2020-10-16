using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class PlusOne
    {
        //Given a non-empty array of digits representing a non-negative integer, plus one to the integer.

        //    The digits are stored such that the most significant digit is at the head of the list, and each element in the array contain a single digit.

        //    You may assume the integer does not contain any leading zero, except the number 0 itself.

        //    Example 1:

        //    Input: [1,2,3]
        //    Output: [1,2,4]
        //    Explanation: The array represents the integer 123.
        //    Example 2:

        //    Input: [4,3,2,1]
        //    Output: [4,3,2,2]
        //    Explanation: The array represents the integer 4321.

        public static int[] PlusOneMethod(int[] digits)
        {
            // int[] array = { 1, 2, 4};
            // Should equal 125

            if (digits == null || digits.Length == 0)
                return new int[0];

            int carry = 1;
            var digitsLength = digits.Length - 1;

            for (int i = digitsLength; i >= 0; i--)
            {
                int sum = digits[i] + carry;
                if (sum >= 10)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }

                // Below line not needed. This is for my understanding
                int value = digits[i] = sum % 10;

                digits[i] = sum % 10;
            }

            if (carry == 1)
            {
                var newDigitsLength = new int[digits.Length + 1];

                int[] result = newDigitsLength;

                Array.Copy(digits, 0, result, 1, digits.Length);

                result[0] = 1;
                return result;
            }
            else
            {
                //int[] result = new int[digits.length];
                return digits;
            }
        }
    }
    }


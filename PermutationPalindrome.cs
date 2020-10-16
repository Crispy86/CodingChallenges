using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class PermutationPalindrome
    {
        //Write an efficient method that checks whether any permutation ↴ of an input string is a palindrome. ↴

        //You can assume the input string only contains lowercase letters.

        //Examples:

        //"civic" should return true
        //"ivicc" should return true
        //"civil" should return false
        //"livci" should return false

        //The word "permutation" also refers to the act or process of changing the linear order of an ordered set.
        public static bool Palindrome(string input)
        {
            var unpairedCharacters = new HashSet<char>();

            foreach (char c in input)
            {
                if (unpairedCharacters.Contains(c))
                {
                    unpairedCharacters.Remove(c);
                }
                else
                {
                    unpairedCharacters.Add(c);
                }
            }

            // The string has a palindrome permutation if it
            // has one or zero characters without a pair
            return unpairedCharacters.Count <= 1;

        }

     
        public static bool PalindromeWithDictionary(string input)
        {

            var unpairedCharacters = new Dictionary<int, char>();

            foreach (char c in input)
            {
                if (unpairedCharacters.ContainsValue(c))
                {
                    unpairedCharacters.Remove(c);
                }
                else
                {
                    unpairedCharacters.Add(c, c);
                }
            }

            // The string has a palindrome permutation if it
            // has one or zero characters without a pair
            return unpairedCharacters.Count <= 1;

        }

        public static bool PalindromeWithHashTable(string input)
        {

            var unpairedCharacters = new Hashtable();

            foreach (char c in input)
            {
                if (unpairedCharacters.Contains(c))
                {
                    unpairedCharacters.Remove(c);
                }
                else
                {
                    unpairedCharacters.Add(c, c);
                }
            }

            // The string has a palindrome permutation if it
            // has one or zero characters without a pair
            return unpairedCharacters.Count <= 1;

        }

        public static string ConvertStringArrayToString(string[] array)
        {
            // Concatenate all the elements into a StringBuilder.
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append('.');
            }
            return builder.ToString();
        }


    }
}

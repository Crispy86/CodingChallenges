using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class FindTheMissingNumber
    {
        public int FindMissingNumber(int[] arr)
        {
            // arr = 1, 2, 4, 6, 5, 7, 8, 9
            // output = 3

            var length = arr.Length;
            int i, total = 1;

            for (i = 2; i <= (length + 1); i++)
            {
                total += i;
                total -= arr[i - 2];
            }
            return total;
        }

        public int GetMissingNo(int[] arr)
        {
            // arr = 1, 2, 4, 6, 5, 7, 8, 9
            // output = 3

            var length = arr.Length;
            int total = (length + 1) * (length + 2) / 2;

            for (int i = 0; i < length; i++)
                total -= arr[i];

            return total;
        }
    }
}

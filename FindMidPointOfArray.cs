using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class FindMidPointOfArray
    {
        // This check if an array can be split up into 2 parts
        public int FindIfArrayCanBeDividedIntoTwoGroups(int[] arr, int n)
        {

            // [ 16, 12, 20, 1, 47 ]
            var leftSide = 0;

            foreach (var no in arr)
            {
                leftSide += no;
            }

            var rightSide = 0;

            for (int no = n - 1; no > 0; no--)
            {
                rightSide += arr[no];

                leftSide -= arr[no];

                if (leftSide == rightSide)
                    return no;
            }


            return -1;
        }

        public int FindArrayMidPoint(int[] arr, int n)
        {
            
            int middIndex = n / 2;
            Console.WriteLine(arr[middIndex]);

            return middIndex;
        }
    }
}

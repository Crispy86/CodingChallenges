using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class MergeArrays
    {
        //Given 2 sorted arrays, A and B, where A is long enough to hold the contents of A and B, write a function to copy the contents of B into A without using any buffer or additional memory.
        //eg:
        //    int[] a = { 1, 3, 5, 7, 9, 0, 0, 0 };
        //    int[] b = { 2, 4, 6 };

        //    MergeArrays(A, B);
        //   a = {1, 2, 5, 6, 8, 10 };

        public static Array Merge(int[] a, int[] b)
        {
            int[] c = new int[a.Length];
            int no = 0;

            for (int n = 0; n  < a.Length; n++)
            {
                if(a[n] == 0)
                {                    
                    var test = a[n] = b[no++];
                }    
                
            }

            //int current = 0;
            //int prev = current;
            //int next = 0;

            //for (int i = a.Length - 1; i >= 0 ; i--)
            //{
            //    current = a[i];

            //    int x = i;
            //    if (x < a.Length - 1) { 
            //    prev = a[i + 1];


            //    if(current > prev)
            //    {
            //            int temp = a[i];
            //            a[i] = a[i + 1];
            //            a[i + 1] = temp;
            //        }
            //    }
            //}
            Array.Sort(a);
            return a;
        }

        public static Array MergeArray(int[] a, int[] b)
        {
            
            int aLength = a.Length;
            int bLength = b.Length;
            //if (aLength + bLength > a.Length) Console.WriteLine("Error");

            int aIndex = aLength - 1;
            int bIndex = bLength - 1;
            int mergeIndex = (aLength + b.Length) - 1;

            while (aIndex >= 0 && bIndex >= 0)
            {
                if (a[aIndex] > b[bIndex])
                {
                    a[mergeIndex] = a[aIndex];
                    aIndex--;
                }
                else
                {
                    a[mergeIndex] = b[bIndex];
                    bIndex--;
                }

                mergeIndex--;
            }

            while (bIndex >= 0)
            {
                a[mergeIndex] = b[bIndex];
                bIndex--;
                mergeIndex--;
            }

            return a;
        }
    }
}

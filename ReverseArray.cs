using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class ReverseArray
    {

        /* Function to reverse arr[] from 
        start to end*/
        static void RvrseArray(int[] arr,
                        int start, int end)
        {
            int temp;

            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

       

        /* Utility that prints out an
        array on a line */
        static void PrintArray(int[] arr,
                                int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }

        static void MoveZeroesToEnd(int[] arr)
        {
            //Given an integer array, move all elements that are 0 to the left while maintaining the order of other elements in the array. The array has to be modified in-place.

            //eg: 1, 10, 20, 0, 59, 63, 0, 88 , 0
            //    1, 10, 20, 59, 63, 88, 0, 0, 0, 


            // Count of non-zero elements 
            int count = 0;
                var length = arr.Length;
                // Traverse the array. If element encountered is 
                // non-zero, then replace the element  
                // at index â..countâ.. with this element 
                for (int i = 0; i < length; i++)
                    if (arr[i] != 0)

                    // here count is incremented 
                    arr[count++] = arr[i];

                // Now all non-zero elements have been shifted to 
                // front and â..countâ.. is set as index of first 0. 
                // Make all elements 0 from count to end. 
                while (count < length)
                arr[count++] = 0;

                int[] newNums = arr;

            }
        



        // Driver function
        //public static void Main()
        //{

        //    //int[] arr = { 1, 2, 3, 4, 5, 6 };
        //    //PrintArray(arr, 6);
        //    //RvrseArray(arr, 0, 5);
        //    //Console.Write("Reversed array is \n");
        //    //PrintArray(arr, 6);

        //    int[] numbers = { 1, 10, 20, 0, 59, 63, 0, 88, 0 };
        //    PrintArray(numbers, 9);
        //    MoveZeroesToEnd(numbers);
        //    Console.Write("Reversed array is \n");
        //    PrintArray(numbers, 9);


        //}
    }
}
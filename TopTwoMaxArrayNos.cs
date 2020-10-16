using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class TopTwoMaxArrayNos
    {
        static void MaxNos(int[] arr)
        {
            //    Write a program to Find Top two maximum number from Array.
            //    For example:

            //Input:

            //    Arr = { 22, 8 , 5, 8, 12}

            //    Output:
            //    22, 12

            if (arr.Length < 2)
            {
                Console.WriteLine("Please provide valid Array");
            }

            if (arr.Length > 2)
            {
                var firstMaxNumber = 0;
                var secondMaxNumber = 0;
                foreach (var i in arr)
                {
                    if (i > firstMaxNumber)
                    {
                        secondMaxNumber = firstMaxNumber;
                        firstMaxNumber = i;
                    }

                    if (i > secondMaxNumber && i < firstMaxNumber)
                        secondMaxNumber = i;

                }
                Console.WriteLine($"First Max number = {firstMaxNumber}");
                Console.WriteLine($"Second Max number = {secondMaxNumber}");
            }
            Console.ReadLine();



        }


        static void PrintArray(int[] arr,
                                int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }

        // Driver function
        public static void Main()
        {

            int[] arr = { 22, 8 , 5, 8, 12 };
            //PrintArray(arr, 5);
            MaxNos(arr);
            //Console.Write("Reversed array is \n");
            //PrintArray(arr, 5);


        }
    }
}

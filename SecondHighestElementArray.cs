using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    public class SecondHighestElementArray
    {


        static void ArraySecondHighestElement(int[] arr)
        {
//          Write a program to Find Second Highest element in an array.

//          For example:

//          Input:
//            Arr = { 1,7,4,2,1,3}

//         Output:
//            4


                var secondMaxNumber = 0;
               
                Console.WriteLine($"Second Max number = {secondMaxNumber}");

            Console.ReadLine();



        }




        // Driver function
        public static void Main()
        {
            int[] arr = { 1, 7, 4, 2, 1, 3 };
            ArraySecondHighestElement(arr);
        }
    }
}
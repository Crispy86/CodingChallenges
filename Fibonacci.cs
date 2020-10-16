using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    //Write a method Fib() that takes an integer nn and returns the nnth Fibonacci ↴
    //The Fibonacci series is a numerical series where each item is the sum of the two previous items.It starts off like this:
    //0,1,1,2,3,5,8,13,21...
    //Let's say our Fibonacci series is 0-indexed and starts with 0. So:
    //Fib(0);  // => 0
    //Fib(1);  // => 1
    //Fib(2);  // => 1
    //Fib(3);  // => 2
    //Fib(4);  // => 3

        //Eg: Fib(10) returns 34

        //0,1,1,2,3,5,8,13,21,34

    public class Fibonacci
    {
        public static int Fib(int n)
        {
            if (n == 0 || n == 1)
            {
                // This returns 0 or 1
                return n;
            }

            return Fib(n - 2) + Fib(n - 1);
        }

        private static Dictionary<int, int> _memo = new Dictionary<int, int>();

        public static int FibTwo(int n)
        {
            // Edge case: negative index
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n),
                    "Index was negative. No such thing as a negative index in a series.");
            }

            // Base case: 0 or 1
            if (n == 0 || n == 1)
            {
                return n;
            }

            // See if we've already calculated this
            int result;
            if (!_memo.TryGetValue(n, out result))
            {
                // Not yet, so compute it
                result = FibTwo(n - 1) + FibTwo(n - 2);

                // Memoize
                _memo.Add(n, result);
            }

            return result;
        }

        // Best Solution
        public static int FibThree(int n)
        {
            // Edge cases:
            if (n < 0)
            {
                throw new ArgumentException("Index was negative. No such thing as a negative index in a series.");
            }

            if (n == 0 || n == 1)
            {
                return n;
            }

            // We'll be building the fibonacci series from the bottom up.
            // So we'll need to track the previous 2 numbers at each step.
            int prevPrev = 0;  // 0th fibonacci
            int prev = 1;      // 1st fibonacci
            int current = 0;   // Declare and initialize current

            for (int i = 1; i < n; i++)
            {
                // Iteration 1: current = 2nd fibonacci
                // Iteration 2: current = 3rd fibonacci
                // Iteration 3: current = 4th fibonacci
                // To get nth fibonacci ... do n-1 iterations.
                current = prev + prevPrev;
                prevPrev = prev;
                prev = current;
            }

            return current;
        }
    }

  
}


using System;

namespace CH3Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursion Example");
            long sumofnumbers = sumOfNumbers(10);
            Console.WriteLine(sumofnumbers);
            long products = ProductOfNumbers(12);
            Console.WriteLine(products);
        }

        private static long sumOfNumbers(long n)
        {
            Console.WriteLine($"sum is {n}");
            if (n == 0)
            {
                return 0;
            }
            return n + sumOfNumbers(--n);
        }
        private static long ProductOfNumbers(long y)
        {
            Console.WriteLine($"calling ProductOfNumbers {y}");
            if (y == 1)
            {
                return 1;
            }
            return y * ProductOfNumbers(--y);
        }

    }
}

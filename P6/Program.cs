using System;

namespace P6
{
    class Program
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(squareOfSum(n) - sumOfSquares(n));
            }
            Console.ReadKey();
        }

        static long squareOfSum(long n) {
            return (long) Math.Pow(n * (n + 1) / 2, 2);
        }

        static long sumOfSquares(long n)
        {
            return n * (n + 1) * (2 * n + 1) / 6;
        }
    }
}

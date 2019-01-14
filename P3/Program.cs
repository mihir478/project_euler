using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace P3
{
    class Program
    {
        static void Main(String[] args)
        {
            // process input
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                long n = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine(LargestPrimeFactor(n));
            }
            Console.ReadKey();
        }

        static long LargestPrimeFactor(long n)
        {
            for (long i = 2; i <= Math.Sqrt(n); i = H.Helper.NextPrime(i)) {
                while (n % i == 0)
                    n /= i;
                if (n == 1)
                    return i;
            }
            return n;
        }
    }
}

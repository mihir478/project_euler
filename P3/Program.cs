using System;

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

        private static bool IsPrime(long n)
        {
            if (n == 2)
                return true;
            if (n == 1 || n % 2 == 0) // takes care of even numbers (which include 0), handled 2 already
                return false;
            for (long i = 3; i <= Math.Sqrt(n); i += 2)
                if (n % i == 0)
                    return false;
            return true;
        }

        public static long NextPrime(long currentPrime)
        {
            if (currentPrime < 2)
                return 2;
            if (currentPrime == 2)
                return 3;
            for (long i = currentPrime + 2; ; i += 2)
                if (IsPrime(i))
                    return i;
        }

        static long LargestPrimeFactor(long n)
        {
            for (long i = 2; i <= Math.Sqrt(n); i = NextPrime(i)) {
                while (n % i == 0)
                    n /= i;
                if (n == 1)
                    return i;
            }
            return n;
        }
    }
}

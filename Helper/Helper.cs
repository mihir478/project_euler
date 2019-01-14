using System;

namespace H
{
    class Helper
    {
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

        static void Main(String[] args) {
            for (int i = 0; i < 10; ++i) {
                Console.WriteLine(i + " is " + (IsPrime(i) ? "" : "not ") + "prime.");
            }
            Console.ReadKey();
        }
    }
}

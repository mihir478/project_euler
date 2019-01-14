using System;

namespace P7
{
    class Program
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(NthPrime(n));
            }
            Console.ReadKey();
        }

        static long NthPrime(int n) {
            int c = 0; long currentPrime = 0;
            do
            {
                currentPrime = H.Helper.NextPrime(currentPrime);
                c++;
            } while (c < n);
            return currentPrime;
        }
    }
}

using System;
using System.Collections.Generic;

namespace P7
{
    class Program
    {
        static List<long> primes = new List<long>() { 2, 3 };

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

            // we already have it
            if (n <= primes.Count)
                return primes[n - 1];

            long current = primes[primes.Count - 1] + 2; // start looking just after the highest prime we have

            while (primes.Count < n) {

                bool isPrime = true; // assume prime 

                foreach (long prime in primes) {
                    if (current % prime == 0) {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primes.Add(current);
                    current = primes[primes.Count - 1] + 2;
                }
                else {
                    current += 2;
                }
            }

            return primes[primes.Count - 1];
        }
    }
}

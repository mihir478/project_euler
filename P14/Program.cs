using System;
using System.Diagnostics;

namespace P14
{
    class Program
    {
        static int LIMIT = 10000000;
        static int[] chains = new int[LIMIT + 1];
        static long[] results;

        static void Main(string[] args)
        {

            int t = Convert.ToInt32(Console.ReadLine());
            long[] inputs = new long[t];
            long maxN = 0;
            for (int a0 = 0; a0 < t; a0++)
            {
                long n = Convert.ToInt64(Console.ReadLine());
                inputs[a0] = n;
                if (n > maxN)
                    maxN = n;
            }

            // pre-compute
            results = new long[maxN + 1];
            FindMaxWithLongestChainUnderN(maxN);

            for (int a0 = 0; a0 < t; a0++) {
                Console.WriteLine(results[inputs[a0]]);
            }

            Console.ReadLine();
        }

        static void FindMaxWithLongestChainUnderN(long n)
        {
            int maxCL = 0;
            int nWithMaxCL = 1;
            for (int i = 1; i <= n; ++i)
            {
                int cL = ChainLength(i);
                if (cL >= maxCL)
                {
                    maxCL = cL;
                    nWithMaxCL = i;
                }
            results[i] = nWithMaxCL;
            }
        }

        static int ChainLength(long n)
        {
            // memoize
            if (n == 1)
                return 0;

            if (n <= LIMIT && chains[n] > 0)
                return chains[n];

            int cL = 0;
            if (n % 2 == 0)
                cL = 1 + ChainLength(n / 2);
            else
                cL = 1 + ChainLength(3 * n + 1);

            if (n <= LIMIT)
            {
                chains[n] = cL;
            }

            return cL;
        }
    }
}

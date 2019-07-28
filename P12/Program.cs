using System;
using System.Collections.Generic;

namespace P12
{
    class Program
    {
        static Dictionary<int, int> cache = new Dictionary<int, int>() { };

        static void Main(string[] args)
        {

            int t = Convert.ToInt32(Console.ReadLine());
            int maxN = 1;
            int[] ns = new int[t];
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine()) + 1;
                ns[a0] = n;
                if (n > maxN)
                {
                    maxN = n;
                }
            }

            BuildFactorCountToTriangleNumberCache(maxN);

            for (int a0 = 0; a0 < t; a0++)
            {
                int n = ns[a0];
                foreach (var entry in cache)
                {
                    // dictionary maintains order
                    if (entry.Key >= n)
                    {
                        Console.WriteLine(entry.Value);
                        break;
                    }
                }
            }
            Console.Read();
        }

        private static void BuildFactorCountToTriangleNumberCache(int maxN)
        {
            int maxFactorCount = 0;
            for (int s = 1; maxFactorCount < maxN; ++s)
            {
                int t = s * (s + 1) / 2;
                int factorCount = FactorCount(t);
                if (factorCount > maxFactorCount)
                {
                    cache.Add(factorCount, t);
                    maxFactorCount = factorCount;
                }
            }
        }

        static int FactorCount(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            int factorCount = 2; // 1 and itself
            double sqrtT = Math.Sqrt(n);

            for (int f = 2; f < sqrtT; ++f)
            {
                if (n % f == 0)
                {
                    factorCount += 2; // factor and t / factor
                }
            }

            if (Math.Floor(sqrtT) == Math.Ceiling(sqrtT) && n % sqrtT == 0)
            {
                factorCount++; // factor = t / factor, counts as 1
            }

            return factorCount;
        }
    }
}

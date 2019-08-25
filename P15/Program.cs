using System;
using System.Numerics;

namespace P15
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] line = Console.ReadLine().Split(new char[] { ' ' });
                int a = Convert.ToInt32(line[0]);
                int b = Convert.ToInt32(line[1]);
                int m = Math.Min(a, b);
                int n = Math.Max(a, b);
                Choose(m, n);
            }
            Console.ReadKey();
        }

        static void Choose(int m, int n) {
            // m < n
            BigInteger result = new BigInteger(m + n);
            for (int i = m - 1; i > 0; --i) {
                result = result * (i + n) / (m + 1 - i);
            }
            Console.WriteLine(result % 1000000007);
        }
    }
}

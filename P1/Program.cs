using System;

namespace P1
{
    class Program
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Calc(n));
            }
            Console.ReadKey();
        }

        private static ulong Calc(int N)
        {
            // multiples less than N
            ulong mult3 = (ulong)(N - 1) / 3,
                mult5 = (ulong)(N - 1) / 5,
                mult15 = (ulong)(N - 1) / 15;

            ulong sum3 = SumNatural(mult3),
                sum5 = SumNatural(mult5),
                sum15 = SumNatural(mult15);

            return 3 * sum3 + 5 * sum5 - 15 * sum15;
        }

        private static ulong SumNatural(ulong n)
        {
            return n * (n + 1) / 2;
        }
    }
}

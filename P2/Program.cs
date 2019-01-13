using System;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                long n = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine(SumEven(n));
            }
            Console.Read();
        }

        static long SumEven(long n)
        {
            long a = 0, b = 2, sum = 0;
            while (b < n)
            {
                sum += b;
                b = a + 4 * b;
                a = (b - a) / 4;
            }
            return sum;
        }
    }
}

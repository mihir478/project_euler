using System;

namespace P9
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(findTriplet(n));
            }
            Console.ReadKey();
        }

        static int findTriplet(int n) {
            int product = -1;
            for (int a = 1; a < n - 1; ++a) {
                int b = (n * n - 2 * a * n) / (2 * n - 2 * a);
                int c = n - a - b;
                int p = a * b * c;
                if (a < b && a * a + b * b == c * c && p > product) {
                    product = p;
                }
            }
            return product;
        }
    }
}

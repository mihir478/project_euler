using System;

namespace P5
{
    class Program
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(LCM(n));
            }
            Console.ReadKey();
        }

        static int LCM(int n) {
            int product = 1;
            for (int i = 1; i <= n; ++i) {
                product *= i / GCD(i, product);
            }
            return product;
        }

        static int GCD(int a, int b) {
            if (b == 0)
                return a;
            else
                return GCD(b, a % b);
        }
    }
}

using System;

namespace P10
{
    class Program
    {
        static int l = 2000001;
        static bool[] p = new bool[l];
        static long[] s = new long[l];

        static void Main(String[] args) {
            // pre-compute
            findPrimes();
            sumPrimes();

            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(s[n]);
            }
            Console.ReadKey();
        }

        static void findPrimes() {

            for (int i = 4; i < l; i += 2)
                p[i] = true;

            for (int i = 3; i <= Math.Sqrt(l); i += 2)
                if (!p[i])
                    for (int j = 2 * i; j < l; j += i)
                        p[j] = true;
        }

        static void sumPrimes() {
            long sum = 0;
            for (int i = 2; i < l; i++) {
                if (!p[i])
                    sum += i;
                s[i] = sum;
            }
        }
    }
}

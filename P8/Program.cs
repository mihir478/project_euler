using System;

namespace P8
{
    class Program
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                string num = Console.ReadLine();
                Console.WriteLine(maxProduct(n, k, num));
            }
            Console.ReadKey();
        }

        static int maxProduct(int n, int k, string num) {
            int maxProduct = -1;
            for (int i = 0; i < n - k; ++i) {
                int product = num[i] - '0';
                for (int j = 1; j < k; ++j) {
                    product *= num[i + j] - '0';
                }
                if (product > maxProduct)
                    maxProduct = product;
            }
            return maxProduct;
        }
    }
}

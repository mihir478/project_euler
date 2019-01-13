using System;

namespace P4
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(largestPalindrome(n));
            }
            Console.ReadKey();
        }

        static int largestPalindrome(int n)
        {
            int maxPalin = 0;
            for (int i = 999; i > 100; --i)
                for (int j = Math.Min(n / i, 999); i * j > maxPalin && j > 100; --j)
                {
                    int product = i * j;
                    if (product % 11 != 0) continue;
                    string s = product + "";
                    char[] chars = s.ToCharArray();
                    Array.Reverse(chars);
                    if (s == new string(chars) && product > maxPalin && product < n)
                        maxPalin = product;
                }
            return maxPalin;
        }
    }
}

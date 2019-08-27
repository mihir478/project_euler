using System;
using System.Numerics;

namespace P16
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; ++a0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                BigInteger b = BigInteger.Pow(2, n);
                string digits = b.ToString();
                int sum = 0;
                for (int i = 0; i < digits.Length; ++i)
                {
                    sum += Convert.ToInt32(digits[i] - '0');
                }
                Console.WriteLine(sum);
                Console.ReadKey();
            }
        }
    }
}

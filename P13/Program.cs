using System;

namespace P13
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            const int digits = 50;
            short[] sum = new short[3 + digits]; // Ceiling(Log10(1000))

            // read lines
            for (int a0 = 0; a0 < N; ++a0)
            {
                String digitsStr = Console.ReadLine();

                // read digits and accumulate logic
                for(int d = 2 + digits; d >= 3; --d)
                {
                    sum[d] += (short) (digitsStr[d - 3] - '0');
                }
            }

            // carry logic
            for (int d = sum.Length - 1; d > 0; d--)
            {
                sum[d - 1] += (short) (sum[d] / 10);
                sum[d] %= (short) 10;
            }
            
            // skip leading zeroes
            int s = -1;
            while (sum[++s] == 0);

            // print
            for (int c = s; c < s + 10; ++c)
            {
                Console.Write(sum[c]);
            }

            Console.ReadKey();
        }
    }
}
